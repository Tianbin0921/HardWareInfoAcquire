﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardWareInfoAcquire.Forms
{
    public partial class FansForm : Form
    {
        string[] sensorArr = new string[] { "sensor1", "sensor2" };
        string[] tempArr = new string[] { "21℃", "22℃" };
        int checkedFan = 0;

        public FansForm()
        {
            InitializeComponent();
        }

        private void SensorForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.FlatAppearance.BorderColor = Color.FromArgb(43, 133, 173);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (checkedFan != 1)
            {
                this.button1.FlatStyle = FlatStyle.Standard;
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.FlatAppearance.BorderColor = Color.FromArgb(43, 133, 173);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (checkedFan != 2)
            {
                this.button2.FlatStyle = FlatStyle.Standard;
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.FlatAppearance.BorderColor = Color.FromArgb(43, 133, 173);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if(checkedFan!=3)
            {
                this.button3.FlatStyle = FlatStyle.Standard;
            }
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.FlatAppearance.BorderColor = Color.FromArgb(43, 133, 173);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (checkedFan != 4)
            {
                this.button4.FlatStyle = FlatStyle.Standard;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            checkedFan = 1;
            this.button2.FlatStyle = FlatStyle.Standard;
            this.button3.FlatStyle = FlatStyle.Standard;
            this.button4.FlatStyle = FlatStyle.Standard;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            checkedFan = 2;
            this.button1.FlatStyle = FlatStyle.Standard;
            this.button3.FlatStyle = FlatStyle.Standard;
            this.button4.FlatStyle = FlatStyle.Standard;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            checkedFan = 3;
            this.button1.FlatStyle = FlatStyle.Standard;
            this.button2.FlatStyle = FlatStyle.Standard;
            this.button4.FlatStyle = FlatStyle.Standard;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            checkedFan = 4;
            this.button1.FlatStyle = FlatStyle.Standard;
            this.button2.FlatStyle = FlatStyle.Standard;
            this.button3.FlatStyle = FlatStyle.Standard;
        }

        private void button1_MouseMove_1(object sender, MouseEventArgs e)
        {

        }
    }
}
