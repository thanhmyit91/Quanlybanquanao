﻿using System;
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
using Liblary.Control;
using Data;
using Entity;

namespace BANHANG
{
    public partial class frmModel : Form
    {
        DataTable data;
        ModelOB ob;
        private object[] objKeywords = null;
        public frmModel()
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
                    txtModel_ID.Enabled = true;
                    if (intFormState == FormStateType.EDIT)
                    {
                        txtModel_ID.Enabled = false;
                    }
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
        private void frmModel_Load(object sender, EventArgs e)
        {
            my_ComboBox.SetTitle(cboCategory, Datacache.GetCategoryCache().Copy(), "--Chọn chủng loại--", "Category_ID", "Category_Name");
            my_ComboBox.SetTitle(cboCategorySHR, Datacache.GetCategoryCache().Copy(), "--Chọn chủng loại--", "Category_ID", "Category_Name");
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
            if (txtModel_ID.Text == string.Empty)
            {
                MessageBox.Show("Mã không được rỗng!", "Thông báo");
                txtModel_ID.Focus();
                return;
            }
            if (FormState == FormStateType.ADD && ModelCtr.Check(txtModel_ID.Text.Trim()))
            {
                MessageBox.Show("Mã cấu hình đã tồn tại vui lòng nhập mã cấu hình khác!", "Thông báo");
                txtModel_ID.SelectAll();
                return;
            }
            if (txtModel_Name.Text == string.Empty)
            {
                MessageBox.Show("Tên không được rỗng!", "Thông báo");
                txtModel_Name.Focus();
                return;
            }
            if ((int)cboCategory.SelectedValue <0)
            {
                MessageBox.Show("Vui lòng chọn chủng loại!", "Thông báo");
                cboCategory.Focus();
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
            my_ExportToExcel.Export_GridView(grvDanhsach);
        }
        #endregion end sự kiện

        #region function
        public void LoadData()
        {
            data=new DataTable();
            objKeywords = new object[] { "@Keyword", this.txtTukhoa.Text.Trim(),
                                         "@Model_CategoryID", (int)cboCategorySHR.SelectedValue,
                                         "@IsDelete",chDaxoa.Checked};
            data = ModelCtr.Seach(objKeywords);
            grvDanhsach.DataSource = data;
            FormState = FormStateType.LIST;
        }
        public void ClearValueControl()
        {
            ob = new ModelOB();
            txtModel_ID.Clear();
            cboCategory.SelectedValue = -1;
            txtModel_Name.Clear();
            txtModel_Description.Clear();
            chIsActive.Checked = true;
        }
        private bool EditData()
        {
            bool kq = false;
            try
            {
                ob = new ModelOB();
                ob = ModelCtr.Select(grvDanhsach.CurrentRow.Cells["colModel_ID"].Value.ToString());
                txtModel_ID.Text = ob.Model_ID;
                cboCategory.SelectedValue = ob.Model_CategoryID;
                txtModel_Name.Text = ob.Model_Name;
                txtModel_Description.Text = ob.Model_Description;
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
                ob = new ModelOB();
                ob.Model_ID = txtModel_ID.Text.Trim();
                ob.Model_Name = txtModel_Name.Text.Trim();
                ob.Model_CategoryID = (int)cboCategory.SelectedValue;
                ob.Model_Description = txtModel_Description.Text.Trim();
                ob.IsActive = chIsActive.Checked;
               
                if (FormState == FormStateType.EDIT)
                {
                    
                    ob.ModifiedBy = frmMain.obUser.User_ID;
                    ModelCtr.Update(ob);
                }
                else
                {
                    ob.CreatedBy = frmMain.obUser.User_ID;
                    ModelCtr.Insert(ob);
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
                ob=new ModelOB();
                ob.Model_ID = grvDanhsach.CurrentRow.Cells["colModel_ID"].Value.ToString();
                ob.ModifiedBy = frmMain.obUser.User_ID;
                ModelCtr.Delete(ob);
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
