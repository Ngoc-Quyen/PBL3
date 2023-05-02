using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    internal class QLDangNhap
    {
        TestPbl3Entities db = new TestPbl3Entities();
        private static QLDangNhap instance;

        public static QLDangNhap Instance 
        {
            get
            {
                if(instance == null)
                    instance = new QLDangNhap();
                return instance;
            }
            private set => instance = value; 
        }
        private QLDangNhap() { }
        public List<Account> GetAllAccounts()
        {
            var list = db.Accounts.Select(p => p);
            return list.ToList();
        }
        public Account GetAccountBy(string id)
        {
            Account account = new Account();
            account = db.Accounts.Find(id);
            return account;
        }
        public bool Login(string username, string password)
        {
            var user = db.Accounts.Where(p => p.UserName.Equals(username)).ToList();
            if (user.Count > 0)
            {
                if (user[0].PassWord.Equals(password))
                {
                    //mật khẩu khớp
                    //hiển thị thông báo rồi chuyển form
                    return true;
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
                return false;
            }
            //return false;
        }
    }
}
