using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.DAO
{
    class DataProvider
    {
        private static DataProvider instance;
        private TestPbl3Entities1 db = new TestPbl3Entities1();

        public static DataProvider Instance 
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set => instance = value; 
        }
        private DataProvider() { }
        public bool Login(string username, string password)
        {
            var user = db.Accounts.Where(p => p.UserName.Equals(username)).ToList();
            if(user.Count > 0 )
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
