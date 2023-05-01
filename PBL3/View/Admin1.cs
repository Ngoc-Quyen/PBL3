using PBL3.BLL;
using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PBL3.View
{
    public partial class Admin1 : Form
    {
        TestPbl3Entities1 db = new TestPbl3Entities1();
        bool _them;
        public Admin1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            LoadCar();
            LoadStaff();
            LoadAccount();
        }

        #region EventCar
        void LoadCar()
        {
            _enable();
            dtgvCar.DataSource = QLXe1.Instance.GetAllCar();
            cbSearchCar.DataSource = QLXe1.Instance.GetAllCar();
            cbSearchCar.DisplayMember = "IdCar";
            cbSearchCar.ValueMember = "IdCar";
            Reset();
        }
        private void btAddCar_Click(object sender, EventArgs e)
        {
            _them = true;
            _disable();

        }

        private void btDelCar_Click(object sender, EventArgs e)
        {
            string id = txtCarId.Text;
            QLXe1.Instance.Delete(id);
            LoadCar();
        }

        private void btEditCar_Click(object sender, EventArgs e)
        {
            _them = false;
            _disable();
            txtCarId.ReadOnly = true;
        }

        private void btShowCar_Click(object sender, EventArgs e)
        {
            LoadCar();
            Reset();

        }
        void Reset()
        {
            txtCarId.Text = "";
            txtCarName.Text = "";
            txtCarColor.Text = "";
            numericChongoi.Value = 0;
            txtCarId.ReadOnly = false;
        }
        private void btSearchCar_Click(object sender, EventArgs e)
        {
            string Id_Car = cbSearchCar.SelectedValue.ToString();
            dtgvCar.DataSource = QLXe1.Instance.GetCarBySearch(Id_Car);
        }

        private void dtgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = dtgvCar.Rows[row];
                txtCarId.Text = selectedRow.Cells["IdCar"].Value.ToString();
                txtCarName.Text = selectedRow.Cells["NameCar"].Value.ToString();
                txtCarColor.Text = selectedRow.Cells["ColorCar"].Value.ToString();
                numericChongoi.Value = Convert.ToInt32(selectedRow.Cells["ChoNgoi"].Value.ToString());
            }
        }

        private void dtgvCar_Click(object sender, EventArgs e)
        {


        }

        void _enable()
        {
            btSaveCar.Visible = false;
            btResetCar.Visible = false;
            btAddCar.Visible = true;
            btEditCar.Visible = true;
            btDelCar.Visible = true;
            btShowCar.Visible = true;
            panelSearchCar.Visible = true;

        }
        void _disable()
        {
            btSaveCar.Visible = true;
            btResetCar.Visible = true;
            btAddCar.Visible = false;
            btEditCar.Visible = false;
            btDelCar.Visible = false;
            btShowCar.Visible = false;
            panelSearchCar.Visible = false;
        }

        private void btSaveCar_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                Car car = new Car();
                car.IdCar = txtCarId.Text;
                car.NameCar = txtCarName.Text;
                car.ColorCar = txtCarColor.Text;
                car.ChoNgoi = Convert.ToInt32(numericChongoi.Value.ToString());

                QLXe1.Instance.Add(car);
                LoadCar();
            }
            else
            {
                Car car = new Car();
                car.IdCar = txtCarId.Text;
                car.NameCar = txtCarName.Text;
                car.ColorCar = txtCarColor.Text;
                car.ChoNgoi = Convert.ToInt32(numericChongoi.Value.ToString());
                QLXe1.Instance.Edit(car);
                LoadCar();
            }
            _enable();
            _them = false;
        }

        private void btResetCar_Click(object sender, EventArgs e)
        {
            _enable();
            LoadCar();
            _them = false;
        }
        #endregion

        #region EventStaff

        void LoadStaff()
        {
            _enableStaff();
            dtgvStaff.DataSource = QLTaiXe.Instance.GetAllStaff();
            cbSearchStaff.DataSource = QLTaiXe.Instance.GetAllStaff();
            cbSearchStaff.DisplayMember = "NameStaff";
            cbSearchStaff.ValueMember = "IdStaff";
            ResetStaff();
        }

        private void btAddStaff_Click(object sender, EventArgs e)
        {
            _them = true;
            _disableStaff();
        }

        private void btDelStaff_Click(object sender, EventArgs e)
        {
            string id = txtStaffID.Text;
            QLTaiXe.Instance.Delete(id);
            LoadStaff();
        }

        private void btEditStaff_Click(object sender, EventArgs e)
        {
            _them = false;
            _disableStaff();
            txtStaffID.ReadOnly = true;
        }

        private void btShowStaff_Click(object sender, EventArgs e)
        {
            LoadStaff();
            ResetStaff();
        }

        private void btSrearchStaff_Click(object sender, EventArgs e)
        {
            string IdStaff = cbSearchStaff.SelectedValue.ToString();
            dtgvStaff.DataSource = QLTaiXe.Instance.GetStaffBySearch(IdStaff);
        }

        private void dtgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = dtgvStaff.Rows[row];
                txtStaffID.Text = selectedRow.Cells["IdStaff"].Value.ToString();
                txtStaffName.Text = selectedRow.Cells["NameStaff"].Value.ToString();
                txtStaffAddress.Text = selectedRow.Cells["AddressStaff"].Value.ToString();
                txtStaffPhone.Text = selectedRow.Cells["PhoneStaff"].Value.ToString();
            }
        }
        void _enableStaff()
        {
            btSaveStaff.Visible = false;
            btResetStaff.Visible = false;
            btAddStaff.Visible = true;
            btEditStaff.Visible = true;
            btDelStaff.Visible = true;
            btShowStaff.Visible = true;
            panelSearchStaff.Visible = true;

        }
        void _disableStaff()
        {
            btSaveStaff.Visible = true;
            btResetStaff.Visible = true;
            btAddStaff.Visible = false;
            btEditStaff.Visible = false;
            btDelStaff.Visible = false;
            btShowStaff.Visible = false;
            panelSearchStaff.Visible = false;
        }

        private void btSaveStaff_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                Staff st = new Staff();
                st.IdStaff = txtStaffID.Text;
                st.NameStaff = txtStaffName.Text;
                st.AddressStaff = txtStaffAddress.Text;
                st.PhoneStaff = txtStaffPhone.Text;
                QLTaiXe.Instance.Add(st);
                LoadStaff();
            }
            else
            {
                Staff st = new Staff();
                st.IdStaff = txtStaffID.Text;
                st.NameStaff = txtStaffName.Text;
                st.AddressStaff = txtStaffAddress.Text;
                st.PhoneStaff = txtStaffPhone.Text;
                QLTaiXe.Instance.Edit(st);
                LoadStaff();
            }
            _enableStaff();
            _them = false;
        }

        private void btResetStaff_Click(object sender, EventArgs e)
        {
            _enableStaff();
            LoadStaff();
            _them = false;
        }
        void ResetStaff()
        {
            txtStaffID.Text = "";
            txtStaffName.Text = "";
            txtStaffAddress.Text = "";
            txtStaffPhone.Text = "";
            txtStaffID.ReadOnly = false;
        }

        #endregion
        #region EventAccount
        void LoadAccount()
        {
            _enableAccount();
            dtgvAccount.DataSource = QLDangNhap.Instance.GetAllAccounts();
            cbSearchAccount_Show();
            cbAccountType.DataSource = QLTaiKhoan.Instance.GetAllType();
            cbAccountType.DisplayMember = "NameType";
            cbAccountType.ValueMember = "IdType";
            

            ResetAccount();
        }

        void ResetAccount()
        {
            txtAccountName.Text = "";
            txtAccountDisplay.Text = "";
            //cbAccountType.Text = "";
            //cbAccountType.Text = "All";
        }
        void _enableAccount()
        {
            panelDisable.Visible = false;
            btShowAccount.Visible = true;
            btAddAccount.Visible = true;
            btDelAccount.Visible = true;
            panelVaitro.Visible = true;
            panelSearchAccount.Visible = true;
            btResetPassWord.Visible = true;

        }
        void _disableAccount()
        {
            panelDisable.Visible = true;
            btShowAccount.Visible = false;
            btAddAccount.Visible = false;
            btDelAccount.Visible = false;
            panelVaitro.Visible = false;
            panelSearchAccount.Visible = false;
            btResetPassWord.Visible = false;
        }


        private void btAddAccount_Click(object sender, EventArgs e)
        {
            _them = true;
            _disableAccount();
            txtAccountName.ReadOnly = false;
        }

        private void btDelAccount_Click(object sender, EventArgs e)
        {

        }

        private void btShowAccount_Click(object sender, EventArgs e)
        {

        }

        private void btSaveAccount_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                Account ac = new Account();
                ac.UserName = txtAccountName.Text;
                ac.DisplayName = txtAccountDisplay.Text;
                ac.PassWord = "1";
                ac.Type = cbAccountType.SelectedIndex;
                QLTaiKhoan.Instance.Add(ac);
                LoadAccount();
            }

            _them = false;
            _enableAccount();
        }

        private void btResetAccount_Click(object sender, EventArgs e)
        {
            _enableAccount();
            ResetAccount();
        }

        #endregion

        private void cbSearchAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void cbSearchAccount_Show()
        {
            //var columns = db.Set<Account>().GetType().GetProperties().Select(p => p.Name).ToList();
            //foreach (var column in columns)
            //{
            //    cbSearchAccount.Items.Add(column);
            //}
            //if (cbSearchAccount.Items.Count > 0)
            //{
            //    cbSearchAccount.SelectedIndex = 0;
            //}
            cbSearchAccount.DataSource = QLTaiKhoan.Instance.GetAllAccount();
            cbSearchAccount.DisplayMember = "DisplayName";
            cbSearchAccount.ValueMember = "UserName";
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = dtgvAccount.Rows[row];
                txtAccountName.Text = selectedRow.Cells["UserName"].Value.ToString();
                txtAccountDisplay.Text = selectedRow.Cells["DisplayName"].Value.ToString();
                cbAccountType.SelectedIndex = Convert.ToInt32(selectedRow.Cells["Type"].Value.ToString());
                
            }

        }
    }
}
