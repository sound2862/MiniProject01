namespace SFMiniProject
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            dataGridView5 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            Sign_up = new Button();
            Sign_in = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-332, -195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 264);
            dataGridView1.TabIndex = 1;
            dataGridView1.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-332, -213);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(439, 282);
            dataGridView2.TabIndex = 2;
            dataGridView2.Visible = false;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 30F);
            label1.Location = new Point(531, 272);
            label1.Name = "label1";
            label1.Size = new Size(131, 54);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(-297, -195);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(404, 264);
            dataGridView3.TabIndex = 3;
            dataGridView3.Visible = false;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(-297, -204);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(404, 273);
            dataGridView4.TabIndex = 4;
            dataGridView4.Visible = false;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(-543, -81);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(650, 150);
            dataGridView5.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "admin";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(741, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            textBox2.Text = "admin";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(741, 152);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "비번";
            // 
            // Sign_up
            // 
            Sign_up.Location = new Point(353, 224);
            Sign_up.Name = "Sign_up";
            Sign_up.Size = new Size(75, 23);
            Sign_up.TabIndex = 10;
            Sign_up.Text = "Sign_up";
            Sign_up.UseVisualStyleBackColor = true;
            // 
            // Sign_in
            // 
            Sign_in.Location = new Point(741, 224);
            Sign_in.Name = "Sign_in";
            Sign_in.Size = new Size(75, 23);
            Sign_in.TabIndex = 11;
            Sign_in.Text = "Sign_in";
            Sign_in.UseVisualStyleBackColor = true;
            Sign_in.Click += Sign_in_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 152);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 12;
            label2.Text = "아이디";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 623);
            Controls.Add(label2);
            Controls.Add(Sign_in);
            Controls.Add(Sign_up);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView5);
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button Sign_up;
        private Button Sign_in;
        private Label label2;
    }
}
