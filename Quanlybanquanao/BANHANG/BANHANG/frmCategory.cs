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
using Liblary.Excel;
using Liblary.Common;
using Entity;
using Data;

namespace BANHANG
{
    public partial class frmCategory : Form
    {
        DataTable data;
        CategoryOB ob;
        private object[] objKeywords = null;

        public frmCategory()
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
                    if (grvView.Rows.Count > 0 && grvView.SelectedRows.Count > 0)
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
                }
            }
            get
            {
                return intFormState;
            }
        }

        #endregion

        #region Các sự kiện
        private void frmCategory_Load(object sender, EventArgs e)
        {
            FormState = FormStateType.LIST;
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
            if (grvView.SelectedRows.Count < 0)
                return;
            if (!EditData())
                return;
            FormState = FormStateType.EDIT;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!btnXoa.Enabled)
                return;

            if (grvView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa!","Thông báo");
                return;
            }

            DataRow row = (DataRow)(grvView.DataSource as DataTable).Rows[grvView.CurrentRow.Index];

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
            if (txtCategory_Name.Text == string.Empty)
            {
                MessageBox.Show("Tên không được rỗng!", "Thông báo");
                txtCategory_Name.Focus();
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
        private void btnExcel_Click(object sender, EventArgs e)
        {
            my_ExportToExcel.Export_GridView(grvView);
        }
        #endregion end sự kiện

        #region function
        public void LoadData()
        {
            
            objKeywords = new object[] { "@Keyword", this.txtTukhoa.Text.Trim(),
                                         "@IsDelete",chDaxoa.Checked};
            data = CategoryCtr.Seach(objKeywords);
            grvView.DataSource = data;
            FormState = FormStateType.LIST;
        }
        public void ClearValueControl()
        {
            ob = new CategoryOB();
            txtCategory_Name.Clear();
            txtCategory_Description.Clear();
            chIsActive.Checked = true;
            txtCategory_ID.Clear();
        }
        private bool EditData()
        {
            bool kq = false;
            try
            {
                ob = new CategoryOB();

                ob = CategoryCtr.Select(int.Parse(grvView.CurrentRow.Cells["colCategory_ID"].Value.ToString()));
                txtCategory_ID.Text = ob.Category_ID.ToString();
                txtCategory_Name.Text = ob.Category_Name;
                txtCategory_Description.Text = ob.Category_Description;
                chIsActive.Checked = ob.IsActive;
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
                ob = new CategoryOB();
                ob.Category_Name = txtCategory_Name.Text.Trim();
                ob.Category_Description = txtCategory_Description.Text.Trim();
                ob.IsActive = chIsActive.Checked;
               
                if (FormState == FormStateType.EDIT)
                {
                    ob.Category_ID = int.Parse(txtCategory_ID.Text.Trim());
                    ob.ModifiedBy = frmMain.obUser.User_ID;

                    CategoryCtr.Update(ob);
                }
                else
                {
                    ob.CreatedBy = frmMain.obUser.User_ID;

                    CategoryCtr.Insert(ob);
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
                ob=new CategoryOB();
                ob.Category_ID = int.Parse(grvView.CurrentRow.Cells["colCategory_ID"].Value.ToString());
                ob.ModifiedBy = frmMain.obUser.User_ID;

                CategoryCtr.Delete(ob);
                kq = true;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }
        #endregion end function

        //Bổ sung phần cập nhật thứ tự hiển thị
        private void btnOrderIndex_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            data = CategoryCtr.Cache();
            if (data.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để sắp xếp.\n Phải có ít nhất 2 dòng dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                List<object> lstOrderIndex = null;
                frmOrderIndex frm = new frmOrderIndex();
                frm.InitOrderList(data, "Category_ID", "Category_Name");
                frm.ShowDialog();
                lstOrderIndex = frm.ValueMemberList;
                if (lstOrderIndex.Count > 0)
                {
                    CategoryCtr.Update_Index(lstOrderIndex.ToList());
                    MessageBox.Show("Cập nhật thứ tự thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }
    }
}
