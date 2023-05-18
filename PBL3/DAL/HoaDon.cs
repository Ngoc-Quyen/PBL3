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
                IdCustomer = s.IdCustomer, IdStaff = s.IdStaff, GiaThanhToan = s.GiaThanhToan,  TimeThanhToan = s.TimeThanhToan}).ToList();
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
    }
}
