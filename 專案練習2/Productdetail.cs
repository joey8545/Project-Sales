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
    public partial class Productdetail : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public Productdetail()
        {
            InitializeComponent();
        }

        private void Productdetail_Load(object sender, EventArgs e)
        {
            
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydata";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from orderdetail join orders on orderdetail.orderid = orders.orderid where orderdetail.orderid=@orderid";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@orderid", GlobalVar.訂單編號);
            SqlDataReader reader = cmd.ExecuteReader();

            

            while (reader.Read()) 
            {
                lbl訂購人名稱.Text = reader["orders_p_name"].ToString();
                lbl聯絡電話.Text = reader["p_phone"].ToString();
                lbl產品.Text += reader["p_name"].ToString() + "\n" + "\n";
                lbl數量.Text += (int)reader["counts"] + "\n" + "\n";
                lbl金額.Text += $"{reader["totalprice"]:C0}\n\n";
                if ((bool)reader["pickupbymyself"] == true)
                {
                    lbl取貨方式.Text = "自行取貨";
                    lbl配送地址.Text = "無";
                }
                else
                {
                    lbl取貨方式.Text = "貨運配送";
                    lbl配送地址.Text = reader["address"].ToString();
                }
            }

            reader.Close();
            con.Close();

        }
    }
}
