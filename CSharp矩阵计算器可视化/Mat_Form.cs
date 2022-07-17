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
    public partial class mat_add_Form : Form//输入矩阵的窗口
    {
        private System.Collections.ArrayList mat;
        private int r;
        private int c;
        private bool reliable=true;
        private string temp = "";
        public mat_add_Form()
        {
            mat = new System.Collections.ArrayList();
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            if(r_box.Text!="0"&&c_box.Text!="0"&&textBox1.Text!="")
            {
                r = Convert.ToInt32(r_box.Text);
                c = Convert.ToInt32(c_box.Text);
                Close();
            }
            else
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.ShowDialog();
            }
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reliable = false;
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(r_box.Text == "0" || c_box.Text == "0")//检测行与列是否输入
            {
                Warning_Form warning_Form= new Warning_Form();
                warning_Form.ShowDialog();
                textBox1.Text = "";
                return;
            }
            if(e.KeyChar == (char)Keys.Enter)//输入回车键后
            {
                //检测是否超出矩阵大小
                if(mat.Count== Convert.ToInt32(r_box.Text)* Convert.ToInt32(c_box.Text))
                {
                    Warning_Form warning_Form=new Warning_Form();
                    warning_Form.set_kind(3);
                    warning_Form.ShowDialog();
                    return;
                }
                mat.Add(Convert.ToInt32(textBox1.Text));
                //消除回车
                int a;
                a= Convert.ToInt32(textBox1.Text);
                temp+=Convert.ToString(a)+" ";
                if (mat.Count % Convert.ToInt32(c_box.Text) == 0)
                    temp += "\r\n";//自动换行
                textBox2.Text = temp;
                textBox1.Text = "";
            }
            
        }
        public bool is_reliable()//是否为直接退出，不返回矩阵
        {
            return reliable;
        }
        public System.Collections.ArrayList GetArray()//返回矩阵
        {
            return mat;
        }
        public int get_r()
        {
            return r;
        }
        public int get_c()
        {
            return c;
        }

        private void mat_add_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
