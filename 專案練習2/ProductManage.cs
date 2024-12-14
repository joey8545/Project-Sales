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
    public partial class ProductManage : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> 商品名稱 = new List<string>();
        List<int> 商品價格 = new List<int>();
        List<int> 商品ID = new List<int>();
        List<string> 商品圖片名稱 = new List<string>();


        public ProductManage()
        {
            InitializeComponent();
        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            顯示資料();
        }

        private void ProductManage_Activated(object sender, EventArgs e)
        {
            重新整理();
        }

        void 重新整理() 
        {
            GlobalVar.模式 = 0;
            商品ID.Clear();
            商品價格.Clear();
            商品名稱.Clear();
            商品圖片名稱.Clear();
            imageList1.Images.Clear();
            顯示資料();
        }
        
        void 顯示資料() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select top 200 * from products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int idx = 0;
            while (reader.Read())
            {
                商品名稱.Add(reader["name"].ToString());
                商品價格.Add((int)reader["price"]);
                商品ID.Add((int)reader["id"]);
                string image_name = reader["pic_before"].ToString();
                string 完整圖檔路徑 =GlobalVar.image_dir +@"\" + image_name;
                System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);
                Image img商品圖檔 = Image.FromStream(fs);
                imageList1.Images.Add(img商品圖檔);
            }
            reader.Close();
            con.Close();

            listView商品展示.Clear();
            listView商品展示.View=View.LargeIcon;
            imageList1.ImageSize = new Size(120,120);
            listView商品展示.LargeImageList = imageList1;

            for (int i=0;i<商品ID.Count;i++) 
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{商品名稱[i]}\n{商品價格[i]:C0}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = 商品ID[i];
                listView商品展示.Items.Add(item);
            }
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            Products products = new Products();
            products.loadid = (int)listView商品展示.SelectedItems[0].Tag;
            products.ShowDialog();
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            GlobalVar.模式 = 1;
            Products products = new Products();
            products.ShowDialog();
        }
    }
}
