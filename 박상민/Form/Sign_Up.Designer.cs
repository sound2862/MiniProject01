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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            textBox3 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(60, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 16);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(60, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 16);
            textBox1.TabIndex = 12;
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
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(60, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 16);
            textBox3.TabIndex = 16;
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
            label4.Location = new Point(34, 25);
            label4.Name = "label4";
            label4.Size = new Size(249, 46);
            label4.TabIndex = 17;
            label4.Text = "회원가입";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(103, 272);
            button1.Name = "button1";
            button1.Size = new Size(108, 46);
            button1.TabIndex = 18;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(307, 372);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Sign_Up";
            Text = "Sign_Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBox3;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Button button1;
    }
}
