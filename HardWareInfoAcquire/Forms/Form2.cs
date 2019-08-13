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
                if (node.Checked)
                {
                    String uuid = node.Name;
                }
                else
                {
                    String uuid = node.Name;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            treeViewMenu.NodeExpandedImage = Resources.UnSelect;
            treeViewMenu.NodeCollapseImage = Resources.IsSelect;
        }
    }
}
