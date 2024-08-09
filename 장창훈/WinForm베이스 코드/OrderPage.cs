using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using UtilProject;

namespace MiniProjectBuycar

{
    public partial class OrderPage : Form
    {
        private DatabaseUtil Util = new DatabaseUtil();

        private int CustomerID;
        private string selectedModel;
        private string selectedEngine;
        private string selectedColor;
        public int NewCustomerID { get; private set; }
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
                comboBox2.Items.Add("1.6 ���ָ�");
            }
            else if (comboBox1.SelectedItem.ToString() == "K5")
            {
                comboBox2.Items.Add("2.0 ���ָ�");
                comboBox2.Items.Add("2.0 LPi");
            }
            else if (comboBox1.SelectedItem.ToString() == "K8")
            {
                comboBox2.Items.Add("3.5 ���ָ�");
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
        private void Orderbutton_Click(object sender, EventArgs e)
        {
            // ���õ� ��, ����, ���� ��������
            selectedModel = comboBox1.SelectedItem?.ToString() ?? "�� �̼���";
            selectedEngine = comboBox2.SelectedItem?.ToString() ?? "���� �̼���";
            selectedColor = comboBox3.SelectedItem?.ToString() ?? "���� �̼���";

            // PLSQL ������ ���� scott ���� ����
            string connectionString = Util.Conneting();
            string sqlCommand = $"drop table CustomerTemp";
            Util.ExecuteNonQuery(sqlCommand);

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // CustomerTemp ���̺� ����
                    string createTemp = "CREATE TABLE CustomerTemp(Model VARCHAR2(20), Engine VARCHAR2(20), Color VARCHAR2(20), Options VARCHAR2(20))";
                    using (OracleCommand createCmd = new OracleCommand(createTemp, conn))
                    {
                        try
                        {
                            createCmd.ExecuteNonQuery(); // ���̺� ���� ��� ����
                        }
                        catch (OracleException ex) when (ex.Number == 955)
                        {
                            // ���̺��� �̹� �����ϴ� ��� �߻��� �� �ִ� ���� 955�� �����ϰ� ����
                        }
                    }

                    // ���� ����
                    string insertQuery = "INSERT INTO CustomerTemp (Model, Engine, Color) VALUES (:model, :engine, :color)";
                    using (OracleCommand insertCmd = new OracleCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add(new OracleParameter("model", selectedModel));
                        insertCmd.Parameters.Add(new OracleParameter("engine", selectedEngine));
                        insertCmd.Parameters.Add(new OracleParameter("color", selectedColor));

                        insertCmd.ExecuteNonQuery(); // ������ ���� ��� ����

                        MessageBox.Show($"���� ������ ����Ǿ����ϴ�.", "���� �Ϸ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // AddOption ���� ���� ���� ����� ������ ����
                    AddOption addOptionForm = new AddOption();
                    addOptionForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�����͸� �����ϴ� ���� ������ �߻��߽��ϴ�: " + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            
        }
    }//orderpage:form END
}
