using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data;
using Entity;

namespace BANHANG
{
    public partial class frmMain : Form
    {

        public static bool bLogin = false;
        public static UserOB obUser=new UserOB();
        public frmMain()
        {
            InitializeComponent();
            obUser = new UserOB();
            setLogin(null, null);
        }
        #region set an hien
        public void setLogin(object sender, EventArgs e)
        {
            toolDoimatkhau.Visible = bLogin;
            toolThoat.Visible = bLogin;
            toolHethong.Enabled = bLogin;
            toolSanpham.Enabled = bLogin;
            toolPayment.Enabled = bLogin;
            toolOrder.Enabled = bLogin;
            toolInv.Enabled = bLogin;
            toolTennguoidung.Text = "Người dùng: " + (obUser != null ? obUser.User_ID + "-" +obUser.User_Name : "");
        }
        #endregion
        public void ShowForm(Form frm)
        {
            if (frm.Name != "frmMain")
            {
                //foreach (Form form in base.MdiChildren)
                //{
                //    if (form.Name.Equals(frm.Name))
                //    {
                //        form.Visible = false;
                //        form.Activate();
                //        form.WindowState = FormWindowState.Maximized;
                //        form.Visible = true;
                //        return;
                //    }
                //}
                frm.WindowState = FormWindowState.Maximized;
                frm.ControlBox = false;
                frm.MdiParent = this;
                frm.Show(); 
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (bLogin == false)
            {
                frmLogin frm = new frmLogin();
                frm.FormClosed += new FormClosedEventHandler(setLogin);
                ShowForm(frm);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi phần mềm\nNhấn OK để thoát khỏi phần mềm Cancel để hủy thao tác", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void toolThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi phần mềm\nNhấn OK để thoát khỏi phần mềm Cancel để hủy thao tác", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bLogin = false;
                obUser = null;
                setLogin(null, null);
                frmLogin frm = new frmLogin();
                frm.FormClosed += new FormClosedEventHandler(setLogin);
                ShowForm(frm);
            } 
        }

        private void toolDoimatkhau_Click(object sender, EventArgs e)
        {
            //frmDoiPassword frm = new frmDoiPassword();
            //frm.ShowDialog();
            //frm.Close();

            //bLogin = false;
            //obUser = null;
            //setLogin(null, null);
            //frmLogin frmLG = new frmLogin();
            //frmLG.FormClosed += new FormClosedEventHandler(setLogin);
            //ShowForm(frmLG);
        }

        //hàm check phân quyền cho tất cả các form
        public static bool checkPhanquyen(string Maquyen)
        {
            bool kq = false;
           // kq = obNguoidung.ObNhomquyen.LisQuyen.Exists(o => o.QuyenID == Maquyen);
            return kq;
        }

        private void toolNguoidung_Click(object sender, EventArgs e)
        {
            //frmUser frm = new frmUser();
            //ShowForm(frm);
        }

        private void toolCategory_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            ShowForm(frm);
        }

        private void toolColor_Click(object sender, EventArgs e)
        {
            frmColor frm = new frmColor();
            ShowForm(frm);
        }

        private void toolConfig_Click(object sender, EventArgs e)
        {
            //frmConfig frm = new frmConfig();
            //ShowForm(frm);
        }

        private void toolSendType_Click(object sender, EventArgs e)
        {
            //frmSendType frm = new frmSendType();
            //ShowForm(frm);
        }

        private void toolModel_Click(object sender, EventArgs e)
        {
            frmModel frm = new frmModel();
            ShowForm(frm);
        }

        private void toolProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            ShowForm(frm);
        }

        private void toolCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            ShowForm(frm);
        }

        private void toolSupplier_Click(object sender, EventArgs e)
        {
            //frmSupplier frm = new frmSupplier();
            //ShowForm(frm);
        }

        private void toolPriceType_Click(object sender, EventArgs e)
        {
            //frmPriceType frm = new frmPriceType();
            //ShowForm(frm);
        }

        private void toolPrice_Click(object sender, EventArgs e)
        {
            //frmPrice frm = new frmPrice();
            //ShowForm(frm);
        }

        private void toolPayment_Click(object sender, EventArgs e)
        {
            //frmPaymentsManage frm = new frmPaymentsManage();
            //ShowForm(frm);
        }

        private void toolOrderNew_Click(object sender, EventArgs e)
        {
            //frmOrder frm = new frmOrder();
            //ShowForm(frm);
        }

        private void toolOrderManage_Click(object sender, EventArgs e)
        {
            //frmOrderManage frm = new frmOrderManage();
            //ShowForm(frm);
        }

        private void toolInputNew_Click(object sender, EventArgs e)
        {
            //frmInput frm = new frmInput();
            //ShowForm(frm);
        }

        private void toolInpurManage_Click(object sender, EventArgs e)
        {
            //frmInputManage frm = new frmInputManage();
            //ShowForm(frm);
        }

        private void toolOutputNew_Click(object sender, EventArgs e)
        {
            //frmOutput frm = new frmOutput();
            //ShowForm(frm);
        }

        private void toolOutputManage_Click(object sender, EventArgs e)
        {
            //frmOutputManage frm = new frmOutputManage();
            //ShowForm(frm);
        }


    }
}
