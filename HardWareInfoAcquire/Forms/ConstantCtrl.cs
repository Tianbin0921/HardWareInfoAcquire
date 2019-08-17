using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardWareInfoAcquire.Forms
{
    public partial class ConstantCtrl : UserControl
    {
        public ControllerForm Owner;

        public ConstantCtrl()
        {
            InitializeComponent();
        }

        private void btnAddOutputs_Click(object sender, EventArgs e)
        {
            OutputsDstCtrl item = new OutputsDstCtrl();
            item.Owner = this;
            outputsflp.Controls.Add(item);
        }

        private void addOutputsDevice(int type)
        {

        }
    }
}
