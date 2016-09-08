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
    public partial class frmOutput : Form
    {
        OutputOB obOutput;
        List<OutputDetailOB> lstDetailOutput = new List<OutputDetailOB>();
        CustomerOB obCustomer = null;

        private object[] objKeywords = null;

        public frmOutput()
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

        private string _OutputID = string.Empty;

        public string OutputID
        {
            get { return _OutputID; }
            set 
            { 
                _OutputID = value;
                groupThongtin.Text = "Thông tin phiếu xuất " + _OutputID.Trim();
            }
        }

        private void frmOutput_Load(object sender, EventArgs e)
        {
            obOutput = new OutputOB();
            setValue();
            ucProductsSelect.IsQuantity = 0;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            toolXoa.Enabled = grvOutputdetail.Focused && grvOutputdetail.RowCount > 0 && grvOutputdetail.SelectedRows.Count > 0;
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            if (grvOutputdetail.SelectedRows.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OutputDetailOB ob = (OutputDetailOB)grvOutputdetail.CurrentRow.DataBoundItem;
            delProduct(ob);
        }

        private void grvOutputdetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            OutputDetailOB ob = (OutputDetailOB)grvOutputdetail.CurrentRow.DataBoundItem;
            //ob.OutputDetail_Total = ob.OutputDetail_Quantity * ob.OutputDetail_Price;

            if (ob.Flat == -1)
            {
                ob.Flat = 1;
            }
            Total(ob);
            grvOutputdetail.Refresh();
            SumTotal();
        }
        #region Load control
        //Load dữ liệu combobox
        #endregion
        #region Function
        //Kiêu 0, lay theo sỉ, 1 lấy theo lẻ
        private void addProduct(string ProductID)
        {
            if (lstDetailOutput != null && lstDetailOutput.Count(o => o.OutputDetail_ProductID == ProductID) > 0)
            {
                var found = lstDetailOutput.FirstOrDefault(c => c.OutputDetail_ProductID == ProductID);
                found.OutputDetail_Quantity++;
                if (found.Flat == -1)
                {
                    found.Flat = 1;
                }
                if (found.Flat == 2)
                {
                    found.Flat = 1;
                    found.OutputDetail_Quantity = 1;
                }
                Total(found);
            }

            else
            {
                DataTable dtProduct = new DataTable();
                dtProduct = Datacache.GetProductCache().Copy();
                string expression = "Product_ID = '" + ProductID + "'";
                DataRow row = dtProduct.Select(expression).FirstOrDefault();
                OutputDetailOB obDetailAdd = new OutputDetailOB();
                obDetailAdd.Flat = 0;
                if (!Convert.IsDBNull(row["Color_Name"])) obDetailAdd.Color_Name = Convert.ToString(row["Color_Name"]).Trim();
                if (!Convert.IsDBNull(row["Product_Name"])) obDetailAdd.Product_Name = Convert.ToString(row["Product_Name"]).Trim();
                if (!Convert.IsDBNull(row["Product_ID"])) obDetailAdd.OutputDetail_ProductID = Convert.ToString(row["Product_ID"]).Trim();
                obDetailAdd.OutputDetail_Price = 0;
                obDetailAdd.OutputDetail_Quantity = 1;
                Total(obDetailAdd);
                lstDetailOutput.Add(obDetailAdd);
            }
            grvOutputdetail.DataSource = lstDetailOutput.ToArray();
            grvOutputdetail.Refresh();
            SumTotal();
        }
        private void delProduct(OutputDetailOB ob)
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
                lstDetailOutput.Remove(ob);
            }
            grvOutputdetail.DataSource = lstDetailOutput;
            grvOutputdetail.Refresh();
            SumTotal();
        }
        private void Total(OutputDetailOB ob)
        {
            ob.OutputDetail_Total = ob.OutputDetail_Quantity * ob.OutputDetail_Price;
        }
        private void SumTotal()
        {
            decimal decTien = lstDetailOutput.Sum(o => o.Flat != 2 ? o.OutputDetail_Total : 0);
            obOutput.Output_Total = decTien;
            txtOutput_Total.Text = decTien.ToString("N0");
        }

        private void setValue()
        {
            if (!string.IsNullOrEmpty(OutputID))
            {
                obOutput = OutputCtr.Select(OutputID);
                obCustomer = new CustomerOB();
                obCustomer = CustomerCtr.Select(obOutput.Output_CustomerID);
                txtCustomer_ID.Text = obOutput.Output_CustomerID.ToString().Trim();
                txtCustomer_Name.Text = obCustomer.Customer_Name;
                txtCustomer_Phone.Text = obCustomer.Customer_Phone;
                txtCustomer_Email.Text = obCustomer.Customer_Email;
                txtCustomer_Facbook.Text = obCustomer.Customer_Facbook;
                txtCustomer_Zalo.Text = obCustomer.Customer_Zalo;
                txtCustomer_Address.Text = obCustomer.Customer_Address;
                txtOutput_Vouchers.Text = obOutput.Output_Vouchers;

                lstDetailOutput = obOutput.LstOutputDetail.ToList();
                grvOutputdetail.DataSource = lstDetailOutput.ToArray();
                txtOutput_Total.Text = obOutput.Output_Total.ToString("N0");
                txtOutput_Description.Text = obOutput.Output_Description;
                
                dtpOutput_Date.Value = (DateTime)obOutput.Output_Date;
                dtpOutput_Date.Enabled = false;

                btnXoa.Visible = true;
                btnSeachKH.Enabled = false;

                btnXoa.Enabled = !obOutput.IsDelete && string.IsNullOrEmpty(obOutput.Output_Vouchers);
                btnCapnhat.Enabled = false;
                btnDeleteCustomer.Enabled = false;
                contextMenuStrip1.Enabled = false;
                //txtProduct.Enabled = obOutput.IsDelete == 0 && obOutput.Output_IsVoucher == 0 && !string.IsNullOrEmpty(obOutput.Output_ID) && obOutput.Output_IsOutput == 0;
                grvOutputdetail.Enabled = false;

                txtOutput_Description.Enabled = false;
                btnSelectProduct.Enabled = false;
                ucProductsSelect.Enabled = false;
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
                txtOutput_Vouchers.Text = string.Empty;

                lstDetailOutput = new List<OutputDetailOB>();
                grvOutputdetail.DataSource = lstDetailOutput.ToArray();

                txtOutput_Total.Text = "0";
                txtOutput_Description.Text = string.Empty;
                dtpOutput_Date.Value = DateTime.Now;
                dtpOutput_Date.Enabled = true;
                txtOutput_Description.Enabled = true;

                btnXoa.Visible = false;
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
            obOutput = new OutputOB();
            obOutput.LstOutputDetail = lstDetailOutput;
            obOutput.Output_Date = Convert.ToDateTime(dtpOutput_Date.Value);
            obOutput.Output_Description = txtOutput_Description.Text.Trim();

            decimal decTien = lstDetailOutput.Sum(o => o.Flat != 2 ? o.OutputDetail_Total : 0);
            obOutput.Output_Total = decTien;

            LibCore lb = null;
            string strCustomer_ID = string.Empty;
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



            obOutput.Output_CustomerID = strCustomer_ID;

            string strOutput_ID = string.Empty;
            if (string.IsNullOrEmpty(OutputID))
            {
                obOutput.CreatedBy = frmMain.obUser.User_ID;
                lb = new LibCore();
                strOutput_ID = lb.CreateId("tbl_Output");
            }
            else
            {
                strOutput_ID = OutputID;
                obOutput.ModifiedBy = frmMain.obUser.User_ID;
            }
            obOutput.Output_ID = strOutput_ID;
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

            objKeywords = new object[] { 
                                         "@Customer_Phone",txtCustomer_Phone.Text.Trim()
                                    };

            if (CustomerCtr.Check(objKeywords) && string.IsNullOrEmpty(txtCustomer_ID.Text.Trim()))
            {
                MessageBox.Show("Thông tin điện thoại đã bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (lstDetailOutput.Count(o => o.Flat != 2) == 0)
            {
                MessageBox.Show("Phiếu nhập phải có ít nhất 1 sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal decOutput_Total = 0;
            decimal.TryParse(txtOutput_Total.Text, out decOutput_Total);
            if (decOutput_Total < 0)
            {
                MessageBox.Show("Phiếu xuất phải có tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ((DateTime)dtpOutput_Date.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian xuất không được lơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private bool UpdateData()
        {
            bool bResult = false;

            try
            {
                OutputCtr.Insert(obOutput, false);
                bResult = true;
            }
            catch
            {
                bResult = false;
            }
            return bResult;
        }

        #endregion

        private void grvOutputdetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            grvOutputdetail.Rows[e.RowIndex].ErrorText = "";
            if (grvOutputdetail.Rows[e.RowIndex].IsNewRow) { return; }
            if (grvOutputdetail.Columns[e.ColumnIndex].Name == "colOutputDetail_Quantity")
            {
                int newInteger;
                if (!int.TryParse(e.FormattedValue.ToString(),out newInteger))
                {
                    e.Cancel = true;
                    grvOutputdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng đúng định dạng số!";
                    MessageBox.Show("Vui lòng nhập số lượng đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newInteger < 1)
                {
                    e.Cancel = true;
                    grvOutputdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng lớn hơn 0!";
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (grvOutputdetail.Columns[e.ColumnIndex].Name == "colOutputDetail_Price")
            {
                decimal newDecimal;
                if (!decimal.TryParse(e.FormattedValue.ToString(), out newDecimal))
                {
                    e.Cancel = true;
                    grvOutputdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập đơn giá đúng định dạng số!";
                    MessageBox.Show("Vui lòng nhập đơn giá đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newDecimal <0)
                {
                    e.Cancel = true;
                    grvOutputdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập đơn giá lớn hơn 0!";
                    MessageBox.Show("Vui lòng nhập đơn giá lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void grvOutputdetail_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            OutputDetailOB ob = new OutputDetailOB();
            ob = (OutputDetailOB)grvOutputdetail.Rows[e.RowIndex].DataBoundItem;
            if (ob.Flat == 2)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[grvOutputdetail.DataSource];
                currencyManager1.SuspendBinding();
                grvOutputdetail.Rows[e.RowIndex].Visible = false;
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

        private void txtOutput_SaleMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

        private void txtOutput_VAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }


        private void txtCustomer_Phone_Leave(object sender, EventArgs e)
        {
            if (txtCustomer_Phone.ReadOnly == true)
                return;
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
            if (!checkQuantity())
                return;
            if (!ValidateData())
                return;
            getValue();
            if (UpdateData())
            {
                OutputID = obOutput.Output_ID;
                setValue();
                MessageBox.Show("Cập nhật phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu xuất thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy thao tác trên phiếu xuất!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                setValue();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy phiếu xuất này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                OutputCtr.Delete(obOutput, false);
                MessageBox.Show("Hủy phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
            frmCustomer_Use frm = new frmCustomer_Use();
            frm.ShowDialog();
            getCustomer(frm.CustomerID);
        }

        private void getCustomer(string strCustomerID)
        {
            if (strCustomerID == string.Empty)
                return;
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

        private bool checkQuantity()
        {
            foreach (OutputDetailOB item in lstDetailOutput)
            {
                if (!Order_Lib.checkProductQuantity(item.OutputDetail_ProductID, item.OutputDetail_Quantity))
                {
                    MessageBox.Show("Sản phẩm " + item.OutputDetail_ProductID + "-" + item.Product_Name + " đã hết số lượng tồn.\n Không thể tạo phiếu xuất này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
