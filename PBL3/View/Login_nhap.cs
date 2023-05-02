using PBL3.BLL;
using PBL3.DAO;
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
    public partial class Login_nhap : Form
    {
        public Login_nhap()
        {
            InitializeComponent();
        }

        private void ckbpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbpass.Checked == true && txt_Pass.Text != "Nhập Password")
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
            if (ckbpass.Checked == false && txt_Pass.Text != "Nhập Password")
            {
                txt_Pass.UseSystemPasswordChar = true;
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thôngng báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_User.Text;
            string passWord = txt_Pass.Text;
            
            if (CheckLogin(userName, passWord))
            {
                Account loginAccount = QLTaiKhoan.Instance.GetAccountBy(userName);
                QuanLy f = new QuanLy(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            //else
            //{
            //    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            //}
        }
        bool CheckLogin(string userName, string passWord)
        {
            return QLDangNhap.Instance.Login(userName, passWord);
        }
    }
}
