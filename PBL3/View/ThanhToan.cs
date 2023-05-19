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
    public partial class ThanhToan : Form
    {
        private string _idCustomer;
        private string _idCar;
        private string _idStaff;
        private double _sum;
        public ThanhToan()
        {
            InitializeComponent();
        }
        public ThanhToan(string IdCustomer, string IdCar, string IdStaff, double Sum)
        {
            this._idCustomer = IdCustomer;
            this._idCar = IdCar;
            this._idStaff = IdStaff;
            this._sum = Sum;
            InitializeComponent();
            ShowDL();
        }

        public string IdCustomer { get => _idCustomer; set => _idCustomer = value; }
        public string IdCar { get => _idCar; set => _idCar = value; }
        public string IdStaff { get => _idStaff; set => _idStaff = value; }
        public double Sum { get => _sum; set => _sum = value; }

        public void ShowDL()
        {
            txtIdCustomer.Text = _idCustomer;
            txtIdCar.Text = _idCar;
            Staff staff = QLTaiXe.Instance.GetStaffBy(_idStaff);
            txtNameStaff.Text = staff.NameStaff;
            txtMoney.Text = _sum.ToString();
        }
    }
}
