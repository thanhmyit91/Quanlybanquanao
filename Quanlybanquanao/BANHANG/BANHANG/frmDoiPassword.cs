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
    public partial class frmDoiPassword : Form
    {
        UserOB ob;
        public frmDoiPassword()
        {
            InitializeComponent();
        }

        private void frmDoiPassword_Load(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (my_Security.GetMD5(txtMatKhauCu.Text.Trim()) != BANHANG.frmMain.obUser.User_Pass)
            {
                lblThongBao.Visible = true;
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                lblThongBao.Text = "Mật khẩu cũ không chính xác.";
                return;
            }
            if (txtMatKhauMoi.Text.Trim() == string.Empty)
            {
                lblThongBao.Visible = true;
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                lblThongBao.Text = "Mật khẩu mới không được rỗng.";
                txtMatKhauMoi.Focus();
                txtMatKhauMoi.SelectAll();
                return;
            }
            if (!Lib.CheckStringID(txtMatKhauMoi.Text.Trim()))
            {
                lblThongBao.Visible = true;
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                lblThongBao.Text = "Mật khẩu mới không đúng định dạng.";
                txtMatKhauMoi.Focus();
                txtMatKhauMoi.SelectAll();
                return;
            }
            if (txtMatKhauMoi.Text.Trim().Length<6)
            {
                lblThongBao.Visible = true;
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                lblThongBao.Text = "Mật khẩu mới phải lớn hơn hoặc bằng 6 ký tự.";
                return;
            }
            if (txtMatKhauMoi.Text.Trim() != txtXacNhan.Text.Trim())
            {
                lblThongBao.Visible = true;
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                lblThongBao.Text = "Mật khẩu mới và xác nhận không khớp.";
                txtMatKhauMoi.Text = "";
                txtXacNhan.Text = "";
                txtMatKhauMoi.Focus();
                return;
            }
            try
            {
                ob = new UserOB();
                ob = BANHANG.frmMain.obUser;
                ob.User_Pass = my_Security.GetMD5(txtMatKhauMoi.Text.Trim());
                UserCtr.UpdatePasse(ob);
                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
