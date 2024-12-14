using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 專案練習2
{
    public partial class Form1 : Form
    {
       SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        
        private List<Control> originalPanel2Controls = new List<Control>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
            foreach (Control controls in splitContainer2.Panel2.Controls) 
            {
                originalPanel2Controls.Add(controls);
            }

            UserControl2 userControl2 = new UserControl2();
            this.Controls.Add(userControl2);
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            SqlConnection con = new SqlConnection(scsb.ConnectionString);
            con.Open();
            string strSQL = "update orders set orderstatus ='已出貨' where datediff(day,orderdate,getdate()) > 1 and orderstatus = '審核中'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();

            string strSQL1 = "update orders set orderstatus ='已送達' where datediff(day,orderdate,getdate()) > 5 and orderstatus = '已出貨'";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            cmd1.ExecuteNonQuery();

            string strSQL2 = "update customer_service set status = '已回覆' where times < GM_times";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            cmd2.ExecuteNonQuery();

            string strSQL3 = "update customer_service set status = '待回覆' where times > GM_times";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
            cmd3.ExecuteNonQuery();

            con.Close();
        }

        private void btn床_Click(object sender, EventArgs e)
        {
            Bed bed = new Bed();
            bed.TopLevel = false;
            bed.FormBorderStyle= FormBorderStyle.None;
            bed.Dock= DockStyle.Fill;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(bed);
            bed.Show();
        }

        private void btn櫃子_Click(object sender, EventArgs e)
        {
            Cabinet  cabinet = new Cabinet();
            cabinet.TopLevel = false;
            cabinet.FormBorderStyle = FormBorderStyle.None;
            cabinet.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(cabinet);
            cabinet.Show();
        }

        private void btn桌子_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            desk.TopLevel = false;
            desk.FormBorderStyle = FormBorderStyle.None;
            desk.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(desk);
            desk.Show();
        }

        private void btn沙發_Click(object sender, EventArgs e)
        {
            Sofa sofa = new Sofa();
            sofa.TopLevel = false;
            sofa.FormBorderStyle = FormBorderStyle.None;
            sofa.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(sofa);
            sofa.Show();
        }

        private void btn購物車_Click(object sender, EventArgs e)
        {
            CheckList checkList = new CheckList();
            checkList.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            foreach (var control in originalPanel2Controls) 
            {
                splitContainer2.Panel2.Controls.Add(control);
            }
        }

        private void btn會員登入_Click(object sender, EventArgs e)
        {
            MemberLogin memberLogin = new MemberLogin();
            memberLogin.ShowDialog();
            if ((GlobalVar.is登入成功 == true) && (GlobalVar.使用者權限 == "employee"))
            {
                btn會員登入.Visible = false;
                btn購物車.Visible = false;
                btn訂單確認.Visible = true;
                btn會員登出.Visible = true;
                btn商品管理.Visible = true;
            }
            else if ((GlobalVar.is登入成功 == true) && (GlobalVar.使用者權限 == "customer"))
            {
                btn會員登入.Visible = false;
                btn會員登出.Visible = true;
                btn購物車.Location = new Point(648, 20);
                btn訂單查詢.Visible = true;
                btn會員資訊.Visible = false;
            }
            else if ((GlobalVar.is登入成功 == true) && (GlobalVar.使用者權限 == "boss")) 
            {
                btn會員登入.Visible = false;
                btn購物車.Visible = false;
                btn訂單確認.Visible = true;
                btn會員登出.Visible = true;
                btn商品管理.Visible = true;
                btn會員資訊.Visible= true;
            }
        }

        private void btn會員登出_Click(object sender, EventArgs e)
        {
            DialogResult R=MessageBox.Show("是否要登出會員?","會員登出",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (R==DialogResult.Yes) 
            {
                btn訂單查詢.Visible=false;
                btn會員登出.Visible=false;
                btn訂單確認.Visible = false;
                btn購物車.Visible=true;
                btn會員登入.Visible= true;
                btn商品管理.Visible = false;
                btn會員資訊.Visible= false;
                GlobalVar.is登入成功 = false;
                GlobalVar.使用者名稱 = "";
                GlobalVar.使用者電話 = "";
                GlobalVar.使用者id = 0;
                GlobalVar.使用者權限 = "";
                GlobalVar.list訂購品項集合.Clear();
            }
        }

        private void btn訂單查詢_Click(object sender, EventArgs e)
        {
            OrderSearch orderSearch = new OrderSearch();
            orderSearch.ShowDialog();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            Orderdetail orderDetail = new Orderdetail();
            orderDetail.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            ProductManage productManage = new ProductManage();
            productManage.ShowDialog();
        }

        private void btn會員資訊_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.ShowDialog();
        }
    }
}
