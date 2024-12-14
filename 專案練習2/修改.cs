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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn床_Click(object sender, EventArgs e)
        {
            Bed bed = new Bed();
            bed.ShowDialog();
        }

        private void btn櫃子_Click(object sender, EventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            cabinet.ShowDialog();
        }

        private void btn桌子_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            desk.ShowDialog();
        }

        private void btn沙發_Click(object sender, EventArgs e)
        {
            Sofa sofa = new Sofa();
            sofa.ShowDialog();
        }

        private void btn購物車_Click(object sender, EventArgs e)
        {
            CheckList checkList = new CheckList();
            checkList.ShowDialog();
        }
    }
}
