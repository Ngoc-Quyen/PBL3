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
        private int IdDetailed;
        private double Distance;
        private Account _account;
        private int _idLoai;
        public TaoLichTrinh()
        {
            InitializeComponent();
        }
        public TaoLichTrinh(string IdStaff, string Location, string Destination, int IdDetailed, double Distance, int IdLoai)
        {
            this.Location1 = Location;
            this.Destination = Destination;
            this.IdStaff = IdStaff;
            this.IdDetailed = IdDetailed;
            this.Distance = Distance;
            this.IdLoai = IdLoai;
            InitializeComponent();
            Show();
            
        }
        public void Show()
        {
            txtIdStaff.Text = IdStaff;
            txtLocation.Text = Location1;
            txtDestination.Text = Destination;
            cbIdCar.DataSource = QLXe1.Instance.GetAllCarByLoai(IdLoai);
            cbIdCar.DisplayMember = "IdCar";
            cbIdCar.ValueMember = "IdCar";
        }

        public string IdStaff { get => _idStaff; set => _idStaff = value; }
        public string Location1 { get => _location; set => _location = value; }
        public string Destination { get => _destination; set => _destination = value; }
        public int IdLoai { get => _idLoai; set => _idLoai = value; }

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
            _sch.IdStatus = 0;
            if(QLLichTrinh.Instance.AddLT(_sch))    
            {
                MessageBox.Show("Bạn đã thêm lịch trình thành công");
                Detailed_Schedule _detai = new Detailed_Schedule();
                _detai.IdDetailed = IdDetailed;
                _detai.Location = txtLocation.Text;
                _detai.Destination = txtDestination.Text;
                _detai.Distance = Distance;
                _detai.Complete = 1;
                QLLichTrinh.Instance.EditComplete( _detai );
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Chưa thêm lịch trình thành công");
            }
            
            //Admin1 admin1 = new Admin1();
        }

        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            string IdCustomer = txtIdCustomer.Text;
            string IdCar = cbIdCar.SelectedValue.ToString();
            string IdStaff = txtIdStaff.Text.ToString();
            int loai = QLXe1.Instance.getChongoi(IdCar);
            double sum = QLHoaDon.Instance.Tinhtien(loai, Distance);
            Schedule _sch = new Schedule();
            _sch.IdCustomer = txtIdCustomer.Text;
            _sch.IdCar = cbIdCar.Text;
            _sch.IdStaff = txtIdStaff.Text;
            _sch.Location = txtLocation.Text;
            _sch.DateLocation = dtLocation.Value;
            _sch.Destination = txtDestination.Text;
            _sch.IdStatus = 0;
            _sch.IdDetailed = IdDetailed;
            if(QLLichTrinh.Instance.AddLT(_sch))    
            {
                //MessageBox.Show("Bạn đã thêm lịch trình thành công");
                Detailed_Schedule _detai = new Detailed_Schedule();
                _detai.IdDetailed = IdDetailed;
                _detai.Location = txtLocation.Text;
                _detai.Destination = txtDestination.Text;
                _detai.Distance = Distance;
                _detai.Complete = 1;
                QLLichTrinh.Instance.EditComplete( _detai );
                Schedule sch = QLLichTrinh.Instance.GetScheduleLast();
                int idSch = sch.IdSchedule;
                this.Hide();
                ThanhToan f = new ThanhToan(IdCustomer, IdCar, IdStaff, sum, idSch);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa có lịch trình để thanh toán");
            }
        }
    }
}
