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
    public partial class Member : Form
    {
        
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int dgv筆數 = 0;
        string role = "";

        public Member()
        {
            InitializeComponent();
        }

        void 顯示全部會員資料() 
        {
            SqlConnection con = new SqlConnection(scsb.ConnectionString);
            con.Open();
            string strSQL = "select top 500 * from member";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv會員資料.DataSource = dataTable;
                dgv筆數=dataTable.Rows.Count;
            }
            reader.Close();
            con.Close();
        }

        void 顯示會員資訊(int myid) 
        {
            SqlConnection con = new SqlConnection(scsb.ConnectionString);
            con.Open();
            string strSQL = "select * from member where id = @id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", myid);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {
                txt會員ID.Text = reader["id"].ToString();
                txt會員名稱.Text = reader["name"].ToString();
                txt帳號.Text = reader["account"].ToString();
                txt密碼.Text = reader["password"].ToString();
                dtp生日.Value = (DateTime)reader["birthday"];
                txt電話.Text= reader["phone"].ToString();
                txt地址.Text= reader["address"].ToString();
                txtemail.Text= reader["email"].ToString();
                switch (reader["role"].ToString()) 
                {
                    case "boss":
                        cbox權限.SelectedIndex = 0;
                        break;
                    case "employee":
                        cbox權限.SelectedIndex = 1;
                        break;
                    case "customer":
                        cbox權限.SelectedIndex = 2;
                        break;
                }
            }
        }

        private void Member_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            cbox權限.Items.Add("boss");
            cbox權限.Items.Add("employee");
            cbox權限.Items.Add("customer");

            cbox欄位名稱.Items.Add("name");
            cbox欄位名稱.Items.Add("phone");
            cbox欄位名稱.Items.Add("address");
            cbox欄位名稱.Items.Add("email");

            cbox欄位名稱.SelectedIndex = 0;
            cbox權限.SelectedIndex = 2;

            rdb_all.Checked = true;

            顯示全部會員資料();
        }


        private void btn資料新增_Click(object sender, EventArgs e)
        {
            if ((txt會員名稱.Text != "") && (txt帳號.Text != "") && (txt密碼.Text != "") && (txt電話.Text != "") && (txt地址.Text != "") && (txtemail.Text != ""))
            {
                SqlConnection con = new SqlConnection(scsb.ConnectionString);
                con.Open();
                string strSQL = "insert member values(@account,@password,@name,@birthday,@phone,@address,@email,@role)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account", txt帳號.Text);
                cmd.Parameters.AddWithValue("@password", txt密碼.Text);
                cmd.Parameters.AddWithValue("@name", txt會員名稱.Text);
                cmd.Parameters.AddWithValue("@birthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@phone", txt電話.Text);
                cmd.Parameters.AddWithValue("@address", txt地址.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@role", cbox權限.SelectedItem);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料新增成功");
            }
            else 
            {
                MessageBox.Show("所有欄位皆須填寫");
            }
        }

        private void btn儲存修正_Click(object sender, EventArgs e)
        {
            if ((txt會員名稱.Text != "") && (txt帳號.Text != "") && (txt密碼.Text != "") && (txt電話.Text != "") && (txt地址.Text != "") && (txtemail.Text != ""))
            {
                SqlConnection con = new SqlConnection(scsb.ConnectionString);
                con.Open();
                string strSQL = "update member set account=@account,password=@password,name=@name,birthday=@birthday,phone=@phone,address=@address,email=@email,role=@role where id = @id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account", txt帳號.Text);
                cmd.Parameters.AddWithValue("@password", txt密碼.Text);
                cmd.Parameters.AddWithValue("@name", txt會員名稱.Text);
                cmd.Parameters.AddWithValue("@birthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@phone", txt電話.Text);
                cmd.Parameters.AddWithValue("@address", txt地址.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@role", cbox權限.SelectedItem);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt會員ID.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修正成功");
            }
            else
            {
                MessageBox.Show("所有欄位皆須填寫");
            }
        }



        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確定要將此資料刪除?","資料刪除",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (txt會員ID.Text != "")
            {
                if (R == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(scsb.ConnectionString);
                    con.Open();
                    string strSQL = "delete from member where id = @id";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt會員ID.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("資料已刪除");
                    清空欄位();
                }
            }
            else 
            {
                MessageBox.Show("未選擇會員");
            }
           
        }

        private void btn會員查詢_Click(object sender, EventArgs e)
        {
            string rolesql = "";
            switch (role) 
            {
                case "customer":
                    rolesql = "and role= 'customer'";
                    break;
                case "employee":
                    rolesql = "and role= 'employee'";
                    break;
                case "all":
                    rolesql = "";
                    break;
                default:
                    break;
            }
            if (txt關鍵字查詢.Text != "")
            {
                string 欄位名稱 = cbox欄位名稱.Text.ToString();
                SqlConnection con = new SqlConnection(scsb.ConnectionString);
                con.Open();
                string strSQL = $"select * from member where {欄位名稱} like @關鍵字 and birthday >= @日期開始 and birthday <= @日期結束  {rolesql}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@欄位", 欄位名稱);
                cmd.Parameters.AddWithValue("@關鍵字", $"%{txt關鍵字查詢.Text}%");
                cmd.Parameters.AddWithValue("@日期開始", dtp開始時間.Value);
                cmd.Parameters.AddWithValue("@日期結束", dtp結束時間.Value);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv會員資料.DataSource = dt;
                    dgv筆數 = dt.Rows.Count;
                }
                else
                {
                    MessageBox.Show("查無資料");
                }

                reader.Close();
                con.Close();
            }
            else 
            {
                MessageBox.Show("請輸入關鍵字");
            }
            
        }

        private void btn顯示全部資料_Click(object sender, EventArgs e)
        {
            顯示全部會員資料();
        }

        private void dgv會員資料_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.RowIndex < dgv筆數) 
            {
                string ID = dgv會員資料.Rows[e.RowIndex].Cells[0].Value.ToString();
                int 會員ID = 0;
                Int32.TryParse(ID, out 會員ID);
                顯示會員資訊(會員ID);
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        void 清空欄位()
        {
            txt會員ID.Clear();
            txt會員名稱.Clear();
            txt帳號.Clear();
            txt密碼.Clear();
            txt電話.Clear();
            txt地址.Clear();
            dtp生日.Value = DateTime.Now;
            txtemail.Clear();
            cbox權限.SelectedIndex = 2;
        }

        private void rdb_customer_CheckedChanged(object sender, EventArgs e)
        {
            role = "customer";
        }

        private void rdb_employee_CheckedChanged(object sender, EventArgs e)
        {
            role = "employee";
        }

        private void rdb_all_CheckedChanged(object sender, EventArgs e)
        {
            role = "all";
        }
    }
}
