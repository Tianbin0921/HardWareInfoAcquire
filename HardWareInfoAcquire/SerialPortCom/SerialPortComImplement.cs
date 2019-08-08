using HardWareInfoAcquire.Log;
using HardWareInfoAcquire.Util;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace HardWareInfoAcquire.SerialPortCom
{
    class SerialPortComImplement
    {
        public delegate void RecEventHandler(byte[] queueByte);
        public event RecEventHandler DataReceivedEvent;
        private SerialPort serialPort;
        private List<byte> buffer = new List<byte>(4096);

        private LogHelper SerialPortLog;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="portName">端口名称</param>
        /// <param name="baudRate">波特率</param>
        /// <param name="dataBits">数据位</param>
        public SerialPortComImplement(string portName, int baudRate, int dataBits)
        {
            //serialPort = new SerialPort(portName, baudRate, Parity.None);
            serialPort = new SerialPort();
            serialPort.PortName = portName;    //串口号
            serialPort.BaudRate = baudRate;    //波特率
            serialPort.DataBits = dataBits;    //数据位
            serialPort.StopBits = StopBits.One;//停止位
            serialPort.ReadTimeout = 500;      //读取数据的超时时间，引发ReadExisting异常
            serialPort.WriteBufferSize = 1024;
            serialPort.ReadBufferSize = 1024;
            serialPort.RtsEnable = true;
            serialPort.DtrEnable = true;
            serialPort.ReceivedBytesThreshold = 1;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceivedEventHandler);

            string serialPortFileName = ConfigurationUtil.GetAppConfig("serialPortLogFile");
            if (!String.IsNullOrEmpty(serialPortFileName))
            {
                this.SerialPortLog = new LogHelper(serialPortFileName);
            }
        }

        /// <summary>
        /// 串口数据接收事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] readBuffer = null;
                int n = serialPort.BytesToRead;
                byte[] buf = new byte[n];
                serialPort.Read(buf, 0, n);

                //1.缓存数据
                buffer.AddRange(buf);
                //2.完整性判断         
                while (buffer.Count >= 8)
                {
                    //至少包含标头(2字节),长度(2字节),指令类型(1字节)，参数个数(1字节)，数据段(n),包尾(2字节)，等等
                    //2.1 查找数据标记头            
                    if (buffer[0] == 0x23 && buffer[1] == 0x23) //传输数据有帧头，用于判断       
                    {
                        byte[] ByteInt16 = new byte[2] { buffer[2], buffer[3] };
                        int datacodelen = BitConverter.ToInt16(ByteInt16, 0);
                        int packagelen = datacodelen + 6;
                        if (buffer.Count < packagelen)
                        {
                            //数据未接收完整跳出循环
                            break;
                        }
                        readBuffer = new byte[packagelen];
                        //得到完整的数据，复制到readBuffer中    
                        buffer.CopyTo(0, readBuffer, 0, packagelen);
                        //从缓冲区中清除
                        buffer.RemoveRange(0, packagelen);

                        //触发外部处理接收消息事件
                    }
                    else //开始标记或版本号不正确时清除           
                    {
                        buffer.RemoveAt(0);
                    }
                }
            }
            catch (Exception ex)
            {
                this.SerialPortLog.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 打开端口
        /// </summary>
        /// <returns></returns>
        public bool Open()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                this.SerialPortLog.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 发送字节
        /// </summary>
        /// <param name="writeBytes">要发送的字节</param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public bool Write(byte[] writeBytes, int len)
        {
            if (Open())
            {
                try
                {
                    serialPort.Write(writeBytes, 0, len);
                    string mergeStr = "发送:";
                    for (int j = 0; j < len; j++)
                    {
                        mergeStr = mergeStr + writeBytes[j].ToString("x") + " ";
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    this.SerialPortLog.WriteLine(ex.Message);
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// 发送字符串
        /// </summary>
        /// <param name="writeStrs"></param>
        /// <returns></returns>
        public bool Write(string writeStrs)
        {
            if (Open())
            {
                try
                {
                    serialPort.Write(writeStrs);
                    Thread.Sleep(100);
                    return true;
                }
                catch (Exception ex)
                {
                    this.SerialPortLog.WriteLine(ex.Message);
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="NumBytes"></param>
        /// <returns></returns>
        public byte[] Read(int NumBytes)
        {
            byte[] inbuffer = null;
            if (serialPort.IsOpen && serialPort.BytesToRead > 0)
            {
                if (NumBytes > serialPort.BytesToRead)
                {
                    NumBytes = serialPort.BytesToRead;
                }

                try
                {
                    inbuffer = new byte[NumBytes];
                    int count = serialPort.Read(inbuffer, 0, NumBytes);
                }
                catch (TimeoutException timeoutEx)
                {
                    //超时异常
                    this.SerialPortLog.WriteLine(timeoutEx.Message);
                }
            }

            return inbuffer;
        }

        /// <summary>
        /// 读取缓冲区数据
        /// </summary>
        /// <returns></returns>
        public byte[] Read()
        {
            return Read(serialPort.BytesToRead);
        }

        public string ReadLine()
        {
            try
            {
                if (serialPort.IsOpen && serialPort.BytesToRead > 0)
                {
                    return serialPort.ReadExisting();
                }

                return null;
            }
            catch (TimeoutException timeoutEx)
            {
                this.SerialPortLog.WriteLine(timeoutEx.Message);
                return timeoutEx.Message;
            }
        }

        public void Close()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                this.SerialPortLog.WriteLine(ex.Message);
            }
        }

        public bool IsOpen
        {
            get
            {
                return serialPort.IsOpen;
            }
        }
    }
}
