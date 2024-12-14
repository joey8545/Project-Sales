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
    public partial class UserControl3 : UserControl
    {

        public UserControl3()
        {
            InitializeComponent();
        }

        public void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void btn明細_Click(object sender, EventArgs e)
        {
            GlobalVar.訂單編號 =Convert.ToInt32(this.lbl訂單編號.Text);
            Productdetail productdetail = new Productdetail();
            productdetail.ShowDialog();
        }
    }
}
