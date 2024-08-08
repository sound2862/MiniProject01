namespace MiniProject1
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView5 = new DataGridView();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            Sign_up = new Button();
            Sign_in = new Button();
            textBox_id = new TextBox();
            textBox_pwd = new TextBox();
            checkBox1 = new CheckBox();
            dataGridView4 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(52, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 326);
            panel1.TabIndex = 0;
            // 
            // dataGridView5
            // 
            dataGridView5.CausesValidation = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(-604, -105);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(650, 150);
            dataGridView5.TabIndex = 13;
            dataGridView5.Visible = false;
            dataGridView5.CellContentClick += dataGridView5_CellContentClick;
            // 
            // label3
            // 
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(32, 282);
            label3.Name = "label3";
            label3.Size = new Size(239, 29);
            label3.TabIndex = 1;
            label3.Text = "KIA 자동차 구매 시스템";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 255);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(98, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 1);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(98, 470);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 1);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(72, 402);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(72, 448);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 3;
            label2.Text = "PW";
            // 
            // Sign_up
            // 
            Sign_up.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Sign_up.Location = new Point(72, 507);
            Sign_up.Name = "Sign_up";
            Sign_up.Size = new Size(98, 36);
            Sign_up.TabIndex = 4;
            Sign_up.Text = "Sign Up";
            Sign_up.UseVisualStyleBackColor = true;
            Sign_up.Click += Sign_up_Click;
            // 
            // Sign_in
            // 
            Sign_in.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Sign_in.Location = new Point(213, 507);
            Sign_in.Name = "Sign_in";
            Sign_in.Size = new Size(98, 36);
            Sign_in.TabIndex = 5;
            Sign_in.Text = "Sign In";
            Sign_in.UseVisualStyleBackColor = true;
            Sign_in.Click += Sign_in_Click;
            // 
            // textBox_id
            // 
            textBox_id.BackColor = Color.White;
            textBox_id.BorderStyle = BorderStyle.None;
            textBox_id.Location = new Point(98, 399);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(210, 16);
            textBox_id.TabIndex = 6;
            // 
            // textBox_pwd
            // 
            textBox_pwd.BorderStyle = BorderStyle.None;
            textBox_pwd.Location = new Point(98, 445);
            textBox_pwd.Name = "textBox_pwd";
            textBox_pwd.Size = new Size(210, 16);
            textBox_pwd.TabIndex = 7;
            textBox_pwd.TextChanged += textBox2_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            checkBox1.Location = new Point(317, 524);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(-378, -252);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(404, 273);
            dataGridView4.TabIndex = 12;
            dataGridView4.Visible = false;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(-378, -243);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(404, 264);
            dataGridView3.TabIndex = 11;
            dataGridView3.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-413, -261);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(439, 282);
            dataGridView2.TabIndex = 10;
            dataGridView2.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-413, -243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 264);
            dataGridView1.TabIndex = 9;
            dataGridView1.Visible = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 577);
            Controls.Add(dataGridView5);
            Controls.Add(dataGridView4);
            Controls.Add(checkBox1);
            Controls.Add(textBox_pwd);
            Controls.Add(dataGridView3);
            Controls.Add(textBox_id);
            Controls.Add(Sign_in);
            Controls.Add(dataGridView2);
            Controls.Add(Sign_up);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "login";
            Text = "로그인 화면";
            Load += login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button Sign_up;
        private Button Sign_in;
        private Label label3;
        private TextBox textBox_id;
        private TextBox textBox_pwd;
        private CheckBox checkBox1;
        private DataGridView dataGridView5;
        private DataGridView dataGridView4;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}