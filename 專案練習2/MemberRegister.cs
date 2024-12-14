using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 專案練習2
{
    
    public partial class MemberRegister : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(GlobalVar.strDBConnectionString);
        
        public MemberRegister()
        {
            InitializeComponent();
        }

        private void MemberRegister_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterWidth = 3;
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            string account = txt帳號.Text;
            string password = txt密碼.Text;
            string name=txt姓名.Text;
            DateTime birthday = dtp生日.Value;
            string phone =txt電話.Text;
            string address = txt地址.Text;
            string email = txtEmail.Text;

            if ((txt帳號.Text != "") & (txt密碼.Text != "") & (txt姓名.Text != "") & (txt電話.Text != "") & (txt地址.Text != "") & (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();

                string checkSQL = "select * from member where account=@account";
                SqlCommand checkcmd = new SqlCommand(checkSQL, con);
                checkcmd.Parameters.AddWithValue("@account",txt帳號.Text);
                SqlDataReader reader = checkcmd.ExecuteReader();
                if (reader.HasRows) 
                {
                    MessageBox.Show("帳號已被註冊");
                    reader.Close();
                    con.Close();
                    return;
                }
                reader.Close();

                string strSQL = "insert member(account,password,name,birthday,phone,address,email) values(@account,@password,@name,@birthday,@phone,@address,@email)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("註冊成功!");
                this.Close();
            }
            else 
            {
                MessageBox.Show("會員資料未填寫完整");
            }

        }
        private void btn登入_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
