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
    public partial class frmInput : Form
    {
        InputOB obInput;
        List<InputDetailOB> lstDetailInput = new List<InputDetailOB>();
        SupplierOB obSupplier = null;
        PaymentsOB obPayments = null;
        private object[] objKeywords = null;

        public frmInput()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
        private string _ProductID=string.Empty;

        public string ProductID
        {
            get { return _ProductID; }
            set 
            {
                _ProductID = value;
                if (!Order_Lib.CheckProduct(_ProductID))
                {
                    MessageBox.Show("Mã sản phẩm không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                addProduct(_ProductID);
            }
        }

        private string _InputID = string.Empty;

        public string InputID
        {
            get { return _InputID; }
            set 
            { 
                _InputID = value;
                groupThongtin.Text = "Thông tin phiếu nhập " + _InputID.Trim();
            }
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            obInput = new InputOB();
            setValue();
            ucProductsSelect.IsQuantity = -1;
        }

        //private void btnSeachProduct_Click(object sender, EventArgs e)
        //{
        //    //this.ProductID = txtProduct.Text.Trim();
        //}

        //private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (txtProduct.Text == string.Empty)
        //        {
        //            MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //        this.ProductID = txtProduct.Text.Trim().ToUpper();
        //    }
        //}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            toolXoa.Enabled = grvInputdetail.Focused && grvInputdetail.RowCount > 0 && grvInputdetail.SelectedRows.Count > 0;
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            if (grvInputdetail.SelectedRows.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            InputDetailOB ob = (InputDetailOB)grvInputdetail.CurrentRow.DataBoundItem;
            delProduct(ob);
        }

        private void grvInputdetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            InputDetailOB ob = (InputDetailOB)grvInputdetail.CurrentRow.DataBoundItem;
            //ob.InputDetail_Total = ob.InputDetail_Quantity * ob.InputDetail_Price;

            if (ob.Flat == -1)
            {
                ob.Flat = 1;
            }
            Total(ob);
            grvInputdetail.Refresh();
            SumTotal();
        }
        #region Load control
        //Load dữ liệu combobox
        #endregion
        #region Function
        //Kiêu 0, lay theo sỉ, 1 lấy theo lẻ
        private void addProduct(string ProductID)
        {
            if (lstDetailInput != null && lstDetailInput.Count(o => o.InputDetail_ProductID == ProductID) > 0)
            {
                var found = lstDetailInput.FirstOrDefault(c => c.InputDetail_ProductID == ProductID);
                found.InputDetail_Quantity++;
                if (found.Flat == -1)
                {
                    found.Flat = 1;
                }
                if (found.Flat == 2)
                {
                    found.Flat = 1;
                    found.InputDetail_Quantity = 1;
                }
                Total(found);
            }

            else
            {
                DataTable dtProduct = new DataTable();
                dtProduct = Datacache.GetProductCache().Copy();
                string expression = "Product_ID = '" + ProductID + "'";
                DataRow row = dtProduct.Select(expression).FirstOrDefault();
                InputDetailOB obDetailAdd = new InputDetailOB();
                obDetailAdd.Flat = 0;
                if (!Convert.IsDBNull(row["Color_Name"])) obDetailAdd.Color_Name = Convert.ToString(row["Color_Name"]).Trim();
                if (!Convert.IsDBNull(row["Product_Name"])) obDetailAdd.Product_Name = Convert.ToString(row["Product_Name"]).Trim();
                if (!Convert.IsDBNull(row["Product_ID"])) obDetailAdd.InputDetail_ProductID = Convert.ToString(row["Product_ID"]).Trim();
                obDetailAdd.InputDetail_Price = 0;
                obDetailAdd.InputDetail_Quantity = 1;
                Total(obDetailAdd);
                lstDetailInput.Add(obDetailAdd);
            }
            grvInputdetail.DataSource = lstDetailInput.ToArray();
            grvInputdetail.Refresh();
            SumTotal();
        }
        private void delProduct(InputDetailOB ob)
        {
            if (ob.Flat != 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ob.Flat = 2;

                }
            }
            else
            {
                lstDetailInput.Remove(ob);
            }
            grvInputdetail.DataSource = lstDetailInput;
            grvInputdetail.Refresh();
            SumTotal();
        }
        private void Total(InputDetailOB ob)
        {
            ob.InputDetail_Total = ob.InputDetail_Quantity * ob.InputDetail_Price;
        }
        private void SumTotal()
        {
            decimal decTien = lstDetailInput.Sum(o => o.Flat != 2 ? o.InputDetail_Total : 0);
            int intInput_VAT = 0;
            int.TryParse(txtInput_VAT.Text, out intInput_VAT);

            decimal decInput_SaleMoney = 0;
            decimal.TryParse(txtInput_SaleMoney.Text, out decInput_SaleMoney);

            obInput.Input_Total = decTien;
            txtInput_TotalVAT.Text = (decTien + (decTien * (intInput_VAT / 100)) - decInput_SaleMoney).ToString("N0");
        }

        private void setValue()
        {
            if (!string.IsNullOrEmpty(InputID))
            {
                obInput = InputCtr.Select(InputID);
                obSupplier = new SupplierOB();
                obSupplier = SupplierCtr.Select(obInput.Input_SupplierID);
                txtCustomer_ID.Text = obInput.Input_SupplierID.ToString().Trim();
                txtCustomer_Name.Text = obSupplier.Supplier_Name;
                txtCustomer_Phone.Text = obSupplier.Supplier_Phone;
                txtCustomer_Email.Text = obSupplier.Supplier_Email;
                txtCustomer_Facbook.Text = obSupplier.Supplier_Facbook;
                txtCustomer_Zalo.Text = obSupplier.Supplier_Zalo;
                txtCustomer_Address.Text = obSupplier.Supplier_Address;

                chkInput_IsVoucher.Checked = obInput.Input_IsVoucher == 1;
                lstDetailInput = obInput.LstInputDetail.ToList();
                grvInputdetail.DataSource = lstDetailInput.ToArray();
                txtInput_VAT.Text = obInput.Input_VAT.ToString();
                txtInput_SaleMoney.Text = obInput.Input_SaleMoney.ToString("n0");
                txtInput_TotalVAT.Text = obInput.Input_TotalVAT.ToString("N0");
                txtInput_Description.Text = obInput.Input_Description;
                
                dtpInput_Date.Value = (DateTime)obInput.Input_Date;
                dtpInput_Date.Enabled = false;

                btnXoa.Visible = true;
                btnThutien.Visible = true;
                btnSeachKH.Enabled = false;

                btnXoa.Enabled = obInput.IsDelete == false  && obInput.Input_IsVoucher == 0 && !string.IsNullOrEmpty(obInput.Input_ID);
                btnThutien.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0 && !string.IsNullOrEmpty(obInput.Input_ID);
                btnCapnhat.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0;
                btnDeleteCustomer.Enabled = false;
                contextMenuStrip1.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0;
                //txtProduct.Enabled = obInput.IsDelete == 0 && obInput.Input_IsVoucher == 0 && !string.IsNullOrEmpty(obInput.Input_ID) && obInput.Input_IsOutput == 0;
                grvInputdetail.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0 && !string.IsNullOrEmpty(obInput.Input_ID);
                txtInput_SaleMoney.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0 && !string.IsNullOrEmpty(obInput.Input_ID);
                txtInput_Description.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0 && !string.IsNullOrEmpty(obInput.Input_ID);
                txtInput_VAT.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0 && !string.IsNullOrEmpty(obInput.Input_ID);
                btnSelectProduct.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0;
                ucProductsSelect.Enabled = obInput.IsDelete == false && obInput.Input_IsVoucher == 0;
            }
            else
            {
                txtCustomer_ID.Text = string.Empty;
                txtCustomer_Name.Text = string.Empty;
                txtCustomer_Phone.Text = string.Empty;
                txtCustomer_Email.Text = string.Empty;
                txtCustomer_Facbook.Text = string.Empty;
                txtCustomer_Zalo.Text = string.Empty;
                txtCustomer_Address.Text = string.Empty;

                chkInput_IsVoucher.Checked = false;
                lstDetailInput = new List<InputDetailOB>();
                grvInputdetail.DataSource = lstDetailInput.ToArray();

                txtInput_VAT.Text = "0";
                txtInput_SaleMoney.Text = "0";
                txtInput_TotalVAT.Text = "0";
                txtInput_Description.Text = string.Empty;
                dtpInput_Date.Value = DateTime.Now;
                dtpInput_Date.Enabled = true;

                txtInput_SaleMoney.Enabled = true;
                txtInput_Description.Enabled = true;
                txtInput_VAT.Enabled = true;

                btnXoa.Visible = false;
                btnThutien.Visible = false;
                btnCapnhat.Enabled = true;
                contextMenuStrip1.Enabled = true;
                //txtProduct.Enabled = true;

                btnSelectProduct.Enabled = true;
                ucProductsSelect.Enabled = true;
                btnSeachKH.Enabled = true;

            }
           // txtProduct.Clear();
            
        }
        private void getValue()
        {
            obInput = new InputOB();
            obInput.LstInputDetail = lstDetailInput;
            obInput.Input_Date = Convert.ToDateTime(dtpInput_Date.Value);
            obInput.Input_Description = txtInput_Description.Text.Trim();

            decimal decTien = lstDetailInput.Sum(o => o.Flat != 2 ? o.InputDetail_Total : 0);
            obInput.Input_Total = decTien;

            decimal decInput_TotalVAT = 0;
            decimal.TryParse(txtInput_TotalVAT.Text, out decInput_TotalVAT);
            obInput.Input_TotalVAT = decInput_TotalVAT;

            int intInput_VAT = 0;
            int.TryParse(txtInput_VAT.Text, out intInput_VAT);
            obInput.Input_VAT = intInput_VAT;

            decimal decInput_SaleMoney = 0;
            decimal.TryParse(txtInput_SaleMoney.Text, out decInput_SaleMoney);
            obInput.Input_SaleMoney = decInput_SaleMoney;

            LibCore lb = null;
            string strSupplier_ID = string.Empty;
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
                strSupplier_ID = lb.CreateId("tbl_Supplier");
                obSupplier.Supplier_ID = strSupplier_ID;
                obSupplier.IsActive = true;
                obSupplier.CreatedBy = frmMain.obUser.User_ID;
                SupplierCtr.Insert(obSupplier);
            }
            else
            {
                strSupplier_ID = txtCustomer_ID.Text.Trim();
            }



            obInput.Input_SupplierID = strSupplier_ID;

            string strInput_ID = string.Empty;
            if (string.IsNullOrEmpty(InputID))
            {
                obInput.CreatedBy = frmMain.obUser.User_ID;
                lb = new LibCore();
                strInput_ID = lb.CreateId("tbl_Input");
            }
            else
            {
                strInput_ID = InputID;
                obInput.ModifiedBy = frmMain.obUser.User_ID;
            }
            obInput.Input_ID = strInput_ID;
        }
        private bool ValidateData()
        {
            if (txtCustomer_Name.Text == string.Empty)
            {
                MessageBox.Show("Tên nhà cung cấp không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomer_Name.Focus();
                return false;
            }
            if (txtCustomer_Phone.Text == string.Empty)
            {
                MessageBox.Show("Điện thoại nhà cung cấp không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomer_Phone.Focus();
                return false;
            }

            objKeywords = new object[] { 
                                         "@Supplier_Phone",txtCustomer_Phone.Text.Trim()
                                    };

            if (SupplierCtr.Check(objKeywords) && string.IsNullOrEmpty(txtCustomer_ID.Text.Trim()))
            {
                MessageBox.Show("Thông tin điện thoại đã bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (lstDetailInput.Count(o => o.Flat != 2) == 0)
            {
                MessageBox.Show("Phiếu nhập phải có ít nhất 1 sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal decInput_TotalVAT = 0;
            decimal.TryParse(txtInput_TotalVAT.Text, out decInput_TotalVAT);
            if (decInput_TotalVAT < 0)
            {
                MessageBox.Show("Phiếu nhập phải có tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ((DateTime)dtpInput_Date.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian nhập không được lơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private bool UpdateData()
        {
            bool bResult = false;

            try
            {
                if (string.IsNullOrEmpty(InputID))
                {
                    InputCtr.Insert(obInput);
                }
                else
                {
                    InputCtr.Update(obInput);
                }
                bResult = true;
            }
            catch
            {
                bResult = false;
            }
            return bResult;
        }

        #endregion

        private void grvInputdetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            grvInputdetail.Rows[e.RowIndex].ErrorText = "";
            if (grvInputdetail.Rows[e.RowIndex].IsNewRow) { return; }
            if (grvInputdetail.Columns[e.ColumnIndex].Name == "colInputDetail_Quantity")
            {
                int newInteger;
                if (!int.TryParse(e.FormattedValue.ToString(),out newInteger))
                {
                    e.Cancel = true;
                    grvInputdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng đúng định dạng số!";
                    MessageBox.Show("Vui lòng nhập số lượng đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newInteger < 1)
                {
                    e.Cancel = true;
                    grvInputdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng lớn hơn 0!";
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (grvInputdetail.Columns[e.ColumnIndex].Name == "colInputDetail_Price")
            {
                decimal newDecimal;
                if (!decimal.TryParse(e.FormattedValue.ToString(), out newDecimal))
                {
                    e.Cancel = true;
                    grvInputdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập đơn giá đúng định dạng số!";
                    MessageBox.Show("Vui lòng nhập đơn giá đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newDecimal <0)
                {
                    e.Cancel = true;
                    grvInputdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập đơn giá lớn hơn 0!";
                    MessageBox.Show("Vui lòng nhập đơn giá lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void grvInputdetail_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            InputDetailOB ob = new InputDetailOB();
            ob = (InputDetailOB)grvInputdetail.Rows[e.RowIndex].DataBoundItem;
            if (ob.Flat == 2)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[grvInputdetail.DataSource];
                currencyManager1.SuspendBinding();
                grvInputdetail.Rows[e.RowIndex].Visible = false;
                currencyManager1.ResumeBinding();
            }
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

        private void txtInput_SaleMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

        private void txtInput_VAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

        private void txtInput_VAT_Leave(object sender, EventArgs e)
        {
            int intInput_VAT = 0;
            int.TryParse(txtInput_VAT.Text, out intInput_VAT);
            txtInput_VAT.Text = intInput_VAT.ToString();
            SumTotal();
        }

        private void txtInput_SaleMoney_Leave(object sender, EventArgs e)
        {
            decimal decInput_SaleMoney = 0;
            decimal.TryParse(txtInput_SaleMoney.Text, out decInput_SaleMoney);
            txtInput_SaleMoney.Text = decInput_SaleMoney.ToString("n0");
            SumTotal();

        }

        private void txtCustomer_Phone_Leave(object sender, EventArgs e)
        {
            if (txtCustomer_Phone.ReadOnly == true)
                return;
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
                MessageBox.Show("Thông tin của nhà cung cấp đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;
            getValue();
            if (UpdateData())
            {
                InputID = obInput.Input_ID;
                setValue();
                MessageBox.Show("Cập nhật phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy thao tác trên đơn hàng!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                setValue();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy phiếu nhập này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                InputCtr.Delete(obInput);
                MessageBox.Show("Hủy phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }       
        }

        private void btnThutien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn tạo phiếu chi. \nSau khi chi phiếu nhập sẽ không được phép sửa và xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                obPayments = new PaymentsOB();

                LibCore lb = null;
                string strPayments_ID = string.Empty;
                lb = new LibCore();
                strPayments_ID = lb.CreateId("tbl_Payments");

                obPayments.Payments_ID = strPayments_ID;
                obPayments.CreatedBy = frmMain.obUser.User_ID;
                obPayments.Payments_Amount = obInput.Input_TotalVAT;
                obPayments.Payments_CustomerID = obInput.Input_SupplierID;
                obPayments.Payments_Date = DateTime.Now;
                obPayments.Payments_Description = "Chi tiền phiếu nhập - " + obInput.Input_ID;
                obPayments.Payments_Type = 1;
                obPayments.Payments_Vouchers = obInput.Input_ID;

                PaymentsCtr.Insert(obPayments);
                setValue();
                MessageBox.Show("Thu tiền phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            if (ucProductsSelect.LisProducts.Count > 0)
            {
                foreach (string strCheck in ucProductsSelect.LisProducts)
                {
                    addProduct(strCheck);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSeachKH_Click(object sender, EventArgs e)
        {
            frmSupplier_Use frm = new frmSupplier_Use();
            frm.ShowDialog();
            getSupplier(frm.SupplierID);
        }

        private void getSupplier(string strSupplierID)
        {
            if (strSupplierID == string.Empty)
                return;
            obSupplier = new SupplierOB();
            obSupplier = SupplierCtr.Select(strSupplierID);
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
