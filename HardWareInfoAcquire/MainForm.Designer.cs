namespace HardWareInfoAcquire
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel3 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel4 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel5 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel6 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel7 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel8 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel9 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel10 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel11 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel12 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel13 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel14 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange5 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange6 = new System.Windows.Forms.AGaugeRange();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temperature_cpu = new System.Windows.Forms.Label();
            this.temperature_gpu = new System.Windows.Forms.Label();
            this.temperature_harddisk = new System.Windows.Forms.Label();
            this.temperature_mainboard = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rotate_cpu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rotate_gpu = new System.Windows.Forms.Label();
            this.loabel6 = new System.Windows.Forms.Label();
            this.load_memory = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.load_cpu = new System.Windows.Forms.Label();
            this.tabcontrol_menu = new CCWin.SkinControl.SkinTabControl();
            this.tabpage_monitor = new CCWin.SkinControl.SkinTabPage();
            this.skinLabel_mainboard_temperature = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel_disk_temperature = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.aGauge_memory = new System.Windows.Forms.AGauge();
            this.aGauge_gpu = new System.Windows.Forms.AGauge();
            this.aGauge_cpu = new System.Windows.Forms.AGauge();
            this.tabpage_temperature = new CCWin.SkinControl.SkinTabPage();
            this.btnAdjust_hdd = new CCWin.SkinControl.SkinButton();
            this.btnAdjust_mainboard = new CCWin.SkinControl.SkinButton();
            this.btnAdjust_gpu = new CCWin.SkinControl.SkinButton();
            this.btnAdjust_cpu = new CCWin.SkinControl.SkinButton();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            this.cmb_hdd_temp_threshold = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel17 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel16 = new CCWin.SkinControl.SkinLabel();
            this.cmb_mainboard_temp__threshold = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.cmb_gpu_temp__threshold = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.cmb_cpu_temp__threshold = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.trb_cpu_fan = new CCWin.SkinControl.SkinTrackBar();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.trb_gpu_fan = new CCWin.SkinControl.SkinTrackBar();
            this.rdo_auto_adjustment = new CCWin.SkinControl.SkinRadioButton();
            this.rdo_manual_adjustment = new CCWin.SkinControl.SkinRadioButton();
            this.tabpage_led = new CCWin.SkinControl.SkinTabPage();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.skinColorSelectPanel2 = new CCWin.SkinControl.SkinColorSelectPanel();
            this.skinTrackBar4 = new CCWin.SkinControl.SkinTrackBar();
            this.skinTrackBar3 = new CCWin.SkinControl.SkinTrackBar();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinColorSelectPanel1 = new CCWin.SkinControl.SkinColorSelectPanel();
            this.skinTrackBar2 = new CCWin.SkinControl.SkinTrackBar();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinTrackBar1 = new CCWin.SkinControl.SkinTrackBar();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tabpage_show = new CCWin.SkinControl.SkinTabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabcontrol_menu.SuspendLayout();
            this.tabpage_monitor.SuspendLayout();
            this.tabpage_temperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_cpu_fan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_gpu_fan)).BeginInit();
            this.tabpage_led.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar3)).BeginInit();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar1)).BeginInit();
            this.tabpage_show.SuspendLayout();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU温度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "显卡温度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "硬盘温度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "主板温度";
            // 
            // temperature_cpu
            // 
            this.temperature_cpu.AutoSize = true;
            this.temperature_cpu.Location = new System.Drawing.Point(26, 45);
            this.temperature_cpu.Name = "temperature_cpu";
            this.temperature_cpu.Size = new System.Drawing.Size(18, 17);
            this.temperature_cpu.TabIndex = 4;
            this.temperature_cpu.Text = "--";
            this.temperature_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperature_gpu
            // 
            this.temperature_gpu.AutoSize = true;
            this.temperature_gpu.Location = new System.Drawing.Point(107, 45);
            this.temperature_gpu.Name = "temperature_gpu";
            this.temperature_gpu.Size = new System.Drawing.Size(18, 17);
            this.temperature_gpu.TabIndex = 5;
            this.temperature_gpu.Text = "--";
            // 
            // temperature_harddisk
            // 
            this.temperature_harddisk.AutoSize = true;
            this.temperature_harddisk.Location = new System.Drawing.Point(200, 45);
            this.temperature_harddisk.Name = "temperature_harddisk";
            this.temperature_harddisk.Size = new System.Drawing.Size(18, 17);
            this.temperature_harddisk.TabIndex = 6;
            this.temperature_harddisk.Text = "--";
            // 
            // temperature_mainboard
            // 
            this.temperature_mainboard.AutoSize = true;
            this.temperature_mainboard.Location = new System.Drawing.Point(290, 45);
            this.temperature_mainboard.Name = "temperature_mainboard";
            this.temperature_mainboard.Size = new System.Drawing.Size(18, 17);
            this.temperature_mainboard.TabIndex = 7;
            this.temperature_mainboard.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPU风速";
            // 
            // rotate_cpu
            // 
            this.rotate_cpu.AutoSize = true;
            this.rotate_cpu.Location = new System.Drawing.Point(26, 169);
            this.rotate_cpu.Name = "rotate_cpu";
            this.rotate_cpu.Size = new System.Drawing.Size(18, 17);
            this.rotate_cpu.TabIndex = 9;
            this.rotate_cpu.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "GPU风速";
            // 
            // rotate_gpu
            // 
            this.rotate_gpu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rotate_gpu.AutoSize = true;
            this.rotate_gpu.Location = new System.Drawing.Point(107, 169);
            this.rotate_gpu.Name = "rotate_gpu";
            this.rotate_gpu.Size = new System.Drawing.Size(18, 17);
            this.rotate_gpu.TabIndex = 11;
            this.rotate_gpu.Text = "--";
            // 
            // loabel6
            // 
            this.loabel6.AutoSize = true;
            this.loabel6.Location = new System.Drawing.Point(185, 199);
            this.loabel6.Name = "loabel6";
            this.loabel6.Size = new System.Drawing.Size(68, 17);
            this.loabel6.TabIndex = 12;
            this.loabel6.Text = "内存使用率";
            // 
            // load_memory
            // 
            this.load_memory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_memory.AutoSize = true;
            this.load_memory.Location = new System.Drawing.Point(190, 169);
            this.load_memory.Name = "load_memory";
            this.load_memory.Size = new System.Drawing.Size(18, 17);
            this.load_memory.TabIndex = 13;
            this.load_memory.Text = "--";
            this.load_memory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "CPU使用率";
            // 
            // load_cpu
            // 
            this.load_cpu.AutoSize = true;
            this.load_cpu.Location = new System.Drawing.Point(301, 169);
            this.load_cpu.Name = "load_cpu";
            this.load_cpu.Size = new System.Drawing.Size(18, 17);
            this.load_cpu.TabIndex = 15;
            this.load_cpu.Text = "--";
            this.load_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabcontrol_menu
            // 
            this.tabcontrol_menu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabcontrol_menu.AllowDrop = true;
            this.tabcontrol_menu.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabcontrol_menu.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabcontrol_menu.Controls.Add(this.tabpage_monitor);
            this.tabcontrol_menu.Controls.Add(this.tabpage_temperature);
            this.tabcontrol_menu.Controls.Add(this.tabpage_led);
            this.tabcontrol_menu.Controls.Add(this.tabpage_show);
            this.tabcontrol_menu.HeadBack = null;
            this.tabcontrol_menu.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabcontrol_menu.ItemSize = new System.Drawing.Size(70, 56);
            this.tabcontrol_menu.Location = new System.Drawing.Point(7, 56);
            this.tabcontrol_menu.Multiline = true;
            this.tabcontrol_menu.Name = "tabcontrol_menu";
            this.tabcontrol_menu.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabcontrol_menu.PageArrowDown")));
            this.tabcontrol_menu.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabcontrol_menu.PageArrowHover")));
            this.tabcontrol_menu.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabcontrol_menu.PageCloseHover")));
            this.tabcontrol_menu.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabcontrol_menu.PageCloseNormal")));
            this.tabcontrol_menu.PageDown = ((System.Drawing.Image)(resources.GetObject("tabcontrol_menu.PageDown")));
            this.tabcontrol_menu.PageHover = ((System.Drawing.Image)(resources.GetObject("tabcontrol_menu.PageHover")));
            this.tabcontrol_menu.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabcontrol_menu.PageNorml = null;
            this.tabcontrol_menu.SelectedIndex = 3;
            this.tabcontrol_menu.Size = new System.Drawing.Size(733, 490);
            this.tabcontrol_menu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcontrol_menu.TabIndex = 16;
            // 
            // tabpage_monitor
            // 
            this.tabpage_monitor.BackColor = System.Drawing.Color.Teal;
            this.tabpage_monitor.Controls.Add(this.skinLabel_mainboard_temperature);
            this.tabpage_monitor.Controls.Add(this.skinLabel3);
            this.tabpage_monitor.Controls.Add(this.skinLabel_disk_temperature);
            this.tabpage_monitor.Controls.Add(this.skinLabel1);
            this.tabpage_monitor.Controls.Add(this.aGauge_memory);
            this.tabpage_monitor.Controls.Add(this.aGauge_gpu);
            this.tabpage_monitor.Controls.Add(this.aGauge_cpu);
            this.tabpage_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpage_monitor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabpage_monitor.Location = new System.Drawing.Point(56, 0);
            this.tabpage_monitor.Name = "tabpage_monitor";
            this.tabpage_monitor.Size = new System.Drawing.Size(677, 490);
            this.tabpage_monitor.TabIndex = 0;
            this.tabpage_monitor.TabItemImage = null;
            this.tabpage_monitor.Text = "监视器";
            // 
            // skinLabel_mainboard_temperature
            // 
            this.skinLabel_mainboard_temperature.AutoSize = true;
            this.skinLabel_mainboard_temperature.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_mainboard_temperature.BorderColor = System.Drawing.Color.White;
            this.skinLabel_mainboard_temperature.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_mainboard_temperature.Location = new System.Drawing.Point(472, 311);
            this.skinLabel_mainboard_temperature.Name = "skinLabel_mainboard_temperature";
            this.skinLabel_mainboard_temperature.Size = new System.Drawing.Size(63, 30);
            this.skinLabel_mainboard_temperature.TabIndex = 6;
            this.skinLabel_mainboard_temperature.Text = "48℃";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(404, 354);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(208, 22);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "MainBoard Temperature";
            // 
            // skinLabel_disk_temperature
            // 
            this.skinLabel_disk_temperature.AutoSize = true;
            this.skinLabel_disk_temperature.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_disk_temperature.BorderColor = System.Drawing.Color.White;
            this.skinLabel_disk_temperature.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_disk_temperature.Location = new System.Drawing.Point(170, 311);
            this.skinLabel_disk_temperature.Name = "skinLabel_disk_temperature";
            this.skinLabel_disk_temperature.Size = new System.Drawing.Size(68, 31);
            this.skinLabel_disk_temperature.TabIndex = 4;
            this.skinLabel_disk_temperature.Text = "48℃";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(129, 354);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(158, 22);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "HDD Temperature";
            // 
            // aGauge_memory
            // 
            this.aGauge_memory.BackColor = System.Drawing.SystemColors.ControlText;
            this.aGauge_memory.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_memory.BaseArcRadius = 80;
            this.aGauge_memory.BaseArcStart = 135;
            this.aGauge_memory.BaseArcSweep = 270;
            this.aGauge_memory.BaseArcWidth = 2;
            this.aGauge_memory.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel1.Color = System.Drawing.Color.Lime;
            aGaugeLabel1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel1.Name = "gaugelabel_memory_load";
            aGaugeLabel1.Position = new System.Drawing.Point(80, 60);
            aGaugeLabel1.Text = "40%";
            aGaugeLabel2.Color = System.Drawing.SystemColors.MenuHighlight;
            aGaugeLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel2.Name = "GaugeLabel1";
            aGaugeLabel2.Position = new System.Drawing.Point(70, 120);
            aGaugeLabel2.Text = "Memory";
            aGaugeLabel3.Color = System.Drawing.Color.DarkCyan;
            aGaugeLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel3.Name = "gaugelabel_memory_used";
            aGaugeLabel3.Position = new System.Drawing.Point(50, 170);
            aGaugeLabel3.Text = "3.3 G";
            aGaugeLabel4.Color = System.Drawing.Color.DarkCyan;
            aGaugeLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel4.Name = "gaugelabel_memory_available";
            aGaugeLabel4.Position = new System.Drawing.Point(110, 170);
            aGaugeLabel4.Text = "4.4 G";
            aGaugeLabel5.Color = System.Drawing.Color.DarkCyan;
            aGaugeLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel5.Name = "GaugeLabel1";
            aGaugeLabel5.Position = new System.Drawing.Point(55, 190);
            aGaugeLabel5.Text = "used";
            aGaugeLabel6.Color = System.Drawing.Color.DarkCyan;
            aGaugeLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel6.Name = "GaugeLabel1";
            aGaugeLabel6.Position = new System.Drawing.Point(105, 190);
            aGaugeLabel6.Text = "available";
            this.aGauge_memory.GaugeLabels.Add(aGaugeLabel1);
            this.aGauge_memory.GaugeLabels.Add(aGaugeLabel2);
            this.aGauge_memory.GaugeLabels.Add(aGaugeLabel3);
            this.aGauge_memory.GaugeLabels.Add(aGaugeLabel4);
            this.aGauge_memory.GaugeLabels.Add(aGaugeLabel5);
            this.aGauge_memory.GaugeLabels.Add(aGaugeLabel6);
            aGaugeRange1.Color = System.Drawing.Color.Red;
            aGaugeRange1.EndValue = 100F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "AlertRange";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 90F;
            aGaugeRange2.Color = System.Drawing.Color.Lime;
            aGaugeRange2.EndValue = 90F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRange1";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 0F;
            this.aGauge_memory.GaugeRanges.Add(aGaugeRange1);
            this.aGauge_memory.GaugeRanges.Add(aGaugeRange2);
            this.aGauge_memory.Location = new System.Drawing.Point(477, 25);
            this.aGauge_memory.MaxValue = 100F;
            this.aGauge_memory.MinValue = 0F;
            this.aGauge_memory.Name = "aGauge_memory";
            this.aGauge_memory.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGauge_memory.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_memory.NeedleRadius = 80;
            this.aGauge_memory.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge_memory.NeedleWidth = 2;
            this.aGauge_memory.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_memory.ScaleLinesInterInnerRadius = 73;
            this.aGauge_memory.ScaleLinesInterOuterRadius = 80;
            this.aGauge_memory.ScaleLinesInterWidth = 1;
            this.aGauge_memory.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_memory.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_memory.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_memory.ScaleLinesMajorStepValue = 10F;
            this.aGauge_memory.ScaleLinesMajorWidth = 2;
            this.aGauge_memory.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_memory.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_memory.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_memory.ScaleLinesMinorTicks = 9;
            this.aGauge_memory.ScaleLinesMinorWidth = 1;
            this.aGauge_memory.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_memory.ScaleNumbersFormat = null;
            this.aGauge_memory.ScaleNumbersRadius = 95;
            this.aGauge_memory.ScaleNumbersRotation = 0;
            this.aGauge_memory.ScaleNumbersStartScaleLine = 0;
            this.aGauge_memory.ScaleNumbersStepScaleLines = 1;
            this.aGauge_memory.Size = new System.Drawing.Size(205, 230);
            this.aGauge_memory.TabIndex = 2;
            this.aGauge_memory.Text = "aGauge1";
            this.aGauge_memory.Value = 0F;
            this.aGauge_memory.ValueChanged += new System.EventHandler(this.aGauge_memory_ValueChanged);
            // 
            // aGauge_gpu
            // 
            this.aGauge_gpu.BackColor = System.Drawing.SystemColors.ControlText;
            this.aGauge_gpu.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_gpu.BaseArcRadius = 80;
            this.aGauge_gpu.BaseArcStart = 135;
            this.aGauge_gpu.BaseArcSweep = 270;
            this.aGauge_gpu.BaseArcWidth = 2;
            this.aGauge_gpu.Center = new System.Drawing.Point(100, 100);
            this.aGauge_gpu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel7.Color = System.Drawing.Color.Lime;
            aGaugeLabel7.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel7.Name = "gaugelabel_gpu_load";
            aGaugeLabel7.Position = new System.Drawing.Point(80, 60);
            aGaugeLabel7.Text = "38%";
            aGaugeLabel8.Color = System.Drawing.SystemColors.MenuHighlight;
            aGaugeLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel8.Name = "GaugeLabel1";
            aGaugeLabel8.Position = new System.Drawing.Point(85, 120);
            aGaugeLabel8.Text = "GPU";
            aGaugeLabel9.Color = System.Drawing.Color.DarkCyan;
            aGaugeLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel9.Name = "gaugelabel_gpu_temperature";
            aGaugeLabel9.Position = new System.Drawing.Point(110, 185);
            aGaugeLabel9.Text = "--- ℃";
            aGaugeLabel10.Color = System.Drawing.Color.DarkCyan;
            aGaugeLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel10.Name = "gaugelabel_gpu_fan";
            aGaugeLabel10.Position = new System.Drawing.Point(30, 185);
            aGaugeLabel10.Text = "--- rpm";
            this.aGauge_gpu.GaugeLabels.Add(aGaugeLabel7);
            this.aGauge_gpu.GaugeLabels.Add(aGaugeLabel8);
            this.aGauge_gpu.GaugeLabels.Add(aGaugeLabel9);
            this.aGauge_gpu.GaugeLabels.Add(aGaugeLabel10);
            aGaugeRange3.Color = System.Drawing.Color.Red;
            aGaugeRange3.EndValue = 100F;
            aGaugeRange3.InnerRadius = 70;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "AlertRange";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 80F;
            aGaugeRange4.Color = System.Drawing.Color.Lime;
            aGaugeRange4.EndValue = 80F;
            aGaugeRange4.InnerRadius = 70;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "GaugeRange1";
            aGaugeRange4.OuterRadius = 80;
            aGaugeRange4.StartValue = 0F;
            this.aGauge_gpu.GaugeRanges.Add(aGaugeRange3);
            this.aGauge_gpu.GaugeRanges.Add(aGaugeRange4);
            this.aGauge_gpu.Location = new System.Drawing.Point(246, 25);
            this.aGauge_gpu.MaxValue = 100F;
            this.aGauge_gpu.MinValue = 0F;
            this.aGauge_gpu.Name = "aGauge_gpu";
            this.aGauge_gpu.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGauge_gpu.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_gpu.NeedleRadius = 80;
            this.aGauge_gpu.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge_gpu.NeedleWidth = 2;
            this.aGauge_gpu.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_gpu.ScaleLinesInterInnerRadius = 73;
            this.aGauge_gpu.ScaleLinesInterOuterRadius = 80;
            this.aGauge_gpu.ScaleLinesInterWidth = 1;
            this.aGauge_gpu.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_gpu.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_gpu.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_gpu.ScaleLinesMajorStepValue = 10F;
            this.aGauge_gpu.ScaleLinesMajorWidth = 2;
            this.aGauge_gpu.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_gpu.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_gpu.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_gpu.ScaleLinesMinorTicks = 9;
            this.aGauge_gpu.ScaleLinesMinorWidth = 1;
            this.aGauge_gpu.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_gpu.ScaleNumbersFormat = null;
            this.aGauge_gpu.ScaleNumbersRadius = 95;
            this.aGauge_gpu.ScaleNumbersRotation = 0;
            this.aGauge_gpu.ScaleNumbersStartScaleLine = 0;
            this.aGauge_gpu.ScaleNumbersStepScaleLines = 1;
            this.aGauge_gpu.Size = new System.Drawing.Size(205, 230);
            this.aGauge_gpu.TabIndex = 1;
            this.aGauge_gpu.Text = "aGauge2";
            this.aGauge_gpu.Value = 0F;
            this.aGauge_gpu.ValueChanged += new System.EventHandler(this.aGauge_gpu_ValueChanged);
            // 
            // aGauge_cpu
            // 
            this.aGauge_cpu.BackColor = System.Drawing.SystemColors.ControlText;
            this.aGauge_cpu.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_cpu.BaseArcRadius = 80;
            this.aGauge_cpu.BaseArcStart = 135;
            this.aGauge_cpu.BaseArcSweep = 270;
            this.aGauge_cpu.BaseArcWidth = 2;
            this.aGauge_cpu.Center = new System.Drawing.Point(100, 100);
            this.aGauge_cpu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel11.Color = System.Drawing.Color.Lime;
            aGaugeLabel11.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel11.Name = "gaugelabel_cpu_load";
            aGaugeLabel11.Position = new System.Drawing.Point(80, 60);
            aGaugeLabel11.Text = "39%";
            aGaugeLabel12.Color = System.Drawing.SystemColors.MenuHighlight;
            aGaugeLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel12.Name = "GaugeLabel2";
            aGaugeLabel12.Position = new System.Drawing.Point(85, 120);
            aGaugeLabel12.Text = "CPU";
            aGaugeLabel13.Color = System.Drawing.Color.DarkCyan;
            aGaugeLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel13.Name = "gaugelabel_cpu_temperature";
            aGaugeLabel13.Position = new System.Drawing.Point(110, 185);
            aGaugeLabel13.Text = "--- ℃";
            aGaugeLabel14.Color = System.Drawing.Color.DarkCyan;
            aGaugeLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            aGaugeLabel14.Name = "gaugelabel_cpu_fan";
            aGaugeLabel14.Position = new System.Drawing.Point(30, 185);
            aGaugeLabel14.Text = "--- rpm";
            this.aGauge_cpu.GaugeLabels.Add(aGaugeLabel11);
            this.aGauge_cpu.GaugeLabels.Add(aGaugeLabel12);
            this.aGauge_cpu.GaugeLabels.Add(aGaugeLabel13);
            this.aGauge_cpu.GaugeLabels.Add(aGaugeLabel14);
            aGaugeRange5.Color = System.Drawing.Color.Red;
            aGaugeRange5.EndValue = 100F;
            aGaugeRange5.InnerRadius = 70;
            aGaugeRange5.InRange = false;
            aGaugeRange5.Name = "AlertRange";
            aGaugeRange5.OuterRadius = 80;
            aGaugeRange5.StartValue = 80F;
            aGaugeRange6.Color = System.Drawing.Color.Lime;
            aGaugeRange6.EndValue = 80F;
            aGaugeRange6.InnerRadius = 70;
            aGaugeRange6.InRange = false;
            aGaugeRange6.Name = "GaugeRange1";
            aGaugeRange6.OuterRadius = 80;
            aGaugeRange6.StartValue = 0F;
            this.aGauge_cpu.GaugeRanges.Add(aGaugeRange5);
            this.aGauge_cpu.GaugeRanges.Add(aGaugeRange6);
            this.aGauge_cpu.Location = new System.Drawing.Point(16, 25);
            this.aGauge_cpu.MaxValue = 100F;
            this.aGauge_cpu.MinValue = 0F;
            this.aGauge_cpu.Name = "aGauge_cpu";
            this.aGauge_cpu.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGauge_cpu.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_cpu.NeedleRadius = 80;
            this.aGauge_cpu.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge_cpu.NeedleWidth = 2;
            this.aGauge_cpu.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_cpu.ScaleLinesInterInnerRadius = 73;
            this.aGauge_cpu.ScaleLinesInterOuterRadius = 80;
            this.aGauge_cpu.ScaleLinesInterWidth = 1;
            this.aGauge_cpu.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_cpu.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_cpu.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_cpu.ScaleLinesMajorStepValue = 10F;
            this.aGauge_cpu.ScaleLinesMajorWidth = 2;
            this.aGauge_cpu.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_cpu.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_cpu.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_cpu.ScaleLinesMinorTicks = 9;
            this.aGauge_cpu.ScaleLinesMinorWidth = 1;
            this.aGauge_cpu.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_cpu.ScaleNumbersFormat = null;
            this.aGauge_cpu.ScaleNumbersRadius = 95;
            this.aGauge_cpu.ScaleNumbersRotation = 0;
            this.aGauge_cpu.ScaleNumbersStartScaleLine = 0;
            this.aGauge_cpu.ScaleNumbersStepScaleLines = 1;
            this.aGauge_cpu.Size = new System.Drawing.Size(205, 230);
            this.aGauge_cpu.TabIndex = 0;
            this.aGauge_cpu.Text = "aGauge1";
            this.aGauge_cpu.Value = 0F;
            this.aGauge_cpu.ValueChanged += new System.EventHandler(this.aGauge_cpu_temperature_ValueChanged);
            // 
            // tabpage_temperature
            // 
            this.tabpage_temperature.BackColor = System.Drawing.Color.White;
            this.tabpage_temperature.Controls.Add(this.btnAdjust_hdd);
            this.tabpage_temperature.Controls.Add(this.btnAdjust_mainboard);
            this.tabpage_temperature.Controls.Add(this.btnAdjust_gpu);
            this.tabpage_temperature.Controls.Add(this.btnAdjust_cpu);
            this.tabpage_temperature.Controls.Add(this.skinLabel18);
            this.tabpage_temperature.Controls.Add(this.cmb_hdd_temp_threshold);
            this.tabpage_temperature.Controls.Add(this.skinLabel17);
            this.tabpage_temperature.Controls.Add(this.skinLabel16);
            this.tabpage_temperature.Controls.Add(this.cmb_mainboard_temp__threshold);
            this.tabpage_temperature.Controls.Add(this.skinLabel15);
            this.tabpage_temperature.Controls.Add(this.skinLabel14);
            this.tabpage_temperature.Controls.Add(this.cmb_gpu_temp__threshold);
            this.tabpage_temperature.Controls.Add(this.skinLabel13);
            this.tabpage_temperature.Controls.Add(this.cmb_cpu_temp__threshold);
            this.tabpage_temperature.Controls.Add(this.skinLabel12);
            this.tabpage_temperature.Controls.Add(this.skinLabel11);
            this.tabpage_temperature.Controls.Add(this.trb_cpu_fan);
            this.tabpage_temperature.Controls.Add(this.skinLabel10);
            this.tabpage_temperature.Controls.Add(this.skinLabel9);
            this.tabpage_temperature.Controls.Add(this.trb_gpu_fan);
            this.tabpage_temperature.Controls.Add(this.rdo_auto_adjustment);
            this.tabpage_temperature.Controls.Add(this.rdo_manual_adjustment);
            this.tabpage_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpage_temperature.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabpage_temperature.Location = new System.Drawing.Point(56, 0);
            this.tabpage_temperature.Name = "tabpage_temperature";
            this.tabpage_temperature.Size = new System.Drawing.Size(677, 490);
            this.tabpage_temperature.TabIndex = 3;
            this.tabpage_temperature.TabItemImage = null;
            this.tabpage_temperature.Text = "温度管理";
            // 
            // btnAdjust_hdd
            // 
            this.btnAdjust_hdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjust_hdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdjust_hdd.DownBack = null;
            this.btnAdjust_hdd.Location = new System.Drawing.Point(436, 399);
            this.btnAdjust_hdd.MouseBack = null;
            this.btnAdjust_hdd.Name = "btnAdjust_hdd";
            this.btnAdjust_hdd.NormlBack = null;
            this.btnAdjust_hdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust_hdd.TabIndex = 21;
            this.btnAdjust_hdd.Text = "调整方案";
            this.btnAdjust_hdd.UseVisualStyleBackColor = false;
            // 
            // btnAdjust_mainboard
            // 
            this.btnAdjust_mainboard.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjust_mainboard.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdjust_mainboard.DownBack = null;
            this.btnAdjust_mainboard.Location = new System.Drawing.Point(436, 358);
            this.btnAdjust_mainboard.MouseBack = null;
            this.btnAdjust_mainboard.Name = "btnAdjust_mainboard";
            this.btnAdjust_mainboard.NormlBack = null;
            this.btnAdjust_mainboard.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust_mainboard.TabIndex = 20;
            this.btnAdjust_mainboard.Text = "调整方案";
            this.btnAdjust_mainboard.UseVisualStyleBackColor = false;
            // 
            // btnAdjust_gpu
            // 
            this.btnAdjust_gpu.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjust_gpu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdjust_gpu.DownBack = null;
            this.btnAdjust_gpu.Location = new System.Drawing.Point(436, 318);
            this.btnAdjust_gpu.MouseBack = null;
            this.btnAdjust_gpu.Name = "btnAdjust_gpu";
            this.btnAdjust_gpu.NormlBack = null;
            this.btnAdjust_gpu.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust_gpu.TabIndex = 19;
            this.btnAdjust_gpu.Text = "调整方案";
            this.btnAdjust_gpu.UseVisualStyleBackColor = false;
            // 
            // btnAdjust_cpu
            // 
            this.btnAdjust_cpu.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjust_cpu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdjust_cpu.DownBack = null;
            this.btnAdjust_cpu.Location = new System.Drawing.Point(436, 277);
            this.btnAdjust_cpu.MouseBack = null;
            this.btnAdjust_cpu.Name = "btnAdjust_cpu";
            this.btnAdjust_cpu.NormlBack = null;
            this.btnAdjust_cpu.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust_cpu.TabIndex = 18;
            this.btnAdjust_cpu.Text = "调整方案";
            this.btnAdjust_cpu.UseVisualStyleBackColor = false;
            // 
            // skinLabel18
            // 
            this.skinLabel18.AutoSize = true;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel18.Location = new System.Drawing.Point(342, 405);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(56, 17);
            this.skinLabel18.TabIndex = 17;
            this.skinLabel18.Text = "自动调节";
            // 
            // cmb_hdd_temp_threshold
            // 
            this.cmb_hdd_temp_threshold.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_hdd_temp_threshold.FormattingEnabled = true;
            this.cmb_hdd_temp_threshold.Items.AddRange(new object[] {
            "40℃",
            "50℃",
            "60℃",
            "70℃",
            "80℃",
            "90℃",
            "100℃"});
            this.cmb_hdd_temp_threshold.Location = new System.Drawing.Point(240, 401);
            this.cmb_hdd_temp_threshold.Name = "cmb_hdd_temp_threshold";
            this.cmb_hdd_temp_threshold.Size = new System.Drawing.Size(96, 24);
            this.cmb_hdd_temp_threshold.TabIndex = 16;
            this.cmb_hdd_temp_threshold.WaterText = "";
            // 
            // skinLabel17
            // 
            this.skinLabel17.AutoSize = true;
            this.skinLabel17.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel17.BorderColor = System.Drawing.Color.White;
            this.skinLabel17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel17.Location = new System.Drawing.Point(155, 405);
            this.skinLabel17.Name = "skinLabel17";
            this.skinLabel17.Size = new System.Drawing.Size(80, 17);
            this.skinLabel17.TabIndex = 15;
            this.skinLabel17.Text = "硬盘温度超过";
            // 
            // skinLabel16
            // 
            this.skinLabel16.AutoSize = true;
            this.skinLabel16.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel16.BorderColor = System.Drawing.Color.White;
            this.skinLabel16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel16.Location = new System.Drawing.Point(342, 362);
            this.skinLabel16.Name = "skinLabel16";
            this.skinLabel16.Size = new System.Drawing.Size(56, 17);
            this.skinLabel16.TabIndex = 14;
            this.skinLabel16.Text = "自动调节";
            // 
            // cmb_mainboard_temp__threshold
            // 
            this.cmb_mainboard_temp__threshold.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_mainboard_temp__threshold.FormattingEnabled = true;
            this.cmb_mainboard_temp__threshold.Items.AddRange(new object[] {
            "40℃",
            "50℃",
            "60℃",
            "70℃",
            "80℃",
            "90℃",
            "100℃"});
            this.cmb_mainboard_temp__threshold.Location = new System.Drawing.Point(240, 358);
            this.cmb_mainboard_temp__threshold.Name = "cmb_mainboard_temp__threshold";
            this.cmb_mainboard_temp__threshold.Size = new System.Drawing.Size(96, 24);
            this.cmb_mainboard_temp__threshold.TabIndex = 13;
            this.cmb_mainboard_temp__threshold.WaterText = "";
            // 
            // skinLabel15
            // 
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel15.Location = new System.Drawing.Point(154, 362);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(80, 17);
            this.skinLabel15.TabIndex = 12;
            this.skinLabel15.Text = "主板温度超过";
            // 
            // skinLabel14
            // 
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel14.Location = new System.Drawing.Point(342, 321);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(56, 17);
            this.skinLabel14.TabIndex = 11;
            this.skinLabel14.Text = "自动调节";
            // 
            // cmb_gpu_temp__threshold
            // 
            this.cmb_gpu_temp__threshold.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_gpu_temp__threshold.FormattingEnabled = true;
            this.cmb_gpu_temp__threshold.Items.AddRange(new object[] {
            "40℃",
            "50℃",
            "60℃",
            "70℃",
            "80℃",
            "90℃",
            "100℃"});
            this.cmb_gpu_temp__threshold.Location = new System.Drawing.Point(240, 317);
            this.cmb_gpu_temp__threshold.Name = "cmb_gpu_temp__threshold";
            this.cmb_gpu_temp__threshold.Size = new System.Drawing.Size(96, 24);
            this.cmb_gpu_temp__threshold.TabIndex = 10;
            this.cmb_gpu_temp__threshold.WaterText = "";
            // 
            // skinLabel13
            // 
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel13.Location = new System.Drawing.Point(155, 321);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(81, 17);
            this.skinLabel13.TabIndex = 9;
            this.skinLabel13.Text = "GPU温度超过";
            // 
            // cmb_cpu_temp__threshold
            // 
            this.cmb_cpu_temp__threshold.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_cpu_temp__threshold.FormattingEnabled = true;
            this.cmb_cpu_temp__threshold.Items.AddRange(new object[] {
            "40℃",
            "50℃",
            "60℃",
            "70℃",
            "80℃",
            "90℃",
            "100℃"});
            this.cmb_cpu_temp__threshold.Location = new System.Drawing.Point(240, 276);
            this.cmb_cpu_temp__threshold.Name = "cmb_cpu_temp__threshold";
            this.cmb_cpu_temp__threshold.Size = new System.Drawing.Size(96, 24);
            this.cmb_cpu_temp__threshold.TabIndex = 8;
            this.cmb_cpu_temp__threshold.WaterText = "";
            // 
            // skinLabel12
            // 
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(342, 280);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(56, 17);
            this.skinLabel12.TabIndex = 7;
            this.skinLabel12.Text = "自动调节";
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(155, 280);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(80, 17);
            this.skinLabel11.TabIndex = 6;
            this.skinLabel11.Text = "CPU温度超过";
            // 
            // trb_cpu_fan
            // 
            this.trb_cpu_fan.BackColor = System.Drawing.Color.Transparent;
            this.trb_cpu_fan.Bar = null;
            this.trb_cpu_fan.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.trb_cpu_fan.Location = new System.Drawing.Point(155, 150);
            this.trb_cpu_fan.Name = "trb_cpu_fan";
            this.trb_cpu_fan.Size = new System.Drawing.Size(104, 45);
            this.trb_cpu_fan.TabIndex = 5;
            this.trb_cpu_fan.Track = null;
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(83, 164);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(56, 17);
            this.skinLabel10.TabIndex = 4;
            this.skinLabel10.Text = "CPU Fan";
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(83, 99);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(57, 17);
            this.skinLabel9.TabIndex = 3;
            this.skinLabel9.Text = "GPU Fan";
            // 
            // trb_gpu_fan
            // 
            this.trb_gpu_fan.BackColor = System.Drawing.Color.Transparent;
            this.trb_gpu_fan.Bar = null;
            this.trb_gpu_fan.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.trb_gpu_fan.Location = new System.Drawing.Point(155, 85);
            this.trb_gpu_fan.Name = "trb_gpu_fan";
            this.trb_gpu_fan.Size = new System.Drawing.Size(104, 45);
            this.trb_gpu_fan.TabIndex = 2;
            this.trb_gpu_fan.Track = null;
            // 
            // rdo_auto_adjustment
            // 
            this.rdo_auto_adjustment.AutoSize = true;
            this.rdo_auto_adjustment.BackColor = System.Drawing.Color.Transparent;
            this.rdo_auto_adjustment.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdo_auto_adjustment.DownBack = null;
            this.rdo_auto_adjustment.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_auto_adjustment.Location = new System.Drawing.Point(66, 245);
            this.rdo_auto_adjustment.MouseBack = null;
            this.rdo_auto_adjustment.Name = "rdo_auto_adjustment";
            this.rdo_auto_adjustment.NormlBack = null;
            this.rdo_auto_adjustment.SelectedDownBack = null;
            this.rdo_auto_adjustment.SelectedMouseBack = null;
            this.rdo_auto_adjustment.SelectedNormlBack = null;
            this.rdo_auto_adjustment.Size = new System.Drawing.Size(74, 21);
            this.rdo_auto_adjustment.TabIndex = 1;
            this.rdo_auto_adjustment.TabStop = true;
            this.rdo_auto_adjustment.Text = "智能调节";
            this.rdo_auto_adjustment.UseVisualStyleBackColor = false;
            // 
            // rdo_manual_adjustment
            // 
            this.rdo_manual_adjustment.AutoSize = true;
            this.rdo_manual_adjustment.BackColor = System.Drawing.Color.Transparent;
            this.rdo_manual_adjustment.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdo_manual_adjustment.DownBack = null;
            this.rdo_manual_adjustment.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_manual_adjustment.Location = new System.Drawing.Point(66, 45);
            this.rdo_manual_adjustment.MouseBack = null;
            this.rdo_manual_adjustment.Name = "rdo_manual_adjustment";
            this.rdo_manual_adjustment.NormlBack = null;
            this.rdo_manual_adjustment.SelectedDownBack = null;
            this.rdo_manual_adjustment.SelectedMouseBack = null;
            this.rdo_manual_adjustment.SelectedNormlBack = null;
            this.rdo_manual_adjustment.Size = new System.Drawing.Size(74, 21);
            this.rdo_manual_adjustment.TabIndex = 0;
            this.rdo_manual_adjustment.TabStop = true;
            this.rdo_manual_adjustment.Text = "手动调节";
            this.rdo_manual_adjustment.UseVisualStyleBackColor = false;
            // 
            // tabpage_led
            // 
            this.tabpage_led.BackColor = System.Drawing.Color.Teal;
            this.tabpage_led.Controls.Add(this.skinGroupBox2);
            this.tabpage_led.Controls.Add(this.skinGroupBox1);
            this.tabpage_led.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpage_led.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabpage_led.Location = new System.Drawing.Point(56, 0);
            this.tabpage_led.Name = "tabpage_led";
            this.tabpage_led.Size = new System.Drawing.Size(677, 490);
            this.tabpage_led.TabIndex = 1;
            this.tabpage_led.TabItemImage = null;
            this.tabpage_led.Text = "灯带";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBox2.Controls.Add(this.skinColorSelectPanel2);
            this.skinGroupBox2.Controls.Add(this.skinTrackBar4);
            this.skinGroupBox2.Controls.Add(this.skinTrackBar3);
            this.skinGroupBox2.Controls.Add(this.skinLabel8);
            this.skinGroupBox2.Controls.Add(this.skinLabel6);
            this.skinGroupBox2.Controls.Add(this.skinLabel7);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Location = new System.Drawing.Point(29, 253);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.Teal;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(642, 219);
            this.skinGroupBox2.TabIndex = 3;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "GPU";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Empty;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinColorSelectPanel2
            // 
            this.skinColorSelectPanel2.Location = new System.Drawing.Point(122, 98);
            this.skinColorSelectPanel2.Name = "skinColorSelectPanel2";
            this.skinColorSelectPanel2.Size = new System.Drawing.Size(271, 23);
            this.skinColorSelectPanel2.TabIndex = 11;
            this.skinColorSelectPanel2.Text = "skinColorSelectPanel2";
            // 
            // skinTrackBar4
            // 
            this.skinTrackBar4.BackColor = System.Drawing.Color.Transparent;
            this.skinTrackBar4.Bar = null;
            this.skinTrackBar4.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.skinTrackBar4.Location = new System.Drawing.Point(122, 20);
            this.skinTrackBar4.Name = "skinTrackBar4";
            this.skinTrackBar4.Size = new System.Drawing.Size(271, 45);
            this.skinTrackBar4.TabIndex = 7;
            this.skinTrackBar4.Track = null;
            // 
            // skinTrackBar3
            // 
            this.skinTrackBar3.BackColor = System.Drawing.Color.Transparent;
            this.skinTrackBar3.Bar = null;
            this.skinTrackBar3.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.skinTrackBar3.Location = new System.Drawing.Point(122, 154);
            this.skinTrackBar3.Name = "skinTrackBar3";
            this.skinTrackBar3.Size = new System.Drawing.Size(271, 45);
            this.skinTrackBar3.TabIndex = 10;
            this.skinTrackBar3.Track = null;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(48, 34);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(56, 17);
            this.skinLabel8.TabIndex = 6;
            this.skinLabel8.Text = "亮度调节";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(48, 168);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(56, 17);
            this.skinLabel6.TabIndex = 9;
            this.skinLabel6.Text = "灯光速度";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(72, 101);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 8;
            this.skinLabel7.Text = "颜色";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Teal;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBox1.Controls.Add(this.skinColorSelectPanel1);
            this.skinGroupBox1.Controls.Add(this.skinTrackBar2);
            this.skinGroupBox1.Controls.Add(this.skinLabel5);
            this.skinGroupBox1.Controls.Add(this.skinLabel4);
            this.skinGroupBox1.Controls.Add(this.skinTrackBar1);
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(29, 16);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Teal;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(642, 219);
            this.skinGroupBox1.TabIndex = 2;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "CPU";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinColorSelectPanel1
            // 
            this.skinColorSelectPanel1.Location = new System.Drawing.Point(122, 104);
            this.skinColorSelectPanel1.Name = "skinColorSelectPanel1";
            this.skinColorSelectPanel1.Size = new System.Drawing.Size(271, 23);
            this.skinColorSelectPanel1.TabIndex = 5;
            this.skinColorSelectPanel1.Text = "skinColorSelectPanel1";
            // 
            // skinTrackBar2
            // 
            this.skinTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.skinTrackBar2.Bar = null;
            this.skinTrackBar2.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.skinTrackBar2.Location = new System.Drawing.Point(122, 160);
            this.skinTrackBar2.Name = "skinTrackBar2";
            this.skinTrackBar2.Size = new System.Drawing.Size(271, 45);
            this.skinTrackBar2.TabIndex = 4;
            this.skinTrackBar2.Track = null;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(48, 174);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 3;
            this.skinLabel5.Text = "灯光速度";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(72, 107);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 2;
            this.skinLabel4.Text = "颜色";
            // 
            // skinTrackBar1
            // 
            this.skinTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinTrackBar1.Bar = null;
            this.skinTrackBar1.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.skinTrackBar1.Location = new System.Drawing.Point(122, 26);
            this.skinTrackBar1.Name = "skinTrackBar1";
            this.skinTrackBar1.Size = new System.Drawing.Size(271, 45);
            this.skinTrackBar1.TabIndex = 1;
            this.skinTrackBar1.Track = null;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(48, 40);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "亮度调节";
            // 
            // tabpage_show
            // 
            this.tabpage_show.BackColor = System.Drawing.Color.Teal;
            this.tabpage_show.Controls.Add(this.temperature_cpu);
            this.tabpage_show.Controls.Add(this.load_cpu);
            this.tabpage_show.Controls.Add(this.label1);
            this.tabpage_show.Controls.Add(this.label7);
            this.tabpage_show.Controls.Add(this.label2);
            this.tabpage_show.Controls.Add(this.load_memory);
            this.tabpage_show.Controls.Add(this.label3);
            this.tabpage_show.Controls.Add(this.loabel6);
            this.tabpage_show.Controls.Add(this.label4);
            this.tabpage_show.Controls.Add(this.rotate_gpu);
            this.tabpage_show.Controls.Add(this.temperature_gpu);
            this.tabpage_show.Controls.Add(this.label6);
            this.tabpage_show.Controls.Add(this.temperature_harddisk);
            this.tabpage_show.Controls.Add(this.rotate_cpu);
            this.tabpage_show.Controls.Add(this.temperature_mainboard);
            this.tabpage_show.Controls.Add(this.label5);
            this.tabpage_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpage_show.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabpage_show.Location = new System.Drawing.Point(56, 0);
            this.tabpage_show.Name = "tabpage_show";
            this.tabpage_show.Size = new System.Drawing.Size(677, 490);
            this.tabpage_show.TabIndex = 2;
            this.tabpage_show.TabItemImage = null;
            this.tabpage_show.Text = "显示屏";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.NotifyMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "信息采集";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(759, 553);
            this.ControlBoxActive = System.Drawing.Color.Silver;
            this.Controls.Add(this.tabcontrol_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "信息采集";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tabcontrol_menu.ResumeLayout(false);
            this.tabpage_monitor.ResumeLayout(false);
            this.tabpage_monitor.PerformLayout();
            this.tabpage_temperature.ResumeLayout(false);
            this.tabpage_temperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_cpu_fan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_gpu_fan)).EndInit();
            this.tabpage_led.ResumeLayout(false);
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar3)).EndInit();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar1)).EndInit();
            this.tabpage_show.ResumeLayout(false);
            this.tabpage_show.PerformLayout();
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label temperature_cpu;
        private System.Windows.Forms.Label temperature_gpu;
        private System.Windows.Forms.Label temperature_harddisk;
        private System.Windows.Forms.Label temperature_mainboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rotate_cpu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rotate_gpu;
        private System.Windows.Forms.Label loabel6;
        private System.Windows.Forms.Label load_memory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label load_cpu;
        private CCWin.SkinControl.SkinTabControl tabcontrol_menu;
        private CCWin.SkinControl.SkinTabPage tabpage_monitor;
        private CCWin.SkinControl.SkinTabPage tabpage_led;
        private CCWin.SkinControl.SkinTabPage tabpage_show;
        private System.Windows.Forms.AGauge aGauge_gpu;
        private System.Windows.Forms.AGauge aGauge_cpu;
        private System.Windows.Forms.AGauge aGauge_memory;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel_disk_temperature;
        private CCWin.SkinControl.SkinLabel skinLabel_mainboard_temperature;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinTrackBar skinTrackBar1;
        private CCWin.SkinControl.SkinTrackBar skinTrackBar2;
        private CCWin.SkinControl.SkinColorSelectPanel skinColorSelectPanel1;
        private CCWin.SkinControl.SkinColorSelectPanel skinColorSelectPanel2;
        private CCWin.SkinControl.SkinTrackBar skinTrackBar4;
        private CCWin.SkinControl.SkinTrackBar skinTrackBar3;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private CCWin.SkinControl.SkinTabPage tabpage_temperature;
        private CCWin.SkinControl.SkinRadioButton rdo_auto_adjustment;
        private CCWin.SkinControl.SkinRadioButton rdo_manual_adjustment;
        private CCWin.SkinControl.SkinTrackBar trb_gpu_fan;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinTrackBar trb_cpu_fan;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinComboBox cmb_cpu_temp__threshold;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private CCWin.SkinControl.SkinComboBox cmb_gpu_temp__threshold;
        private CCWin.SkinControl.SkinLabel skinLabel15;
        private CCWin.SkinControl.SkinComboBox cmb_mainboard_temp__threshold;
        private CCWin.SkinControl.SkinLabel skinLabel16;
        private CCWin.SkinControl.SkinLabel skinLabel17;
        private CCWin.SkinControl.SkinComboBox cmb_hdd_temp_threshold;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private CCWin.SkinControl.SkinButton btnAdjust_cpu;
        private CCWin.SkinControl.SkinButton btnAdjust_gpu;
        private CCWin.SkinControl.SkinButton btnAdjust_hdd;
        private CCWin.SkinControl.SkinButton btnAdjust_mainboard;
    }
}

