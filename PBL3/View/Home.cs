using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            tabDnDky.SelectedTab = tabDnDky.TabPages[1];
        }

        private void lbDangnhap_Click(object sender, EventArgs e)
        {
            tabDnDky.SelectedTab = tabDnDky.TabPages[0];
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {

            this.Hide();
            CaiDat run = new CaiDat();
            run.Show();
           

        }

        private void btDangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            CaiDat run = new CaiDat();
            run.Show();
        }
    }
}
