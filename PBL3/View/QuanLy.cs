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
        private static QuanLy instance;
        public  Account LoginAccount
        { 
            get => loginAccount; 
            set 
            {
                loginAccount = value;
                ChangeAccount(Convert.ToInt32(loginAccount.Type.ToString()));
            }
        }

        public static QuanLy Instance { get => instance; set => instance = value; }

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
                lịchTrìnhToolStripMenuItem.Enabled = false;
            }
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
            
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
        public static int idLoai = 0;
        private void btXacnhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            string idStaff = LoginAccount.UserName;
            idLoai = Convert.ToInt32(cbIdLoai.SelectedValue.ToString());
            TaoLichTrinh f = new TaoLichTrinh(idStaff, location, destination, Id, distance, idLoai);
            f.ShowDialog();
            ShowQly();
            this.Show();
        }

        public void ShowQly()
        {
            dtgvDetailed.DataSource = QLLichTrinh.Instance.GetAllDetailedBy();
            cbIdLoai.DataSource = QLXe1.Instance.GetAllPrice();
            cbIdLoai.DisplayMember = "IdLoai";
            cbIdLoai.ValueMember = "IdLoai";
            btThanhtoan.Visible = false;
        }
        public double Tinhtoan()
        {
            int loai = Convert.ToInt32(cbIdLoai.SelectedValue.ToString());
            return QLHoaDon.Instance.Tinhtien(loai, distance);
        }

        private void btShowPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Text = Tinhtoan().ToString();
        }

        private void chưaThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgvDetailed.Visible = false;
            lbLoaixe.Visible = false;
            cbIdLoai.Visible = false;
            btShowPrice.Visible = false;
            btXacnhan.Visible = false;
            txtPrice.Visible = false;
            btThanhtoan.Visible = true;
            dtgvDetailed.DataSource = QLLichTrinh.Instance.GetScheduleByIdStaffAndStatus(loginAccount.UserName);
        }

        private void dtgvDetailed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = dtgvDetailed.Rows[row];
                Id = Convert.ToInt32(selectedRow.Cells["IdDetailed"].Value.ToString());
                location = selectedRow.Cells["Location"].Value.ToString();
                destination = selectedRow.Cells["Destination"].Value.ToString();
                distance = Convert.ToDouble(selectedRow.Cells["Distance"].Value.ToString());
                idLoai = Convert.ToInt32(cbIdLoai.SelectedValue.ToString());
            }
        }
    }
}
