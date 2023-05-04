using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class QLLichTrinh
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private QLLichTrinh() { }
        private static QLLichTrinh instance;

        public static QLLichTrinh Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new QLLichTrinh();
                return instance;
            }
            private set => instance = value; 
        }

        public List<Schedule> GetAllSchedule()
        {
            var l = db.Schedules.Select(p => p);
            return l.ToList();
            //var sch = from s in db.Schedules
            //          select new Schedule(s.IdSchedule, s.IdCar, s.IdStaff, 
            //          s.IdCustomer, s.Location, s.DateLocation, s.Destination, s.IdStatus);
            ////select new Schedule 
            ////{ 
            ////    IdSchedule = s.IdSchedule, 
            ////    IdCar = s.IdCar, 
            ////    IdCustomer = s.IdCustomer, 
            ////    IdStaff = s.IdStaff, 
            ////    Location = s.Location, 
            ////    DateLocation = s.DateLocation, 
            ////    Destination = s.Destination, 
            ////    IdStatus = s.IdStatus 
            ////};
            //return sch.ToList();
        }
        public List<Status> GetAllStatus()
        {
            var l = db.Status.Select(p => p);
            return l.ToList();
        }
        public Schedule GetScheduleById(int id)
        {
            Schedule schedule = new Schedule();
            schedule = db.Schedules.Find(id);
            return schedule;
        }

        public Schedule GetScheduleByIdStaff(string IdStaff)
        {
            return db.Schedules.FirstOrDefault(p => p.IdStaff.ToString() == IdStaff);
        }

        public bool Checked(string id)
        {
            bool c = false;
            foreach(Schedule i in GetAllSchedule())
            {
                if (i.IdCustomer == id)
                {
                    c = true;
                }
            }
            return c;
        }

        public void Edit(Schedule schedule)
        {
            try
            {
                if (Checked(schedule.IdCustomer))
                {
                    //var _sch = new Schedule { IdSchedule = schedule.IdSchedule }; // Tạo một đối tượng mới với IdSchedule được chỉ định
                    //db.Schedules.Attach(_sch); // Đính kèm đối tượng mới vào đối tượng db
                    var _sch = db.Schedules.Find(schedule.IdSchedule);
                    _sch.IdSchedule = schedule.IdSchedule;
                    _sch.IdCar = schedule.IdCar;
                    _sch.IdCustomer = schedule.IdCustomer;
                    _sch.IdStaff = schedule.IdStaff;
                    _sch.Location = schedule.Location;
                    _sch.Destination = schedule.Destination;
                    _sch.DateLocation = schedule.DateLocation;
                    _sch.Status = schedule.Status;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Lịch trình không có trong hệ thống!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void Add(Schedule schedule)
        {
            try
            {
                db.Schedules.Add(schedule);
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void Delete(string txt)
        {
            try
            {
                if(Checked(txt))
                {
                    var ac = db.Schedules.FirstOrDefault(p => p.IdCustomer == txt);
                    db.Schedules.Remove(ac);
                    db.SaveChanges();
                    MessageBox.Show("Lịch trình đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Lịch trình không có trong hệ thống!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public List<string> GetColumnValue(string tableName, string columnName)
        {
            var tableType = Type.GetType(tableName);
            var query = from row in db.Set(tableType) as IQueryable<object>
                        select 
                        row.GetType().GetProperty(columnName).GetValue(row, null) != null ?
                        row.GetType().GetProperty(columnName).GetValue(row, null).ToString()
                        : null;
            return query.ToList();
        }
        public List<Schedule> GetSearchByTime(DateTime start)
        {
            var l = db.Schedules.Where(p => p.DateLocation == start).ToList();
            return l; 
        }    
        public List<Schedule> GetSearchByIdStaff(string id)
        {
            var l = db.Schedules.Where(p => p.IdStaff == id).ToList();
            return l;
        }
        public List<Schedule> GetSearchByIdCar(string id)
        {
            var l = db.Schedules.Where(p => p.IdCar == id).ToList();
            return l;
        }
        public List<Schedule> GetSearchByIdCustomer(string id)
        {
            var l = db.Schedules.Where(p => p.IdCustomer == id).ToList();
            return l;
        }
        public List<Schedule> GetSearchByStatus(int id)
        {
            var l = db.Schedules.Where(p => p.IdStatus == id).ToList();
            return l;
        }
        public List<DateTime?> GetAllByDateLocation()
        {
            var l = db.Schedules.Select(p => p.DateLocation).Distinct().ToList();
            return l;
        }
        public List<string> GetAllByCustomer()
        {
            var l = db.Schedules.Select(p => p.IdCustomer).Distinct().ToList();
            return l;
        }    
    }
}
