namespace KiaSys
{
    partial class FacForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacForm));
            Production_btn = new Button();
            Live_btn = new Button();
            Pause_btn = new Button();
            Exit_btn = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar5 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // Production_btn
            // 
            Production_btn.Location = new Point(24, 53);
            Production_btn.Name = "Production_btn";
            Production_btn.Size = new Size(152, 79);
            Production_btn.TabIndex = 0;
            Production_btn.Text = "생산";
            Production_btn.UseVisualStyleBackColor = true;
            Production_btn.Click += Production_btn_Click;
            // 
            // Live_btn
            // 
            Live_btn.Location = new Point(24, 182);
            Live_btn.Name = "Live_btn";
            Live_btn.Size = new Size(152, 79);
            Live_btn.TabIndex = 1;
            Live_btn.Text = "실시간";
            Live_btn.UseVisualStyleBackColor = true;
            Live_btn.Click += Live_btn_Click;
            // 
            // Pause_btn
            // 
            Pause_btn.Location = new Point(24, 311);
            Pause_btn.Name = "Pause_btn";
            Pause_btn.Size = new Size(152, 79);
            Pause_btn.TabIndex = 2;
            Pause_btn.Text = "일시정지";
            Pause_btn.UseVisualStyleBackColor = true;
            Pause_btn.Click += Pause_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(24, 434);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(152, 79);
            Exit_btn.TabIndex = 3;
            Exit_btn.Text = "종료";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(Exit_btn);
            groupBox1.Controls.Add(Pause_btn);
            groupBox1.Controls.Add(Live_btn);
            groupBox1.Controls.Add(Production_btn);
            groupBox1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.Location = new Point(12, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 541);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(1311, 60);
            label1.TabIndex = 5;
            label1.Text = "KIA 자동화 공정 시스템";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(655, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(313, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1012, 137);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(227, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(478, 434);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(227, 158);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(834, 434);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(227, 158);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(313, 310);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(227, 23);
            progressBar1.TabIndex = 12;
            progressBar1.Click += progressBar1_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(655, 310);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(227, 23);
            progressBar2.TabIndex = 13;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(1012, 310);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(227, 23);
            progressBar3.TabIndex = 14;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(478, 611);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(227, 23);
            progressBar4.TabIndex = 15;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(834, 611);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(227, 23);
            progressBar5.TabIndex = 16;
            // 
            // label2
            // 
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(313, 93);
            label2.Name = "label2";
            label2.Size = new Size(115, 35);
            label2.TabIndex = 17;
            label2.Text = "프레스 공정";
            // 
            // label3
            // 
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(655, 93);
            label3.Name = "label3";
            label3.Size = new Size(115, 35);
            label3.TabIndex = 18;
            label3.Text = "차체 공정";
            // 
            // label4
            // 
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(1012, 93);
            label4.Name = "label4";
            label4.Size = new Size(115, 35);
            label4.TabIndex = 19;
            label4.Text = "도장 공정";
            // 
            // label5
            // 
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.Location = new Point(478, 395);
            label5.Name = "label5";
            label5.Size = new Size(115, 35);
            label5.TabIndex = 20;
            label5.Text = "조립 공정";
            // 
            // label6
            // 
            label6.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.Location = new Point(834, 395);
            label6.Name = "label6";
            label6.Size = new Size(124, 35);
            label6.TabIndex = 21;
            label6.Text = "안정성 검사";
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(440, 81);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(782, 81);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(1139, 81);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(605, 378);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 50);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 25;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(961, 378);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 50);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 26;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(575, 200);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(45, 40);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 27;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(924, 200);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(45, 40);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 28;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(402, 495);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(45, 40);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 29;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(747, 495);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(45, 40);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 30;
            pictureBox14.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(374, 339);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox2.Location = new Point(724, 339);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox3.Location = new Point(1081, 339);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 33;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox4.Location = new Point(536, 640);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 34;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox5.Location = new Point(905, 640);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 29);
            textBox5.TabIndex = 35;
            // 
            // FacForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1401, 684);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FacForm";
            Text = "KIA 자동화 공정 시스템";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Production_btn;
        private Button Live_btn;
        private Button Pause_btn;
        private Button Exit_btn;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
