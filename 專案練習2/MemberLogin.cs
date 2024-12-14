using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 專案練習2
{
    public partial class MemberLogin : Form
    {
        public MemberLogin()
        {
            InitializeComponent();
        }

        private void MemberLogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            int id = 0;
            string account = txt密碼.Text;
            string password = txt帳號.Text;
            if ((account != "") && (password != "")) 
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from member where account = @account and password = @password";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account",account);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.Read())
                {
                    GlobalVar.is登入成功=true;
                    GlobalVar.使用者名稱 = reader["name"].ToString();
                    GlobalVar.使用者電話 =reader["phone"].ToString();
                    GlobalVar.使用者id = (int)reader["id"];
                    GlobalVar.使用者權限 = reader["role"].ToString() ;
                    MessageBox.Show("登入成功");
                    reader.Close();
                    con.Close();
                    this.Close();
                }

                if (GlobalVar.is登入成功 == false) 
                {
                    MessageBox.Show("帳號密碼有誤");
                }
                reader.Close();
                con.Close();

            }

            
        }


        private void btn會員註冊_Click(object sender, EventArgs e)
        {
            MemberRegister memberRegister = new MemberRegister();
            memberRegister.ShowDialog();
        }
    }
}
