using Oracle.ManagedDataAccess.Client;

namespace MiniProjectBuycar
{
    public partial class OrderPage : Form
    {
        public OrderPage()
        {
            InitializeComponent();
            comboBox1.Items.Add("K3");
            comboBox1.Items.Add("K5");
            comboBox1.Items.Add("K8");

            // comboBox1�� SelectedIndexChanged �̺�Ʈ �ڵ鷯 �߰�
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
            comboBox3.SelectedIndexChanged += new EventHandler(comboBox3_SelectedIndexChanged);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox2�� �׸��� �ʱ�ȭ
            comboBox2.Items.Clear();

            // comboBox1���� ������ �׸� ���� comboBox2�� �׸� �߰�
            if (comboBox1.SelectedItem.ToString() == "K3")
            {
                comboBox2.Items.Add("1.6���ָ�");
            }
            else if (comboBox1.SelectedItem.ToString() == "K5")
            {
                comboBox2.Items.Add("2.0 ���ָ�");
                comboBox2.Items.Add("2.0 LPi");
            }
            else if (comboBox1.SelectedItem.ToString() == "K8")
            {
                comboBox2.Items.Add("3.5���ָ�");
                comboBox2.Items.Add("3.5 LPi");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combobox2�� �׸� ���� comboBox3�� �׸� ����
            comboBox3.Items.Clear();
            comboBox3.Items.Add("����");
            comboBox3.Items.Add("���");
            comboBox3.Items.Add("ȸ��");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1�� comboBox3�� ���õ� �׸��� ������
            string selectedModel = comboBox1.SelectedItem?.ToString();
            string selectedColor = comboBox3.SelectedItem?.ToString();
            string imagePath = "";

            // �� ComboBox�� ���õ� �׸� ���� ���� �˻�
            if (selectedModel == "K3" && selectedColor == "ȸ��")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K3\\K3_GRAY.png"; // K3 ��� �̹��� ���� ���
            }
            else if (selectedModel == "K3" && selectedColor == "����")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K3\\K3_BLACK.png"; // K3 ������ �̹��� ���� ���
            }
            else if (selectedModel == "K3" && selectedColor == "���")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K3\\K3_WHITE.png"; // K3 ��� �̹��� ���� ���
            }
            else if (selectedModel == "K5" && selectedColor == "����")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K5\\K5_BLACK.png"; // K5 ������ �̹��� ���� ���
            }
            else if (selectedModel == "K5" && selectedColor == "ȸ��")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K5\\K5_GRAY.png"; // K5 ��� �̹��� ���� ���
            }
            else if (selectedModel == "K5" && selectedColor == "���")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K5\\K5_WHITE.png"; // K5 ��� �̹��� ���� ���
            }
            else if (selectedModel == "K8" && selectedColor == "����")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K8\\K8_BLACK.png"; // K8 ������ �̹��� ���� ���
            }
            else if (selectedModel == "K8" && selectedColor == "ȸ��")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K8\\K8_GRAY.png"; // K8 ��� �̹��� ���� ���
            }
            else if (selectedModel == "K8" && selectedColor == "���")
            {
                imagePath = "C:\\Users\\Admin\\source\\repos\\MiniProjectBuycar\\K8\\K8_WHITE.png";// K8 ��� �̹��� ���� ���
            }
            else
            {
                pictureBox1.Image = null; // ���õ� �׸��� ���� ��� �̹����� �ʱ�ȭ
                return;
            }

            // pictureBox1�� �̹��� �ε�
            if (!string.IsNullOrEmpty(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        } // Form1_Load end

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ���õ� ��, ����, ���� ��������
            string selectedModel = comboBox1.SelectedItem?.ToString() ?? "�� �̼���";
            string selectedEngine = comboBox2.SelectedItem?.ToString() ?? "���� �̼���";
            string selectedColor = comboBox3.SelectedItem?.ToString() ?? "���� �̼���";

            // PLSQL ������ ���� scott ���� ����
            string connectionString = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=SCOTT;Password=TIGER;";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Customer (Model, Engine, Color) VALUES (:model, :engine, :color )";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("model", selectedModel));
                        cmd.Parameters.Add(new OracleParameter("engine", selectedEngine));
                        cmd.Parameters.Add(new OracleParameter("color", selectedColor));
                        MessageBox.Show("�ֹ� ������ ����Ǿ����ϴ�.", "���� �Ϸ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�����͸� �����ϴ� ���� ������ �߻��߽��ϴ�: " + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // AddOption �� �ν��Ͻ� ���� �� ������ ����
            AddOption addOptionForm = new AddOption();
            addOptionForm.ShowDialog();
        }

    } // Form1:Form
}

