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

namespace MiniProject1
{
    public partial class Sign_Up : Form
    {
        private DatabaseUtil Util = new DatabaseUtil();

        public Sign_Up()
        {
            InitializeComponent();
        }


        private void Sign_Up_Load(object sender, EventArgs e)
        {

            dataGridView5.DataSource = Util.GetTableData("LoginTable");
        }

        private void Sign_up_btn_Click(object sender, EventArgs e)
        {
            string sqlCommand = $"INSERT INTO loginTable (ID, USER_NAME, USER_ID, USER_PWD, ADMIN) " +
                                $"VALUES (logintable_seq.nextval, '{textBox_name.Text}', '{textBox_id.Text}', '{textBox_pwd.Text}', 0)";
            
            try
            {
                Util.ExecuteNonQuery(sqlCommand);
                Util = new DatabaseUtil();
                dataGridView5.DataSource = Util.GetTableData("LoginTable");

                this.Close();
                MessageBox.Show("회원가입이 완료되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
        }


        //실수
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
