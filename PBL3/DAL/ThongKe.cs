using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class ThongKe
    {
        TestPbl3Entities db = new TestPbl3Entities();
        
        private static ThongKe instance;
        private ThongKe() { }

        public static ThongKe Instance 
        { 
            get
            {
                if(instance == null)
                    instance = new ThongKe();
                return instance;
            }
            set => instance = value; 
        }
        public int getCountIdCustomer(DateTime start, DateTime end)
        {
            int count = db.Bills.Where(s => s.TimeThanhToan >= start && s.TimeThanhToan <= end).Select(s => s.IdCustomer).Count();
            return count;
        }
        public double getSumPrice(DateTime start, DateTime end)
        {
            double? total = Convert.ToDouble(db.Bills.Where(s => s.TimeThanhToan >= start && s.TimeThanhToan <= end).Sum(s => s.GiaThanhToan));
            return (double)total;
        }
    }
}
