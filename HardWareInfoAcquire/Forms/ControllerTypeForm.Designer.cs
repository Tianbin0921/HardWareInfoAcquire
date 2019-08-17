namespace HardWareInfoAcquire.Forms
{
    partial class ControllerTypeForm
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
            this.constantrdo = new System.Windows.Forms.RadioButton();
            this.curverdo = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // constantrdo
            // 
            this.constantrdo.AutoSize = true;
            this.constantrdo.Location = new System.Drawing.Point(141, 65);
            this.constantrdo.Name = "constantrdo";
            this.constantrdo.Size = new System.Drawing.Size(107, 16);
            this.constantrdo.TabIndex = 0;
            this.constantrdo.TabStop = true;
            this.constantrdo.Tag = "constant";
            this.constantrdo.Text = "Constant value";
            this.constantrdo.UseVisualStyleBackColor = true;
            // 
            // curverdo
            // 
            this.curverdo.AutoSize = true;
            this.curverdo.Location = new System.Drawing.Point(141, 106);
            this.curverdo.Name = "curverdo";
            this.curverdo.Size = new System.Drawing.Size(119, 16);
            this.curverdo.TabIndex = 1;
            this.curverdo.TabStop = true;
            this.curverdo.Tag = "curve";
            this.curverdo.Text = "Curve controller";
            this.curverdo.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(58, 279);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ControllerTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 344);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.curverdo);
            this.Controls.Add(this.constantrdo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControllerTypeForm";
            this.Text = "Controller Type";
            this.Load += new System.EventHandler(this.ControllerTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton constantrdo;
        private System.Windows.Forms.RadioButton curverdo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}