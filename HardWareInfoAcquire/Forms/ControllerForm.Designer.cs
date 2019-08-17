namespace HardWareInfoAcquire.Forms
{
    partial class ControllerForm
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
            this.controllerflp = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddController = new System.Windows.Forms.Button();
            this.controllerflp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controllerflp
            // 
            this.controllerflp.AutoScroll = true;
            this.controllerflp.AutoSize = true;
            this.controllerflp.Controls.Add(this.panel1);
            this.controllerflp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerflp.Location = new System.Drawing.Point(0, 0);
            this.controllerflp.Name = "controllerflp";
            this.controllerflp.Size = new System.Drawing.Size(686, 470);
            this.controllerflp.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HardWareInfoAcquire.Properties.Resources.imgBack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddController);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 32);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(598, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Controllers";
            // 
            // btnAddController
            // 
            this.btnAddController.AutoSize = true;
            this.btnAddController.BackColor = System.Drawing.Color.Transparent;
            this.btnAddController.BackgroundImage = global::HardWareInfoAcquire.Properties.Resources.add_circular;
            this.btnAddController.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddController.Location = new System.Drawing.Point(641, 1);
            this.btnAddController.Name = "btnAddController";
            this.btnAddController.Size = new System.Drawing.Size(27, 27);
            this.btnAddController.TabIndex = 0;
            this.btnAddController.UseVisualStyleBackColor = false;
            this.btnAddController.Click += new System.EventHandler(this.btnAddController_Click);
            // 
            // ControllerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(686, 470);
            this.Controls.Add(this.controllerflp);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ControllerForm";
            this.Text = "ControllerForm";
            this.Load += new System.EventHandler(this.SensorForm_Load);
            this.controllerflp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel controllerflp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddController;
        private System.Windows.Forms.Label label3;
    }
}