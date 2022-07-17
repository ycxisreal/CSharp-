namespace CSharp矩阵计算器可视化
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.button_addA = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.evaluation = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accompany = new System.Windows.Forms.Button();
            this.button_addB = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_muti = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.inverse = new System.Windows.Forms.Button();
            this.num_muti = new System.Windows.Forms.Button();
            this.num_box = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addA
            // 
            this.button_addA.Location = new System.Drawing.Point(12, 12);
            this.button_addA.Name = "button_addA";
            this.button_addA.Size = new System.Drawing.Size(112, 34);
            this.button_addA.TabIndex = 0;
            this.button_addA.Text = "添加矩阵A";
            this.button_addA.UseVisualStyleBackColor = true;
            this.button_addA.Click += new System.EventHandler(this.button_addA_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(454, 398);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(112, 34);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "关闭";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 169);
            this.textBox1.TabIndex = 2;
            // 
            // evaluation
            // 
            this.evaluation.Location = new System.Drawing.Point(256, 52);
            this.evaluation.Name = "evaluation";
            this.evaluation.Size = new System.Drawing.Size(112, 34);
            this.evaluation.TabIndex = 3;
            this.evaluation.Text = "A行列式";
            this.evaluation.UseVisualStyleBackColor = true;
            this.evaluation.Click += new System.EventHandler(this.evaluation_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(387, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(179, 169);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "结果：";
            // 
            // accompany
            // 
            this.accompany.Location = new System.Drawing.Point(256, 96);
            this.accompany.Name = "accompany";
            this.accompany.Size = new System.Drawing.Size(112, 34);
            this.accompany.TabIndex = 6;
            this.accompany.Text = "A伴随矩阵";
            this.accompany.UseVisualStyleBackColor = true;
            this.accompany.Click += new System.EventHandler(this.accompany_Click);
            // 
            // button_addB
            // 
            this.button_addB.Location = new System.Drawing.Point(12, 227);
            this.button_addB.Name = "button_addB";
            this.button_addB.Size = new System.Drawing.Size(158, 34);
            this.button_addB.TabIndex = 7;
            this.button_addB.Text = "添加矩阵B(次要)";
            this.button_addB.UseVisualStyleBackColor = true;
            this.button_addB.Click += new System.EventHandler(this.button_addB_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 267);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(200, 169);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(252, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(29, 35);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "A";
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_plus.Location = new System.Drawing.Point(287, 285);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(46, 36);
            this.button_plus.TabIndex = 10;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_sub.Location = new System.Drawing.Point(287, 327);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(46, 33);
            this.button_sub.TabIndex = 11;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_muti
            // 
            this.button_muti.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_muti.Location = new System.Drawing.Point(288, 366);
            this.button_muti.Name = "button_muti";
            this.button_muti.Size = new System.Drawing.Size(45, 34);
            this.button_muti.TabIndex = 12;
            this.button_muti.Text = "x";
            this.button_muti.UseVisualStyleBackColor = true;
            this.button_muti.Click += new System.EventHandler(this.button_muti_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(339, 325);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(29, 35);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "B";
            // 
            // inverse
            // 
            this.inverse.Location = new System.Drawing.Point(256, 141);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(112, 34);
            this.inverse.TabIndex = 14;
            this.inverse.Text = "A逆矩阵";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.Click += new System.EventHandler(this.inverse_Click);
            // 
            // num_muti
            // 
            this.num_muti.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_muti.Location = new System.Drawing.Point(288, 200);
            this.num_muti.Name = "num_muti";
            this.num_muti.Size = new System.Drawing.Size(45, 34);
            this.num_muti.TabIndex = 15;
            this.num_muti.Text = "x";
            this.num_muti.UseVisualStyleBackColor = true;
            this.num_muti.Click += new System.EventHandler(this.num_muti_Click);
            // 
            // num_box
            // 
            this.num_box.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_box.Location = new System.Drawing.Point(252, 200);
            this.num_box.Name = "num_box";
            this.num_box.Size = new System.Drawing.Size(29, 35);
            this.num_box.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(339, 200);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(29, 35);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 53);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.num_box);
            this.Controls.Add(this.num_muti);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button_muti);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_addB);
            this.Controls.Add(this.accompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.evaluation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_addA);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "潇の矩阵计算器";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_addA;
        private Button button_close;
        private TextBox textBox1;
        private Button evaluation;
        private TextBox textBox2;
        private Label label1;
        private Button accompany;
        private Button button_addB;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button_plus;
        private Button button_sub;
        private Button button_muti;
        private TextBox textBox5;
        private Button inverse;
        private Button num_muti;
        private TextBox num_box;
        private TextBox textBox7;
        private PictureBox pictureBox1;
    }
}