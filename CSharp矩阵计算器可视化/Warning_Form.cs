using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp矩阵计算器可视化
{
    public partial class Warning_Form : Form
    {
        private int warning_kind;
        public Warning_Form()
        {
            warning_kind = 0;
            InitializeComponent();
        }
        //public Warning_Form(int a)
        //{
        //    if (a == 1)
        //    {
        //        label1.Text = "请检查相应矩阵是否输入！";
        //    }
        //    InitializeComponent();
        //}
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        public void set_kind(int a)
        {
            warning_kind = a; 
            if(warning_kind == 1)
            {
                label1.Text = "请检查相应矩阵是否输入！";
            }else if(warning_kind == 2)
            {
                label1.Text = "请输入数字！";
            }else if(warning_kind==3)
            {
                label1.Text = "数据超过矩阵大小！";
            }else if(warning_kind==4)
            {
                label1.Text = "矩阵不为方阵！";
            }
            else if(warning_kind==5)
            {
                label1.Text = "两矩阵无法进行相应操作！";
            }
        }


    }
}
