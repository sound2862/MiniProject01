using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiaSys
{
    public partial class FacForm_Live : Form
    {
        private FacForm facForm; // 메인 폼을 참조하기 위한 변수

        public FacForm_Live(FacForm facForm)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/cctv.gif");
            this.facForm = facForm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string output = "";

            // mainForm 대신 facForm을 사용하여 현재 공정을 참조해야 합니다.
            if (string.IsNullOrEmpty(facForm.CurrentProcess))
            {
                output = "자동화 공정이 동작하고 있지 않습니다. 명령을 내려주세요.";
            }
            else
            {
                output = $"{currentTime} - 현재 동작 중인 공정: {facForm.CurrentProcess}";
            }

            textBox1.AppendText(output + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
