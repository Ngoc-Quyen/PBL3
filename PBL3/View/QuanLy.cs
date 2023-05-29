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
                lịchTrìnhToolStripMenuItem.Enabled = true;
            }
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
            
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Admin1 f = new Admin1();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
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
        void _enable()
        {
            dtgvDetailed.Visible = true;
            lbLoaixe.Visible = true;
            cbIdLoai.Visible = true;
            btShowPrice.Visible = true;
            btXacnhan.Visible = true;
            txtPrice.Visible = true;
            btThanhtoan.Visible = false;
            dtgvSchedule.Visible = false ;
        }
        void _disable()
        {
            dtgvDetailed.Visible = false;
            lbLoaixe.Visible = false;
            cbIdLoai.Visible = false;
            btShowPrice.Visible = false;
            btXacnhan.Visible = false;
            txtPrice.Visible = false;
            btThanhtoan.Visible = true;
            dtgvSchedule.Visible = true;
        }
        public void ShowQly()
        {
            _enable();
            dtgvDetailed.DataSource = QLLichTrinh.Instance.GetAllDetailedInfosBy();
            cbIdLoai.DataSource = QLXe1.Instance.GetAllPrice();
            cbIdLoai.DisplayMember = "IdLoai";
            cbIdLoai.ValueMember = "IdLoai";
            btThanhtoan.Visible = false;
            dtgvSchedule.Visible = false;
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
            _disable();
            dtgvSchedule.DataSource = QLLichTrinh.Instance.GetScheduleByIdStaffAndStatus(loginAccount.UserName);
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

        public static string idCustomer = "";
        public static string idStaff = "";
        public static string idCar = "";
        public static int idDetailed = 0;
        public static int idSchedule = 0;
        private void dtgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row >= 0)
            {
                DataGridViewRow selectedRow = dtgvSchedule.Rows[row];
                idCustomer = selectedRow.Cells["IdCustomer"].Value.ToString();
                idStaff = selectedRow.Cells["IdStaff"].Value.ToString();
                idCar = selectedRow.Cells["IdCar"].Value.ToString();
                idDetailed = Convert.ToInt32(selectedRow.Cells["IdDetailed"].Value.ToString());
                idSchedule = Convert.ToInt32(selectedRow.Cells["IdSchedule"].Value.ToString());
            }    
        }

        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            string IdCustomer = idCustomer;
            string IdCar = idCar;
            string IdStaff = idStaff;
            int IdSchedule = idSchedule;
            int loai = QLXe1.Instance.getChongoi(IdCar);
            double Distance = QLLichTrinh.Instance.GetDistanceById(idDetailed);
            double sum = QLHoaDon.Instance.Tinhtien(loai, Distance);
            //this.Hide();
            ThanhToan f = new ThanhToan(IdCustomer, IdCar, IdStaff, sum, IdSchedule);
            f.ShowDialog();
            ShowQly();
        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQly();
        }

        private void BaocaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin1 f = new Admin1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke f = new Thongke();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
