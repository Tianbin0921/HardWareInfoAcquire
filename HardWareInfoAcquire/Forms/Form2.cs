using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HardWareInfoAcquire.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void skinTreeView1_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode node = treeViewMenu.GetNodeAt(new Point(e.X, e.Y));
            if (node != null)
            {
                rightPanel.Controls.Clear();
                switch (node.Name)
                {
                    case "sensor":
                        SensorForm sensorfrm = new SensorForm();
                        sensorfrm.TopLevel = false;
                        sensorfrm.Dock = DockStyle.Fill;
                        sensorfrm.FormBorderStyle = FormBorderStyle.None;
                        rightPanel.Controls.Add(sensorfrm);
                        sensorfrm.Show();
                        break;
                    case "fans":
                        FansForm fanfrm = new FansForm();
                        fanfrm.TopLevel = false;
                        fanfrm.Dock = DockStyle.Fill;
                        fanfrm.FormBorderStyle = FormBorderStyle.None;
                        rightPanel.Controls.Add(fanfrm);
                        fanfrm.Show();
                        break;
                    case "controllers":
                        ControllerForm confrm = new ControllerForm();
                        confrm.TopLevel = false;
                        confrm.Dock = DockStyle.Fill;
                        confrm.FormBorderStyle = FormBorderStyle.None;
                        rightPanel.Controls.Add(confrm);
                        confrm.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void ShowForm(string formName)
        {
            Form frm = GetForm(formName);
            frm.BringToFront();
            frm.Show();
        }

        private Form GetForm(string formName)
        {
            Control.ControlCollection ctrls = skinSplitContainer1.Panel2.Controls;
            if (ctrls.ContainsKey(formName))
            {
                return ctrls[formName] as Form;
            }
            else
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type type = assembly.GetTypes().Where(item => item.Name.Equals(formName)).FirstOrDefault();

                Form frm = assembly.CreateInstance(type.FullName) as Form;
                frm.Name = formName;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                skinSplitContainer1.Panel2.Controls.Add(frm);

                return frm;
            }
        }

        /// <summary>
        /// 创建窗口
        /// </summary>
        private void CreateFormInstance(string formName,string formText,string assemblyName)
        {
            Form frm = null;

            try
            {
                Type tp = Assembly.Load(assemblyName).GetType(formName);
                frm = (Form)System.Activator.CreateInstance(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frm.Name = formName;
            frm.Text = formText;

            frm.Show(skinSplitContainer1.Panel2);
        }
    }
}
