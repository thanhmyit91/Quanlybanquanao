using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Liblary.Security;
using Data;
using Entity;

namespace BANHANG
{
    public partial class frmLogin : Form
    {
        UserOB ob;
        private object[] objKeywords = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
        private void dangnhap()
        {
            ob = new UserOB();
            objKeywords = new object[] { "@User_ID", txtTaikhoan.Text.Trim(),
                                         "@User_Pass",my_Security.GetMD5(txtMatkhau.Text.Trim())};

            ob = UserCtr.Login(objKeywords);
            if (ob.User_ID == string.Empty)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai! vui lòng kiểm tra lại.", "Thông báo");
                txtTaikhoan.Focus();
                txtTaikhoan.SelectAll();
                return;
            }
            else
            {
                BANHANG.frmMain.obUser = ob;
                BANHANG.frmMain.bLogin = true;
                frmMain frmMain = (frmMain)base.MdiParent;
                base.Close();
            }
            frmMain frm = (frmMain)base.MdiParent;
            base.Close();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //WSBanquyen.BanquyenSW bq = new WSBanquyen.BanquyenSW();
            //MessageBox.Show(bq.HelloWorld().ToString());
        }

        private void txtMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangnhap();
            }
        }

        private void txtTaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangnhap();
            }
        }
    }
}
