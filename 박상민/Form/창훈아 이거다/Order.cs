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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("K3");
            comboBox1.Items.Add("K5");
            comboBox1.Items.Add("K8");

            comboBox2.Items.Add("WHITE");
            comboBox2.Items.Add("GRAY");
            comboBox2.Items.Add("BLACK");

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
            comboBox3.SelectedIndexChanged += new EventHandler(comboBox3_SelectedIndexChanged);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("선택하신 차량과 옵션은 " + comboBox1.Text + textBox1.Text + "입니다.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
