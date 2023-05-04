using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class ThongTinCaNhan : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount);
            }
        }
        static Admin1 admin = new Admin1();
        public ThongTinCaNhan(Account acc)
        {
            InitializeComponent();
            //cbAccountType_Show();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUserName.Text = loginAccount.UserName;
            txtDisplayName.Text = loginAccount.DisplayName;

        }
        //public void cbAccountType_Show()
        //{
        //    cbAccountType.DataSource = QLTaiKhoan.Instance.GetAllType();
        //    cbAccountType.DisplayMember = "NameType";
        //    cbAccountType.ValueMember = "IdType";
        //}

        private void btSaveTT_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.UserName = txtUserName.Text;
            ac.DisplayName = txtDisplayName.Text;
            ac.PassWord = txtPassWordNew.Text;
            //ac.Type = cbAccountType.SelectedIndex;
            QLTaiKhoan.Instance.Edit(ac);
            MessageBox.Show("Bạn đã cập nhật thành công!");
            this.Hide();
        }

        private void btExitTT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
