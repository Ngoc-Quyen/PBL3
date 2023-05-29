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
        public void LoadData()
        {
            LoadCar();
            LoadStaff();
            LoadAccount();
            LoadSchedule();
            LoadBill();
        }

        #region EventCar
        void LoadCar()
        {
            _enable();
            dtgvCar.DataSource = QLXe1.Instance.getAllCarInfo();
            cbSearchCar.DataSource = QLXe1.Instance.GetAllCar();
            cbSearchCar.DisplayMember = "IdCar";
            cbSearchCar.ValueMember = "IdCar";
            cbChongoi.DataSource = QLXe1.Instance.GetAllPrice();
            cbChongoi.DisplayMember = "IdLoai";
            cbChongoi.ValueMember = "IdLoai";
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
            cbChongoi.ResetText();
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
                cbChongoi.SelectedValue = Convert.ToInt32(selectedRow.Cells["ChoNgoi"].Value.ToString());
            }
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
                car.ChoNgoi = Convert.ToInt32(cbChongoi.SelectedValue.ToString());

                QLXe1.Instance.Add(car);
                LoadCar();
            }
            else
            {
                Car car = new Car();
                car.IdCar = txtCarId.Text;
                car.NameCar = txtCarName.Text;
                car.ColorCar = txtCarColor.Text;
                car.ChoNgoi = Convert.ToInt32(cbChongoi.SelectedValue.ToString());
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
            dtgvStaff.DataSource = QLTaiXe.Instance.getAllStaffInfo();
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
            //dtgvAccount.DataSource = QLDangNhap.Instance.GetAllAccounts();
            dtgvAccount.DataSource = QLTaiKhoan.Instance.getAllAccoutInfo();
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
        private void btResetPassWord_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.UserName = txtAccountName.Text;
            ac.DisplayName = txtAccountDisplay.Text;
            ac.PassWord = "1";
            //ac.Type = cbAccountType.SelectedIndex;
            QLTaiKhoan.Instance.Edit(ac);
            MessageBox.Show("Bạn đã đặt lại mật khẩu thành công!");
            LoadAccount();
        }
        #endregion

        #region EventSchedule
        static int Id;
        public void LoadSchedule()
        {
            _enableSchedule();
            dtgvSchedule.DataSource = QLLichTrinh.Instance.GetAllScheduleInfo();
           
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
                _sch.IdStatus = Convert.ToInt32(cbStatus.SelectedValue.ToString());
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

        private void gbDanhmuc_CheckedChanged()
        {
            string columnName = "";
            foreach(Control control in gbDanhmuc.Controls)
            {
                if(control is System.Windows.Forms.RadioButton && ((System.Windows.Forms.RadioButton)control).Checked)
                {
                    switch(control.Name)
                    {
                        case "rdbTime":
                            columnName = "DateLocation";
                            MessageBox.Show(columnName);
                            break;
                        case "rdbStaff":
                            columnName = "IdStaff";
                            MessageBox.Show(columnName);
                            break;
                        case "rdbCustomer":
                            columnName = "IdCustomer";
                            MessageBox.Show(columnName);
                            break;
                        case "rdbCar":
                            columnName = "IdCar";
                            MessageBox.Show(columnName);
                            break;
                        case "rdbStatus":
                            columnName = "IdStatus";
                            MessageBox.Show(columnName);
                            break;
                    }    
                }
                //cbSearchSchedule.Items.Clear();
                //cbSearchSchedule.Items.AddRange(QLLichTrinh.Instance.GetColumnValue("Schedule", columnName).ToArray());
                
            }
        }
        static string columnName = "";
        private void rdbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTime.Checked)
            {
                var l = QLLichTrinh.Instance.GetAllByDateLocation();
                cbSearchSchedule.DataSource = null;
                if(cbSearchSchedule.Items.Count > 0)
                {
                    cbSearchSchedule.Items.Clear();
                }
                foreach (var i in l)
                {
                    cbSearchSchedule.Items.Add(i);
                }    
            }
        }

        private void rdbStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStaff.Checked)
            {
                columnName = "IdStaff";
                cbSearchSchedule.DataSource = QLTaiXe.Instance.GetAllStaff();
                cbSearchSchedule.DisplayMember = columnName;
                cbSearchSchedule.ValueMember = columnName;

            }
        }
        
        private void rdbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCustomer.Checked)
            {
                var l = QLLichTrinh.Instance.GetAllByCustomer();
                cbSearchSchedule.DataSource = null;
                if (cbSearchSchedule.Items.Count > 0)
                {
                    cbSearchSchedule.Items.Clear();
                }
                foreach (var i in l)
                {
                    cbSearchSchedule.Items.Add(i);
                }
            }
        }

        private void rdbCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCar.Checked)
            {
                columnName = "IdCar";
                cbSearchSchedule.DataSource = QLXe1.Instance.GetAllCar();
                cbSearchSchedule.DisplayMember = columnName;
                cbSearchSchedule.ValueMember = columnName;
            }
        }

        private void rdbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStatus.Checked)
            {
                columnName = "IdStatus";
                cbSearchSchedule.DataSource = null;
                cbSearchSchedule.DataSource = QLLichTrinh.Instance.GetAllStatus();
                cbSearchSchedule.DisplayMember = "NameStatus";
                cbSearchSchedule.ValueMember = columnName;
            }
        }

        private void btSearchSchedule_Click(object sender, EventArgs e)
        {
            if (rdbTime.Checked)
            {
                DateTime dateTime = Convert.ToDateTime(cbSearchSchedule.SelectedItem.ToString());
                dtgvSchedule.DataSource = QLLichTrinh.Instance.GetSearchByTime(dateTime);
            }
            if (rdbStaff.Checked)
            {
                string staff = cbSearchSchedule.SelectedValue.ToString();
                dtgvSchedule.DataSource = QLLichTrinh.Instance.GetSearchByIdStaff(staff);
            }  
            if (rdbCustomer.Checked)
            {
                string sdt = cbSearchSchedule.SelectedItem.ToString();
                dtgvSchedule.DataSource = QLLichTrinh.Instance.GetSearchByIdCustomer(sdt);
            }
            if (rdbCar.Checked)
            {
                string car = cbSearchSchedule.SelectedValue.ToString();
                dtgvSchedule.DataSource = QLLichTrinh.Instance.GetSearchByIdCar(car);
            }    
            if(rdbStatus.Checked)
            {
                int status = Convert.ToInt32(cbSearchSchedule.SelectedValue.ToString());
                dtgvSchedule.DataSource = QLLichTrinh.Instance.GetSearchByStatus(status);
            }    
        }
        #endregion

        #region Event_Bill

        void _enableBill()
        {
            //btSave_Bill.Visible = false;
            //btReset_Bill.Visible = false;
            //btAdd_Bill.Visible = true;
            ////btDelete_Bill.Visible = true;
            //btEdit_Bill.Visible = true;
            btShow_Bill.Visible = true;
            pnSearch_Bill.Visible = true;
        }
        void _disableBill()
        {
            //btSave_Bill.Visible = true;
            //btReset_Bill.Visible = true;
            //btAdd_Bill.Visible = false;
            //btEdit_Bill.Visible = false;
            btShow_Bill.Visible = false;
            pnSearch_Bill.Visible = false;
        }
        void LoadBill()
        {
            _enableBill();
            dtgvBill.DataSource = QLHoaDon.Instance.getAllBillInfo();
        }

        
       
        void ResetBill()
        {
            txtSDT_Bill.ResetText();
            txtIdStaff_Bill.ResetText();
            txtIdCar_Bill.ResetText();
            txtMoney.ResetText();
            dtBill.ResetText();
            cbSearch_Bill.ResetText();
        }
       

        private void btShow_Bill_Click(object sender, EventArgs e)
        {
            LoadBill();
            ResetBill();
        }

        private void rdbTime_Bill_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTime_Bill.Checked)
            {
                var l = QLHoaDon.Instance.getAllByTime();
                cbSearch_Bill.DataSource = null;
                if (cbSearch_Bill.Items.Count > 0)
                {
                    cbSearch_Bill.Items.Clear();
                }
                foreach (var i in l)
                {
                    cbSearch_Bill.Items.Add(i);
                }
            }
        }

        private void rdbStaff_Bill_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStaff_Bill.Checked)
            {
                columnName = "IdStaff";
                cbSearch_Bill.DataSource = QLTaiXe.Instance.GetAllStaff();
                cbSearch_Bill.DisplayMember = columnName;
                cbSearch_Bill.ValueMember = columnName;

            }
        }

        private void rdbCar_Bill_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCar_Bill.Checked)
            {
                columnName = "IdCar";
                cbSearch_Bill.DataSource = QLXe1.Instance.GetAllCar();
                cbSearch_Bill.DisplayMember = columnName;
                cbSearch_Bill.ValueMember = columnName;
            }
        }

        private void rdbSDT_Bill_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSDT_Bill.Checked)
            {
                var l = QLHoaDon.Instance.getAllByCustomer();
                cbSearch_Bill.DataSource = null;
                if (cbSearch_Bill.Items.Count > 0)
                {
                    cbSearch_Bill.Items.Clear();
                }
                foreach (var i in l)
                {
                    cbSearch_Bill.Items.Add(i);
                }
            }
        }

        private void btSearch_Bill_Click(object sender, EventArgs e)
        {
            if (rdbTime_Bill.Checked)
            {
                DateTime dateTime = Convert.ToDateTime(cbSearch_Bill.SelectedItem.ToString());
                dtgvBill.DataSource = QLHoaDon.Instance.GetSearchByTime(dateTime);
            }
            if (rdbStaff_Bill.Checked)
            {
                string staff = cbSearch_Bill.SelectedValue.ToString();
                dtgvBill.DataSource = QLHoaDon.Instance.GetSearchByIdStaff(staff);
            }
            if (rdbSDT_Bill.Checked)
            {
                string sdt = cbSearch_Bill.SelectedItem.ToString();
                dtgvBill.DataSource = QLHoaDon.Instance.GetSearchByIdCustomer(sdt);
            }
            if (rdbCar_Bill.Checked)
            {
                string car = cbSearch_Bill.SelectedValue.ToString();
                dtgvBill.DataSource = QLHoaDon.Instance.GetSearchByIdCar(car);
            }

        }
        private static int id = 0;
        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = dtgvBill.Rows[row];
                id = Convert.ToInt32(selectedRow.Cells["IdBill"].Value.ToString());
                txtSDT_Bill.Text = selectedRow.Cells["IdCustomer"].Value.ToString();
                txtIdCar_Bill.Text = selectedRow.Cells["IdCar"].Value.ToString();
                txtIdStaff_Bill.Text = selectedRow.Cells["IdStaff"].Value.ToString();
                txtMoney.Text = selectedRow.Cells["GiaThanhToan"].Value.ToString();
                dtBill.Text = selectedRow.Cells["TimeThanhToan"].Value.ToString();
            }
        }

        #endregion
       
    }
}
