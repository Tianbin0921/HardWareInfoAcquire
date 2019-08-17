using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardWareInfoAcquire.Forms
{
    public partial class ControllerTypeForm : Form
    {
        public ControllerForm Owner;

        private int controllerType = 0;

        public ControllerTypeForm()
        {
            InitializeComponent();
        }

        private void ControllerTypeForm_Load(object sender, EventArgs e)
        {
            this.constantrdo.CheckedChanged += new System.EventHandler(RadioBtn_CheckedChanged);
        }

        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }

            string filterValue = string.Empty;

            switch (((RadioButton)sender).Tag.ToString())
            {
                case "constant":
                    controllerType = 1;
                    break;
                case "curve":
                    controllerType = 2;
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (controllerType != 0)
            {
                this.Owner.addController(controllerType);
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
