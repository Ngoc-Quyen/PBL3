using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    public class DetailedInfo
    {
        public int IdDetailed { get; set; }
        public string Location { get; set; }
        public string Destination { get; set; }
        public double? Distance { get; set; }
        public int? Complete { get; set; }
    }
}
