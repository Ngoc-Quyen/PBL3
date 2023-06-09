﻿using PBL3.BLL;
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
        private int _idSchedule;
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
        public ThanhToan(string IdCustomer, string IdCar, string IdStaff, double Sum, int IdSchedule)
        {
            this._idCustomer = IdCustomer;
            this._idCar = IdCar;
            this._idStaff = IdStaff;
            this._sum = Sum;
            this.IdSchedule = IdSchedule;
            InitializeComponent();
            ShowDL();
        }
        public string IdCustomer { get => _idCustomer; set => _idCustomer = value; }
        public string IdCar { get => _idCar; set => _idCar = value; }
        public string IdStaff { get => _idStaff; set => _idStaff = value; }
        public double Sum { get => _sum; set => _sum = value; }
        public int IdSchedule { get => _idSchedule; set => _idSchedule = value; }

        public void ShowDL()
        {
            txtIdCustomer.Text = _idCustomer;
            txtIdCar.Text = _idCar;
            Staff staff = QLTaiXe.Instance.GetStaffBy(_idStaff);
            txtIdStaff.Text = _idStaff;
            txtMoney.Text = _sum.ToString();
        }

        private void btTT_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.IdCustomer = _idCustomer;
            bill.IdCar = _idCar;
            //Staff staff = QLTaiXe.Instance.GetStaffBy(_idStaff);
            bill.IdStaff = _idStaff;
            bill.GiaThanhToan = Convert.ToDecimal(_sum.ToString());
            bill.TimeThanhToan = dtBill.Value;
            bill.IdSchedule = _idSchedule;
            //Schedule _sch = QLLichTrinh.Instance.GetScheduleLast();
            //_sch.IdStatus = 1;
            Schedule _sch = QLLichTrinh.Instance.GetScheduleById(_idSchedule);
            _sch.IdStatus = 1;
            Car _car = QLXe1.Instance.GetCarBy(_idCar);
            _car.IdStatus = 0;
            Staff _staff = QLTaiXe.Instance.GetStaffBy(_idStaff);
            _staff.IdStatus = 0;
            if(QLHoaDon.Instance.AddBill(bill))
            {
                MessageBox.Show("Bạn đã thanh toán thành công!");
                QLLichTrinh.Instance.Edit(_sch);
                QLTaiXe.Instance.Edit(_staff);
                QLXe1.Instance.EditStatus(_car);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn chưa thanh toán thành công!");
            }
            

        }
    }
}
