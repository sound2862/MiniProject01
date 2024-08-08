using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace SFMiniProject
{
    public partial class Form1 : Form
    {
        private DatabaseUtil Util = new DatabaseUtil();
        private string a;
        private string b;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Util.GetTableData("MaterialTable");
            dataGridView2.DataSource = Util.GetTableData("PressTable");
            dataGridView3.DataSource = Util.GetTableData("WeldTable");
            dataGridView4.DataSource = Util.GetTableData("PaintTable");
            dataGridView5.DataSource = Util.GetTableData("LoginTable");

            a = Util.GetCellValue(dataGridView5, 1, 3);
            b = Util.GetCellValue(dataGridView5, 1, 4);
            label1.Text = a;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            bool loginSuccess = false;

            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    string id = row.Cells[2].Value.ToString();
                    string password = row.Cells[3].Value.ToString();

                    if (textBox1.Text == id && textBox2.Text == password)
                    {
                        loginSuccess = true;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                label1.Text = "로그인 성공!";
            }
            else
            {
                label1.Text = "잘못된 입력입니다";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class DatabaseUtil
    {
        private string strConn = "Data Source=(DESCRIPTION=" +
                                 "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                                 "(HOST=localhost)(PORT=1521)))" +
                                 "(CONNECT_DATA=(SERVER=DEDICATED)" +
                                 "(SERVICE_NAME=xe)));" +
                                 "User Id=scott;Password=TIGER;";

        public DataTable GetTableData(string tableName)
        {
            using (OracleConnection conn = new OracleConnection(strConn))
            {
                string query = $"SELECT * FROM {tableName}";
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public string GetCellValue(DataGridView dgv, int rowIndex, int columnIndex)
        {
            int adjustedRowIndex = rowIndex - 1;
            int adjustedColumnIndex = columnIndex - 1;

            if (adjustedRowIndex >= 0 && adjustedRowIndex < dgv.Rows.Count &&
                adjustedColumnIndex >= 0 && adjustedColumnIndex < dgv.Columns.Count)
            {
                return dgv.Rows[adjustedRowIndex].Cells[adjustedColumnIndex].Value.ToString();
            }
            else
            {
                return "Invalid index";
            }
        }
    }
}
