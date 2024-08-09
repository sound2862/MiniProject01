namespace KiaSys
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            label1 = new Label();
            Search_btn = new Button();
            Production_btn = new Button();
            Live_btn = new Button();
            Chart_btn = new Button();
            Menu_Box = new GroupBox();
            Exit_btn = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Menu_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(867, 53);
            label1.TabIndex = 0;
            label1.Text = "KIA 자동화 공정 시스템";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Search_btn
            // 
            Search_btn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Search_btn.Location = new Point(28, 32);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(152, 79);
            Search_btn.TabIndex = 1;
            Search_btn.Text = "주문 조회";
            Search_btn.UseVisualStyleBackColor = true;
            // 
            // Production_btn
            // 
            Production_btn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Production_btn.Location = new Point(28, 117);
            Production_btn.Name = "Production_btn";
            Production_btn.Size = new Size(152, 79);
            Production_btn.TabIndex = 2;
            Production_btn.Text = "생산";
            Production_btn.UseVisualStyleBackColor = true;
            // 
            // Live_btn
            // 
            Live_btn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Live_btn.Location = new Point(28, 202);
            Live_btn.Name = "Live_btn";
            Live_btn.Size = new Size(152, 79);
            Live_btn.TabIndex = 3;
            Live_btn.Text = "실시간 감시";
            Live_btn.UseVisualStyleBackColor = true;
            // 
            // Chart_btn
            // 
            Chart_btn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Chart_btn.Location = new Point(28, 287);
            Chart_btn.Name = "Chart_btn";
            Chart_btn.Size = new Size(152, 79);
            Chart_btn.TabIndex = 4;
            Chart_btn.Text = "차트";
            Chart_btn.UseVisualStyleBackColor = true;
            // 
            // Menu_Box
            // 
            Menu_Box.BackColor = SystemColors.ActiveCaption;
            Menu_Box.Controls.Add(Exit_btn);
            Menu_Box.Controls.Add(Search_btn);
            Menu_Box.Controls.Add(Chart_btn);
            Menu_Box.Controls.Add(Production_btn);
            Menu_Box.Controls.Add(Live_btn);
            Menu_Box.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Menu_Box.Location = new Point(12, 77);
            Menu_Box.Name = "Menu_Box";
            Menu_Box.Size = new Size(206, 461);
            Menu_Box.TabIndex = 5;
            Menu_Box.TabStop = false;
            Menu_Box.Text = "메뉴";
            // 
            // Exit_btn
            // 
            Exit_btn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Exit_btn.Location = new Point(28, 372);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(152, 79);
            Exit_btn.TabIndex = 6;
            Exit_btn.Text = "종료";
            Exit_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 407);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(627, 131);
            textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(252, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(627, 308);
            dataGridView1.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(937, 109);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 17;
            chart1.Text = "chart1";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1469, 816);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(Menu_Box);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            Menu_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Search_btn;
        private Button Production_btn;
        private Button Live_btn;
        private Button Chart_btn;
        private GroupBox Menu_Box;
        private Button Exit_btn;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}