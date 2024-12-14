using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 專案練習2
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

        private void btn客服開啟_Click(object sender, EventArgs e)
        {
            GlobalVar.客服ID=Convert.ToInt32(lbl會員ID.Text);
            Customer_service customer_Service = new Customer_service();
            customer_Service.ShowDialog();

        }
    }
}
