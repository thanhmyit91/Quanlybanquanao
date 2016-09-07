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
    public partial class frmUser : Form
    {
        DataTable data;
        UserOB ob;
        private object[] objKeywords = null;
        
        public frmUser()
        {
            InitializeComponent();
        }

        #region Form Status
        /// <summary>
        /// Các trạng thái của Form
        /// </summary>
        enum FormStateType
        {
            LIST,
            ADD,
            EDIT
        }

        FormStateType intFormState = FormStateType.LIST;
        FormStateType FormState
        {
            set
            {
                intFormState = value;
                if (intFormState == FormStateType.LIST)
                {
                    btnHuy.Enabled = false;
                    btnCapnhat.Enabled = false;
                    btnThem.Enabled = true;
                    if (grvDanhsach.Rows.Count > 0 && grvDanhsach.SelectedRows.Count > 0)
                    {
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                    else
                    {
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                    }
                    tabControl1.SelectedTab = tabDanhsach;
                    
                }
                else if (intFormState == FormStateType.ADD || intFormState == FormStateType.EDIT)
                {
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnCapnhat.Enabled = !ob.IsDelete;
                    tabControl1.SelectedTab = tabChitiet;
                    if (intFormState == FormStateType.EDIT)
                    {
                        txtUser_ID.ReadOnly = true;
                        txtUser_Pass.ReadOnly = true;
                        txtUser_Pass_RQ.ReadOnly = true;
                    }
                    else
                    {
                        txtUser_ID.ReadOnly = false;
                        txtUser_Pass.ReadOnly = false;
                        txtUser_Pass_RQ.ReadOnly = false;
                    }
                  
                }
            }
            get
            {
                return intFormState;
            }
        }

        #endregion

        #region Các sự kiện
        private void frmUser_Load(object sender, EventArgs e)
        {
            //LoadData();
            FormState = FormStateType.LIST;
        }
        private void menuDoimatkhau_Click(object sender, EventArgs e)
        {
            if (grvDanhsach.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để đổi mật khẩu!", "Thông báo");
                return;
            }
            frmDoimatkhau frm = new frmDoimatkhau();
            frm.User_ID=grvDanhsach.CurrentRow.Cells["colUser_ID"].Value.ToString();
            frm.ShowDialog();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!btnThem.Enabled)
                return;
            ClearValueControl();
            FormState = FormStateType.ADD;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!btnSua.Enabled)
                return;
            if (grvDanhsach.SelectedRows.Count < 0)
                return;
            if (!EditData())
                return;
            FormState = FormStateType.EDIT;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!btnXoa.Enabled)
                return;

            if (grvDanhsach.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa!","Thông báo");
                return;
            }

            DataRow row = (DataRow)(grvDanhsach.DataSource as DataTable).Rows[grvDanhsach.CurrentRow.Index];

            if (MessageBox.Show(this, "Bạn có chắc muốn xóa dòng dữ liệu đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                return;
            if (!DeleteData())
                return;
            LoadData();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!btnCapnhat.Enabled)
                return;
            if (txtUser_ID.Text == string.Empty)
            {
                MessageBox.Show("Tài khoản không được rỗng!", "Thông báo");
                txtUser_ID.Focus();
                return;
            }
            if (FormState == FormStateType.ADD && UserCtr.Check(txtUser_ID.Text.Trim()))
            {
                MessageBox.Show("Tài khoản đã tồn tại vui lòng nhập tài khoản khác!", "Thông báo");
                txtUser_ID.SelectAll();
                return;
            }
            if (txtUser_Name.Text == string.Empty)
            {
                MessageBox.Show("Tên không được rỗng!", "Thông báo");
                txtUser_Name.Focus();
                return;
            }
            
            if (!Lib.CheckStringID(txtUser_ID.Text.Trim()))
            {
                MessageBox.Show("Tài khoản nhập vào không bao gồm chữ có dấu và khoản cách!", "Thông báo");
                txtUser_ID.Focus();
                txtUser_ID.SelectAll();
                return;
            }
            if (txtUser_Pass.Text == string.Empty && FormState == FormStateType.ADD)
            {
                MessageBox.Show("Mật khẩu không được rỗng!", "Thông báo");
                txtUser_Pass.Focus();
                return;
            }
            if (!Lib.CheckStringID(txtUser_Pass.Text.Trim()) && FormState == FormStateType.ADD)
            {
                MessageBox.Show("Mật khẩu nhập vào không bao gồm chữ có dấu và khoản cách!", "Thông báo");
                txtUser_Pass.Focus();
                txtUser_Pass.SelectAll();
                return;
            }
            if (txtUser_Pass.Text.Trim().Length < 6 && FormState == FormStateType.ADD)
            {
                MessageBox.Show("Mật khẩu nhập vào phải lớn hơn hoặc bằng 6 ký tự!", "Thông báo");
                txtUser_Pass.Focus();
                return;
            }
            if (txtUser_Pass.Text.Trim() != txtUser_Pass_RQ.Text.Trim() && FormState == FormStateType.ADD)
            {
                MessageBox.Show("Mật khẩu và xác nhận không đúng!", "Thông báo");
                txtUser_Pass_RQ.Clear();
                txtUser_Pass.SelectAll();
                txtUser_Pass.Focus();
                return;
            }
            if (!UpdateData())
                return;
            LoadData();
            FormState = FormStateType.LIST;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.LIST;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabChitiet && FormState == FormStateType.LIST)
            {
                tabControl1.SelectedTab = tabDanhsach;
                
            }
            else if (FormState != FormStateType.LIST)
            {
                tabControl1.SelectedTab = tabChitiet;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grvDanhsach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_Click(null, null);
        }

        private void txtTukhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }
        #endregion end sự kiện

        #region function
        public void LoadData()
        {
            data=new DataTable();
            objKeywords = new object[] { "@Keyword", this.txtTukhoa.Text.Trim(),
                                        "@IsDelete",chDaxoa.Checked};
            data = UserCtr.Seach(objKeywords);
            grvDanhsach.DataSource = data;
            FormState = FormStateType.LIST;
        }
        public void ClearValueControl()
        {
            ob = new UserOB();
            txtUser_Name.Clear();
            chIsActive.Checked = true;
            txtUser_ID.Clear();
            txtUser_Pass.Clear();
            txtUser_Pass_RQ.Clear();
        }
        private bool EditData()
        {
            bool kq = false;
            try
            {
                ob = new UserOB();
                ob = UserCtr.Select(grvDanhsach.CurrentRow.Cells["colUser_ID"].Value.ToString());
                txtUser_Name.Text = ob.User_Name;
                chIsActive.Checked = ob.IsActive;
                txtUser_ID.Text = ob.User_ID;
                txtUser_Pass.Clear();
                txtUser_Pass_RQ.Clear();
                kq = true;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }
        private bool UpdateData()
        {
            bool kq = false;
            try
            {
                ob = new UserOB();
                ob.User_Name = txtUser_Name.Text.Trim();
                ob.IsActive = chIsActive.Checked;
                ob.User_ID = txtUser_ID.Text.Trim();
                if (FormState == FormStateType.EDIT)
                {
                    ob.ModifiedBy = frmMain.obUser.User_ID;
                    UserCtr.Update(ob);
                }
                else
                {
                    ob.User_Pass = my_Security.GetMD5(txtUser_Pass.Text.Trim());
                    ob.CreatedBy = frmMain.obUser.User_ID;
                    UserCtr.Insert(ob);
                }
                kq = true;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }
        private bool DeleteData()
        {
            bool kq = false;
            try
            {
                ob=new UserOB();
                ob.User_ID = grvDanhsach.CurrentRow.Cells["colUser_ID"].Value.ToString();
                ob.ModifiedBy = frmMain.obUser.User_ID;
                UserCtr.Delete(ob);
                kq = true;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }
        #endregion end function

    }
}
