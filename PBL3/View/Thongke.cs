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

namespace PBL3.View
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtStart.Value = DateTime.Today.AddDays(-7);
            dtEnd.Value = DateTime.Now;
            btLast7day.Select();

            LoadData(dtStart.Value, dtEnd.Value);
        }
        public static int countId = 0;
        public static double price = 0.0;
        public void LoadData(DateTime start, DateTime end)
        {
            countId = QLThongKe.Instance.GetCountIdCustomer(start, end);
            price = QLThongKe.Instance.GetTotalPrice(start, end);
            lbSoluongKhach.Text = countId.ToString();
            lbTongDoanhthu.Text =  price.ToString() + " VND" ;
            if (QLThongKe.Instance.GetLoadData(start, end))
            {
                chartTongDoanhthu.DataSource = ThongKe.Instance.GrossRevenueList;
                chartTongDoanhthu.Series[0].XValueMember = "Date";
                chartTongDoanhthu.Series[0].YValueMembers = "TotalAmount";
                chartTongDoanhthu.DataBind();

                //chartLoaixe.DataSource = ThongKe.Instance.carByDateList;
                //chartLoaixe.Series[0].XValueMember = "Key";
                //chartLoaixe.Series[0].YValueMembers = "Value";
                //chartLoaixe.DataBind();
            }    
        }
        public void _enable()
        {
            dtStart.Enabled = false; 
            dtEnd.Enabled = false;
            btShow.Enabled = false;
        }
        public void _disable()
        {
            dtStart.Enabled = true;
            dtEnd.Enabled = true;
            btShow.Enabled = true;
        }

        private void btCustom_Click(object sender, EventArgs e)
        {
            _disable();
            
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            DateTime start = dtStart.Value;
            DateTime end = dtEnd.Value;
            LoadData(start, end);
        }

        private void btLast7day_Click(object sender, EventArgs e)
        {
            _enable();
            dtStart.Value = DateTime.Today.AddDays(-7);
            dtEnd.Value = DateTime.Now;
            DateTime start = dtStart.Value;
            DateTime end = dtEnd.Value;
            LoadData(start, end);
        }

        private void btLast30day_Click(object sender, EventArgs e)
        {
            _enable();
            dtStart.Value = DateTime.Today.AddDays(-30);
            dtEnd.Value = DateTime.Now;
            DateTime start = dtStart.Value;
            DateTime end = dtEnd.Value;
            LoadData(start, end);
        }

        private void btToday_Click(object sender, EventArgs e)
        {
            _enable();
            dtStart.Value = DateTime.Today;
            dtEnd.Value = DateTime.Now;
            DateTime start = dtStart.Value;
            DateTime end = dtEnd.Value;
            LoadData(start, end);
        }

        private void btThisMonth_Click(object sender, EventArgs e)
        {
            _enable();
            dtStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtEnd.Value = DateTime.Now;
            DateTime start = dtStart.Value;
            DateTime end = dtEnd.Value;
            LoadData(start, end);
        }
    }
}
