using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    public class BillInfo
    {
        public int IdBill { get; set; }
        public string IdCar { get; set; }
        public string IdCustomer { get; set; }
        public string IdStaff { get; set; }
        public decimal? GiaThanhToan { get; set; }
        public DateTime? TimeThanhToan { get; set; }
    }
}
