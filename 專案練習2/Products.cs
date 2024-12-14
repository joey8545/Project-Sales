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
    public partial class Products : Form
    {
        public int loadid = 0;
        string str修改後的圖檔名稱1 = "";
        string str修改後的圖檔名稱2 = "";
        bool is修改圖檔 = false;

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {

            if (GlobalVar.模式==1) 
            {
                btn儲存修改.Visible = false;
                btn新增商品.Visible = true;
                btn刪除商品.Visible = false;
            }
            
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            cbox商品種類.Items.Add("床");
            cbox商品種類.Items.Add("櫃子");
            cbox商品種類.Items.Add("桌子");
            cbox商品種類.Items.Add("沙發");

            cbox商品種類.SelectedIndex = 0;

            

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from products where id = @id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id",loadid);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) 
            {
                txt商品ID.Text = reader["id"].ToString();
                txt商品名稱.Text = reader["name"].ToString();
                switch (reader["sort"].ToString()) 
                {
                    case "床":
                        cbox商品種類.SelectedIndex = 0;
                        break;
                    case "櫃子":
                        cbox商品種類.SelectedIndex = 1;
                        break;
                    case "桌子":
                        cbox商品種類.SelectedIndex = 2;
                        break;
                    case "沙發":
                        cbox商品種類.SelectedIndex = 3;
                        break;
                    default:
                        break;
                }
                txt商品尺寸.Text = reader["size"].ToString();
                txt商品價格.Text = $"{reader["price"]}";
                txt商品庫存.Text = reader["counts"].ToString();
                txt商品描述.Text = reader["introduce"].ToString();
                str修改後的圖檔名稱1 = reader["pic_before"].ToString() ;
                str修改後的圖檔名稱2 = reader["pic_after"].ToString();
                string str完整圖檔路徑1 = GlobalVar.image_dir + @"\" + str修改後的圖檔名稱1;
                string str完整圖檔路徑2 = GlobalVar.image_dir + @"\" + str修改後的圖檔名稱2;

                System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑1);
                System.IO.File.OpenRead(str完整圖檔路徑1);
                pbox1.Image=Image.FromStream(fs);
                System.IO.FileStream fs2 = System.IO.File.OpenRead(str完整圖檔路徑2);
                System.IO.File.OpenRead(str完整圖檔路徑2);
                pbox2.Image=Image.FromStream(fs2);
                fs.Close();
                fs2.Close();
                pbox1.Tag = str修改後的圖檔名稱1;
                pbox2.Tag = str修改後的圖檔名稱2;
            }

            reader.Close();
            con.Close();
        }

        private void btn選取圖片1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(Jpeg,Jpg,Png)|*.jpeg;*.jpg;*.png";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) 
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pbox1.Image = Image.FromStream(fs);
                pbox1.Tag = ofd.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(ofd.FileName).ToLower();
                Random random = new Random();
                str修改後的圖檔名稱1 = DateTime.Now.ToString("yyMMdd")+random.Next(1000,10000).ToString() +str圖檔副檔名;
                is修改圖檔 = true;
                fs.Close();
            }

        }

        private void btn選取圖片2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(Jpeg,Jpg,Png)|*.jpeg;*.jpg;*.png";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pbox2.Image = Image.FromStream(fs);
                pbox2.Tag = ofd.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(ofd.FileName).ToLower();
                Random random = new Random();
                str修改後的圖檔名稱2 = DateTime.Now.ToString("yyMMdd") + random.Next(1000, 10000).ToString() + str圖檔副檔名;
                is修改圖檔 = true;
                fs.Close();
            }
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要刪除此商品","商品刪除",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "delete from products where id = @id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@id", loadid);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
           
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品ID.Text != "") && (txt商品名稱.Text != "") && (txt商品尺寸.Text != "") && (txt商品價格.Text != "") && (txt商品庫存.Text != "") && (txt商品描述.Text != "") && (pbox1.Image != null) && (pbox2.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update products set name =@name,sort=@sort,introduce=@introduce,size=@size,price=@price,counts=@counts,pic_before=@pic_before,pic_after=@pic_after where id = @id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@name", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@sort", cbox商品種類.SelectedItem);
                cmd.Parameters.AddWithValue("@introduce", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@size", txt商品尺寸.Text);
                int price = 0;
                Int32.TryParse(txt商品價格.Text, out price);
                cmd.Parameters.AddWithValue("@price", price);
                int counts = 0;
                Int32.TryParse(txt商品庫存.Text, out counts);
                cmd.Parameters.AddWithValue("@counts", counts);
                cmd.Parameters.AddWithValue("@pic_before", str修改後的圖檔名稱1);
                cmd.Parameters.AddWithValue("@pic_after", str修改後的圖檔名稱2);
                cmd.Parameters.AddWithValue("@id", loadid);
                cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔 == true)
                { 
                    string str完整圖檔路徑1 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱1}";
                    pbox1.Tag = str完整圖檔路徑1;
                    pbox1.Image.Save(str完整圖檔路徑1);
                    string str完整圖檔路徑2 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱2}";
                    pbox2.Tag = str完整圖檔路徑2;
                    pbox2.Image.Save(str完整圖檔路徑2);
                    is修改圖檔 = false;
                }

                MessageBox.Show("儲存修改成功");
            }
            else
            {
                MessageBox.Show("所有欄位都必須填");
            }
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品尺寸.Text != "") && (txt商品價格.Text != "") && (txt商品庫存.Text != "") && (txt商品描述.Text != "") && (pbox1.Image != null) && (pbox2.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert products values(@name,@sort,@introduce,@size,@price,@counts,@pic_before,@pic_after)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@name", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@sort", cbox商品種類.SelectedItem);
                cmd.Parameters.AddWithValue("@introduce", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@size", txt商品尺寸.Text);
                int price = 0;
                Int32.TryParse(txt商品價格.Text, out price);
                cmd.Parameters.AddWithValue("@price", price);
                int counts = 0;
                Int32.TryParse(txt商品庫存.Text, out counts);
                cmd.Parameters.AddWithValue("@counts", counts);
                cmd.Parameters.AddWithValue("@pic_before", str修改後的圖檔名稱1);
                cmd.Parameters.AddWithValue("@pic_after", str修改後的圖檔名稱2);
                cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔 == true)
                {
                    string str完整圖檔路徑1 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱1}";
                    pbox1.Tag = str完整圖檔路徑1;
                    pbox1.Image.Save(str完整圖檔路徑1);
                    string str完整圖檔路徑2 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱2}";
                    pbox2.Tag = str完整圖檔路徑2;
                    pbox2.Image.Save(str完整圖檔路徑2);
                    is修改圖檔 = false;
                }
                this.Close();
                MessageBox.Show("商品新增成功");
            }
            else
            {
                MessageBox.Show("所有欄位都必須填");
            }
        }
    }
}
