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
    public partial class Customer_service : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        
        public Customer_service()
        {
            InitializeComponent();
        }

        private void Customer_service_Load(object sender, EventArgs e)
        {
            
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            SqlConnection con = new SqlConnection(scsb.ConnectionString);
            con.Open();
            string strSQL = "select * from customer_service where m_id = @m_id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            if (GlobalVar.使用者權限 == "customer")
            {
                cmd.Parameters.AddWithValue("@m_id", GlobalVar.使用者id);
            }
            else 
            {
                cmd.Parameters.AddWithValue("@m_id", GlobalVar.客服ID);
            }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt對話框.Text += reader["texts"].ToString();
            }
            con.Close();
        }


        private void btn發送_Click(object sender, EventArgs e)
        {
            if (GlobalVar.使用者權限 == "customer")
            {
                txt對話框.Text += $"{DateTime.Now:t} {GlobalVar.使用者名稱}: {txt訊息.Text}\r\n";
                txt訊息.Clear();
                scsb.DataSource = @".";
                scsb.InitialCatalog = "mydata";
                scsb.IntegratedSecurity = true;
                GlobalVar.strDBConnectionString = scsb.ConnectionString;
                SqlConnection con = new SqlConnection(scsb.ConnectionString);
                con.Open();

                string SQL = "select * from customer_service where m_id =@m_id";
                SqlCommand cmd1 = new SqlCommand(SQL, con);
                cmd1.Parameters.AddWithValue("@m_id", GlobalVar.使用者id);
                SqlDataReader reader = cmd1.ExecuteReader();
                string SQL1 = "delete from customer_service where m_id =@m_id";
                SqlCommand cmd2 = new SqlCommand(SQL1, con);
                cmd2.Parameters.AddWithValue("@m_id", GlobalVar.使用者id);
                if (reader.HasRows)
                {
                    reader.Close();
                    cmd2.ExecuteNonQuery();
                }
                reader.Close();

                string strSQL = "insert customer_service(m_id,texts) values(@m_id,@texts)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@m_id", GlobalVar.使用者id);
                cmd.Parameters.AddWithValue("@texts", txt對話框.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else 
            {
                txt對話框.Text += $"{DateTime.Now:t} 客服人員: {txt訊息.Text}\r\n";
                txt訊息.Clear();
                scsb.DataSource = @".";
                scsb.InitialCatalog = "mydata";
                scsb.IntegratedSecurity = true;
                GlobalVar.strDBConnectionString = scsb.ConnectionString;
                SqlConnection con = new SqlConnection(scsb.ConnectionString);
                con.Open();
                string strSQL = "update customer_service set GM_times=@time,texts=@texts where m_id =@m_id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@time", DateTime.Now);
                cmd.Parameters.AddWithValue("@texts", txt對話框.Text);
                cmd.Parameters.AddWithValue("@m_id", GlobalVar.客服ID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
        }
    }
}
