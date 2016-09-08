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
    public partial class frmPayments : Form
    {
        PaymentsOB ob;
        CustomerOB obCustomer = null;
        SupplierOB obSupplier = null;

        string strCaption = "";
        private object[] objKeywords = null;

        private string _Payments_ID;

        public string Payments_ID
        {
            get { return _Payments_ID; }
            set { _Payments_ID = value; }
        }

        private int _Payments_Type;

        public int Payments_Type
        {
            get { return _Payments_Type; }
            set
            {
                _Payments_Type = value;
                if (Payments_Type == 0)
                {
                    strCaption = "thu";
                    lbMaKH.Text = "Mã KH:";
                    lbTenKH.Text = "Tên KH:";
                }
                else
                {
                    strCaption = "chi";
                    lbMaKH.Text = "Mã NCC:";
                    lbTenKH.Text = "Tên NCC:";
                }
                this.Text = "Cập nhật phiếu " + strCaption;
                groupThongtin.Text = "Thông tin phiếu " + strCaption;
            }
        }

        public frmPayments()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        #region Các sự kiện
        private void frmPayments_Load(object sender, EventArgs e)
        {
            ob = new PaymentsOB();
            setValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy phiếu " + strCaption + " này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                PaymentsCtr.Delete(ob);
                MessageBox.Show("Hủy hủy phiếu " + strCaption + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;
            getValue();
            if (UpdateData())
            {
                Payments_ID = ob.Payments_ID;
                setValue();
                MessageBox.Show("Cập nhật phiếu " + strCaption + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu " + strCaption + " thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion end sự kiện

        #region function
        private void setValue()
        {
            if (!string.IsNullOrEmpty(Payments_ID))
            {
                ob = PaymentsCtr.Select(Payments_ID);
                Payments_Type = ob.Payments_Type;
                if (ob.Payments_Type == 0)
                {
                    obCustomer = new CustomerOB();
                    obCustomer = CustomerCtr.Select(ob.Payments_CustomerID);
                    txtCustomer_ID.Text = ob.Payments_CustomerID.ToString().Trim();
                    txtCustomer_Name.Text = obCustomer.Customer_Name;
                    txtCustomer_Phone.Text = obCustomer.Customer_Phone;
                    txtCustomer_Email.Text = obCustomer.Customer_Email;
                    txtCustomer_Facbook.Text = obCustomer.Customer_Facbook;
                    txtCustomer_Zalo.Text = obCustomer.Customer_Zalo;
                    txtCustomer_Address.Text = obCustomer.Customer_Address;
                }
                else
                {
                    obSupplier = new SupplierOB();
                    obSupplier = SupplierCtr.Select(ob.Payments_CustomerID);
                    txtCustomer_ID.Text = ob.Payments_CustomerID.ToString().Trim();
                    txtCustomer_Name.Text = obSupplier.Supplier_Name;
                    txtCustomer_Phone.Text = obSupplier.Supplier_Phone;
                    txtCustomer_Email.Text = obSupplier.Supplier_Email;
                    txtCustomer_Facbook.Text = obSupplier.Supplier_Facbook;
                    txtCustomer_Zalo.Text = obSupplier.Supplier_Zalo;
                    txtCustomer_Address.Text = obSupplier.Supplier_Address;
                }
                txtPayments_ID.Text = ob.Payments_ID;
                dtpPayments_Date.Value = (DateTime)ob.Payments_Date;
                txtPayments_Vouchers.Text = ob.Payments_Vouchers;
                txtPayments_Amount.Text = ob.Payments_Amount.ToString("N0");
                txtPayments_Description.Text = ob.Payments_Description;
                txtPayments_Amount.Enabled = false;
                btnXoa.Visible = true;
                btnXoa.Enabled = string.IsNullOrEmpty(ob.Payments_Vouchers) && !ob.IsDelete;
                btnCapnhat.Enabled =  !ob.IsDelete;
                txtPayments_Description.ReadOnly = ob.IsDelete;
                btnSeachKH.Enabled = false;
                btnDeleteCustomer.Enabled = false;
            }
            else
            {
                txtCustomer_ID.Clear();
                txtCustomer_Name.Clear();
                txtCustomer_Phone.Clear();
                txtCustomer_Email.Clear();
                txtCustomer_Facbook.Clear();
                txtCustomer_Zalo.Clear();
                txtCustomer_Address.Clear();

                txtPayments_ID.Clear();
                dtpPayments_Date.Value = DateTime.Now;
                txtPayments_Vouchers.Clear();
                txtPayments_Amount.Text = "0";
                txtPayments_Description.Clear();
                txtPayments_Amount.Enabled = true;
                btnXoa.Visible = false;
                btnCapnhat.Enabled = true;
                txtPayments_Description.ReadOnly = false;
                btnSeachKH.Enabled = true;
                btnDeleteCustomer.Enabled = true;
            }
        }

        private void getValue()
        {
            LibCore lb = null;
            string strCustomer_ID = string.Empty;
            if (Payments_Type == 0)
            {
                if (string.IsNullOrEmpty(txtCustomer_ID.Text.Trim()))
                {

                    obCustomer = new CustomerOB();

                    obCustomer.Customer_Name = txtCustomer_Name.Text.Trim();
                    obCustomer.Customer_Address = txtCustomer_Address.Text.Trim();
                    obCustomer.Customer_Email = txtCustomer_Email.Text.Trim();
                    obCustomer.Customer_Facbook = txtCustomer_Facbook.Text.Trim();
                    obCustomer.Customer_Phone = txtCustomer_Phone.Text.Trim();
                    obCustomer.Customer_Zalo = txtCustomer_Zalo.Text.Trim();
                    lb = new LibCore();
                    strCustomer_ID = lb.CreateId("tbl_Customer");
                    obCustomer.Customer_ID = strCustomer_ID;
                    obCustomer.IsActive = true;
                    obCustomer.CreatedBy = frmMain.obUser.User_ID;
                    CustomerCtr.Insert(obCustomer);
                }
                else
                {
                    strCustomer_ID = txtCustomer_ID.Text.Trim();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCustomer_ID.Text.Trim()))
                {

                    obSupplier = new SupplierOB();

                    obSupplier.Supplier_Name = txtCustomer_Name.Text.Trim();
                    obSupplier.Supplier_Address = txtCustomer_Address.Text.Trim();
                    obSupplier.Supplier_Email = txtCustomer_Email.Text.Trim();
                    obSupplier.Supplier_Facbook = txtCustomer_Facbook.Text.Trim();
                    obSupplier.Supplier_Phone = txtCustomer_Phone.Text.Trim();
                    obSupplier.Supplier_Zalo = txtCustomer_Zalo.Text.Trim();
                    lb = new LibCore();
                    strCustomer_ID = lb.CreateId("tbl_Supplier");
                    obSupplier.Supplier_ID = strCustomer_ID;
                    obSupplier.IsActive = true;
                    obSupplier.CreatedBy = frmMain.obUser.User_ID;
                    SupplierCtr.Insert(obSupplier);
                }
                else
                {
                    strCustomer_ID = txtCustomer_ID.Text.Trim();
                }
            }
            ob.Payments_CustomerID = strCustomer_ID;
            ob.Payments_Type = Payments_Type;

            string strPayments_ID = string.Empty;
            if (string.IsNullOrEmpty(Payments_ID))
            {
                ob.CreatedBy = frmMain.obUser.User_ID;
                lb = new LibCore();
                strPayments_ID = lb.CreateId("tbl_Payments");
            }
            else
            {
                strPayments_ID = Payments_ID;
                ob.ModifiedBy = frmMain.obUser.User_ID;
            }
            ob.Payments_ID = strPayments_ID;
            decimal decPayments_Amount = 0;
            decimal.TryParse(txtPayments_Amount.Text, out decPayments_Amount);
            ob.Payments_Amount = decPayments_Amount;
            ob.Payments_Date = Convert.ToDateTime(dtpPayments_Date.Value);
            ob.Payments_Description = txtPayments_Description.Text.Trim();
        }

        private bool ValidateData()
        {
            if (txtCustomer_Name.Text == string.Empty)
            {
                MessageBox.Show("Tên khách hàng không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomer_Name.Focus();
                return false;
            }
            if (txtCustomer_Phone.Text == string.Empty)
            {
                MessageBox.Show("Điện thoại khách hàng không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomer_Phone.Focus();
                return false;
            }

            if (Payments_Type == 0)
            {
                objKeywords = new object[] { 
                                         "@Customer_Phone",txtCustomer_Phone.Text.Trim()
                                    };

                if (CustomerCtr.Check(objKeywords) && string.IsNullOrEmpty(txtCustomer_ID.Text.Trim()))
                {
                    MessageBox.Show("Thông tin điện thoại đã bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                objKeywords = new object[] { 
                                         "@Supplier_Phone",txtCustomer_Phone.Text.Trim()
                                    };
                if (SupplierCtr.Check(objKeywords) && string.IsNullOrEmpty(txtCustomer_ID.Text.Trim()))
                {
                    MessageBox.Show("Thông tin điện thoại đã bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;

        }
        private bool UpdateData()
        {
            bool bResult = false;

            try
            {
                if (string.IsNullOrEmpty(Payments_ID))
                {
                    PaymentsCtr.Insert(ob);
                }
                else
                {
                    PaymentsCtr.Update(ob);
                }
                bResult = true;
            }
            catch
            {
                bResult = false;
            }
            return bResult;
        }
        private void txtCustomer_ID_TextChanged(object sender, EventArgs e)
        {
            bool boolStatus = !string.IsNullOrEmpty(txtCustomer_ID.Text);
            btnDeleteCustomer.Enabled = boolStatus;
            txtCustomer_ID.ReadOnly = boolStatus;
            txtCustomer_Name.ReadOnly = boolStatus;
            txtCustomer_Phone.ReadOnly = boolStatus;
            txtCustomer_Email.ReadOnly = boolStatus;
            txtCustomer_Facbook.ReadOnly = boolStatus;
            txtCustomer_Zalo.ReadOnly = boolStatus;
            txtCustomer_Address.ReadOnly = boolStatus;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            txtCustomer_ID.Clear();
            txtCustomer_Name.Text = string.Empty;
            txtCustomer_Phone.Text = string.Empty;
            txtCustomer_Email.Text = string.Empty;
            txtCustomer_Facbook.Text = string.Empty;
            txtCustomer_Zalo.Text = string.Empty;
            txtCustomer_Address.Text = string.Empty;
            txtCustomer_Name.Focus();
        }

        private void txtCustomer_Phone_Leave(object sender, EventArgs e)
        {
            if (txtCustomer_Phone.ReadOnly == true)
                return;
            if (Payments_Type == 0)
            {
                objKeywords = new object[] { 
                                         "@Customer_Phone",txtCustomer_Phone.Text.Trim()
                                    };

                if (CustomerCtr.Check(objKeywords))
                {
                    obCustomer = new CustomerOB();
                    obCustomer = CustomerCtr.SelectByPhone(txtCustomer_Phone.Text.Trim());
                    if (!string.IsNullOrEmpty(obCustomer.Customer_ID))
                    {
                        txtCustomer_ID.Text = obCustomer.Customer_ID.ToString().Trim();
                        txtCustomer_Name.Text = obCustomer.Customer_Name;
                        txtCustomer_Phone.Text = obCustomer.Customer_Phone;
                        txtCustomer_Email.Text = obCustomer.Customer_Email;
                        txtCustomer_Facbook.Text = obCustomer.Customer_Facbook;
                        txtCustomer_Zalo.Text = obCustomer.Customer_Zalo;
                        txtCustomer_Address.Text = obCustomer.Customer_Address;
                    }
                    MessageBox.Show("Thông tin của khách hàng đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                objKeywords = new object[] { 
                                         "@Supplier_Phone",txtCustomer_Phone.Text.Trim()
                                    };
                if (SupplierCtr.Check(objKeywords))
                {
                    obSupplier = new SupplierOB();
                    obSupplier = SupplierCtr.SelectByPhone(txtCustomer_Phone.Text.Trim());
                    if (!string.IsNullOrEmpty(obSupplier.Supplier_ID))
                    {
                        txtCustomer_ID.Text = obSupplier.Supplier_ID.ToString().Trim();
                        txtCustomer_Name.Text = obSupplier.Supplier_Name;
                        txtCustomer_Phone.Text = obSupplier.Supplier_Phone;
                        txtCustomer_Email.Text = obSupplier.Supplier_Email;
                        txtCustomer_Facbook.Text = obSupplier.Supplier_Facbook;
                        txtCustomer_Zalo.Text = obSupplier.Supplier_Zalo;
                        txtCustomer_Address.Text = obSupplier.Supplier_Address;
                    }
                    MessageBox.Show("Thông tin của khách hàng đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion end function

        private void txtPayments_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

        private void txtPayments_Amount_Leave(object sender, EventArgs e)
        {
            decimal decPayments_Amount = 0;
            decimal.TryParse(txtPayments_Amount.Text, out decPayments_Amount);
            txtPayments_Amount.Text = decPayments_Amount.ToString("n0");
            if (decPayments_Amount < 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền lớn hơn hoặc 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPayments_Amount.Text = "0";
                txtPayments_Amount.Focus();
                txtPayments_Amount.SelectAll();
            }
        }

        private void btnSeachKH_Click(object sender, EventArgs e)
        {
            if (Payments_Type == 0)
            {
                frmCustomer_Use frm = new frmCustomer_Use();
                frm.ShowDialog();
                getCustomer(frm.CustomerID);
            }
            else
            {
                frmSupplier_Use frm = new frmSupplier_Use();
                frm.ShowDialog();
                getCustomer(frm.SupplierID);
            }
        }

        private void getCustomer(string strCustomerID)
        {
            if (strCustomerID == string.Empty)
                return;
            if (Payments_Type == 0)
            {
                obCustomer = new CustomerOB();
                obCustomer = CustomerCtr.Select(strCustomerID);
                if (!string.IsNullOrEmpty(obCustomer.Customer_ID))
                {
                    txtCustomer_ID.Text = obCustomer.Customer_ID.ToString().Trim();
                    txtCustomer_Name.Text = obCustomer.Customer_Name;
                    txtCustomer_Phone.Text = obCustomer.Customer_Phone;
                    txtCustomer_Email.Text = obCustomer.Customer_Email;
                    txtCustomer_Facbook.Text = obCustomer.Customer_Facbook;
                    txtCustomer_Zalo.Text = obCustomer.Customer_Zalo;
                    txtCustomer_Address.Text = obCustomer.Customer_Address;
                }
            }
            else
            {
                obSupplier = new SupplierOB();
                obSupplier = SupplierCtr.Select(strCustomerID);
                if (!string.IsNullOrEmpty(obSupplier.Supplier_ID))
                {
                    txtCustomer_ID.Text = obSupplier.Supplier_ID.ToString().Trim();
                    txtCustomer_Name.Text = obSupplier.Supplier_Name;
                    txtCustomer_Phone.Text = obSupplier.Supplier_Phone;
                    txtCustomer_Email.Text = obSupplier.Supplier_Email;
                    txtCustomer_Facbook.Text = obSupplier.Supplier_Facbook;
                    txtCustomer_Zalo.Text = obSupplier.Supplier_Zalo;
                    txtCustomer_Address.Text = obSupplier.Supplier_Address;
                }
            }
        }
    }
}
