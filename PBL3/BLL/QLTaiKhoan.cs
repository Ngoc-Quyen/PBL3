using PBL3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    class QLTaiKhoan
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static QLTaiKhoan instance;

        public static QLTaiKhoan Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new QLTaiKhoan();
                return instance;
            }
            private set => instance = value; 
        }
        private QLTaiKhoan() { }
        public List<Account> GetAllAccount()
        {
            var list = db.Accounts.Select(p => p);
            return list.ToList();
        }
        public Account GetAccountByPrime(string id)  //lấy account theo khóa chính
        {
            Account account = new Account();
            account = db.Accounts.Find(id);
            return account;
        }
        public Account GetAccountBy(string userName)    //lấy account theo thuộc tính, nếu ko tìm thấy trả về giá trị mặc định là null
        {
            return db.Accounts.FirstOrDefault(p => p.UserName == userName);
        }
        public bool Check(string id)
        {
            bool c = false;
            foreach(Account i in GetAllAccount())
            {
                if (id == i.UserName)
                    c = true;
            }    
            return c;
        }
        public void Add(Account ac)
        {
            try
            {
                if(Check(ac.UserName))
                {
                    MessageBox.Show("Tài khoản đã có trong hệ thống!");
                }
                else
                {
                    db.Accounts.Add(ac);
                    db.SaveChanges();
                }    
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void Delete(string id)
        {
            try
            {
                if(Check(id))
                {
                    var ac = db.Accounts.Find(id);
                    db.Accounts.Remove(ac);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Tài khoản không có trong hệ thống!");
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public void Edit(Account ac)
        {
            try
            {
                if(Check(ac.UserName))
                {
                    var _ac = db.Accounts.Find(ac.UserName);
                    _ac.UserName = ac.UserName;
                    _ac.DisplayName = ac.DisplayName;
                    _ac.PassWord = ac.PassWord;
                    _ac.Type = ac.Type;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Tài khoản không có trong hệ thống!");
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public List<Account> GetAccountBySearch(string txt)
        {
            var l = db.Accounts.Where(p => p.UserName.Contains(txt)).ToList();
            return l;
        }

        public List<TypeAccount> GetAllType()
        {
            var l = db.TypeAccounts.Select(p => p);
            return l.ToList();
        }

        void ChangeLogin(int type)
        {
            
                
        }    


    }
}
