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
    public partial class Sofa : Form
    {
       SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        
        public Sofa()
        {
            InitializeComponent();
        }

        private void Sofa_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            SqlConnection con = new SqlConnection(scsb.ConnectionString);
            con.Open();

            string strSQL = "select * from products where sort = '沙發'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            int j = 0;

            while (reader.Read())
            {
                if (j > 1)
                {
                    j = 0;
                    i++;
                }

                UserControl1 userControl1 = new UserControl1();

                userControl1.pic圖片.Tag = (int)reader["id"];
                userControl1.Location = new Point(6 + 373 * j, 12 + 462 * i);
                userControl1.品項名稱 = (string)reader["name"];
                userControl1.單價金額 = (int)reader["price"];
                userControl1.lbl_項目名稱.Text = (string)reader["name"];
                userControl1.lbl_剩餘數量.Text = reader["counts"].ToString();
                userControl1.lbl_項目介紹.Text = (string)reader["introduce"];
                userControl1.lbl_金額.Text = reader["price"].ToString();
                userControl1.lbl_尺寸.Text = (string)reader["size"];
                userControl1.pic_before = (string)reader["pic_before"];
                userControl1.pic_after = (string)reader["pic_after"];
                userControl1.str修改後的圖檔名稱 = reader["pic_before"].ToString();
                string str完整圖檔路徑 = GlobalVar.image_dir + @"\" + userControl1.str修改後的圖檔名稱;
                System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                userControl1.pic圖片.Image = Image.FromStream(fs);



                fs.Close();
                Controls.Add(userControl1);

                j++;

            }

            reader.Close();
            con.Close();
        }

       
    }
}
