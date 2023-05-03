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
                if (i.IdStaff == id)
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
                if (Checked(schedule.IdStaff))
                {
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
                    var ac = db.Schedules.FirstOrDefault(p => p.IdStaff == txt);
                    db.Schedules.Remove(ac);
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
    }
}
