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
using Data;
using Entity;

namespace BANHANG
{
    public partial class frmSupplier : Form
    {
        DataTable data;
        SupplierOB ob;
        private object[] objKeywords = null;

        public frmSupplier()
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
                }
            }
            get
            {
                return intFormState;
            }
        }

        #endregion

        #region Các sự kiện
        private void frmSupplier_Load(object sender, EventArgs e)
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
            if (txtSupplier_Name.Text == string.Empty)
            {
                MessageBox.Show("Tên không được rỗng!", "Thông báo");
                txtSupplier_Name.Focus();
                return;
            }
            if (txtSupplier_Phone.Text == string.Empty)
            {
                MessageBox.Show("Điện thoại không được rỗng!", "Thông báo");
                txtSupplier_Phone.Focus();
                return;
            }
            objKeywords = new object[] { "@Supplier_ID", this.txtSupplier_ID.Text.Trim(),
                                         "@Supplier_Phone",txtSupplier_Phone.Text.Trim(),
                                    };
            if (SupplierCtr.Check(objKeywords))
            {
                MessageBox.Show("Thông tin điện thoại, Email, Facbook, Zalo có đã bị trùng!", "Thông báo");
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
                                         "@IsDelete",chDaxoa.Checked};
            data = SupplierCtr.Seach(objKeywords);
            grvDanhsach.DataSource = data;
            FormState = FormStateType.LIST;
        }
        public void ClearValueControl()
        {
            ob = new SupplierOB();
            txtSupplier_Name.Clear();
            txtSupplier_Address.Clear();
            txtSupplier_Email.Clear();
            txtSupplier_Facbook.Clear();
            txtSupplier_Phone.Clear();
            txtSupplier_Zalo.Clear();
            txtSupplier_Description.Clear();
            chIsActive.Checked = true;
            txtSupplier_ID.Clear();
        }
        private bool EditData()
        {
            bool kq = false;
            try
            {
                ob = new SupplierOB();
                ob = SupplierCtr.Select(grvDanhsach.CurrentRow.Cells["colSupplier_ID"].Value.ToString());
                txtSupplier_ID.Text = ob.Supplier_ID.ToString();
                txtSupplier_Name.Text = ob.Supplier_Name;
                txtSupplier_Address.Text = ob.Supplier_Address;
                txtSupplier_Email.Text = ob.Supplier_Email;
                txtSupplier_Facbook.Text = ob.Supplier_Facbook;
                txtSupplier_Phone.Text = ob.Supplier_Phone.Trim();
                txtSupplier_Zalo.Text = ob.Supplier_Zalo;
                txtSupplier_Description.Text = ob.Supplier_Description;
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
                ob = new SupplierOB();
                ob.Supplier_Name = txtSupplier_Name.Text.Trim();
                ob.Supplier_Address = txtSupplier_Address.Text.Trim();
                ob.Supplier_Email = txtSupplier_Email.Text.Trim();
                ob.Supplier_Facbook = txtSupplier_Facbook.Text.Trim();
                ob.Supplier_Phone = txtSupplier_Phone.Text.Trim();
                ob.Supplier_Zalo = txtSupplier_Zalo.Text.Trim();
                ob.Supplier_Description = txtSupplier_Description.Text.Trim();
                ob.IsActive = chIsActive.Checked;
               
                if (FormState == FormStateType.EDIT)
                {
                    ob.Supplier_ID = txtSupplier_ID.Text.Trim();
                    ob.ModifiedBy = frmMain.obUser.User_ID;
                    SupplierCtr.Update(ob);
                }
                else
                {
                    LibCore lb = new LibCore();
                    ob.Supplier_ID = lb.CreateId("tbl_Supplier");
                    ob.CreatedBy = frmMain.obUser.User_ID;
                    SupplierCtr.Insert(ob);
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
                ob=new SupplierOB();
                ob.Supplier_ID = grvDanhsach.CurrentRow.Cells["colSupplier_ID"].Value.ToString();
                ob.ModifiedBy = frmMain.obUser.User_ID;
                SupplierCtr.Delete(ob);
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
