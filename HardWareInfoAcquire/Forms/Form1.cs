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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> list = new List<Button>();

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            ChangeLocation(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = true;
            this.label3.Visible = false;
            this.label4.Visible = false;
            ChangeLocation(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = true;
            this.label4.Visible = false;
            ChangeLocation(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = true;
            ChangeLocation(button4);
        }

        private void ChangeLocation(Button btn)
        {
            int num1 = int.Parse(btn.Name.Substring(6));//num1 代表本按钮的名称序号  
            string direction = null;//定义一个方向变量  
            if (btn.Top > this.panel1.Top)//如果本按钮的纵坐标大于面板的纵坐标  
            {
                direction = "up";//设置方向变量的值为“up” 即代表菜单向上翻  
            }
            else if (btn.Top + btn.Height < this.panel1.Top) //如果本按钮的纵坐标加本按钮的高度小于面板的纵坐标  
            {
                direction = "down";//设置方向变量的值为“down” 即代表菜单向下翻  
            }
            if (direction != null)//如果方向变量的值不为空  
            {
                btn.Top = this.button1.Top + (btn.Height) * (num1 - 1);//设置本按钮的纵坐标等于本折叠菜单的第一个按钮的纵坐标加上在本按钮之上的几个按钮的高度之和  
                this.panel1.Top = btn.Top + btn.Height;//面板的纵坐标等于本按钮的纵坐标加上本按钮的高度  
                int count = 1;//定义计数变量 计算在本按钮之上或之下的按钮有多少个  
                //循环遍历菜单按钮集合  
                foreach (Button bt in list)
                {
                    int num2 = int.Parse(bt.Name.Substring(6));//得到此按钮的名称序号 即集合中此子元素按钮的名称序号  
                    if (direction == "up")//如果方向变量值为“up”，即菜单往上翻  
                    {
                        if (num2 < num1 && num2 != 1)//如果此子元素按钮的名称序号小于本按钮的名称序号，并且此子元素按钮的名称序号不等于1  
                        {
                            bt.Top = button1.Top + btn.Height * count;//此子元素按钮的纵坐标等于本折叠菜单的第一个按钮的纵坐标加上此子元素按钮之上的几个按钮的高度之和  
                            if (num2 == num1 - 1)//如果此子元素按钮的名称序号等于本按钮的名称序号减1,则  
                                break;//跳出方法  
                            count++;//按钮个数加1  
                        }

                    }
                    else//否则方向变量值为“down”，即菜单往下翻  
                    {
                        if (num2 > num1)//如果此子元素按钮的名称序号大于本按钮的名称序号  
                        {
                            bt.Top = btn.Top + btn.Height * count + this.panel1.Height;//此子元素按钮的纵坐标等于本按钮的纵坐标加上本按钮之下的几个按钮的高度之和  
                            count++;//按钮个数加1  
                        }
                    }
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label2.Visible = false;
            this.label2.Location = this.label1.Location;
            this.label3.Visible = false;
            this.label3.Location = this.label1.Location;
            this.label4.Visible = false;
            this.label4.Location = this.label1.Location;

            list.Add(button1);
            list.Add(button2);
            list.Add(button3);
            list.Add(button4);
        }
    }
}
