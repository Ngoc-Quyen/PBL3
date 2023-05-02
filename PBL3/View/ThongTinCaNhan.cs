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
        Admin1 admin = new Admin1();
        public ThongTinCaNhan()
        {
            InitializeComponent();
            cbAccountType_Show();
        }
        public void cbAccountType_Show()
        {
            cbAccountType.DataSource = QLTaiKhoan.Instance.GetAllType();
            cbAccountType.DisplayMember = "NameType";
            cbAccountType.ValueMember = "IdType";
        }

        private void btSaveTT_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.UserName = txtUserName.Text;
            ac.DisplayName = txtDisplayName.Text;
            ac.PassWord = txtPassWordNew.Text;
            ac.Type = cbAccountType.SelectedIndex;
            QLTaiKhoan.Instance.Edit(ac);
            admin.LoadAccount();
            MessageBox.Show("Bạn đã cập nhật thành công!");
            this.Close();
        }

        private void btExitTT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
