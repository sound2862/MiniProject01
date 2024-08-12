using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace KiaSys
{
    public partial class FacForm : Form
    {
        //private Timer timer1;
        private int progress;
        private int currentStep;
        private ProgressBar[] progressBars;
        private TextBox[] textBoxes;
        private bool isPaused;
        private System.Windows.Forms.Timer progressTimer;
        public string CurrentProcess { get; set; }

        public FacForm()
        {
            InitializeComponent();
            //timer1 = new Timer();
            timer1.Interval = 100; // 100ms �������� Ÿ�̸� ƽ �߻�
            timer1.Tick += Timer1_Tick;

            InitializeProgressTimer();

            // ProgressBar�� TextBox �迭 �ʱ�ȭ
            progressBars = new ProgressBar[] { progressBar1, progressBar2, progressBar3, progressBar4, progressBar5 };
            textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImages();
            ResetProgressBarsAndTextBoxes();
        }
        private void LoadImages()
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/press.gif");
            pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/welding.gif");
            pictureBox3.Image = Image.FromFile(System.Environment.CurrentDirectory + "/paint.gif");
            pictureBox4.Image = Image.FromFile(System.Environment.CurrentDirectory + "/assemble.gif");
            pictureBox5.Image = Image.FromFile(System.Environment.CurrentDirectory + "/checkk.gif");

            pictureBox11.Image = Image.FromFile(System.Environment.CurrentDirectory + "/arrow.gif");
            pictureBox12.Image = Image.FromFile(System.Environment.CurrentDirectory + "/arrow.gif");
            pictureBox13.Image = Image.FromFile(System.Environment.CurrentDirectory + "/arrow.gif");
            pictureBox14.Image = Image.FromFile(System.Environment.CurrentDirectory + "/arrow.gif");
        }
        private void ResetProgressBarsAndTextBoxes()
        {
            foreach (var progressBar in progressBars)
            {
                progressBar.Value = 0;
            }

            foreach (var textBox in textBoxes)
            {
                textBox.Text = "�����: 0%";
            }
        }
        private void Production_btn_Click(object sender, EventArgs e)
        {
            currentStep = 0; // ù ��° PictureBox�� ProgressBar���� ����
            progress = 0;
            timer1.Start();
            CurrentProcess = "������ ����"; // ù ��° ������ ���÷� ����
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progress < 100)
            {
                progress += 2; // ProgressBar�� ������Ŵ
                progressBars[currentStep].Value = progress;
                textBoxes[currentStep].Text = $"�����: {progress}%";
            }
            else
            {
                progressBars[currentStep].Value = 100;
                textBoxes[currentStep].Text = $"�����: 100%";

                currentStep++;

                if (currentStep < progressBars.Length)
                {
                    progress = 0;
                    CurrentProcess = GetProcessName(currentStep); // ���� �̸��� ������Ʈ

                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("��� �۾��� �Ϸ�Ǿ����ϴ�!!");
                    CurrentProcess = ""; // ��� �۾� �Ϸ� �� ���� ���� �ʱ�ȭ
                }
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private string GetProcessName(int step)
        {
            switch (step)
            {
                case 0:
                    return "������ ����";
                case 1:
                    return "��ü ����";
                case 2:
                    return "���� ����";
                case 3:
                    return "���� ����";
                case 4:
                    return "������ �˻�";
                default:
                    return "";
            }
        }
        private void Live_btn_Click(object sender, EventArgs e)
        {
            FacForm_Live liveForm = new FacForm_Live(this); // ���� ���� ����
            liveForm.Show();
        }
        private void InitializeProgressTimer()
        {
            progressTimer = new System.Windows.Forms.Timer(); // ��Ȯ�� ���ӽ����̽� ����
            progressTimer.Interval = 100; // 100ms���� Ÿ�̸� ƽ �̺�Ʈ �߻�
            progressTimer.Tick += ProgressTimer_Tick;
        }
        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            else
            {
                progressTimer.Stop(); // �ִ밪�� �����ϸ� Ÿ�̸Ӹ� ����ϴ�.
            }
        }
        private void Pause_btn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop(); // ������ �����ϱ� ���� timer1�� ����
                MessageBox.Show("��� ������ ������ ����ϴ�.");
                isPaused = true; // ���¸� ��Ÿ���� ���� ����
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
