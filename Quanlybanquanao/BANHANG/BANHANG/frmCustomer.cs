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
    public partial class frmCustomer : Form
    {
        DataTable data;
        CustomerOB ob;
        private object[] objKeywords = null;

        public frmCustomer()
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
        private void frmCustomer_Load(object sender, EventArgs e)
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
            if (txtCustomer_Name.Text == string.Empty)
            {
                MessageBox.Show("Tên không được rỗng!", "Thông báo");
                txtCustomer_Name.Focus();
                return;
            }
            if (txtCustomer_Phone.Text == string.Empty)
            {
                MessageBox.Show("Điện thoại không được rỗng!", "Thông báo");
                txtCustomer_Phone.Focus();
                return;
            }
            
            objKeywords = new object[] { "@Customer_ID", this.txtCustomer_ID.Text.Trim(),
                                         "@Customer_Phone",txtCustomer_Phone.Text.Trim(),
                                    };

            if (CustomerCtr.Check(objKeywords))
            {
                MessageBox.Show("Thông tin điện thoại đã bị trùng!", "Thông báo");
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
            data = CustomerCtr.Seach(objKeywords);
            grvDanhsach.DataSource = data;
            FormState = FormStateType.LIST;
        }
        public void ClearValueControl()
        {
            ob = new CustomerOB();
            txtCustomer_Name.Clear();
            txtCustomer_Address.Clear();
            txtCustomer_Email.Clear();
            txtCustomer_Facbook.Clear();
            txtCustomer_Phone.Clear();
            txtCustomer_Zalo.Clear();
            txtCustomer_Description.Clear();
            chIsActive.Checked = true;
            txtCustomer_ID.Clear();
        }
        private bool EditData()
        {
            bool kq = false;
            try
            {
                ob = new CustomerOB();
                ob = CustomerCtr.Select(grvDanhsach.CurrentRow.Cells["colCustomer_ID"].Value.ToString());
                txtCustomer_ID.Text = ob.Customer_ID.ToString();
                txtCustomer_Name.Text = ob.Customer_Name;
                txtCustomer_Address.Text = ob.Customer_Address;
                txtCustomer_Email.Text = ob.Customer_Email;
                txtCustomer_Facbook.Text = ob.Customer_Facbook;
                txtCustomer_Phone.Text = ob.Customer_Phone.Trim();
                txtCustomer_Zalo.Text = ob.Customer_Zalo;
                txtCustomer_Description.Text = ob.Customer_Description;
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
                ob = new CustomerOB();
                ob.Customer_Name = txtCustomer_Name.Text.Trim();
                ob.Customer_Address = txtCustomer_Address.Text.Trim();
                ob.Customer_Email = txtCustomer_Email.Text.Trim();
                ob.Customer_Facbook = txtCustomer_Facbook.Text.Trim();
                ob.Customer_Phone = txtCustomer_Phone.Text.Trim();
                ob.Customer_Zalo = txtCustomer_Zalo.Text.Trim();
                ob.Customer_Description = txtCustomer_Description.Text.Trim();
                ob.IsActive = chIsActive.Checked;
               
                if (FormState == FormStateType.EDIT)
                {
                    ob.Customer_ID = txtCustomer_ID.Text.Trim();
                    ob.ModifiedBy = frmMain.obUser.User_ID;
                    CustomerCtr.Update(ob);
                }
                else
                {
                    LibCore lb = new LibCore();
                    ob.Customer_ID = lb.CreateId("tbl_Customer");
                    ob.CreatedBy = frmMain.obUser.User_ID;
                    CustomerCtr.Insert(ob);
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
                ob=new CustomerOB();
                ob.Customer_ID = grvDanhsach.CurrentRow.Cells["colCustomer_ID"].Value.ToString();
                ob.ModifiedBy = frmMain.obUser.User_ID;
                CustomerCtr.Delete(ob);
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
