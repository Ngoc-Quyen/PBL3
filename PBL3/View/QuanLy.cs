using Microsoft.SqlServer.Management.Facets;
using PBL3.BLL;
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
            ShowQly();
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

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }
        public static int Id = 0;
        public static string location = "";
        public static string destination = "";
        public static double distance = 0.0;
        private void dtgvLichtrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = dtgvLichtrinh.Rows[row];
                Id = Convert.ToInt32(selectedRow.Cells["IdDetailed"].Value.ToString());
                location = selectedRow.Cells["Location"].Value.ToString();
                destination = selectedRow.Cells["Destination"].Value.ToString();
                distance = Convert.ToDouble(selectedRow.Cells["Distance"].Value.ToString());

            }
        }
        private void btXacnhan_Click(object sender, EventArgs e)
        {
            string idStaff = LoginAccount.UserName;
            TaoLichTrinh f = new TaoLichTrinh(idStaff, location, destination, Id, distance);
            f.ShowDialog();
        }

        public void ShowQly()
        {
            dtgvLichtrinh.DataSource = QLLichTrinh.Instance.GetAllDetailedBy();
        }

    }
}
