using Microsoft.SqlServer.Management.Smo;
using PBL3.BLL;
using PBL3.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class HoaDon
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static HoaDon instance;

        public static HoaDon Instance 
        { 
            get
            {
                if(instance == null)
                    instance = new HoaDon();
                return instance;
            } 
            private set => instance = value; 
        }
        private  HoaDon()
        {

        }
        public List<Bill> getAllBill()
        {
            var l = db.Bills.Select(p => p);
            return l.ToList();
        }
        public List<BillInfo> getAllBillInfos()
        {
            var l = db.Bills.Select(s => new BillInfo { IdBill = s.IdBill, IdCar = s.IdCar, 
                IdCustomer = s.IdCustomer, IdStaff = s.IdStaff, GiaThanhToan = s.GiaThanhToan,  TimeThanhToan = s.TimeThanhToan, IdSchedule = s.IdSchedule}).ToList();
            return l;
        }
        public List<Bill> GetSearchByTime(DateTime start)
        {
            var l = db.Bills.Where(p => p.TimeThanhToan == start).ToList();
            return l;
        }
        public List<DateTime?> getAllByTime()
        {
            var l = db.Bills.Select(p => p.TimeThanhToan).Distinct().ToList();
            return l;
        }
        public List<string> getAllByCustomer()
        {
            var l = db.Bills.Select(p => p.IdCustomer).Distinct().ToList();
            return l;
        }
        public double Tinhtien(int loai, double distance)
        {
            double sum = 0.0;
            if (distance > 2)
            {
                sum = distance * Convert.ToDouble(QLXe1.Instance.getPrice(loai));
            }
            else
            {
                sum = Convert.ToDouble(QLXe1.Instance.getPriceDuoi2km(loai));
            }
            return sum;
        }
        public bool Add(Bill bill)
        {
            bool check = false;
            try
            {
                db.Bills.Add(bill);
                db.SaveChanges();
                check = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
            return check;

        }
        public List<BillInfo> GetSearchTime(DateTime time)
        {
            var l = db.Bills.Where(s => s.TimeThanhToan == time).Select(s => new BillInfo
            {
                IdBill = s.IdBill,
                IdCar = s.IdCar,
                IdCustomer = s.IdCustomer,
                IdStaff = s.IdStaff,
                GiaThanhToan = s.GiaThanhToan,
                TimeThanhToan = s.TimeThanhToan,
                IdSchedule = s.IdSchedule
            }).ToList();
            return l;
        }
        public List<BillInfo> GetSearchIdCustomer(string idCustomer)
        {
            var l = db.Bills.Where(s => s.IdCustomer == idCustomer).Select(s => new BillInfo
            {
                IdBill = s.IdBill,
                IdCar = s.IdCar,
                IdCustomer = s.IdCustomer,
                IdStaff = s.IdStaff,
                GiaThanhToan = s.GiaThanhToan,
                TimeThanhToan = s.TimeThanhToan,
                IdSchedule = s.IdSchedule
            }).ToList();
            return l;
        }
        public List<BillInfo> GetSearchIdStaff(string idStaff)
        {
            var l = db.Bills.Where(s => s.IdStaff == idStaff).Select(s => new BillInfo
            {
                IdBill = s.IdBill,
                IdCar = s.IdCar,
                IdCustomer = s.IdCustomer,
                IdStaff = s.IdStaff,
                GiaThanhToan = s.GiaThanhToan,
                TimeThanhToan = s.TimeThanhToan,
                IdSchedule = s.IdSchedule
            }).ToList();
            return l;
        }
        public List<BillInfo> GetSearchIdCar(string idCar)
        {
            var l = db.Bills.Where(s => s.IdCar == idCar).Select(s => new BillInfo
            {
                IdBill = s.IdBill,
                IdCar = s.IdCar,
                IdCustomer = s.IdCustomer,
                IdStaff = s.IdStaff,
                GiaThanhToan = s.GiaThanhToan,
                TimeThanhToan = s.TimeThanhToan,
                IdSchedule = s.IdSchedule
            }).ToList();
            return l;
        }

    }
}
