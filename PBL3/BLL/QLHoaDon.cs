using PBL3.DAL;
using PBL3.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLHoaDon
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static QLHoaDon instance;

        public static QLHoaDon Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLHoaDon();
                return instance;
            }
            private set => instance = value;
        }
        private QLHoaDon()
        {

        }
        public List<Bill> getAllBill()
        {
            return HoaDon.Instance.getAllBill();
        }
        public List<BillInfo> getAllBillInfo()
        {
            return HoaDon.Instance.getAllBillInfos();
        }    
        public List<DateTime?> getAllByTime()
        {
            return HoaDon.Instance.getAllByTime();
        }
        public List<string> getAllByCustomer()
        {
            return HoaDon.Instance.getAllByCustomer();
        }
        public double Tinhtien(int loai, double distance)
        {
            return HoaDon.Instance.Tinhtien(loai, distance);
        }    
        public bool AddBill(Bill bill)
        {
            return HoaDon.Instance.Add(bill);
        }
    }
}
