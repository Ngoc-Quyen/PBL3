using PBL3.BLL;
using PBL3.DAO;
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
        public List<DetailedInfo> getAllDetailedInfoBy()
        {
            var l = db.Detailed_Schedule.Where(s => s.Complete == 0).Select(s => new DetailedInfo { IdDetailed = s.IdDetailed, Location = s.Location,
            Destination = s.Destination, Distance = s.Distance, Complete = s.Complete}).ToList();
            return l;
        }
        public List<Detailed_Schedule> getAllDetailedBy()
        {
            var l = db.Detailed_Schedule.Where(s => s.Complete == 0).Select(s => s).ToList();
            return l;
        }
        public Detailed_Schedule getDetailed_ScheduleBy(int id)
        {
            Detailed_Schedule detailed_ = new Detailed_Schedule();
            detailed_ = db.Detailed_Schedule.Find(id);
            return detailed_;
        }
        public double DistanceById(int id)
        {
            double? distance = db.Detailed_Schedule.Where(p => p.IdDetailed == id).Select(p => p.Distance).FirstOrDefault();
                
            return (double)distance; ;
        }
    }
}
