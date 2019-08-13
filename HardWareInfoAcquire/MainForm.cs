using CCWin;
using HardWareInfoAcquire.Dto;
using HardWareInfoAcquire.Forms;
using HardWareInfoAcquire.Hardware;
using HardWareInfoAcquire.Log;
using HardWareInfoAcquire.SerialPortCom;
using HardWareInfoAcquire.Util;
using OpenHardwareMonitor.Hardware;
using shenhuaBlister.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardWareInfoAcquire
{
    //指令类型
    public enum InstructionType : byte
    {
        senddata = 0x21,   //发送数据
        getdata = 0x22,    //索取数据
        setmainboard = 0x23//设置主板
    }

    //数据类型
    public enum DataType : byte
    {
        realtime = 0x52,//实时数据
        minutes = 0x4D, //分钟数据
        hours = 0x48,   //小时数据
        days = 0x44     //当日数据
    }
    
    public partial class MainForm : CCSkinMain
    {
        byte[][] ParamCode = { 
            new byte[]{ 0x42, 0x30, 0x31 },   //CPU温度
            new byte[]{ 0x47, 0x30, 0x31 },   //GPU温度
            new byte[]{ 0x48, 0x30, 0x31 },   //硬盘温度
            new byte[]{ 0x4d, 0x30, 0x31}};   //主板温度

        //cpu仪表盘显示信息
        private System.Windows.Forms.AGaugeLabel label_cpu_load;
        private System.Windows.Forms.AGaugeLabel label_cpu_temperature;
        private System.Windows.Forms.AGaugeLabel label_cpu_fan;

        //gpu仪表盘显示信息
        private System.Windows.Forms.AGaugeLabel label_gpu_load;
        private System.Windows.Forms.AGaugeLabel label_gpu_temperature;
        private System.Windows.Forms.AGaugeLabel label_gpu_fan;

        //内存仪表盘显示信息
        private System.Windows.Forms.AGaugeLabel label_memory_load;
        private System.Windows.Forms.AGaugeLabel label_memory_used;
        private System.Windows.Forms.AGaugeLabel label_memory_available;

        //处理线程
        Thread AcquireThread;

        //串口发送线程
        Thread HardwareInfoSendThread;

        //串口接收线程
        Thread GetReceiveThread;

        //采集信息队列
        Queue<HardwareInfo> hardwareQueue = new Queue<HardwareInfo>();

        private SerialPortComImplement serialPort;

        private Computer myComputer;

        private UpdateVisitor updateVisitor = new UpdateVisitor();

        private LogHelper MaintLog;

        public MainForm()
        {
            InitializeComponent();

            label_cpu_load = aGauge_cpu.GaugeLabels.FindByName("gaugelabel_cpu_load");
            label_cpu_temperature = aGauge_cpu.GaugeLabels.FindByName("gaugelabel_cpu_temperature");
            label_cpu_fan = aGauge_cpu.GaugeLabels.FindByName("gaugelabel_cpu_fan");

            label_gpu_load = aGauge_gpu.GaugeLabels.FindByName("gaugelabel_gpu_load");
            label_gpu_temperature = aGauge_gpu.GaugeLabels.FindByName("gaugelabel_gpu_temperature");
            label_gpu_fan = aGauge_gpu.GaugeLabels.FindByName("gaugelabel_gpu_fan");

            label_memory_load = aGauge_memory.GaugeLabels.FindByName("gaugelabel_memory_load");
            label_memory_used = aGauge_memory.GaugeLabels.FindByName("gaugelabel_memory_used");
            label_memory_available = aGauge_memory.GaugeLabels.FindByName("gaugelabel_memory_available");

            string mainlog = ConfigurationUtil.GetAppConfig("MainFormLogFile");
            if (!String.IsNullOrEmpty(mainlog))
            {
                this.MaintLog = new LogHelper(mainlog);
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            myComputer = new Computer();
            myComputer.Open();
            myComputer.CPUEnabled = true;
            myComputer.GPUEnabled = true;
            myComputer.HDDEnabled = true;
            myComputer.MainboardEnabled = true;
            myComputer.RAMEnabled = true;

            serialPort = new SerialPortComImplement("COM3", 9600, 8);
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            serialPort.Open();

            AcquireThread = new Thread(AcquireHardWareInfo);
            AcquireThread.Start();

            HardwareInfoSendThread = new Thread(SendHardwareInfo);
            HardwareInfoSendThread.Start();

            GetReceiveThread = new Thread(AcceptData);
            //GetReceiveThread.Start();

            for (int i = 0; i < 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = cpuTempAdjustDataGrid.Rows.Add(row);
                cpuTempAdjustDataGrid.Rows[index].Cells[0].Value = "40~45℃";
                cpuTempAdjustDataGrid.Rows[index].Cells[1].Value = "80%";
                cpuTempAdjustDataGrid.Rows[index].Cells[2].Value = "80%";
                cpuTempAdjustDataGrid.Rows[index].Cells[3].Value = "17,18,20";
                cpuTempAdjustDataGrid.Rows[index].Cells[4].Value = "60%";
                cpuTempAdjustDataGrid.Rows[index].Cells[5].Value = "50%";
                cpuTempAdjustDataGrid.Rows[index].Cells[6].Value = "available";
            }

        }

        private void AcquireHardWareInfo()
        {
            while (true)
            {
                GetHardWareInfo();
                Thread.Sleep(200000);
            }
        }

        private void SendHardwareInfo()
        {
            while (true)
            {
                if (this.hardwareQueue.Count > 0)
                {
                    HardwareInfo info = this.hardwareQueue.Dequeue();

                    SendHardwareInfoBySerial(info);
                }
                else
                {
                    Thread.Sleep(2000);
                }
            }
        }

        private void AcceptData()
        {
            while (true)
            {
                byte[] byteReceive = serialPort.Read();
                if (byteReceive != null && byteReceive.Length > 0)
                {
                    string strReceive = ByteToAllType.byte2HexStr(byteReceive, byteReceive.Length);
                    this.MaintLog.WriteLine("serial port receive: " + strReceive);
                }

                //string strReceive = serialPort.ReadLine();
                //if (!String.IsNullOrEmpty(strReceive))
                //{
                //    this.MaintLog.WriteLine("serial port receive: " + strReceive);
                //}
            }
        }


        private void SendHardwareInfoBySerial(HardwareInfo info)
        {
            byte[] writeBytes = new byte[1024];
            //包头 ##
            writeBytes[0] = 0x23;
            writeBytes[1] = 0x23;

            //指令类型
            writeBytes[4] = Convert.ToByte(InstructionType.senddata);
            //参数个数
            writeBytes[5] = 0x04;

            //数据段
            //CPU温度 参数代码
            Array.Copy(ParamCode[0], 0, writeBytes, 6, 3);
            //CPU温度
            byte[] cputemp = BitConverter.GetBytes(info.cpuTemperature);
            Array.Copy(cputemp, 0, writeBytes, 9, cputemp.Length);
            //分隔符
            writeBytes[13] = 0x3B;

            //GPU温度 参数代码
            Array.Copy(ParamCode[1], 0, writeBytes, 14, 3);
            //GPU温度
            byte[] gputemp = BitConverter.GetBytes(info.gpuTemperature);
            Array.Copy(gputemp, 0, writeBytes, 17, gputemp.Length);
            //分隔符
            writeBytes[21] = 0x3B;

            //硬盘温度 参数代码
            Array.Copy(ParamCode[2], 0, writeBytes, 22, 3);
            //硬盘温度
            byte[] hddtemp = BitConverter.GetBytes(info.hddTemperature);
            Array.Copy(hddtemp, 0, writeBytes, 25, hddtemp.Length);
            //分隔符
            writeBytes[29]= 0x3B;

            //主板温度 参数代码
            Array.Copy(ParamCode[3], 0, writeBytes, 30, 3);
            //主板温度
            byte[] boardtemp= BitConverter.GetBytes(info.mainBoardTemperature);
            Array.Copy(boardtemp, 0, writeBytes, 33, boardtemp.Length);

            //数据长度
            ushort datalength = 1 + 1 + 8 * 4 - 1;//指令类型长度(1)＋参数个数长度(1)＋数据段长度(n=8*4-1)
            byte[] packagelen = BitConverter.GetBytes(datalength);
            Array.Copy(packagelen, 0, writeBytes, 2, packagelen.Length);

            writeBytes[37] = 0x26;
            writeBytes[38] = 0x26;

            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write(writeBytes, 39);
                    //serialPort.Write("tt1");
                }
                catch (Exception ex)
                {
                    this.MaintLog.WriteLine("Serial port Write failed: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get hardware info
        /// </summary>
        private void GetHardWareInfo()
        {
            myComputer.Accept(updateVisitor);
            List<int> cputemperaturelist = new List<int>();
            List<int> boardtemperaturelist = new List<int>();
            HardwareInfo info = new HardwareInfo();

            for (int i = 0; i < myComputer.Hardware.Length; i++)
            {
                //查找硬件类型为CPU
                if (myComputer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < myComputer.Hardware[i].Sensors.Length; j++)
                    {
                        //找到温度传感器
                        if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            int cputemperature = Convert.ToInt32(myComputer.Hardware[i].Sensors[j].Value);
                            cputemperaturelist.Add(cputemperature);
                        }
                        else if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Load && myComputer.Hardware[i].Sensors[j].Name == "CPU Total")
                        {
                            //占用率
                            float cpuload = (float)myComputer.Hardware[i].Sensors[j].Value;
                            info.cpuLoad = cpuload;//CPU占用率
                            this.BeginInvoke(new Action(() =>
                            {
                                load_cpu.Text = cpuload.ToString();
                                aGauge_cpu.Value = cpuload;
                            }));
                        }
                        else if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Fan)
                        {
                            //找到风扇
                            ushort fans = (ushort)myComputer.Hardware[i].Sensors[j].Value;
                            info.cpuFan = fans;//CPU风扇
                            this.BeginInvoke(new Action(() =>
                            {
                                label_cpu_fan.Text = fans + " rpm";
                            }));
                        }
                    }
                    if (cputemperaturelist.Count > 0)
                    {
                        int temperaturesum = 0;
                        for (int k = 0; k < cputemperaturelist.Count; k++)
                        {
                            temperaturesum += cputemperaturelist[k];
                        }

                        ushort cpuTemperature = (ushort)Math.Ceiling((double)temperaturesum / cputemperaturelist.Count);
                        info.cpuTemperature = cpuTemperature;//CPU温度

                        this.BeginInvoke(new Action(() =>
                        {
                            temperature_cpu.Text = cpuTemperature.ToString() + "℃";
                            label_cpu_temperature.Text= cpuTemperature.ToString() + " ℃";
                        }));
                    }
                }
                //查找硬件类型为GPU
                else if (myComputer.Hardware[i].HardwareType == HardwareType.GpuNvidia ||
                    myComputer.Hardware[i].HardwareType == HardwareType.GpuAti)
                {
                    for (int j = 0; j < myComputer.Hardware[i].Sensors.Length; j++)
                    {
                        if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {//找到温度传感器
                            string temperature = myComputer.Hardware[i].Sensors[j].Value.ToString();

                            //GPU温度
                            ushort gpuTemperature = (ushort)myComputer.Hardware[i].Sensors[j].Value;
                            info.gpuTemperature = gpuTemperature;//GPU温度

                            this.BeginInvoke(new Action(() =>
                            {
                                temperature_gpu.Text = gpuTemperature.ToString() + "℃";
                                label_gpu_temperature.Text = gpuTemperature.ToString() + " ℃";
                            }));
                        }
                        else if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Fan)
                        {
                            //找到风扇
                            ushort gpuFan = (ushort)myComputer.Hardware[i].Sensors[j].Value;
                            info.gpuFan = gpuFan;

                            this.BeginInvoke(new Action(() =>
                            {
                                rotate_gpu.Text = gpuFan.ToString() + "rpm";
                                label_gpu_fan.Text = gpuFan.ToString() + " rpm";
                            }));
                        }
                        else if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Load 
                            && myComputer.Hardware[i].Sensors[j].Name == "GPU Core")
                        {
                            //GPU占用
                            float gpucore = (float)myComputer.Hardware[i].Sensors[j].Value;
                            info.gpuLoad = gpucore;

                            this.BeginInvoke(new Action(() =>
                            {
                                aGauge_gpu.Value = gpucore;
                            }));
                        }
                    }
                }
                else if (myComputer.Hardware[i].HardwareType == HardwareType.HDD)
                {//硬盘
                    for (int j = 0; j < myComputer.Hardware[i].Sensors.Length; j++)
                    {
                        //找到温度传感器
                        if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            string temperature = myComputer.Hardware[i].Sensors[j].Value.ToString();
                            ushort hddTemperature = (ushort)myComputer.Hardware[i].Sensors[j].Value;
                            info.hddTemperature = hddTemperature;

                            this.BeginInvoke(new Action(() =>
                            {
                                temperature_harddisk.Text = hddTemperature.ToString() + "℃";
                                skinLabel_disk_temperature.Text = hddTemperature.ToString() + "℃";
                            }));
                            break;
                        }
                    }
                }
                else if (myComputer.Hardware[i].HardwareType == HardwareType.Mainboard)
                {//主板
                    boardtemperaturelist.Clear();
                    for (int j = 0; j < myComputer.Hardware[i].SubHardware.Length; j++)
                    {
                        for (int k = 0; k < myComputer.Hardware[i].SubHardware[j].Sensors.Length; k++)
                        {
                            if (myComputer.Hardware[i].SubHardware[j].Sensors[k].SensorType == SensorType.Temperature)
                            {
                                int mainboardtemperature = Convert.ToInt32(myComputer.Hardware[i].SubHardware[j].Sensors[k].Value);
                                boardtemperaturelist.Add(mainboardtemperature);
                            }
                        }
                    }

                    if (boardtemperaturelist.Count > 0)
                    {
                        int temperaturesum = 0;
                        for (int k = 0; k < boardtemperaturelist.Count; k++)
                        {
                            temperaturesum += boardtemperaturelist[k];
                        }

                        temperaturesum = (int)Math.Ceiling((double)temperaturesum / boardtemperaturelist.Count);

                        //主板温度
                        info.mainBoardTemperature = (ushort)temperaturesum;
                        this.BeginInvoke(new Action(() =>
                        {
                            temperature_mainboard.Text = temperaturesum.ToString() + "℃";
                            skinLabel_mainboard_temperature.Text = temperaturesum.ToString() + "℃";
                        }));
                    }
                }
                else if(myComputer.Hardware[i].HardwareType==HardwareType.RAM)
                {//内存
                    for (int j = 0; j < myComputer.Hardware[i].Sensors.Length; j++)
                    {
                        //占用率
                        if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            float memoryload = (float)myComputer.Hardware[i].Sensors[j].Value;

                            info.memoryLoad = memoryload;//内存占用率

                            this.BeginInvoke(new Action(() =>
                            {
                                load_memory.Text = memoryload.ToString("F0") + "%";
                                aGauge_memory.Value = memoryload;
                            }));
                        }
                        else if (myComputer.Hardware[i].Sensors[j].SensorType == SensorType.Data)
                        {
                            //used and available
                            if (myComputer.Hardware[i].Sensors[j].Name == "Used Memory")
                            {
                                //used memory
                                float usedmemory = (float)myComputer.Hardware[i].Sensors[j].Value;
                                info.memoryUsed = usedmemory;//已用内存

                                this.BeginInvoke(new Action(() =>
                                {
                                    label_memory_used.Text = usedmemory.ToString("F1") + " G";
                                }));
                            }
                            else if(myComputer.Hardware[i].Sensors[j].Name == "Available Memory")
                            {
                                //available memory
                                float availablememory = (float)myComputer.Hardware[i].Sensors[j].Value;
                                info.memoryAvailable = availablememory;

                                this.BeginInvoke(new Action(() =>
                                {
                                    label_memory_available.Text = availablememory.ToString("F1") + " G";
                                }));
                            }
                        }
                    }
                }
            }

            this.hardwareQueue.Enqueue(info);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                stopForm();

                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            myComputer.Close();
        }

        private void aGauge_cpu_temperature_ValueChanged(object sender, EventArgs e)
        {
            label_cpu_load.Text = aGauge_cpu.Value.ToString("F0") + "%";
        }

        private void aGauge_gpu_ValueChanged(object sender, EventArgs e)
        {
            label_gpu_load.Text = aGauge_gpu.Value.ToString("F0") + "%";
        }

        private void aGauge_memory_ValueChanged(object sender, EventArgs e)
        {
            label_memory_load.Text = aGauge_memory.Value.ToString("F0") + "%";
        }

        /// <summary>
        /// 窗口关闭事项
        /// </summary>
        private void stopForm()
        {
            //关闭信息采集线程
            if (AcquireThread != null)
            {
                AcquireThread.Abort();
                AcquireThread = null;
            }

            //关闭串口发送线程
            if (HardwareInfoSendThread != null)
            {
                HardwareInfoSendThread.Abort();
                HardwareInfoSendThread = null;
            }
            
            //关闭串口接收线程
            if (GetReceiveThread != null)
            {
                GetReceiveThread.Abort();
                GetReceiveThread = null;
            }

            //关闭串口
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        /// <summary>
        /// 添加双击托盘图标事件（双击显示窗口）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        /// <summary>
        /// 判断是否最小化，然后显示托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon1.Visible = true;
            }
        }

        /// <summary>
        /// 托盘右键显示主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// 托盘右键退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                stopForm();

                //关闭所有线程
                this.Dispose();
                this.Close();
            }
        }

        private void btnAdd_cpuTempAdjust_Click(object sender, EventArgs e)
        {
            TemperatureAdjustForm frm = new TemperatureAdjustForm();
            frm.MainForm = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void tabcontrol_menu_DrawItem(object sender, DrawItemEventArgs e)
        {
            //获取TabControl主控件的工作区域
            Rectangle rec = tabcontrol_menu.ClientRectangle;

            //新建一个StringFormat对象，用于对标签文字的布局设置
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;// 设置文字垂直方向居中
            StrFormat.Alignment = StringAlignment.Center;// 设置文字水平方向居中       

            SolidBrush bruFont = new SolidBrush(Color.FromArgb(217, 54, 26));// 标签字体颜色
            Font font = new System.Drawing.Font("微软雅黑", 18F);//设置标签字体样式

            for (int i = 0; i < tabcontrol_menu.TabPages.Count; i++)
            {
                //获取标签头的工作区域
                Rectangle recChild = tabcontrol_menu.GetTabRect(i);

                //绘制标签头的文字
                e.Graphics.DrawString(tabcontrol_menu.TabPages[i].Text, font, bruFont, recChild, StrFormat);
            }
        }
    }
}
