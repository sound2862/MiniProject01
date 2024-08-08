using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniProject1
{
    public partial class login : Form
    {
        private DatabaseUtil Util = new DatabaseUtil();

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Util.GetTableData("MaterialTable");
            dataGridView2.DataSource = Util.GetTableData("PressTable");
            dataGridView3.DataSource = Util.GetTableData("WeldTable");
            dataGridView4.DataSource = Util.GetTableData("PaintTable");
            dataGridView5.DataSource = Util.GetTableData("LoginTable");

            //a = Util.GetCellValue(dataGridView5, 1, 3);
            //b = Util.GetCellValue(dataGridView5, 1, 4);
            //label1.Text = a;
        }


        private void Sign_up_Click(object sender, EventArgs e)
        {
            Sign_Up signUpForm = new Sign_Up();
            signUpForm.Show();
        }
        private void Sign_in_Click(object sender, EventArgs e)
        {
            bool loginSuccess = false;
            bool isAdmin = false;

            Util = new DatabaseUtil();
            dataGridView5.DataSource = Util.GetTableData("LoginTable");

            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null)
                {
                    string id = row.Cells[2].Value.ToString();
                    string password = row.Cells[3].Value.ToString();
                    string admin = row.Cells[4].Value.ToString();

                    if (textBox_id.Text == id && textBox_pwd.Text == password)
                    {
                        loginSuccess = true;
                        isAdmin = admin == "1";
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                if (isAdmin && checkBox1.Checked)
                {
                    // 관리자 페이지 접속
                    //Sign_Up signUpForm = new Sign_Up();
                    //signUpForm.Show();
                    MessageBox.Show("관리자 로그인!");
                }
                else
                {
                    // 사용자 페이지 접속
                    MessageBox.Show("로그인 성공");
                }
            }
            else
            {
                // 로그인 실패
                MessageBox.Show("로그인 실패");
            }
        }

        //실수
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
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

    public void ExecuteNonQuery(string commandText)
    {
        using (OracleConnection conn = new OracleConnection(strConn))
        {
            using (OracleCommand cmd = new OracleCommand(commandText, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
