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
    public partial class QuanLy : Form
    {
        private  Account loginAccount;

        public  Account LoginAccount
        { 
            get => loginAccount; 
            set 
            {
                loginAccount = value;
                ChangeAccount(Convert.ToInt32(loginAccount.Type.ToString()));
            }
        }

        public QuanLy(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        void ChangeAccount(int type)
        {
            if (type != 1)
            {
                adminToolStripMenuItem.Enabled = false;
            }
            else
            {
                adminToolStripMenuItem.Enabled = true;
            }
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
            
        }
        private void lbDiembatdau_Click(object sender, EventArgs e)
        {

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin1 f = new Admin1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan(LoginAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
