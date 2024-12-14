using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 專案練習2.Properties;

namespace 專案練習2
{
    public partial class UserControl1 : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public string 品項名稱 = "";
        public int 數量 = 0;
        public int 單價金額 = 0;
        public int 總額 = 0;
        public string pic_before = "";
        public string pic_after = "";
        public string str修改後的圖檔名稱 = "";

        List<int> list訂購數量 = new List<int>();


        public UserControl1()
        {
            InitializeComponent();
        }



        public void UserControl1_Load(object sender, EventArgs e)
        {
            list訂購數量.Add(0);
            list訂購數量.Add(1);
            list訂購數量.Add(2);
            list訂購數量.Add(3);
            list訂購數量.Add(4);
            list訂購數量.Add(5);


            foreach (int num in list訂購數量)
            {
                cbox_數量.Items.Add(num);
            }
            cbox_數量.SelectedIndex = 0;

            lbl_缺貨.Visible = false;

            缺貨();
        }

        public void 缺貨()
        {
            if (Convert.ToInt32(lbl_剩餘數量.Text) == 0)
            {
                lbl_缺貨.Visible = true;
                cbox_數量.Enabled = false;
                btn_加入購物車.Enabled = false;
                pic圖片.Enabled = false;
            }
            else
            {
                lbl_缺貨.Visible = false;
                cbox_數量.Enabled = true;
                btn_加入購物車.Enabled = true;
            }
        }

        public void 加入購物車()
        {
            
            if (cbox_數量.SelectedIndex > Convert.ToInt32(lbl_剩餘數量.Text)) 
            {
                MessageBox.Show("商品庫存不足");
            }
            else if (cbox_數量.SelectedIndex > 0)
            {
                數量 = cbox_數量.SelectedIndex;
                總額 = 單價金額 * 數量;

                ArrayList 訂購品項資料 = new ArrayList();
                訂購品項資料.Add(pic圖片.Tag);
                訂購品項資料.Add(品項名稱);
                訂購品項資料.Add(數量);
                訂購品項資料.Add(單價金額);
                訂購品項資料.Add(總額);
                MessageBox.Show("已加入購物車");
                GlobalVar.list訂購品項集合.Add(訂購品項資料);
            }
            else
            {
                MessageBox.Show("請選擇數量");
            }
        }

        public void btn_加入購物車_Click(object sender, EventArgs e)
        {
            加入購物車();
        }

        public void pic圖片_MouseEnter(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from products where id =@id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", pic圖片.Tag);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {
                str修改後的圖檔名稱 = reader["pic_after"].ToString();
                string str完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後的圖檔名稱;
                System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                pic圖片.Image = Image.FromStream(fs);
                fs.Close();
            }

            lbl_剩餘數量.Visible = false;
            lbl_剩餘.Visible = false;
            con.Close();
        }

        public void pic圖片_MouseLeave(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from products where id =@id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", pic圖片.Tag);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                str修改後的圖檔名稱 = reader["pic_before"].ToString();
                string str完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後的圖檔名稱;
                System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                pic圖片.Image = Image.FromStream(fs);
                fs.Close();
            }

            lbl_剩餘數量.Visible = true;
            lbl_剩餘.Visible = true;
            con.Close();
        }
    }
}

