namespace project
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
            components = new System.ComponentModel.Container();
            pressPB = new PictureBox();
            weldingPB = new PictureBox();
            paintPB = new PictureBox();
            assemblePB = new PictureBox();
            pressBtn = new Button();
            weldingBtn = new Button();
            paintBtn = new Button();
            assembleBtn = new Button();
            pressBtn2 = new Button();
            weldingBtn2 = new Button();
            paintBtn2 = new Button();
            assembleBtn2 = new Button();
            pressPrB = new CircularProgressBar_NET5.CircularProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            weldingPrB = new CircularProgressBar_NET5.CircularProgressBar();
            paintPrB = new CircularProgressBar_NET5.CircularProgressBar();
            assemblePrB = new CircularProgressBar_NET5.CircularProgressBar();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            arrowPB1 = new PictureBox();
            arrowPB2 = new PictureBox();
            arrowPB3 = new PictureBox();
            consignmentBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pressPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weldingPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paintPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assemblePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrowPB1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrowPB2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrowPB3).BeginInit();
            SuspendLayout();
            // 
            // pressPB
            // 
            pressPB.Location = new Point(12, 12);
            pressPB.Name = "pressPB";
            pressPB.Size = new Size(290, 239);
            pressPB.SizeMode = PictureBoxSizeMode.StretchImage;
            pressPB.TabIndex = 0;
            pressPB.TabStop = false;
            pressPB.Click += pressPB_Click;
            // 
            // weldingPB
            // 
            weldingPB.Location = new Point(387, 12);
            weldingPB.Name = "weldingPB";
            weldingPB.Size = new Size(290, 239);
            weldingPB.SizeMode = PictureBoxSizeMode.StretchImage;
            weldingPB.TabIndex = 1;
            weldingPB.TabStop = false;
            // 
            // paintPB
            // 
            paintPB.Location = new Point(762, 12);
            paintPB.Name = "paintPB";
            paintPB.Size = new Size(290, 239);
            paintPB.SizeMode = PictureBoxSizeMode.StretchImage;
            paintPB.TabIndex = 2;
            paintPB.TabStop = false;
            // 
            // assemblePB
            // 
            assemblePB.Location = new Point(1137, 12);
            assemblePB.Name = "assemblePB";
            assemblePB.Size = new Size(290, 239);
            assemblePB.TabIndex = 3;
            assemblePB.TabStop = false;
            // 
            // pressBtn
            // 
            pressBtn.Font = new Font("맑은 고딕", 16F);
            pressBtn.Location = new Point(34, 450);
            pressBtn.Name = "pressBtn";
            pressBtn.Size = new Size(221, 51);
            pressBtn.TabIndex = 4;
            pressBtn.Text = "프레스 공정 시작";
            pressBtn.UseVisualStyleBackColor = true;
            pressBtn.Click += pressBtn_Click;
            // 
            // weldingBtn
            // 
            weldingBtn.Font = new Font("맑은 고딕", 16F);
            weldingBtn.Location = new Point(422, 450);
            weldingBtn.Name = "weldingBtn";
            weldingBtn.Size = new Size(221, 51);
            weldingBtn.TabIndex = 5;
            weldingBtn.Text = "용접 공정 시작";
            weldingBtn.UseVisualStyleBackColor = true;
            weldingBtn.Click += weldingBtn_Click;
            // 
            // paintBtn
            // 
            paintBtn.Font = new Font("맑은 고딕", 16F);
            paintBtn.Location = new Point(803, 450);
            paintBtn.Name = "paintBtn";
            paintBtn.Size = new Size(221, 51);
            paintBtn.TabIndex = 6;
            paintBtn.Text = "도장 공정 시작";
            paintBtn.UseVisualStyleBackColor = true;
            paintBtn.Click += paintBtn_Click;
            // 
            // assembleBtn
            // 
            assembleBtn.Font = new Font("맑은 고딕", 16F);
            assembleBtn.Location = new Point(1164, 450);
            assembleBtn.Name = "assembleBtn";
            assembleBtn.Size = new Size(221, 51);
            assembleBtn.TabIndex = 7;
            assembleBtn.Text = "조립 공정 시작";
            assembleBtn.UseVisualStyleBackColor = true;
            assembleBtn.Click += assembleBtn_Click;
            // 
            // pressBtn2
            // 
            pressBtn2.Font = new Font("맑은 고딕", 16F);
            pressBtn2.Location = new Point(34, 522);
            pressBtn2.Name = "pressBtn2";
            pressBtn2.Size = new Size(221, 49);
            pressBtn2.TabIndex = 8;
            pressBtn2.Text = "프레스 공정 정지";
            pressBtn2.UseVisualStyleBackColor = true;
            pressBtn2.Click += pressBtn2_Click;
            // 
            // weldingBtn2
            // 
            weldingBtn2.Font = new Font("맑은 고딕", 16F);
            weldingBtn2.Location = new Point(422, 520);
            weldingBtn2.Name = "weldingBtn2";
            weldingBtn2.Size = new Size(221, 51);
            weldingBtn2.TabIndex = 9;
            weldingBtn2.Text = "용접 공정 정지";
            weldingBtn2.UseVisualStyleBackColor = true;
            weldingBtn2.Click += weldingBtn2_Click;
            // 
            // paintBtn2
            // 
            paintBtn2.Font = new Font("맑은 고딕", 16F);
            paintBtn2.Location = new Point(803, 522);
            paintBtn2.Name = "paintBtn2";
            paintBtn2.Size = new Size(221, 51);
            paintBtn2.TabIndex = 10;
            paintBtn2.Text = "도장 공정 정지";
            paintBtn2.UseVisualStyleBackColor = true;
            paintBtn2.Click += paintBtn2_Click;
            // 
            // assembleBtn2
            // 
            assembleBtn2.Font = new Font("맑은 고딕", 16F);
            assembleBtn2.Location = new Point(1164, 520);
            assembleBtn2.Name = "assembleBtn2";
            assembleBtn2.Size = new Size(221, 51);
            assembleBtn2.TabIndex = 11;
            assembleBtn2.Text = "조립 공정 정지\r\n";
            assembleBtn2.UseVisualStyleBackColor = true;
            assembleBtn2.Click += assembleBtn2_Click;
            // 
            // pressPrB
            // 
            pressPrB.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            pressPrB.AnimationSpeed = 500;
            pressPrB.BackColor = Color.Transparent;
            pressPrB.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            pressPrB.ForeColor = Color.FromArgb(64, 64, 64);
            pressPrB.InnerColor = Color.FromArgb(224, 224, 224);
            pressPrB.InnerMargin = 2;
            pressPrB.InnerWidth = -1;
            pressPrB.Location = new Point(66, 271);
            pressPrB.MarqueeAnimationSpeed = 2000;
            pressPrB.Name = "pressPrB";
            pressPrB.OuterColor = Color.Gray;
            pressPrB.OuterMargin = -25;
            pressPrB.OuterWidth = 26;
            pressPrB.ProgressColor = Color.FromArgb(255, 128, 0);
            pressPrB.ProgressWidth = 25;
            pressPrB.SecondaryFont = new Font("맑은 고딕", 9F);
            pressPrB.Size = new Size(153, 154);
            pressPrB.StartAngle = 270;
            pressPrB.Style = ProgressBarStyle.Continuous;
            pressPrB.SubscriptColor = Color.FromArgb(166, 166, 166);
            pressPrB.SubscriptMargin = new Padding(10, -35, 0, 0);
            pressPrB.SubscriptText = "";
            pressPrB.SuperscriptColor = Color.FromArgb(166, 166, 166);
            pressPrB.SuperscriptMargin = new Padding(10, 35, 0, 0);
            pressPrB.SuperscriptText = "";
            pressPrB.TabIndex = 12;
            pressPrB.TextMargin = new Padding(8, 8, 0, 0);
            pressPrB.UseWaitCursor = true;
            pressPrB.Value = 68;
            pressPrB.Click += pressPrB_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // weldingPrB
            // 
            weldingPrB.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            weldingPrB.AnimationSpeed = 500;
            weldingPrB.BackColor = Color.Transparent;
            weldingPrB.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            weldingPrB.ForeColor = Color.FromArgb(64, 64, 64);
            weldingPrB.InnerColor = Color.FromArgb(224, 224, 224);
            weldingPrB.InnerMargin = 2;
            weldingPrB.InnerWidth = -1;
            weldingPrB.Location = new Point(444, 271);
            weldingPrB.MarqueeAnimationSpeed = 2000;
            weldingPrB.Name = "weldingPrB";
            weldingPrB.OuterColor = Color.Gray;
            weldingPrB.OuterMargin = -25;
            weldingPrB.OuterWidth = 26;
            weldingPrB.ProgressColor = Color.FromArgb(255, 128, 128);
            weldingPrB.ProgressWidth = 25;
            weldingPrB.SecondaryFont = new Font("맑은 고딕", 9F);
            weldingPrB.Size = new Size(153, 154);
            weldingPrB.StartAngle = 270;
            weldingPrB.Style = ProgressBarStyle.Continuous;
            weldingPrB.SubscriptColor = Color.FromArgb(166, 166, 166);
            weldingPrB.SubscriptMargin = new Padding(10, -35, 0, 0);
            weldingPrB.SubscriptText = "";
            weldingPrB.SuperscriptColor = Color.FromArgb(166, 166, 166);
            weldingPrB.SuperscriptMargin = new Padding(10, 35, 0, 0);
            weldingPrB.SuperscriptText = "";
            weldingPrB.TabIndex = 13;
            weldingPrB.TextMargin = new Padding(8, 8, 0, 0);
            weldingPrB.Value = 68;
            // 
            // paintPrB
            // 
            paintPrB.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            paintPrB.AnimationSpeed = 500;
            paintPrB.BackColor = Color.Transparent;
            paintPrB.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            paintPrB.ForeColor = Color.FromArgb(64, 64, 64);
            paintPrB.InnerColor = Color.FromArgb(224, 224, 224);
            paintPrB.InnerMargin = 2;
            paintPrB.InnerWidth = -1;
            paintPrB.Location = new Point(839, 271);
            paintPrB.MarqueeAnimationSpeed = 2000;
            paintPrB.Name = "paintPrB";
            paintPrB.OuterColor = Color.Gray;
            paintPrB.OuterMargin = -25;
            paintPrB.OuterWidth = 26;
            paintPrB.ProgressColor = Color.FromArgb(128, 128, 255);
            paintPrB.ProgressWidth = 25;
            paintPrB.SecondaryFont = new Font("맑은 고딕", 36F);
            paintPrB.Size = new Size(153, 154);
            paintPrB.StartAngle = 270;
            paintPrB.Style = ProgressBarStyle.Continuous;
            paintPrB.SubscriptColor = Color.FromArgb(166, 166, 166);
            paintPrB.SubscriptMargin = new Padding(10, -35, 0, 0);
            paintPrB.SubscriptText = "";
            paintPrB.SuperscriptColor = Color.FromArgb(166, 166, 166);
            paintPrB.SuperscriptMargin = new Padding(10, 35, 0, 0);
            paintPrB.SuperscriptText = "";
            paintPrB.TabIndex = 14;
            paintPrB.TextMargin = new Padding(8, 8, 0, 0);
            paintPrB.Value = 68;
            paintPrB.Click += circularProgressBar2_Click;
            // 
            // assemblePrB
            // 
            assemblePrB.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            assemblePrB.AnimationSpeed = 500;
            assemblePrB.BackColor = Color.Transparent;
            assemblePrB.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            assemblePrB.ForeColor = Color.FromArgb(64, 64, 64);
            assemblePrB.InnerColor = Color.FromArgb(224, 224, 224);
            assemblePrB.InnerMargin = 2;
            assemblePrB.InnerWidth = -1;
            assemblePrB.Location = new Point(1214, 271);
            assemblePrB.MarqueeAnimationSpeed = 2000;
            assemblePrB.Name = "assemblePrB";
            assemblePrB.OuterColor = Color.Gray;
            assemblePrB.OuterMargin = -25;
            assemblePrB.OuterWidth = 26;
            assemblePrB.ProgressColor = Color.FromArgb(255, 128, 255);
            assemblePrB.ProgressWidth = 25;
            assemblePrB.SecondaryFont = new Font("맑은 고딕", 36F);
            assemblePrB.Size = new Size(153, 154);
            assemblePrB.StartAngle = 270;
            assemblePrB.Style = ProgressBarStyle.Continuous;
            assemblePrB.SubscriptColor = Color.FromArgb(166, 166, 166);
            assemblePrB.SubscriptMargin = new Padding(10, -35, 0, 0);
            assemblePrB.SubscriptText = "";
            assemblePrB.SuperscriptColor = Color.FromArgb(166, 166, 166);
            assemblePrB.SuperscriptMargin = new Padding(10, 35, 0, 0);
            assemblePrB.SuperscriptText = "";
            assemblePrB.TabIndex = 15;
            assemblePrB.TextMargin = new Padding(8, 8, 0, 0);
            assemblePrB.Value = 68;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // arrowPB1
            // 
            arrowPB1.Location = new Point(308, 115);
            arrowPB1.Name = "arrowPB1";
            arrowPB1.Size = new Size(73, 47);
            arrowPB1.SizeMode = PictureBoxSizeMode.StretchImage;
            arrowPB1.TabIndex = 16;
            arrowPB1.TabStop = false;
            // 
            // arrowPB2
            // 
            arrowPB2.Location = new Point(683, 115);
            arrowPB2.Name = "arrowPB2";
            arrowPB2.Size = new Size(73, 47);
            arrowPB2.SizeMode = PictureBoxSizeMode.StretchImage;
            arrowPB2.TabIndex = 17;
            arrowPB2.TabStop = false;
            // 
            // arrowPB3
            // 
            arrowPB3.Location = new Point(1058, 115);
            arrowPB3.Name = "arrowPB3";
            arrowPB3.Size = new Size(73, 47);
            arrowPB3.SizeMode = PictureBoxSizeMode.StretchImage;
            arrowPB3.TabIndex = 18;
            arrowPB3.TabStop = false;
            // 
            // consignmentBtn
            // 
            consignmentBtn.Font = new Font("맑은 고딕", 16F);
            consignmentBtn.Location = new Point(1431, 332);
            consignmentBtn.Name = "consignmentBtn";
            consignmentBtn.Size = new Size(127, 58);
            consignmentBtn.TabIndex = 19;
            consignmentBtn.Text = "탁송 하기";
            consignmentBtn.UseVisualStyleBackColor = true;
            consignmentBtn.Click += consignmentBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 668);
            Controls.Add(consignmentBtn);
            Controls.Add(arrowPB3);
            Controls.Add(arrowPB2);
            Controls.Add(arrowPB1);
            Controls.Add(assemblePrB);
            Controls.Add(paintPrB);
            Controls.Add(weldingPrB);
            Controls.Add(pressPrB);
            Controls.Add(assembleBtn2);
            Controls.Add(paintBtn2);
            Controls.Add(weldingBtn2);
            Controls.Add(pressBtn2);
            Controls.Add(assembleBtn);
            Controls.Add(paintBtn);
            Controls.Add(weldingBtn);
            Controls.Add(pressBtn);
            Controls.Add(assemblePB);
            Controls.Add(paintPB);
            Controls.Add(weldingPB);
            Controls.Add(pressPB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pressPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)weldingPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)paintPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)assemblePB).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrowPB1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrowPB2).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrowPB3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pressPB;
        private PictureBox weldingPB;
        private PictureBox paintPB;
        private PictureBox assemblePB;
        private Button pressBtn;
        private Button weldingBtn;
        private Button paintBtn;
        private Button assembleBtn;
        private Button pressBtn2;
        private Button weldingBtn2;
        private Button paintBtn2;
        private Button assembleBtn2;
        private CircularProgressBar_NET5.CircularProgressBar pressPrB;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar_NET5.CircularProgressBar weldingPrB;
        private CircularProgressBar_NET5.CircularProgressBar paintPrB;
        private CircularProgressBar_NET5.CircularProgressBar assemblePrB;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private PictureBox arrowPB1;
        private PictureBox arrowPB2;
        private PictureBox arrowPB3;
        private Button consignmentBtn;
    }
}
