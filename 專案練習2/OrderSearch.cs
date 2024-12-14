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
    public partial class OrderSearch : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int num = 0;
        List<UserControl> list_usercontrol = new List<UserControl>();
        public OrderSearch()
        {
            InitializeComponent();
        }

        private void OrderSearch_Load(object sender, EventArgs e)
        {
            usercontrol建立();
        }

        
        void usercontrol建立() 
        {
            foreach (var control in list_usercontrol)
            {
                this.Controls.Remove(control);
            }
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select count(*) from orders where m_id =@id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id",GlobalVar.使用者id);
            object result = cmd.ExecuteScalar();
            if (result != null) 
            {
                num = Convert.ToInt32(result);
            }

            string strSQL1 = "select * from orders  where m_id = @id order by orderdate desc";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            cmd1.Parameters.AddWithValue("@id", GlobalVar.使用者id);
            SqlDataReader reader = cmd1.ExecuteReader();

            if (num == 0)
            {
                Label label = new Label();
                label.Text = "未訂購商品";
                label.Font = new Font("微軟正黑體", 16,FontStyle.Bold);
                label.ForeColor = Color.DarkRed;
                label.Location = new Point(12, 150);
                label.Size=new Size(140,35);
                Controls.Add(label);
            }
            else
            {
                int i = 0;
                while(reader.Read())
                {
                    UserControl3 userControl3 = new UserControl3();
                    userControl3.lbl訂單編號.Text = reader["orderid"].ToString();
                    userControl3.lbl訂單日期.Text = $"{reader["orderdate"]:yyyy/MM/dd}";
                    userControl3.lbl金額.Text = $"{reader["totalprice"]:C0}";
                    userControl3.lbl訂單狀態.Text = reader["orderstatus"].ToString();
                    userControl3.Location = new Point(12, 100+100*i);
                    i++;
                    Controls.Add(userControl3);
                    list_usercontrol.Add(userControl3);
                }
            }

            reader.Close();
            con.Close();
        }

        void 訂單查詢() 
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            DateTime 訂單開始日期 = dtp開始.Value;
            DateTime 訂單結束日期 = dtp結束.Value;

            string strSQL = "select * from orders where orders.m_id = @id and (orderdate >= @orderdate1 and orderdate <= @orderdate2)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id",GlobalVar.使用者id);
            cmd.Parameters.AddWithValue("@orderdate1", 訂單開始日期);
            cmd.Parameters.AddWithValue("@orderdate2", 訂單結束日期);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                foreach (var control in list_usercontrol) 
                {
                    this.Controls.Remove(control);
                }
            }
            else 
            {
                MessageBox.Show("查無訂單");
            }
                
            int i = 0;
            while (reader.Read())
            {
                UserControl3 userControl3 = new UserControl3();
                userControl3.lbl訂單編號.Text = reader["orderid"].ToString();
                userControl3.lbl訂單日期.Text = $"{reader["orderdate"]:yyyy/MM/dd}";
                userControl3.lbl金額.Text = $"{reader["totalprice"]:C0}";
                userControl3.lbl訂單狀態.Text = reader["orderstatus"].ToString();
                userControl3.Location = new Point(12, 100 + 100 * i);
                i++;
                Controls.Add(userControl3);
                list_usercontrol.Add(userControl3);
            }

            reader.Close ();
            con.Close();
        }

        private void btn商品查詢_Click(object sender, EventArgs e)
        {
            訂單查詢();
        }

        private void btn清除查詢_Click(object sender, EventArgs e)
        {
            usercontrol建立();
        }

        private void btn客服_Click(object sender, EventArgs e)
        {
            Customer_service customer_Service = new Customer_service();
            customer_Service.ShowDialog();
        }
    }
}
