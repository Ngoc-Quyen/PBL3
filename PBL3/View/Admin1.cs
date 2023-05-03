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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PBL3.View
{
    public partial class Admin1 : Form
    {
        TestPbl3Entities db = new TestPbl3Entities();
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
            LoadSchedule();
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
        public void LoadAccount()
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
            //panelVaitro.Visible = true;
            panelSearchAccount.Visible = true;
            btResetPassWord.Visible = true;

        }
        void _disableAccount()
        {
            panelDisable.Visible = true;
            btShowAccount.Visible = false;
            btAddAccount.Visible = false;
            btDelAccount.Visible = false;
            //panelVaitro.Visible = false;
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
            string id = txtAccountName.Text;
            QLTaiKhoan.Instance.Delete(id);
            LoadAccount();
        }

        private void btShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
            ResetAccount();
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
        public void cbSearchAccount_Show()
        {
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
        private void btSearchAccount_Click(object sender, EventArgs e)
        {
            string IdAccount = cbSearchAccount.SelectedValue.ToString();
            dtgvAccount.DataSource = QLTaiKhoan.Instance.GetAccountBySearch(IdAccount);
        }
        #endregion

        #region EventSchedule
        static int Id;
        public void LoadSchedule()
        {
            _enableSchedule();
            dtgvSchedule.DataSource = QLLichTrinh.Instance.GetAllSchedule();
            show_combobox();

        }
        public void ResetSchedule()
        {
            txtIdCustomer.Text = "";
            cbIdCar.ResetText();
            cbIdStaff.ResetText();
            txtLocation.ResetText();
            dtLocation.ResetText();
            txtDestination.ResetText();
            cbStatus.ResetText();
        }
        void _enableSchedule()
        {
            btSaveSchedule.Visible = false;
            btResetSchedule.Visible = false;
            btAddSchedule.Visible = true;
            btDeleteSchedule.Visible = true;
            btEditSchedule.Visible = true;
            btShowSchedule.Visible = true;
            panelSearchSchedule.Visible = true;
        }
        void _disableSchedule()
        {
            btSaveSchedule.Visible = true;
            btResetSchedule.Visible = true;
            btAddSchedule.Visible = false;
            btDeleteSchedule.Visible = false;
            btEditSchedule.Visible = false;
            btShowSchedule.Visible = false;
            panelSearchSchedule.Visible = false;
        }

        private void dtgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = dtgvSchedule.Rows[row];
                Id = Convert.ToInt32(selectedRow.Cells["IdSchedule"].Value.ToString());
                txtIdCustomer.Text = selectedRow.Cells["IdCustomer"].Value.ToString();
                cbIdCar.SelectedValue = selectedRow.Cells["IdCar"].Value.ToString();
                cbIdStaff.SelectedValue = selectedRow.Cells["IdStaff"].Value.ToString();
                txtLocation.Text = selectedRow.Cells["Location"].Value.ToString();
                dtLocation.Text = selectedRow.Cells["DateLocation"].Value.ToString();
                txtDestination.Text = selectedRow.Cells["Destination"].Value.ToString();
                int numberValue = Convert.ToInt32(selectedRow.Cells["IdStatus"].Value.ToString());
                cbStatus.SelectedValue = numberValue;
            }
        }
        public void show_combobox()
        { 
            cbIdCar.DataSource = QLXe1.Instance.GetAllCar();
            cbIdCar.DisplayMember = "IdCar";
            cbIdCar.ValueMember = "IdCar";

            cbIdStaff.DataSource = QLTaiXe.Instance.GetAllStaff();
            cbIdStaff.DisplayMember = "IdStaff";
            cbIdStaff.ValueMember = "IdStaff";

            cbStatus.DataSource = QLLichTrinh.Instance.GetAllStatus();
            cbStatus.DisplayMember = "NameStatus";
            cbStatus.ValueMember = "IdStatus";
        }

        private void btAddSchedule_Click(object sender, EventArgs e)
        {
            _them = true;
            ResetSchedule();
            txtIdCustomer.ReadOnly = false;
            _disableSchedule();
        }

        private void btDeleteSchedule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string id = txtIdCustomer.Text;
                    // Xóa đối tượng
                    QLLichTrinh.Instance.Delete(id);

                    // Tải lại danh sách
                    LoadSchedule();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("An error occurred while deleting the item: " + ex.Message);

                    // Hủy sự kiện
                    if (e is CancelEventArgs)
                    {
                        ((CancelEventArgs)e).Cancel = true;
                    }
                }
            }
        }

    private void btEditSchedule_Click(object sender, EventArgs e)
    {
        _them = false;
        _disableSchedule();
        txtIdCustomer.ReadOnly = true;
    }

        private void btShowSchedule_Click(object sender, EventArgs e)
        {
            LoadSchedule();
            ResetSchedule();
        }

        private void btSaveSchedule_Click(object sender, EventArgs e)
        {
            if(_them)
            {
                Schedule _sch = new Schedule();
                _sch.IdCustomer = txtIdCustomer.Text;
                _sch.IdCar = cbIdCar.Text;
                _sch.IdStaff = cbIdStaff.Text;
                _sch.Location = txtLocation.Text;
                _sch.DateLocation = dtLocation.Value;
                _sch.Destination = txtDestination.Text;
                _sch.IdStatus = Convert.ToInt32(cbStatus.SelectedIndex);
                QLLichTrinh.Instance.Add(_sch );
                LoadSchedule();
            }
            else
            {
                Schedule _sch = new Schedule();
                _sch.IdSchedule = Id;
                _sch.IdCustomer = txtIdCustomer.Text;
                _sch.IdCar = cbIdCar.Text;
                _sch.IdStaff = cbIdStaff.Text;
                _sch.Location = txtLocation.Text;
                _sch.DateLocation = dtLocation.Value;
                _sch.Destination = txtDestination.Text;
                _sch.IdStatus = Convert.ToInt32(cbStatus.SelectedValue.ToString());
                QLLichTrinh.Instance.Edit(_sch);
                LoadSchedule();
            }
            _them = false;
            _enableSchedule();
        }

        private void btExitSchedule_Click(object sender, EventArgs e)
        {
            _enableSchedule();
            ResetSchedule();
        }

        #endregion

    }
}
