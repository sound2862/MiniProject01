namespace KiaSys
{
    partial class Form2
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
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 447);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(713, 196);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 43);
            label1.TabIndex = 1;
            label1.Text = "KIA 차량 주문";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "K3", "K5", "K8" });
            comboBox1.Location = new Point(228, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(24, 81);
            label2.Name = "label2";
            label2.Size = new Size(135, 35);
            label2.TabIndex = 3;
            label2.Text = "차 종류";
            // 
            // label3
            // 
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(24, 141);
            label3.Name = "label3";
            label3.Size = new Size(135, 35);
            label3.TabIndex = 5;
            label3.Text = "차량 색상";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "WHITE", "GRAY", "BLACK" });
            comboBox2.Location = new Point(228, 141);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(146, 33);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(24, 202);
            label4.Name = "label4";
            label4.Size = new Size(135, 35);
            label4.TabIndex = 7;
            label4.Text = "차량 등급";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "프레스티지", "노블레스", "시그니처" });
            comboBox3.Location = new Point(228, 202);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(146, 33);
            comboBox3.TabIndex = 6;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(423, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 310);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(24, 301);
            button1.Name = "button1";
            button1.Size = new Size(104, 42);
            button1.TabIndex = 10;
            button1.Text = "담기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(270, 301);
            button2.Name = "button2";
            button2.Size = new Size(104, 42);
            button2.TabIndex = 11;
            button2.Text = "주문";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(763, 655);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}