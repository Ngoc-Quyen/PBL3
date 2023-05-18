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
    public partial class TaoLichTrinh : Form
    {
        private string _idStaff;
        private string _location;
        private string _destination;
        private Account _account;
        public TaoLichTrinh()
        {
            InitializeComponent();
        }
        public TaoLichTrinh(string IdStaff, string Location, string Destination)
        {
            this.Location1 = Location;
            this.Destination = Destination;
            this.IdStaff = IdStaff;
            InitializeComponent();
            Show();
            
        }
        public void Show()
        {
            txtIdStaff.Text = IdStaff;
            txtLocation.Text = Location1;
            txtDestination.Text = Destination;
            cbIdCar.DataSource = QLXe1.Instance.GetAllCar();
            cbIdCar.DisplayMember = "IdCar";
            cbIdCar.ValueMember = "IdCar";
        }

        public string IdStaff { get => _idStaff; set => _idStaff = value; }
        public string Location1 { get => _location; set => _location = value; }
        public string Destination { get => _destination; set => _destination = value; }
        private Account loginAccount;

        private void btSaveSchedule_Click(object sender, EventArgs e)
        {
            Schedule _sch = new Schedule();
            _sch.IdCustomer = txtIdCustomer.Text;
            _sch.IdCar = cbIdCar.Text;
            _sch.IdStaff = txtIdStaff.Text;
            _sch.Location = txtLocation.Text;
            _sch.DateLocation = dtLocation.Value;
            _sch.Destination = txtDestination.Text;
            _sch.IdStatus = 1;
            if(QLLichTrinh.Instance.AddLT(_sch))    
            {
                MessageBox.Show("Bạn đã thêm lịch trình thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chưa thêm lịch trình thành công");
            }
            
            //Admin1 admin1 = new Admin1();
        }
    }
}
