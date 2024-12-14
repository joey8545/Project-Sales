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

namespace 專案練習2
{
    public partial class CheckList : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(GlobalVar.strDBConnectionString);
        List<ArrayList> list商品庫存=new List<ArrayList>();

        bool 自行取貨 ;
        int 運費 = 0;
        int 商品總價 = 0;
        int 會員折扣 = 0;
        string 付費方式 = "";
        public CheckList()
        {
            InitializeComponent();
        }

        private void CheckList_Load(object sender, EventArgs e)
        {
            foreach (ArrayList 品項 in GlobalVar.list訂購品項集合) 
            {
                string 品項名稱 = (string)品項[1];
                int 數量 = (int)品項[2];
                int 單價 = (int)品項[3];
                int 總額 = (int)品項[4];
                lbox購物車.Items.Add($"品項名稱:{品項名稱}　單價:{單價:C0}元　數量:{數量}個，共計{總額:C0}元");
            }
            rdb自行取貨.Checked = true;
            if (GlobalVar.is登入成功 == true)
            {
                txt訂購人.Text = GlobalVar.使用者名稱;
                txt電話.Text = GlobalVar.使用者電話;
                會員折扣 = -Convert.ToInt32((商品總價 * 0.2));
            }
            計算總價();
            rdb現金付款.Checked = true;
            lbl會員折扣.Text = $"{會員折扣:C0}";
        }


        void 計算總價() 
        {
            商品總價 = 0;
            foreach (ArrayList 品項 in GlobalVar.list訂購品項集合)
            {
                int 商品費用 = (int)品項[4];
                商品總價 += 商品費用;
            }
             if (GlobalVar.is登入成功 == true)
            {
                會員折扣 = -Convert.ToInt32((商品總價 * 0.2));
            }
            lbl會員折扣.Text = $"{會員折扣:C0}";
            lbl商品總額.Text = $"{商品總價:C0}";
            if (自行取貨)
            {
                運費 = 0;
                lbl運費.Text = $"{運費:C0}";
                lbl總額.Text = $"{商品總價 + 運費+ 會員折扣:C0}";
            }
            else if(lbox購物車.Items.Count==0)
            {
                lbl運費.Text = $"尚未購買商品";
            }
            else if (自行取貨 == false && 商品總價 >= 10000)
            {
                運費 = 0;
                lbl運費.Text = $"{運費:C0}";
                lbl總額.Text = $"{商品總價 + 運費+ 會員折扣:C0}";
            }
            else
            {
                運費 = 500;
                lbl運費.Text = $"{運費:C0}";
                lbl總額.Text = $"{商品總價 + 運費+ 會員折扣:C0}";
            }
        }

        private void btn移除選項_Click(object sender, EventArgs e)
        {
            int idx = lbox購物車.SelectedIndex;

            if (lbox購物車.SelectedIndex >= 0)
            {
                DialogResult R = MessageBox.Show("確定要移除此商品嗎?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    lbox購物車.Items.RemoveAt(idx);
                    GlobalVar.list訂購品項集合.RemoveAt(idx);
                    計算總價();
                }
            }
            else 
            {
                MessageBox.Show("請選擇要刪除的商品");
            }
        }

        private void btn移除全部_Click(object sender, EventArgs e)
        {
            if (lbox購物車.Items.Count != 0)
            {
                DialogResult R = MessageBox.Show("確定要移除全部商品嗎?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    lbox購物車.Items.Clear();
                    GlobalVar.list訂購品項集合.Clear();
                    計算總價();
                }
            }
            else 
            {
                MessageBox.Show("尚未選購商品");
            }
        }

        private void rdb自行取貨_CheckedChanged(object sender, EventArgs e)
        {
            自行取貨 = true;
            lbl配送地址.Enabled = false;
            txt配送地址.Enabled = false;
            計算總價();
        }

        private void rdb貨運配送_CheckedChanged(object sender, EventArgs e)
        {
            自行取貨 = false;
            lbl配送地址.Enabled = true;
            txt配送地址.Enabled = true;
            計算總價();
        }

        private void btn結帳_Click(object sender, EventArgs e)
        {
            string str = "";
            if (lbox購物車.Items.Count == 0)
            {
                MessageBox.Show("未選購商品");
            }
            else if ((txt訂購人.Text == "") || (txt電話.Text == ""))
            {
                MessageBox.Show("未輸入訂購人或電話資訊");
            }
            else if ((自行取貨 == false) && (txt配送地址.Text == ""))
            {
                MessageBox.Show("未輸入配送地址");
            }
            else
            {
                scsb.DataSource = @".";
                scsb.InitialCatalog = "mydata";
                scsb.IntegratedSecurity = true;
                GlobalVar.strDBConnectionString = scsb.ConnectionString;
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert orders(m_id,totalprice,orders_p_name,p_phone) output inserted.orderid values(@m_id,@totalprice,@p_name,@p_phone)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@m_id",GlobalVar.使用者id);
                cmd.Parameters.AddWithValue("@totalprice", 商品總價+運費+會員折扣);
                cmd.Parameters.AddWithValue("@p_name", txt訂購人.Text);
                cmd.Parameters.AddWithValue("@p_phone", txt電話.Text);

                int orderid = (int)cmd.ExecuteScalar();

                string strSQL1 = $"insert orderdetail(orderid,p_id,p_name,counts,price,totalprice,pickupbymyself,address) values(@orderid,@p_id,@p_name,@counts,@price,@totalprice,@pickupbymyself,@address)";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);

                string strSQL2 = "update products set counts -= @counts where id = @id";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);

                foreach (ArrayList 產品 in GlobalVar.list訂購品項集合) 
                {
                    cmd1.Parameters.Clear();
                    cmd2.Parameters.Clear();
                    cmd1.Parameters.AddWithValue("@orderid", orderid);
                    cmd1.Parameters.AddWithValue("@p_id", 產品[0]);
                    cmd1.Parameters.AddWithValue("@p_name", 產品[1]);
                    cmd1.Parameters.AddWithValue("@counts",產品[2]);
                    cmd1.Parameters.AddWithValue("@price", 產品[3]);
                    cmd1.Parameters.AddWithValue("@totalprice", 產品[4]);
                    cmd1.Parameters.AddWithValue("@pickupbymyself", 自行取貨);
                    cmd1.Parameters.AddWithValue("@address", txt配送地址.Text);
                    cmd1.ExecuteNonQuery();


                    cmd2.Parameters.AddWithValue("@counts", 產品[2]);
                    cmd2.Parameters.AddWithValue("@id", 產品[0]);
                    cmd2.ExecuteNonQuery();
                }

                switch (付費方式)
                {
                    case "現金付款":
                        str = $"訂購成功\n總金額為:{lbl總額.Text}";
                        MessageBox.Show(str);
                        break;
                    case "信用卡":
                        str = $"訂購成功\n請掃描信用卡，總金額為:{lbl總額.Text}";
                        MessageBox.Show(str);
                        break;
                    case "LinePay":
                        str = $"訂購成功\n請掃描QRcode，總金額為:{lbl總額.Text}";
                        MessageBox.Show(str);
                        break;
                }

                con.Close();
                lbox購物車.Items.Clear();
                GlobalVar.list訂購品項集合.Clear();
                計算總價();
                會員折扣 = -Convert.ToInt32((商品總價 * 0.2));
                lbl總額.Text = $"0";
            }

        }

        private void rdb現金付款_CheckedChanged(object sender, EventArgs e)
        {
            付費方式 = "現金付款";
        }

        private void rdb信用卡_CheckedChanged(object sender, EventArgs e)
        {
            付費方式 = "信用卡";
        }

        private void rdbLinePay_CheckedChanged(object sender, EventArgs e)
        {
            付費方式 = "LinePay";
        }

    }
}
