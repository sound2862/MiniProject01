namespace KiaSys
{
    public partial class FacForm : Form
    {
        public FacForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/press.gif");
        }
    }
}
