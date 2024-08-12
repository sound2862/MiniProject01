using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        Image originalGif1; //�̹��� �ϳ�
        Image originalGif2;
        Image originalGif3;
        Image originalGif4;
        Image originalGif5; 
        Image originalGif6;
        Image originalGif7;
        Bitmap firstFrame; //��� ������ ��
        Bitmap secondFrame;
        Bitmap thirdFrame;
        Bitmap fourthFrame;
        Bitmap fifthFrame;
        Bitmap sixthFrame;
        Bitmap sevenFrame;
        private int counter;
        private int progressValue1 = 0;
        private int progressValue2 = 0;
        private int progressValue3 = 0;
        private int progressValue4 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pressPrB.Minimum = 0;
            pressPrB.Maximum = 100;
            pressPrB.Value = 0;
            pressPrB.Text = "���൵: 0%";
            weldingPrB.Minimum = 0;
            weldingPrB.Maximum = 100;
            weldingPrB.Value = 0;
            weldingPrB.Text = "���൵: 0%";
            paintPrB.Minimum = 0;
            paintPrB.Maximum = 100;
            paintPrB.Value = 0;
            paintPrB.Text = "���൵: 0%";
            assemblePrB.Minimum = 0;
            assemblePrB.Maximum = 100;
            assemblePrB.Value = 0;
            assemblePrB.Text = "���൵: 0%";
        }

        private void pressPB_Click(object sender, EventArgs e)
        {
        }

        private void pressBtn_Click(object sender, EventArgs e)
        {
            progressValue1 = 0;
            pressPrB.Value = 0; // ���α׷����� �ʱ�ȭ
            pressPrB.Text = "���൵: 0%"; // ���α׷����� �ؽ�Ʈ �ʱ�ȭ

            timer1.Start();
            // press.gif ���� ��� ����
            string filePath = System.Environment.CurrentDirectory + "/press.gif";
            string filePath2 = System.Environment.CurrentDirectory + "/arrow.gif";
            // ������ �����ϴ��� Ȯ��
            if (System.IO.File.Exists(filePath))
            {
                // ������ �����ϸ� PictureBox�� �̹��� ����
                originalGif1 = Image.FromFile(filePath);
                originalGif5 = Image.FromFile(filePath2);
                pressPB.Image = originalGif1;
                arrowPB1.Image = originalGif5;

                // ù ��° �������� �����Ͽ� ����
                firstFrame = GetFirstFrame(originalGif1);
                fifthFrame = GetFirstFrame(originalGif5);
            }
            else
            {
                MessageBox.Show("������ ã�� �� �����ϴ�: " + filePath);
            }
        }

        private void pressBtn2_Click(object sender, EventArgs e)
        {
            // Ÿ�̸� ����
            timer1.Stop();
            timer1.Enabled = false; // Ÿ�̸� ��Ȱ��ȭ
            Application.DoEvents(); // UI ������Ʈ ����

            // PictureBox�� ù ������ �����Ͽ� GIF ����
            if (firstFrame != null)
            {
                pressPB.Image = firstFrame;
                arrowPB1.Image = fifthFrame;
            }
        }

        private Bitmap GetFirstFrame(Image gifImage)
        {
            // GIF�� ù ������ ����
            FrameDimension dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
            gifImage.SelectActiveFrame(dimension, 0);
            return new Bitmap(gifImage);
        }

        private void weldingBtn_Click(object sender, EventArgs e)
        {
            progressValue2 = 0;
            weldingPrB.Value = 0; // ���α׷����� �ʱ�ȭ
            weldingPrB.Text = "���൵: 0%"; // ���α׷����� �ؽ�Ʈ �ʱ�ȭ

            timer2.Start();
            // welding.gif ���� ��� ����
            string filePath = System.Environment.CurrentDirectory + "/welding.gif";
            string filePath2 = System.Environment.CurrentDirectory + "/arrow.gif";
            // ������ �����ϴ��� Ȯ��
            if (System.IO.File.Exists(filePath))
            {
                // ������ �����ϸ� PictureBox�� �̹��� ����
                originalGif2 = Image.FromFile(filePath);
                originalGif6 = Image.FromFile(filePath2);
                weldingPB.Image = originalGif2;
                arrowPB2.Image = originalGif6;

                // �� ��° �������� �����Ͽ� ����
                secondFrame = GetFirstFrame(originalGif2);
                sixthFrame = GetFirstFrame(originalGif6);
            }
            else
            {
                MessageBox.Show("������ ã�� �� �����ϴ�: " + filePath);
            }
        }

        private void weldingBtn2_Click(object sender, EventArgs e)
        {
            // Ÿ�̸� ����
            timer2.Stop();
            timer2.Enabled = false; // Ÿ�̸� ��Ȱ��ȭ
            Application.DoEvents(); // UI ������Ʈ ����

            if (secondFrame != null)
            {
                weldingPB.Image = secondFrame;
                arrowPB2.Image = sixthFrame;
            }
        }

        private void paintBtn_Click(object sender, EventArgs e)
        {
            progressValue3 = 0;
            paintPrB.Value = 0; // ���α׷����� �ʱ�ȭ
            paintPrB.Text = "���൵: 0%"; // ���α׷����� �ؽ�Ʈ �ʱ�ȭ

            timer3.Start();
            // paint.gif ���� ��� ����
            string filePath = System.Environment.CurrentDirectory + "/paint.gif";
            string filepath2 = System.Environment.CurrentDirectory + "/arrow.gif";
            // ������ �����ϴ��� Ȯ��
            if (System.IO.File.Exists(filePath))
            {
                // ������ �����ϸ� PictureBox�� �̹��� ����
                originalGif3 = Image.FromFile(filePath);
                originalGif7 = Image.FromFile(filepath2);
                paintPB.Image = originalGif3;
                arrowPB3.Image = originalGif7;

                // �� ��° �������� �����Ͽ� ����
                thirdFrame = GetFirstFrame(originalGif3);
                sevenFrame = GetFirstFrame(originalGif7);
            }
            else
            {
                MessageBox.Show("������ ã�� �� �����ϴ�: " + filePath);
            }
        }

        private void paintBtn2_Click(object sender, EventArgs e)
        {
            // Ÿ�̸� ����
            timer3.Stop();
            timer3.Enabled = false; // Ÿ�̸� ��Ȱ��ȭ
            Application.DoEvents(); // UI ������Ʈ ����

            if (thirdFrame != null)
            {
                paintPB.Image = thirdFrame;
                arrowPB3.Image = sevenFrame;
            }
        }

        private void assembleBtn_Click(object sender, EventArgs e)
        {
            progressValue4 = 0;
            assemblePrB.Value = 0; // ���α׷����� �ʱ�ȭ
            assemblePrB.Text = "���൵: 0%"; // ���α׷����� �ؽ�Ʈ �ʱ�ȭ

            timer4.Start();
            // assemble.gif ���� ��� ����
            string filePath = System.Environment.CurrentDirectory + "/assemble.gif";
            string filepath2 = System.Environment.CurrentDirectory + "/arrow.gif";
            // ������ �����ϴ��� Ȯ��
            if (System.IO.File.Exists(filePath))
            {
                // ������ �����ϸ� PictureBox�� �̹��� ����
                originalGif4 = Image.FromFile(filePath);
                assemblePB.Image = originalGif4;

                // �� ��° �������� �����Ͽ� ����
                fourthFrame = GetFirstFrame(originalGif4);
            }
            else
            {
                MessageBox.Show("������ ã�� �� �����ϴ�: " + filePath);
            }
        }

        private void assembleBtn2_Click(object sender, EventArgs e)
        {
            // Ÿ�̸� ����
            timer4.Stop();
            timer4.Enabled = false; // Ÿ�̸� ��Ȱ��ȭ
            Application.DoEvents(); // UI ������Ʈ ����

            if (fourthFrame != null)
            {
                assemblePB.Image = fourthFrame;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressValue1 < 100)
            {
                progressValue1 += 1;
                pressPrB.Value = progressValue1;
                pressPrB.Text = $"���൵: {progressValue1}%";
            }
            else
            {
                timer1.Stop();
            }
        }

        private void pressPrB_Click(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressValue2 < 100)
            {
                progressValue2 += 1;
                weldingPrB.Value = progressValue2;
                weldingPrB.Text = $"���൵: {progressValue2}%";
            }
            else
            {
                timer2.Stop();
            }
        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressValue3 < 100)
            {
                progressValue3 += 1;
                paintPrB.Value = progressValue3;
                paintPrB.Text = $"���൵: {progressValue3}%";
            }
            else
            {
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (progressValue4 < 100)
            {
                progressValue4 += 1;
                assemblePrB.Value = progressValue4;
                assemblePrB.Text = $"���൵: {progressValue4}%";
            }
            else
            {
                timer4.Stop();
            }
        }

        private void consignmentBtn_Click(object sender, EventArgs e)
        {
            Form2 frm2= new Form2();    
            frm2.ShowDialog();
        }
    }
}
