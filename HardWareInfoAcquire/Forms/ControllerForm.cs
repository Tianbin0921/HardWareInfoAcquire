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
    public partial class ControllerForm : Form
    {
        string[] sensorArr = new string[] { "sensor1", "sensor2" };
        string[] tempArr = new string[] { "21℃", "22℃" };

        public ControllerForm()
        {
            InitializeComponent();
        }

        private void SensorForm_Load(object sender, EventArgs e)
        {
        }

        private void btnAddController_Click(object sender, EventArgs e)
        {
            ControllerTypeForm frm = new ControllerTypeForm();
            frm.Owner = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        /// <summary>
        /// 添加控制方案
        /// </summary>
        /// <param name="type">1 constant / 2 curve</param>
        public void addController(int type)
        {
            switch (type)
            {
                case 1:
                    ConstantCtrl item = new ConstantCtrl();
                    item.Owner = this;
                    controllerflp.Controls.Add(item);
                    break;
                case 2:

                    break;
                default:
                    break;
            }
        }

        public void removeController(int type)
        {

        }
    }
}
