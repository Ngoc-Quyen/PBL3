using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class QLTaiXe
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static QLTaiXe instance;
        public static QLTaiXe Instance 
        {
            get
            {
                if(instance == null)
                    instance = new QLTaiXe();
                return instance;
            }
            private set => instance = value; 
        }
        private QLTaiXe() { }

        public List<Staff> GetAllStaff()
        {
            var data = db.Staffs.Select(p => p);
            return data.ToList();
        } 
        public Staff GetStaffBy(string id)
        {
            Staff st = new Staff();
            st = db.Staffs.Find(id);
            return st;
        }
        public void Add(Staff staff)
        {
            try
            {
                if(Check(staff.IdStaff))
                {
                    MessageBox.Show("Tài xế đã có trong hệ thống!");
                }
                else
                {
                    db.Staffs.Add(staff);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void Edit(Staff st)
        {
            try
            {
                var _staff = db.Staffs.Find(st.IdStaff);
                _staff.IdStaff = st.IdStaff;
                _staff.NameStaff = st.NameStaff;
                _staff.AddressStaff = st.AddressStaff;
                _staff.PhoneStaff = st.PhoneStaff;
                db.SaveChanges();
            }

            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void Delete(string Id)
        {
            try
            {
                if (Check(Id))
                {
                    var st = db.Staffs.Find(Id);
                    db.Staffs.Remove(st);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Xe không có trong hệ thống!");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public List<Staff> GetStaffBySearch(string txt)
        {
            var l = db.Staffs.Where(p => p.IdStaff.Contains(txt)).ToList();
            return l;
        }
        public bool Check(string Id)
        {
            bool c = false;
            foreach (Staff i in GetAllStaff())
            {
                if (i.IdStaff == Id)
                {
                    c = true;
                }
            }
            return c;
        }
    }
}
