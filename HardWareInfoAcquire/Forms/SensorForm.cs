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
    public partial class SensorForm : Form
    {
        string[] sensorArr = new string[] { "sensor1", "sensor2" };
        string[] tempArr = new string[] { "21℃", "22℃" };

        public SensorForm()
        {
            InitializeComponent();
        }

        private void SensorForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = sensorDgv.Rows.Add(row);
                sensorDgv.Rows[index].Cells[0].Value = sensorArr[i];
                sensorDgv.Rows[index].Cells[1].Value = tempArr[i];
            }
        }
    }
}
