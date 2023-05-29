
using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLThongKe
    {
        TestPbl3Entities db = new TestPbl3Entities();

        private static QLThongKe instance;
        private QLThongKe() { }

        public static QLThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLThongKe();
                return instance;
            }
            set => instance = value;
        }
        public int GetCountIdCustomer(DateTime start, DateTime end)
        {
            return ThongKe.Instance.getCountIdCustomer(start, end);
        }
        public double GetTotalPrice(DateTime start, DateTime end)
        {
            return ThongKe.Instance.getSumPrice(start, end);
        }
    }
}
