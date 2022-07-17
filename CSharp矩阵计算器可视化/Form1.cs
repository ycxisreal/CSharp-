namespace CSharp矩阵计算器可视化
{
    public partial class Main_Form : Form
    {
        public System.Collections.ArrayList matrix_A;
        public System.Collections.ArrayList matrix_B;
        public int A_r;
        public int B_r;
        public int A_c;
        public int B_c;
        public Main_Form()
        {
            matrix_A = new System.Collections.ArrayList();
            matrix_B = new System.Collections.ArrayList();
            A_r = 0;
            B_r = 0;
            A_c = 0;
            B_c = 0;
            InitializeComponent();
        }

        private void button_addA_Click(object sender, EventArgs e)
        {
            mat_add_Form mat_Add_Form = new mat_add_Form();
            mat_Add_Form.ShowDialog();
            matrix_A = mat_Add_Form.GetArray();
            if(mat_Add_Form.is_reliable())
            {
                string mat = "";
                int a = 1;
                foreach (int i in matrix_A)
                {
                    mat += i.ToString() + " ";
                    if (a% mat_Add_Form.get_c() == 0)
                        mat += "\r\n";
                    a++;
                }
                A_c = mat_Add_Form.get_c();
                A_r = mat_Add_Form.get_r();
                textBox1.Text = mat;
            }
            
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_addB_Click(object sender, EventArgs e)
        {
            mat_add_Form mat_Add_Form = new mat_add_Form();
            mat_Add_Form.ShowDialog();
            matrix_B = mat_Add_Form.GetArray();
            if (mat_Add_Form.is_reliable())
            {
                string mat = "";
                int a = 1;
                foreach (int i in matrix_B)
                {
                    mat += i.ToString() + " ";
                    if (a % mat_Add_Form.get_c() == 0)
                        mat += "\r\n";
                    a++;
                }
                B_c = mat_Add_Form.get_c();
                B_r = mat_Add_Form.get_r();
                textBox3.Text = mat;
            }
        }

        private void evaluation_Click(object sender, EventArgs e)
        {
            if(A_r!=A_c)//检测方阵
            {
                Warning_Form warning_Form=new Warning_Form();
                warning_Form.set_kind(4);
                warning_Form.ShowDialog();
                return;
            }
            //手动将ArrayList转为二维数组
            int i=0, j=0;
            double[,] mat_array = new double[A_r, A_c];
            foreach (int k in matrix_A)
            {
                mat_array[i,j] = Convert.ToDouble(k);
                if(j==A_c-1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            //调用矩阵类方法
            Matrix matrix = new Matrix(A_r, A_c, mat_array);
            textBox2.Text = Convert.ToString(matrix.evaluation(A_r));
        }

        private void accompany_Click(object sender, EventArgs e)
        {
            if (A_r != A_c)//检测方阵
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.set_kind(4);
                warning_Form.ShowDialog();
                return;
            }
            //手动将ArrayList转为二维数组
            int i = 0, j = 0;
            double[,] mat_array = new double[A_r, A_c];
            foreach (int k in matrix_A)
            {
                mat_array[i, j] = Convert.ToDouble(k);
                if (j == A_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            //调用矩阵类方法
            Matrix matrix = new Matrix(A_r, A_c, mat_array);
            double[,] temp = matrix.comp();
            string m = "";
            for(int o=0;o<A_r;o++)
            {
                for(int p=0;p<A_c;p++)
                {
                    m += temp[o, p] + " ";
                }
                m += "\r\n";
            }
            textBox2.Text = m;
        }

        private void inverse_Click(object sender, EventArgs e)
        {
            if (A_r != A_c)//检测方阵
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.set_kind(4);
                warning_Form.ShowDialog();
                return;
            }
            //手动将ArrayList转为二维数组
            int i = 0, j = 0;
            double[,] mat_array = new double[A_r, A_c];
            foreach (int k in matrix_A)
            {
                mat_array[i, j] = Convert.ToDouble(k);
                if (j == A_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            //调用矩阵类方法
            Matrix matrix = new Matrix(A_r, A_c, mat_array);
            double[,] temp = matrix.inverse();
            string m = "";//在文本框中输出矩阵
            for (int o = 0; o < A_r; o++)
            {
                for (int p = 0; p < A_c; p++)
                {
                    m += temp[o, p] + " ";
                }
                m += "\r\n";
            }
            textBox2.Text = m;
        }

        private void num_muti_Click(object sender, EventArgs e)
        {
            if(num_box.Text=="")
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.set_kind(2);
                warning_Form.ShowDialog();
                return;
            }
            double a=Convert.ToDouble(num_box.Text);

            int i = 0, j = 0;
            double[,] mat_array = new double[A_r, A_c];
            foreach (int k in matrix_A)
            {
                mat_array[i, j] = Convert.ToDouble(k);
                if (j == A_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            //调用矩阵类方法
            Matrix matrix = new Matrix(A_r, A_c, mat_array);
            double[,] temp = matrix.num_muti(a);
            string m = "";//在文本框中输出矩阵
            for (int o = 0; o < A_r; o++)
            {
                for (int p = 0; p < A_c; p++)
                {
                    m += temp[o, p] + " ";
                }
                m += "\r\n";
            }
            textBox2.Text = m;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if(textBox3.Text=="")
            {
                Warning_Form warning_Form=new Warning_Form();
                warning_Form.set_kind(1);
                warning_Form.ShowDialog();
            }else if(A_c!=B_c||A_r!=B_r)
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.set_kind(5);
                warning_Form.ShowDialog();
            }
            int i = 0, j = 0;
            double[,] A_mat_array = new double[A_r, A_c];
            foreach (int k in matrix_A)
            {
                A_mat_array[i, j] = Convert.ToDouble(k);
                if (j == A_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            i = 0;
            j = 0;
            double[,] B_mat_array = new double[B_r, B_c];
            foreach(int k in matrix_B)
            {
                B_mat_array[i, j] = Convert.ToDouble(k);
                if (j == A_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            //调用矩阵类方法
            Matrix A = new Matrix(A_r, A_c, A_mat_array);
            Matrix B = new Matrix(B_r, B_c, B_mat_array);
            double[,] temp = new double[A_r, A_c];
            for (int a = 0; a < A_r; a++)
                for (int b = 0; b < A_r; b++)
                    temp[a, b] = A_mat_array[a, b] + B_mat_array[a, b];
            string m = "";//在文本框中输出矩阵
            for (int o = 0; o < A_r; o++)
            {
                for (int p = 0; p < A_c; p++)
                {
                    m += temp[o, p] + " ";
                }
                m += "\r\n";
            }
            textBox2.Text = m;
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.set_kind(1);
                warning_Form.ShowDialog();
            }
            else if (A_c != B_c || A_r != B_r)
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.set_kind(5);
                warning_Form.ShowDialog();
            }
            int i = 0, j = 0;
            double[,] A_mat_array = new double[A_r, A_c];
            foreach (int k in matrix_A)
            {
                A_mat_array[i, j] = Convert.ToDouble(k);
                if (j == A_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            i = 0;
            j = 0;
            double[,] B_mat_array = new double[B_r, B_c];
            foreach (int k in matrix_B)
            {
                B_mat_array[i, j] = Convert.ToDouble(k);
                if (j == A_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            //调用矩阵类方法
            Matrix A = new Matrix(A_r, A_c, A_mat_array);
            Matrix B = new Matrix(B_r, B_c, B_mat_array);
            double[,] temp = new double[A_r, A_c];
            for (int a = 0; a < A_r; a++)
                for (int b = 0; b < A_r; b++)
                    temp[a, b] = A_mat_array[a, b] - B_mat_array[a, b];
            string m = "";//在文本框中输出矩阵
            for (int o = 0; o < A_r; o++)
            {
                for (int p = 0; p < A_c; p++)
                {
                    m += temp[o, p] + " ";
                }
                m += "\r\n";
            }
            textBox2.Text = m;
        }

        private void button_muti_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.set_kind(1);
                warning_Form.ShowDialog();
            }
            else if (A_c!=B_r)
            {
                Warning_Form warning_Form = new Warning_Form();
                warning_Form.set_kind(5);
                warning_Form.ShowDialog();
            }
            int i = 0, j = 0;
            double[,] A_mat_array = new double[A_r, A_c];
            foreach (int k in matrix_A)
            {
                A_mat_array[i, j] = Convert.ToDouble(k);
                if (j == A_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            i = 0;
            j = 0;
            double[,] B_mat_array = new double[B_r, B_c];
            foreach (int k in matrix_B)
            {
                B_mat_array[i, j] = Convert.ToDouble(k);
                if (j == B_c - 1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                j++;
            }
            //调用矩阵类方法
            Matrix A = new Matrix(A_r, A_c, A_mat_array);
            Matrix B = new Matrix(B_r, B_c, B_mat_array);
            Matrix C=new Matrix(A_r,B_c,new double[A_r,B_c]);
            double temp = 0;
            for (int n = 0; n < A_r; n++)
            {
                for (int k = 0; k < B_c; k++)
                {
                    for (int m = 0; m < A_c; m++)
                        temp += A.matrix[n,m] * B.matrix[m,k];
                    C.matrix[n,k] = temp;
                    temp = 0;
                }
            }
            string str = "";//在文本框中输出矩阵
            for (int o = 0; o < A_r; o++)
            {
                for (int p = 0; p < B_c; p++)
                {
                    str += C.matrix[o, p] + " ";
                }
                str += "\r\n";
            }
            textBox2.Text = str;
        }
    }
    public class Matrix
    {
        private int r;
        private int c;
        public double[,] matrix;
        public Matrix(int r, int c, double[,] matrix)
        {
            this.r = r;
            this.c = c;
            this.matrix = matrix;
        }
        public double evaluation(int ran)//求行列式的值
        {
            //递归求解行列式的值
            int rank = ran;
            if (rank == 1)
            {
                return matrix[0,0];
            }
            else if (rank == 2)
            {
                return matrix[0,0] * matrix[1,1] - matrix[1,0] * matrix[0,1];
            }
            else if (rank == 3)
            {
                double a = matrix[0,0] * matrix[1,1] * matrix[2,2] + matrix[1,0] * matrix[2,1] * matrix[0,2] + matrix[2,0] * matrix[0,1] * matrix[1,2];
                double b = matrix[2,0] * matrix[1,1] * matrix[0,2] + matrix[1,0] * matrix[0,1] * matrix[2,2] + matrix[0,0] * matrix[2,1] * matrix[1,2];
                return a - b;
            }
            else if (rank > 3)
            {
                //使最后一列中除最后一行外，全部消为0。
                for (int i = 0; i < rank - 1; i++)
                {
                    double a = matrix[i,rank - 1];
                    for (int j = 0; j < rank; j++)
                    {
                        matrix[i,j] -= matrix[rank - 1,j] * matrix[i,rank - 1] / matrix[rank - 1,rank - 1];
                    }
                }
                return Math.Pow(-1, rank * rank) * matrix[rank - 1,rank - 1] * evaluation(rank - 1);
            }else
            {
                return 0;
            }
        }
        public double[,] comp()//求伴随矩阵
        {
            Matrix a = new Matrix(r, c, new double[r,c]);
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Matrix b=new Matrix(r-1, c-1, new double[r-1,c-1]);
                    int column = 0;//构造代数余子式
                    int row = 0;
                    for (int k = 0; k < r; k++)
                    {
                        if (k == i)
                            continue;
                        for (int l = 0; l < c; l++)
                        {
                            if (l == j)
                                continue;
                            b.matrix[row,column] = matrix[k,l];
                            column++;
                        }
                        column = 0;
                        row++;
                    }
                    a.matrix[i,j] = Math.Pow(-1, i + j) * b.evaluation(c-1);
                }
            }
            //转置a以获得伴随矩阵
            Matrix d =new Matrix(r, c, new double[r,c]);
            for(int k = 0; k < r; k++)
                for(int l = 0; l < c; l++)
                    d.matrix[k,l] = a.matrix[k,l];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    a.matrix[i, j] = d.matrix[j, i];
            return a.matrix;
        }
        public double[,] inverse()//求逆矩阵
        {
            double[,] a = new double[r,c];
            a = comp();
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    a[i, j] *= 1 / evaluation(r);
            return a;
        }
        public double[,] num_muti(double a)//数乘矩阵
        {
            double[,] temp = matrix;
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    temp[i, j] *= a;
            return temp;
        }
    }
}