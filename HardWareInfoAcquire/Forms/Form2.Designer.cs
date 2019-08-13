namespace HardWareInfoAcquire.Forms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sensor", 26, 26);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Controllers", 15, 15);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Fans", 25, 25);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Outputs", 27, 27);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Pumps");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("AQ 5", -2, -2, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点5", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.treeViewMenu = new CCWin.SkinControl.SkinTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.LineBack = System.Drawing.Color.Silver;
            this.skinSplitContainer1.LineBack2 = System.Drawing.Color.Silver;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.treeViewMenu);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1285, 626);
            this.skinSplitContainer1.SplitterDistance = 279;
            this.skinSplitContainer1.SplitterWidth = 7;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMenu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewMenu.ImageIndex = 0;
            this.treeViewMenu.ImageList = this.imageList1;
            this.treeViewMenu.Location = new System.Drawing.Point(0, 0);
            this.treeViewMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.BackColor = System.Drawing.Color.DarkGray;
            treeNode1.ImageIndex = 26;
            treeNode1.Name = "sensor";
            treeNode1.SelectedImageIndex = 26;
            treeNode1.Text = "Sensor";
            treeNode2.ImageIndex = 15;
            treeNode2.Name = "节点3";
            treeNode2.SelectedImageIndex = 15;
            treeNode2.Text = "Controllers";
            treeNode3.ImageIndex = 25;
            treeNode3.Name = "节点4";
            treeNode3.SelectedImageIndex = 25;
            treeNode3.Text = "Fans";
            treeNode4.ImageIndex = 27;
            treeNode4.Name = "节点0";
            treeNode4.SelectedImageIndex = 27;
            treeNode4.Text = "Outputs";
            treeNode5.ImageKey = "pump.png";
            treeNode5.Name = "节点1";
            treeNode5.SelectedImageKey = "pump.png";
            treeNode5.Text = "Pumps";
            treeNode6.ImageIndex = -2;
            treeNode6.Name = "节点0";
            treeNode6.SelectedImageIndex = -2;
            treeNode6.Text = "AQ 5";
            treeNode7.Name = "节点6";
            treeNode7.Text = "节点6";
            treeNode8.Name = "节点7";
            treeNode8.Text = "节点7";
            treeNode9.Name = "节点8";
            treeNode9.Text = "节点8";
            treeNode10.Name = "节点9";
            treeNode10.Text = "节点9";
            treeNode11.Name = "节点10";
            treeNode11.Text = "节点10";
            treeNode12.Name = "节点5";
            treeNode12.Text = "节点5";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12});
            this.treeViewMenu.SelectedImageIndex = 0;
            this.treeViewMenu.Size = new System.Drawing.Size(279, 626);
            this.treeViewMenu.TabIndex = 0;
            this.treeViewMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.skinTreeView1_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "acicon70.png");
            this.imageList1.Images.SetKeyName(1, "acicon150.png");
            this.imageList1.Images.SetKeyName(2, "alarm_0.png");
            this.imageList1.Images.SetKeyName(3, "alarm_1.png");
            this.imageList1.Images.SetKeyName(4, "alarm_2.png");
            this.imageList1.Images.SetKeyName(5, "alarm_icon_16.png");
            this.imageList1.Images.SetKeyName(6, "aquaduct_0.png");
            this.imageList1.Images.SetKeyName(7, "aquaduct_50.png");
            this.imageList1.Images.SetKeyName(8, "aquaduct_100.png");
            this.imageList1.Images.SetKeyName(9, "aquaduct_eco_240.png");
            this.imageList1.Images.SetKeyName(10, "aquaduct_eco_360.png");
            this.imageList1.Images.SetKeyName(11, "aqualis_fill_20.png");
            this.imageList1.Images.SetKeyName(12, "aqualis_fill_50.png");
            this.imageList1.Images.SetKeyName(13, "aqualis_fill_100.png");
            this.imageList1.Images.SetKeyName(14, "auswertung.png");
            this.imageList1.Images.SetKeyName(15, "controller_16.png");
            this.imageList1.Images.SetKeyName(16, "fans.png");
            this.imageList1.Images.SetKeyName(17, "flow.png");
            this.imageList1.Images.SetKeyName(18, "pressure.png");
            this.imageList1.Images.SetKeyName(19, "pump.png");
            this.imageList1.Images.SetKeyName(20, "regler.png");
            this.imageList1.Images.SetKeyName(21, "relais_an.png");
            this.imageList1.Images.SetKeyName(22, "relais_aus.png");
            this.imageList1.Images.SetKeyName(23, "relais_off_16.png");
            this.imageList1.Images.SetKeyName(24, "relais_on_16.png");
            this.imageList1.Images.SetKeyName(25, "running_fan_black.png");
            this.imageList1.Images.SetKeyName(26, "sensor.png");
            this.imageList1.Images.SetKeyName(27, "stecker.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1285, 626);
            this.Controls.Add(this.skinSplitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinTreeView treeViewMenu;
        private System.Windows.Forms.ImageList imageList1;
    }
}