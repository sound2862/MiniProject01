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
            timer1.Interval = 100; // 100ms 간격으로 타이머 틱 발생
            timer1.Tick += Timer1_Tick;

            InitializeProgressTimer();

            // ProgressBar와 TextBox 배열 초기화
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
                textBox.Text = "진행률: 0%";
            }
        }
        private void Production_btn_Click(object sender, EventArgs e)
        {
            currentStep = 0; // 첫 번째 PictureBox와 ProgressBar부터 시작
            progress = 0;
            timer1.Start();
            CurrentProcess = "프레스 공정"; // 첫 번째 공정을 예시로 설정
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progress < 100)
            {
                progress += 2; // ProgressBar를 증가시킴
                progressBars[currentStep].Value = progress;
                textBoxes[currentStep].Text = $"진행률: {progress}%";
            }
            else
            {
                progressBars[currentStep].Value = 100;
                textBoxes[currentStep].Text = $"진행률: 100%";

                currentStep++;

                if (currentStep < progressBars.Length)
                {
                    progress = 0;
                    CurrentProcess = GetProcessName(currentStep); // 공정 이름을 업데이트

                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("모든 작업이 완료되었습니다!!");
                    CurrentProcess = ""; // 모든 작업 완료 시 현재 공정 초기화
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
                    return "프레스 공정";
                case 1:
                    return "차체 공정";
                case 2:
                    return "도장 공정";
                case 3:
                    return "조립 공정";
                case 4:
                    return "안정성 검사";
                default:
                    return "";
            }
        }
        private void Live_btn_Click(object sender, EventArgs e)
        {
            FacForm_Live liveForm = new FacForm_Live(this); // 현재 폼을 전달
            liveForm.Show();
        }
        private void InitializeProgressTimer()
        {
            progressTimer = new System.Windows.Forms.Timer(); // 명확한 네임스페이스 지정
            progressTimer.Interval = 100; // 100ms마다 타이머 틱 이벤트 발생
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
                progressTimer.Stop(); // 최대값에 도달하면 타이머를 멈춥니다.
            }
        }
        private void Pause_btn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop(); // 공정을 중지하기 위해 timer1을 멈춤
                MessageBox.Show("모든 공정이 동작을 멈춥니다.");
                isPaused = true; // 상태를 나타내는 변수 설정
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
