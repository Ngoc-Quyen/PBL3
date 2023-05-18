using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class CTLTrinh
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private CTLTrinh() { }
        private static CTLTrinh instance;

        public static CTLTrinh Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTLTrinh();
                return instance;
            }
            private set => instance = value;
        }
        public List<Detailed_Schedule> getAllDetailed()
        {
            var l = db.Detailed_Schedule.Select(s => s).ToList();
            return l;
        }
    }
}
