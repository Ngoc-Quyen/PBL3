using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class BaoCao
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static BaoCao instance;

        public static BaoCao Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new BaoCao();
                return instance;
            }
            set => instance = value; 
        }
        private BaoCao()
        {

        }
        public double GetDoanhthuByDay(DateTime time)
        {
            double? doanhthu = Convert.ToDouble( db.Bills.Where(s => s.TimeThanhToan == time).Sum(s => s.GiaThanhToan));
            return (double)doanhthu ;
        }
    }
}
