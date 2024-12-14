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
    public partial class UserControl2 : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string 產品類別 = "";
        string str修改後的圖檔名稱 = "";
        public UserControl2()
        {
            InitializeComponent();
        }

        public void UserControl2_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            
            SqlConnection con =new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select p_name,orderdetail.price,sum(orderdetail.counts),sort,pic_before from orderdetail join products on orderdetail.p_id=products.id group by p_name,orderdetail.price,sort,pic_before order by sum(orderdetail.counts) desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 1;
            while (reader.Read()&&i<=4) 
            {
                string 產品名稱 = reader["p_name"].ToString();
                int 價錢 = (int)reader["price"];
                
                str修改後的圖檔名稱 = reader["pic_before"].ToString();
                string str完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後的圖檔名稱;
                System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);


                產品類別 = reader["sort"].ToString();
                switch (i) 
                {
                    case 1:
                        lbl產品名稱1.Text = 產品名稱;
                        lbl價錢1.Text = $"{價錢:C0}";
                        pbox1.Tag =產品類別;
                        pbox1.Image = Image.FromStream(fs);
                        break;
                    case 2:
                        lbl產品名稱2.Text = 產品名稱;
                        lbl價錢2.Text = $"{價錢:C0}";
                        pbox2.Tag = 產品類別;
                        pbox2.Image = Image.FromStream(fs);
                        break;
                    case 3:
                        lbl產品名稱3.Text = 產品名稱;
                        lbl價錢3.Text = $"{價錢:C0}";
                        pbox3.Tag = 產品類別;
                        pbox3.Image = Image.FromStream(fs);
                        break;
                    case 4:
                        lbl產品名稱4.Text = 產品名稱;
                        lbl價錢4.Text = $"{價錢:C0}";
                        pbox4.Tag = 產品類別;
                        pbox4.Image = Image.FromStream(fs);
                        break;
                        default:
                        break;
                }
                i++;
                fs.Close();
            }
            
            reader.Close();
            con.Close();
        }

    }
}
