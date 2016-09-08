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
    public partial class frmOrder : Form
    {
        OrderOB obOrder;
       
        List<OrderDetailOB> lstDetailOrder = new List<OrderDetailOB>();
        CustomerOB obCustomer = null;
        PaymentsOB obPayments = null;
        private object[] objKeywords = null;

        public frmOrder()
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

        private string _OrderID = string.Empty;

        public string OrderID
        {
            get { return _OrderID; }
            set 
            { 
                _OrderID = value;
                groupThongtin.Text = "Thông tin đơn hàng " + _OrderID.Trim();
            }
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            obOrder = new OrderOB();
            LoadCombobox();
            setValue();
            ucProductsSelect.IsQuantity = 0;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            toolXoa.Enabled = grvOrderdetail.Focused && grvOrderdetail.RowCount > 0 && grvOrderdetail.SelectedRows.Count > 0;
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            if (grvOrderdetail.SelectedRows.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OrderDetailOB ob = (OrderDetailOB)grvOrderdetail.CurrentRow.DataBoundItem;
            delProduct(ob);
        }

        private void grvOrderdetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            OrderDetailOB ob = (OrderDetailOB)grvOrderdetail.CurrentRow.DataBoundItem;
            if (grvOrderdetail.Columns[e.ColumnIndex].Name == "colPriceType")
            {
                if (Order_Lib.checkPrice(ob.OrderDetail_PriceType, ob.OrderDetail_ProductID))
                {
                    ob.OrderDetail_Price = Order_Lib.getPrice(ob.OrderDetail_PriceType, ob.OrderDetail_ProductID);
                }
                else
                {
                    MessageBox.Show("Chưa làm giá cho sản phẩm này theo cách lấy giá này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ob.OrderDetail_Price = 0;
                }
            }

            if (ob.Flat == -1)
            {
                ob.Flat = 1;
            }
            Total(ob);
            grvOrderdetail.Refresh();
            SumTotal();
        }
        #region Load control
        //Load dữ liệu combobox
        private void LoadCombobox()
        {
            my_ComboBox.SetTitle(cboOrder_SendType, Datacache.GetSendTypeCache().Copy(), "--Chọn cách gửi--", "SendType_ID", "SendType_Name");

            colPriceType.DataSource = Datacache.GetPriceTypeCache().Copy();
            colPriceType.ValueMember = "PriceType_ID";
            colPriceType.DisplayMember = "PriceType_Name";
        }
        //Load dữ liệu combobox
        #endregion
        #region Function
        private void addProduct(string ProductID)
        {
            if (lstDetailOrder != null && lstDetailOrder.Count(o => o.OrderDetail_ProductID == ProductID) > 0)
            {
                var found = lstDetailOrder.FirstOrDefault(c => c.OrderDetail_ProductID == ProductID);
                found.OrderDetail_Quantity++;
                if (found.Flat == -1)
                {
                    found.Flat = 1;
                }
                if (found.Flat == 2)
                {
                    found.Flat = 1;
                    found.OrderDetail_Quantity = 1;
                    int iPRICETYPE_DEFAULT = 0;
                    DataRow row = Datacache.GetPriceTypeCache().Select("Isdefault = 1").FirstOrDefault();
                    int.TryParse(row["PriceType_ID"].ToString(), out iPRICETYPE_DEFAULT);
                    found.OrderDetail_PriceType = iPRICETYPE_DEFAULT;
                    found.OrderDetail_Price = Order_Lib.getPrice(found.OrderDetail_PriceType, found.OrderDetail_ProductID);
                    found.OrderDetail_Sale = 0;
                }
                Total(found);
            }

            else
            {
                string expression = "Product_ID = '" + ProductID + "'";
                DataRow row = Datacache.GetProductCache().Select(expression).FirstOrDefault();
                OrderDetailOB obDetailAdd = new OrderDetailOB();
                obDetailAdd.Flat = 0;
                if (!Convert.IsDBNull(row["Color_Name"])) obDetailAdd.Color_Name = Convert.ToString(row["Color_Name"]).Trim();
                if (!Convert.IsDBNull(row["Product_Name"])) obDetailAdd.Product_Name = Convert.ToString(row["Product_Name"]).Trim();
                if (!Convert.IsDBNull(row["Product_ID"])) obDetailAdd.OrderDetail_ProductID = Convert.ToString(row["Product_ID"]).Trim();
                obDetailAdd.OrderDetail_Quantity = 1;
                obDetailAdd.OrderDetail_Sale = 0;
                int iPRICETYPE_DEFAULT = 0;
                DataRow row1 = Datacache.GetPriceTypeCache().Select("Isdefault = 1").FirstOrDefault();
                int.TryParse(row1["PriceType_ID"].ToString(), out iPRICETYPE_DEFAULT);
                obDetailAdd.OrderDetail_PriceType = iPRICETYPE_DEFAULT;
                obDetailAdd.OrderDetail_Price = Order_Lib.getPrice(obDetailAdd.OrderDetail_PriceType, obDetailAdd.OrderDetail_ProductID);
                Total(obDetailAdd);
                lstDetailOrder.Add(obDetailAdd);
            }
            grvOrderdetail.DataSource = lstDetailOrder.ToArray();
            grvOrderdetail.Refresh();
            SumTotal();
        }
        private void delProduct(OrderDetailOB ob)
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
                lstDetailOrder.Remove(ob);
            }
            grvOrderdetail.DataSource = lstDetailOrder;
            grvOrderdetail.Refresh();
            SumTotal();
        }
        private void Total(OrderDetailOB ob)
        {
            ob.OrderDetail_Total = (ob.OrderDetail_Quantity * ob.OrderDetail_Price) - (ob.OrderDetail_Quantity *ob.OrderDetail_Sale);
        }
        private void SumTotal()
        {
            decimal decTien = lstDetailOrder.Sum(o => o.Flat != 2 ? o.OrderDetail_Total : 0);
            int intOrder_VAT = 0;
            int.TryParse(txtOrder_VAT.Text, out intOrder_VAT);

            decimal decOrder_SaleMoney = 0;
            decimal.TryParse(txtOrder_SaleMoney.Text, out decOrder_SaleMoney);

            decimal decOrder_SendMoney = 0;
            decimal.TryParse(txtOrder_SendMoney.Text, out decOrder_SendMoney);

            obOrder.Order_Total = decTien;
            txtOrder_TotalVAT.Text = (decTien + (decTien * (intOrder_VAT / 100)) - decOrder_SaleMoney + decOrder_SendMoney).ToString("N0");
        }

        private void setValue()
        {
            if (!string.IsNullOrEmpty(OrderID))
            {
                obOrder = OrderCtr.Select(OrderID);
                obCustomer = new CustomerOB();
                obCustomer = CustomerCtr.Select(obOrder.Order_CustomerID);
                txtCustomer_ID.Text = obOrder.Order_CustomerID.ToString().Trim();
                txtCustomer_Name.Text = obCustomer.Customer_Name;
                txtCustomer_Phone.Text = obCustomer.Customer_Phone;
                txtCustomer_Email.Text = obCustomer.Customer_Email;
                txtCustomer_Facbook.Text = obCustomer.Customer_Facbook;
                txtCustomer_Zalo.Text = obCustomer.Customer_Zalo;
                txtCustomer_Address.Text = obCustomer.Customer_Address;

                chkOrder_IsVoucher.Checked = obOrder.Order_IsVoucher == 1;
                chkOrder_IsOutput.Checked = obOrder.Order_IsOutput == 1;
                cdkOrder_IsSend.Checked = obOrder.Order_IsSend == 1;
                lstDetailOrder = obOrder.LstOrderDetail.ToList();
                grvOrderdetail.DataSource = lstDetailOrder.ToArray();

                cboOrder_SendType.SelectedValue = obOrder.Order_SendType;
                txtOrder_VAT.Text = obOrder.Order_VAT.ToString();
                txtOrder_SendMoney.Text = obOrder.Order_SendMoney.ToString("n0");
                txtOrder_SaleMoney.Text = obOrder.Order_SaleMoney.ToString("n0");
                txtOrder_TotalVAT.Text = obOrder.Order_TotalVAT.ToString("N0");
                txtOrder_Description.Text = obOrder.Order_Description;
                
                dtpOrder_Date.Value = (DateTime)obOrder.Order_Date;
                dtpOrder_Date.Enabled = false;

                btnXoa.Visible = true;
                btnThutien.Visible = true;
                btnXuat.Visible = true;
                btnGiao.Visible = true;
                btnSeachKH.Enabled = false;

                btnXoa.Enabled = !obOrder.IsDelete && obOrder.Order_IsOutput == 0 && obOrder.Order_IsVoucher == 0 && !string.IsNullOrEmpty(obOrder.Order_ID);
                btnThutien.Enabled =  !obOrder.IsDelete && obOrder.Order_IsVoucher == 0 && !string.IsNullOrEmpty(obOrder.Order_ID);
                btnXuat.Enabled = !obOrder.IsDelete && obOrder.Order_IsOutput == 0 && !string.IsNullOrEmpty(obOrder.Order_ID);
                btnGiao.Enabled = !obOrder.IsDelete && obOrder.Order_IsSend == 0 && !string.IsNullOrEmpty(obOrder.Order_ID);
                btnCapnhat.Enabled = !obOrder.IsDelete && (obOrder.Order_IsOutput == 0 && obOrder.Order_IsVoucher == 0);
                btnDeleteCustomer.Enabled = false;
                contextMenuStrip1.Enabled = !obOrder.IsDelete && (obOrder.Order_IsOutput == 0 && obOrder.Order_IsVoucher == 0);
               
                grvOrderdetail.Enabled = !obOrder.IsDelete && obOrder.Order_IsVoucher == 0 && !string.IsNullOrEmpty(obOrder.Order_ID) && obOrder.Order_IsOutput == 0;
                cboOrder_SendType.Enabled = !obOrder.IsDelete && obOrder.Order_IsVoucher == 0 && !string.IsNullOrEmpty(obOrder.Order_ID) && obOrder.Order_IsOutput == 0;
                txtOrder_SendMoney.Enabled = !obOrder.IsDelete && obOrder.Order_IsVoucher == 0 && !string.IsNullOrEmpty(obOrder.Order_ID) && obOrder.Order_IsOutput == 0;
                txtOrder_SaleMoney.Enabled = !obOrder.IsDelete && obOrder.Order_IsVoucher == 0 && !string.IsNullOrEmpty(obOrder.Order_ID) && obOrder.Order_IsOutput == 0;
                txtOrder_Description.Enabled = !obOrder.IsDelete && obOrder.Order_IsVoucher == 0 && !string.IsNullOrEmpty(obOrder.Order_ID) && obOrder.Order_IsOutput == 0;
                txtOrder_VAT.Enabled = !obOrder.IsDelete && obOrder.Order_IsVoucher == 0 && !string.IsNullOrEmpty(obOrder.Order_ID) && obOrder.Order_IsOutput == 0;
                btnSelectProduct.Enabled = !obOrder.IsDelete && (obOrder.Order_IsOutput == 0 && obOrder.Order_IsVoucher == 0);
                ucProductsSelect.Enabled = !obOrder.IsDelete && (obOrder.Order_IsOutput == 0 && obOrder.Order_IsVoucher == 0);
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

                chkOrder_IsVoucher.Checked = false;
                chkOrder_IsOutput.Checked = false;
                cdkOrder_IsSend.Checked = false;
                lstDetailOrder = new List<OrderDetailOB>();
                grvOrderdetail.DataSource = lstDetailOrder.ToArray();

                cboOrder_SendType.SelectedValue = -1;

                txtOrder_VAT.Text = "0";
                txtOrder_SendMoney.Text = "0";
                txtOrder_SaleMoney.Text = "0";
                txtOrder_TotalVAT.Text = "0";
                txtOrder_Description.Text = string.Empty;
                dtpOrder_Date.Value = DateTime.Now;
                dtpOrder_Date.Enabled = true;

                cboOrder_SendType.Enabled = true;
                txtOrder_SendMoney.Enabled = true;
                txtOrder_SaleMoney.Enabled = true;
                txtOrder_Description.Enabled = true;
                txtOrder_VAT.Enabled = true;

                btnXoa.Visible = false;
                btnThutien.Visible = false;
                btnXuat.Visible = false;
                btnGiao.Visible = false;
                btnCapnhat.Enabled = true;
                contextMenuStrip1.Enabled = true;

                btnSelectProduct.Enabled = true;
                ucProductsSelect.Enabled = true;
                btnSeachKH.Enabled = true;

            }
           // txtProduct.Clear();
            
        }
        private void getValue()
        {
            obOrder = new OrderOB();
            obOrder.LstOrderDetail = lstDetailOrder;
            obOrder.Order_Date = Convert.ToDateTime(dtpOrder_Date.Value);
            obOrder.Order_Description = txtOrder_Description.Text.Trim();
            obOrder.Order_SendType = (int)cboOrder_SendType.SelectedValue;

            decimal decOrder_SendMoney = 0;
            decimal.TryParse(txtOrder_SendMoney.Text, out decOrder_SendMoney);
            obOrder.Order_SendMoney = decOrder_SendMoney;

            decimal decTien = lstDetailOrder.Sum(o => o.Flat != 2 ? o.OrderDetail_Total : 0);
            obOrder.Order_Total = decTien;

            decimal decOrder_TotalVAT = 0;
            decimal.TryParse(txtOrder_TotalVAT.Text, out decOrder_TotalVAT);
            obOrder.Order_TotalVAT = decOrder_TotalVAT;

            int intOrder_VAT = 0;
            int.TryParse(txtOrder_VAT.Text, out intOrder_VAT);
            obOrder.Order_VAT = intOrder_VAT;

            decimal decOrder_SaleMoney = 0;
            decimal.TryParse(txtOrder_SaleMoney.Text, out decOrder_SaleMoney);
            obOrder.Order_SaleMoney = decOrder_SaleMoney;

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

            

            obOrder.Order_CustomerID = strCustomer_ID;

            string strOrder_ID = string.Empty;
            if (string.IsNullOrEmpty(OrderID))
            {
                obOrder.CreatedBy = frmMain.obUser.User_ID;
                lb = new LibCore();
                strOrder_ID = lb.CreateId("tbl_Order");
            }
            else
            {
                strOrder_ID = OrderID;
                obOrder.ModifiedBy = frmMain.obUser.User_ID;
            }
            obOrder.Order_ID = strOrder_ID;
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
            
            if (lstDetailOrder.Count(o => o.Flat != 2) == 0)
            {
                MessageBox.Show("Đơn hàng phải có ít nhất 1 sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal decOrder_TotalVAT = 0;
            decimal.TryParse(txtOrder_TotalVAT.Text, out decOrder_TotalVAT);
            if (decOrder_TotalVAT <= 0)
            {
                MessageBox.Show("Đơn hàng phải có tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ((DateTime)dtpOrder_Date.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian đơn hàng không được lơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private bool UpdateData()
        {
            bool bResult = false;

            try
            {
                if (string.IsNullOrEmpty(OrderID))
                {
                    OrderCtr.Insert(obOrder);
                }
                else
                {
                    OrderCtr.Update(obOrder);
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

        private void grvOrderdetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            grvOrderdetail.Rows[e.RowIndex].ErrorText = "";
            if (grvOrderdetail.Rows[e.RowIndex].IsNewRow) { return; }
            if (grvOrderdetail.Columns[e.ColumnIndex].Name == "colOrderDetail_Quantity")
            {
                int newInteger;
                if (!int.TryParse(e.FormattedValue.ToString(),out newInteger))
                {
                    e.Cancel = true;
                    grvOrderdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng đúng định dạng số!";
                    MessageBox.Show("Vui lòng nhập số lượng đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newInteger < 1)
                {
                    e.Cancel = true;
                    grvOrderdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập số lượng lớn hơn 0!";
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (grvOrderdetail.Columns[e.ColumnIndex].Name == "colOrderDetail_Price")
            {
                decimal newDecimal;
                if (!decimal.TryParse(e.FormattedValue.ToString(), out newDecimal))
                {
                    e.Cancel = true;
                    grvOrderdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập đơn giá đúng định dạng số!";
                    MessageBox.Show("Vui lòng nhập đơn giá đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newDecimal <0)
                {
                    e.Cancel = true;
                    grvOrderdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập đơn giá lớn hơn hoặc bằng 0!";
                    MessageBox.Show("Vui lòng nhập đơn giá lớn hơn hoặc bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (grvOrderdetail.Columns[e.ColumnIndex].Name == "colOrderDetail_Sale")
            {
                decimal newDecimal;
                if (!decimal.TryParse(e.FormattedValue.ToString(), out newDecimal))
                {
                    e.Cancel = true;
                    grvOrderdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập chiết khấu đúng định dạng số!";
                    MessageBox.Show("Vui lòng nhập chiết khấu đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newDecimal < 0)
                {
                    e.Cancel = true;
                    grvOrderdetail.Rows[e.RowIndex].ErrorText = "Vui lòng nhập chiết khấu giá lớn hơn hoặc bằng 0!";
                    MessageBox.Show("Vui lòng nhập chiết khấu lớn hơn hoặc 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void grvOrderdetail_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            OrderDetailOB ob = new OrderDetailOB();
            ob = (OrderDetailOB)grvOrderdetail.Rows[e.RowIndex].DataBoundItem;
            if (ob.Flat == 2)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[grvOrderdetail.DataSource];
                currencyManager1.SuspendBinding();
                grvOrderdetail.Rows[e.RowIndex].Visible = false;
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

        private void txtOrder_SendMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

        private void txtOrder_SaleMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

        private void txtOrder_VAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lib.TextNumeric_KeyPress(sender, e);
        }

        private void txtOrder_SendMoney_Leave(object sender, EventArgs e)
        {

            decimal decOrder_SendMoney = 0;
            decimal.TryParse(txtOrder_SendMoney.Text, out decOrder_SendMoney);
            txtOrder_SendMoney.Text = decOrder_SendMoney.ToString("n0");
            SumTotal();
        }

        private void txtOrder_VAT_Leave(object sender, EventArgs e)
        {
            int intOrder_VAT = 0;
            int.TryParse(txtOrder_VAT.Text, out intOrder_VAT);
            txtOrder_VAT.Text = intOrder_VAT.ToString();
            SumTotal();
        }

        private void txtOrder_SaleMoney_Leave(object sender, EventArgs e)
        {
            decimal decOrder_SaleMoney = 0;
            decimal.TryParse(txtOrder_SaleMoney.Text, out decOrder_SaleMoney);
            txtOrder_SaleMoney.Text = decOrder_SaleMoney.ToString("n0");
            SumTotal();

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
            if (!ValidateData())
                return;
            getValue();
            if (UpdateData())
            {
                OrderID = obOrder.Order_ID;
                setValue();
                MessageBox.Show("Cập nhật đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật đơn hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (MessageBox.Show("Bạn muốn hủy đơn hàng này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                OrderCtr.Delete(obOrder);
                MessageBox.Show("Hủy đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }       
        }

        private void btnThutien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn tạo phiếu thu. \nSau khi thu đơn hàng sẽ không được phép sửa và xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                obPayments = new PaymentsOB();

                LibCore lb = null;
                string strPayments_ID = string.Empty;
                lb = new LibCore();
                strPayments_ID = lb.CreateId("tbl_Payments");

                obPayments.Payments_ID = strPayments_ID;
                obPayments.CreatedBy = frmMain.obUser.User_ID;
                obPayments.Payments_Amount = obOrder.Order_TotalVAT;
                obPayments.Payments_CustomerID = obOrder.Order_CustomerID;
                obPayments.Payments_Date = DateTime.Now;
                obPayments.Payments_Description = "Thu tiền đơn hàng - " + obOrder.Order_ID;
                obPayments.Payments_Type = 0;
                obPayments.Payments_Vouchers = obOrder.Order_ID;

                PaymentsCtr.Insert(obPayments);
                setValue();
                MessageBox.Show("Thu tiền đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnGiao_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn cập nhật trạng thái gửi!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    objKeywords = new object[] { 
                                         "@Order_ID",OrderID,
                                         "Order_IsSend",1
                                    };
                    OrderCtr.Update_Status(objKeywords);
                    MessageBox.Show("Cập nhật trạng thái chuyển thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setValue();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật trạng thái không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (strCustomerID==string.Empty)
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xuất hàng!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (!checkQuantity())
                    return;
                if (UpdateOutput())
                {
                    MessageBox.Show("Xuất hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setValue();
                    return;
                }
                else
                {
                    MessageBox.Show("Xuất hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }  
            }
        }

        private bool UpdateOutput()
        {
            bool bResult = false;
            try
            {
                OutputOB obOutput = new OutputOB(); ;
                List<OutputDetailOB> lstDetailOuput = new List<OutputDetailOB>();

                LibCore lb = null;
                string strOutput_ID = string.Empty;
                lb = new LibCore();
                strOutput_ID = lb.CreateId("tbl_Output");
                obOutput.Output_ID = strOutput_ID;
                foreach (OrderDetailOB item in obOrder.LstOrderDetail)
                {
                    OutputDetailOB obItem = new OutputDetailOB();
                    obItem.OutputDetail_OutputID = obOutput.Output_ID;
                    obItem.OutputDetail_Price = item.OrderDetail_Price;
                    obItem.OutputDetail_ProductID = item.OrderDetail_ProductID;
                    obItem.OutputDetail_Quantity = item.OrderDetail_Quantity;
                    obItem.OutputDetail_QuantityOld = 0;
                    obItem.OutputDetail_Total = item.OrderDetail_Total;
                    obItem.Product_Name = item.Product_Name;
                    obItem.Color_Name = item.Color_Name;
                    obItem.Flat = 0;
                    lstDetailOuput.Add(obItem);
                }
                obOutput.LstOutputDetail = lstDetailOuput;
                obOutput.CreatedBy = frmMain.obUser.User_ID;
                obOutput.Output_CustomerID = obOutput.Output_CustomerID;
                obOutput.Output_Date = DateTime.Now;
                obOutput.Output_Description = "Xuất hàng cho đơn hàng - " + obOrder.Order_ID.ToString();
                obOutput.Output_Total = obOrder.Order_Total;
                obOutput.Output_Vouchers = obOrder.Order_ID;
                OutputCtr.Insert(obOutput, true);

                objKeywords = new object[] { 
                                         "@Order_ID",OrderID,
                                         "@Order_IsOutput",1,
                                         "@Order_OutputID", obOutput.Output_ID
                                    };
                OrderCtr.Update_Status(objKeywords);

                bResult = true;
            }
            catch
            {
                bResult = false;
            }
            return bResult;
        }

        private bool checkQuantity()
        {
            foreach (OrderDetailOB item in obOrder.LstOrderDetail)
            {
                if (!Order_Lib.checkProductQuantity(item.OrderDetail_ProductID,item.OrderDetail_Quantity))
                {
                    MessageBox.Show("Sản phẩm "+item.OrderDetail_ProductID +"-"+item.Product_Name + " đã hết số lượng tồn.\n Không thể xuất đơn hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void grvOrderdetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            //if (grvOrderdetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            //{
            //    grvOrderdetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            //}
        }
    }
}
