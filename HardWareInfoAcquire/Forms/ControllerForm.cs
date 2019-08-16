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

        }
    }
}
