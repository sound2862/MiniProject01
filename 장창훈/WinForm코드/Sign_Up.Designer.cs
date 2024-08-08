namespace MiniProject1
{
    partial class Sign_Up
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
            textBox_pwd = new TextBox();
            textBox_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            textBox_name = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            Sign_up_btn = new Button();
            dataGridView5 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // textBox_pwd
            // 
            textBox_pwd.BorderStyle = BorderStyle.None;
            textBox_pwd.Location = new Point(60, 201);
            textBox_pwd.Name = "textBox_pwd";
            textBox_pwd.Size = new Size(210, 16);
            textBox_pwd.TabIndex = 13;
            // 
            // textBox_id
            // 
            textBox_id.BackColor = Color.White;
            textBox_id.BorderStyle = BorderStyle.None;
            textBox_id.Location = new Point(60, 155);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(210, 16);
            textBox_id.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(34, 203);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 11;
            label2.Text = "PW";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(34, 157);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(60, 219);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 1);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(60, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 1);
            panel2.TabIndex = 8;
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.White;
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Location = new Point(60, 115);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(210, 16);
            textBox_name.TabIndex = 16;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 15;
            label3.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(60, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 1);
            panel1.TabIndex = 14;
            // 
            // label4
            // 
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(51, 358);
            label4.Name = "label4";
            label4.Size = new Size(249, 46);
            label4.TabIndex = 17;
            label4.Text = "회원가입";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // Sign_up_btn
            // 
            Sign_up_btn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Sign_up_btn.Location = new Point(103, 272);
            Sign_up_btn.Name = "Sign_up_btn";
            Sign_up_btn.Size = new Size(108, 46);
            Sign_up_btn.TabIndex = 18;
            Sign_up_btn.Text = "Sign Up";
            Sign_up_btn.UseVisualStyleBackColor = true;
            Sign_up_btn.Click += Sign_up_btn_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.CausesValidation = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(12, 337);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(650, 150);
            dataGridView5.TabIndex = 19;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(595, 624);
            Controls.Add(dataGridView5);
            Controls.Add(Sign_up_btn);
            Controls.Add(label4);
            Controls.Add(textBox_name);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBox_pwd);
            Controls.Add(textBox_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Sign_Up";
            Text = "Sign_Up";
            Load += Sign_Up_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_pwd;
        private TextBox textBox_id;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBox_name;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Button Sign_up_btn;
        private DataGridView dataGridView5;
    }
}