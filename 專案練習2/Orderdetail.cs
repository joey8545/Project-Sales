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
    public partial class Orderdetail : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<Control> list1_usercontrol = new List<Control>();
        List<Control> list3_usercontrol = new List<Control>();
        int num = 0;
        string 訂單狀態 = "";
        string 回覆狀態 = "";
        public Orderdetail()
        {
            InitializeComponent();
        }

        private void Orderdetail_Load(object sender, EventArgs e)
        {
            page1_usercontrol建立();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            rdb全部.Checked = true;
            rdb全部回覆.Checked= true;
        }

        void page1_usercontrol建立()
        {
            foreach (var control in list1_usercontrol)
            {
                tabPage1.Controls.Remove(control);
            }

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            string strSQL1 = "select * from orders";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            SqlDataReader reader = cmd1.ExecuteReader();

            if (!reader.HasRows)
            {
                Label label = new Label();
                label.Text = "未訂購商品";
                label.Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                label.ForeColor = Color.DarkRed;
                label.Location = new Point(12, 120);
                label.Size = new Size(140, 35);
                tabPage1.Controls.Add(label);
                reader.Close();
                con.Close();
            }
            else
            {
                int i = 0;
                while (reader.Read())
                {
                    UserControl3 userControl3 = new UserControl3();
                    userControl3.lbl訂單編號.Text = reader["orderid"].ToString();
                    userControl3.lbl訂單日期.Text = $"{reader["orderdate"]:yyyy/MM/dd}";
                    userControl3.lbl金額.Text = $"{reader["totalprice"]:C0}";
                    userControl3.lbl訂單狀態.Text = reader["orderstatus"].ToString();
                    userControl3.Location = new Point(12, 80 + 100 * i);
                    i++;
                    tabPage1.Controls.Add(userControl3);
                    list1_usercontrol.Add(userControl3);
                }
            }

            reader.Close();
            con.Close();
        }

        void page2_usercontrol建立() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);

            string strSQL = "select p_id,p_name,sum(orderdetail.counts) '總銷售數量',sum(totalprice) '總銷售金額' from orderdetail join products on orderdetail.p_id=products.id group by p_id,p_name order by sum(totalprice) desc";
            SqlDataAdapter adapter = new SqlDataAdapter(strSQL,con);
            DataTable dataTable = new DataTable();
            string strSQL1 = "select sum(totalprice) sum_totalprice from orders ";
            SqlCommand cmd = new SqlCommand(strSQL1, con);

            try
            {
                con.Open();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    lbl營業額.Text = $"{reader["sum_totalprice"]:C0}";
                }
                reader.Close ();
                con.Close();
            }
            catch  
            {
                MessageBox.Show("發生錯誤");
            }
        }


        void page3_usercontrol建立()
        {
            foreach (var control in list3_usercontrol)
            {
                tabPage3.Controls.Remove(control);
            }
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            string strSQL1 = "select * from customer_service join member on customer_service.m_id=member.id order by m_id";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            SqlDataReader reader = cmd1.ExecuteReader();

            if (!reader.HasRows)
            {
                Label label1 = new Label();
                label1.Text = "無客服訊息";
                label1.Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                label1.ForeColor = Color.DarkRed;
                label1.Location = new Point(12, 120);
                label1.Size = new Size(140, 35);
                tabPage3.Controls.Add(label1);
                reader.Close();
                con.Close();
            }
            else
            {
                int i = 0;
                DateTime dt = new DateTime();
                while (reader.Read())
                {
                    UserControl4 userControl4 = new UserControl4();
                    userControl4.lbl會員ID.Text = reader["m_id"].ToString();
                    userControl4.lbl會員名稱.Text = $"{reader["name"]}";
                    userControl4.lbl回覆狀態.Text = reader["status"].ToString();
                    userControl4.Location = new Point(4, 60 + 100 * i);
                    i++;
                    tabPage3.Controls.Add(userControl4);
                    list3_usercontrol.Add(userControl4);
                }
            }

            reader.Close();
            con.Close();
        }

            private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                page1_usercontrol建立();
            }
            else if (tabControl1.SelectedTab == tabPage2) 
            {
                page2_usercontrol建立();
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                page3_usercontrol建立();
            }
        }

        private void rdb全部_CheckedChanged(object sender, EventArgs e)
        {
            訂單狀態 = "全部";
        }

        private void rdb審核中_CheckedChanged(object sender, EventArgs e)
        {
            訂單狀態 = "審核中";
        }

        private void rdb已出貨_CheckedChanged(object sender, EventArgs e)
        {
            訂單狀態 = "已出貨";
        }

        private void rdb已送達_CheckedChanged(object sender, EventArgs e)
        {
            訂單狀態 = "已送達";
        }

        private void btn訂單查詢_Click(object sender, EventArgs e)
        {
            string orderstatus = "";
            string 訂購人名稱 = "";
            foreach (var control in list1_usercontrol)
            {
                tabPage1.Controls.Remove(control);
            }

            switch (txt訂購人名稱.Text) 
            {
                case "":
                    訂購人名稱 = "";
                    break;
                default:
                    訂購人名稱 = $" and orders_p_name like '%{txt訂購人名稱.Text}%'";
                    break;
            }

            switch (訂單狀態) 
            {
                case "審核中":
                    orderstatus = "and orderstatus = '審核中'";
                    break;
                case "已出貨":
                    orderstatus = "and orderstatus = '已出貨'";
                    break;
                case "已送達":
                    orderstatus = "and orderstatus = '已送達'";
                    break;
                default:
                    break;
            }

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from orders where orderdate >= @orderdate1 and orderdate <= @orderdate2 {orderstatus} {訂購人名稱}";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@orderdate1", dtp開始.Value);
            cmd.Parameters.AddWithValue("@orderdate2", dtp結束.Value);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    UserControl3 userControl3 = new UserControl3();
                    userControl3.lbl訂單編號.Text = reader["orderid"].ToString();
                    userControl3.lbl訂單日期.Text = $"{reader["orderdate"]:yyyy/MM/dd}";
                    userControl3.lbl金額.Text = $"{reader["totalprice"]:C0}";
                    userControl3.lbl訂單狀態.Text = reader["orderstatus"].ToString();
                    userControl3.Location = new Point(12, 80 + 100 * i);
                    i++;
                    tabPage1.Controls.Add(userControl3);
                    list1_usercontrol.Add(userControl3);
                }
            }
            else 
            {
                MessageBox.Show("沒有符合條件的訂單");
            }
        }

        private void btn銷量查詢_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            string strSQL = "select p_id,p_name,sum(orderdetail.counts) '總銷售數量',sum(orderdetail.totalprice) '總銷售金額' from orderdetail join products on orderdetail.p_id=products.id join orders on orderdetail.orderid= orders.orderid where orderdate >= @orderdate1 and orderdate <= @orderdate2 group by p_id,p_name order by sum(orderdetail.totalprice) desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@orderdate1",dtp開始1.Value);
            cmd.Parameters.AddWithValue("@orderdate2", dtp結束1.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            string strSQL1 = "select sum(totalprice) sum_totalprice from orders where orderdate >= @orderdate1 and orderdate <= @orderdate2";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            cmd1.Parameters.AddWithValue("@orderdate1", dtp開始1.Value);
            cmd1.Parameters.AddWithValue("@orderdate2", dtp結束1.Value);
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                con.Open();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    lbl營業額.Text = $"{reader["sum_totalprice"]:C0}";
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("查無資料");
            }
            finally 
            {
                con.Close();
            }
        }

        private void txt客服查詢_Click(object sender, EventArgs e)
        {
            string 狀態 = "";
            string 名稱 = "";
            foreach (var control in list3_usercontrol)
            {
                tabPage3.Controls.Remove(control);
            }
            switch (txt客人名稱.Text)
            {
                case "":
                    名稱 = "";
                    break;
                default:
                    名稱 = $" and name like '%{txt客人名稱.Text}%'";
                    break;
            }

            switch (回覆狀態)
            {
                case "待回覆":
                    狀態 = " status = '待回覆'";
                    break;
                case "已回覆":
                    狀態 = " status = '已回覆'";
                    break;
                case "全部":
                    狀態 = " (status = '待回覆' or status = '已回覆')";
                    break;
                default:
                    break;
            }

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from customer_service join member on customer_service.m_id=member.id where {狀態} {名稱} order by m_id";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    UserControl4 userControl4 = new UserControl4();
                    userControl4.lbl會員ID.Text = reader["m_id"].ToString();
                    userControl4.lbl會員名稱.Text = $"{reader["name"]}";
                    userControl4.lbl回覆狀態.Text = reader["status"].ToString();
                    userControl4.Location = new Point(4, 60 + 100 * i);
                    i++;
                    tabPage3.Controls.Add(userControl4);
                    list3_usercontrol.Add(userControl4);
                }
            }
            else
            {
                MessageBox.Show("沒有符合條件");
            }

        }

        private void rdb全部回覆_CheckedChanged(object sender, EventArgs e)
        {
            回覆狀態 = "全部";
        }

        private void rdb待回覆_CheckedChanged(object sender, EventArgs e)
        {
            回覆狀態 = "待回覆";
        }

        private void rdb已回覆_CheckedChanged(object sender, EventArgs e)
        {
            回覆狀態 = "已回覆";
        }

        private void Orderdetail_Activated(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            SqlConnection con = new SqlConnection(scsb.ConnectionString);
            con.Open();
            string strSQL2 = "update customer_service set status = '已回覆' where times < GM_times";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            cmd2.ExecuteNonQuery();

            string strSQL3 = "update customer_service set status = '待回覆' where times > GM_times";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
            cmd3.ExecuteNonQuery();

            con.Close();
            page3_usercontrol建立();

        }
    }
}
