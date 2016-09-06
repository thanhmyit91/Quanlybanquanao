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
using Liblary.Control;
using Data;
using Entity;

namespace BANHANG
{
    public partial class frmProduct : Form
    {
        DataTable data;
        ProductOB ob;
        private object[] objKeywords = null;

        public frmProduct()
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
                    txtProduct_ID.Enabled = true;
                    if (intFormState == FormStateType.EDIT)
                    {
                        txtProduct_ID.Enabled = false;
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
        private void frmProduct_Load(object sender, EventArgs e)
        {
            my_ComboBox.SetTitle(cboProduct_ModelIDSHR, Datacache.GetModelCache().Copy(), "--Chọn model--", "Model_ID", "Model_Name");
            my_ComboBox.SetTitle(cboProduct_ModelID, Datacache.GetModelCache().Copy(), "--Chọn model--", "Model_ID", "Model_Name");
            my_ComboBox.SetTitle(cboProduct_ColorIDSHR, Datacache.GetColorCache().Copy(), "--Chọn màu sắc--", "Color_Id", "Color_Name");
            my_ComboBox.SetTitle(cboProduct_ColorID, Datacache.GetColorCache().Copy(), "--Chọn màu sắc--", "Color_Id", "Color_Name");
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
            if (txtProduct_ID.Text == string.Empty)
            {
                MessageBox.Show("Mã không được rỗng!", "Thông báo");
                txtProduct_ID.Focus();
                return;
            }
            if (FormState == FormStateType.ADD && ProductCtr.Check(txtProduct_ID.Text.Trim()))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại vui lòng nhập mã sản phẩm khác!", "Thông báo");
                txtProduct_ID.SelectAll();
                return;
            }
            if (txtProduct_Name.Text == string.Empty)
            {
                MessageBox.Show("Tên không được rỗng!", "Thông báo");
                txtProduct_Name.Focus();
                return;
            }
            if (cboProduct_ModelID.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Vui lòng chọn model sản phẩm!", "Thông báo");
                cboProduct_ModelID.Focus();
                return;
            }
            if ((int)cboProduct_ColorID.SelectedValue == -1)
            {
                MessageBox.Show("Vui lòng chọn màu sắc sản phẩm!", "Thông báo");
                cboProduct_ColorID.Focus();
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
                                         "@Product_ColorID", (int)cboProduct_ColorIDSHR.SelectedValue,
                                         "@Product_ModelID", cboProduct_ModelIDSHR.SelectedValue.ToString(),
                                         "@IsDelete",chDaxoa.Checked};
            data = ProductCtr.Seach(objKeywords);
            grvDanhsach.DataSource = data;
            FormState = FormStateType.LIST;
        }
        public void ClearValueControl()
        {
            ob = new ProductOB();
            txtProduct_Name.Clear();
            txtProduct_Description.Clear();
            chIsActive.Checked = true;
            txtProduct_ID.Clear();
            cboProduct_ColorID.SelectedValue = -1;
            cboProduct_ModelID.SelectedValue = "-1";
        }
        private bool EditData()
        {
            bool kq = false;
            try
            {
                ob = new ProductOB();
                ob = ProductCtr.Select(grvDanhsach.CurrentRow.Cells["colProduct_ID"].Value.ToString());
                txtProduct_ID.Text = ob.Product_ID.ToString();
                txtProduct_Name.Text = ob.Product_Name;
                cboProduct_ColorID.SelectedValue = ob.Product_ColorID;
                cboProduct_ModelID.SelectedValue = ob.Product_ModelID;
                txtProduct_Description.Text = ob.Product_Description;
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
                ob = new ProductOB();
                ob.Product_ID = txtProduct_ID.Text.Trim();
                ob.Product_Name = txtProduct_Name.Text.Trim();
                ob.Product_ModelID = cboProduct_ModelID.SelectedValue.ToString();
                ob.Product_ColorID = (int)cboProduct_ColorID.SelectedValue;
                ob.Product_Description = txtProduct_Description.Text.Trim();
                ob.IsActive = chIsActive.Checked;
               
                if (FormState == FormStateType.EDIT)
                {
                    
                    ob.ModifiedBy = frmMain.obUser.User_ID;
                    ProductCtr.Update(ob);
                }
                else
                {
                    ob.CreatedBy = frmMain.obUser.User_ID;
                    ProductCtr.Insert(ob);
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
                ob=new ProductOB();
                ob.Product_ID = grvDanhsach.CurrentRow.Cells["colProduct_ID"].Value.ToString();
                ob.ModifiedBy = frmMain.obUser.User_ID;
                ProductCtr.Delete(ob);
                kq = true;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }
        #endregion end function

        private void txtProduct_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

        private void txtProduct_Price1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

       

    }
}
