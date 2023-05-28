using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    public class ScheduleInfo
    {
        public int IdSchedule { get; set; }
        public string IdCar { get; set; }
        public string IdStaff { get; set; }
        public string IdCustomer { get; set; }
        public string Location { get; set; }
        public DateTime? DateLocation { get; set; }
        public string Destination { get; set; }
        public int? IdStatus { get; set; }
        public int? IdDetailed { get; set; }
    }
}
