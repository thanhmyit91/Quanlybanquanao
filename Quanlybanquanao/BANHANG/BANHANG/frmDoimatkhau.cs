using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Liblary;
using Liblary.Security;
using Data;
using Entity;

namespace BANHANG
{
    public partial class frmDoimatkhau : Form
    {

        private UserOB ob;
        private string _User_ID;

        public string User_ID
        {
            get { return _User_ID; }
            set { _User_ID = value; }
        }

        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void frmDoimatkhau_Load(object sender, EventArgs e)
        {
            ob = new UserOB();
            ob = UserCtr.Select(_User_ID);
            lblTaikhoan.Text = ob.User_ID.ToUpper();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
           
            if (txtMatkhaumoi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mật khẩu mới không được để rỗng", "Thông báo");
                txtMatkhaumoi.Focus();
                return;
            }
            if (!Lib.CheckStringID(txtMatkhaumoi.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu mới không bao gồm chữ có dấu và khoản trắng", "Thông báo");
                txtMatkhaumoi.Focus();
                return;
            }
            if (txtMatkhaumoi.Text.Trim().Length<6)
            {
                MessageBox.Show("Mật khẩu mới phải lớn hơn hoặc bằng 6 ký tự", "Thông báo");
                txtMatkhaumoi.Focus();
                return;
            }
            ob.User_Pass= my_Security.GetMD5(txtMatkhaumoi.Text.Trim());
            ob.ModifiedBy = frmMain.obUser.User_ID;
            try
            {
                UserCtr.UpdatePasse(ob);
                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
