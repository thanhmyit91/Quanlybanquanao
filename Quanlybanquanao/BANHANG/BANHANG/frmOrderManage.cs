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

namespace BANHANG
{
    public partial class frmOrderManage : Form
    {
        DataTable data;
        private object[] objKeywords = null;

        public frmOrderManage()
        {
            InitializeComponent();
            InitControl();
        }

        #region Các sự kiện
        private void frmOrder_Load(object sender, EventArgs e)
        {
           
        }

        private void grvDanhsach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grvDanhsach.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grvDanhsach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grvDanhsach.SelectedRows.Count <= 0)
                return;
            frmOrder frm = new frmOrder();
            frm.OrderID = grvDanhsach.CurrentRow.Cells["colOrder_ID"].Value.ToString();
            frm.ShowDialog();
            LoadData();
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
            data = new DataTable();
            objKeywords = new object[] { "@Keyword", this.txtTukhoa.Text.Trim(),
                                         "@Type", (int)cboType.SelectedValue,
                                         "@Fromdate ", Convert.ToDateTime(dtpOrder_DateFrom.Value),
                                         "@Todate ", Convert.ToDateTime(dtpOrder_DateTo.Value),
                                         "@Order_IsSend", (int)cboOrder_IsSend.SelectedValue,
                                         "@Order_SendType", (int)cboOrder_SendType.SelectedValue,
                                         "@Order_IsVoucher", (int)cboOrder_IsVoucher.SelectedValue,
                                         "@Order_IsOutput", (int)cboOrder_IsOutput.SelectedValue,
                                         "@IsDelete",chDaxoa.Checked};
            data = OrderCtr.Seach(objKeywords);
            grvDanhsach.DataSource = data;
        }

        private void InitControl()
        {
            //Tìm theo
            DataTable tableType = new DataTable("Type");
            tableType.Columns.Add("TypeID", typeof(Int32));
            tableType.Columns.Add("TypeName", typeof(string));
            DataRow tableTypeRow1 = tableType.NewRow();
            tableTypeRow1["TypeID"] = 0;
            tableTypeRow1["TypeName"] = "Mã phiếu";

            tableType.Rows.Add(tableTypeRow1);
            DataRow tableTypeRow2 = tableType.NewRow();
            tableTypeRow2["TypeID"] = 1;
            tableTypeRow2["TypeName"] = "Tên khách hàng";
            tableType.Rows.Add(tableTypeRow2);

            DataRow tableTypeRow3 = tableType.NewRow();
            tableTypeRow3["TypeID"] = 2;
            tableTypeRow3["TypeName"] = "Số điện thoại";
            tableType.Rows.Add(tableTypeRow3);

            DataRow tableTypeRow4 = tableType.NewRow();
            tableTypeRow4["TypeID"] = 3;
            tableTypeRow4["TypeName"] = "Mã phiếu thu";
            tableType.Rows.Add(tableTypeRow4);

            DataRow tableTypeRow5 = tableType.NewRow();
            tableTypeRow5["TypeID"] = 4;
            tableTypeRow5["TypeName"] = "Mã phiếu xuất";
            tableType.Rows.Add(tableTypeRow5);

            my_ComboBox.SetDataSource(cboType, tableType, "TypeID", "TypeName");

            //Cách gửi
            my_ComboBox.SetTitle(cboOrder_SendType, Datacache.GetSendTypeCache().Copy(), "--Tất cả--", "SendType_ID", "SendType_Name");

            //Đã thu
            DataTable tableIsVoucher = new DataTable("IsVoucher");
            tableIsVoucher.Columns.Add("IsVoucherID", typeof(Int32));
            tableIsVoucher.Columns.Add("IsVoucherName", typeof(string));

            DataRow IsVoucherRow1 = tableIsVoucher.NewRow();
            IsVoucherRow1["IsVoucherID"] = 0;
            IsVoucherRow1["IsVoucherName"] = "Chưa thu";
            tableIsVoucher.Rows.Add(IsVoucherRow1);

            DataRow IsVoucherRow2 = tableIsVoucher.NewRow();
            IsVoucherRow2["IsVoucherID"] = 1;
            IsVoucherRow2["IsVoucherName"] = "Đã thu";
            tableIsVoucher.Rows.Add(IsVoucherRow2);

            my_ComboBox.SetTitle(cboOrder_IsVoucher, tableIsVoucher, "--Tất cả--", "IsVoucherID", "IsVoucherName");

            //Đã xuất
            DataTable tableIsOutput = new DataTable("IsOutput");
            tableIsOutput.Columns.Add("IsOutputID", typeof(Int32));
            tableIsOutput.Columns.Add("IsOutputName", typeof(string));

            DataRow IsOutputRow1 = tableIsOutput.NewRow();
            IsOutputRow1["IsOutputID"] = 0;
            IsOutputRow1["IsOutputName"] = "Chưa xuất";
            tableIsOutput.Rows.Add(IsOutputRow1);

            DataRow IsOutputRow2 = tableIsOutput.NewRow();
            IsOutputRow2["IsOutputID"] = 1;
            IsOutputRow2["IsOutputName"] = "Đã xuất";
            tableIsOutput.Rows.Add(IsOutputRow2);

            my_ComboBox.SetTitle(cboOrder_IsOutput, tableIsOutput, "--Tất cả--", "IsOutputID", "IsOutputName");

            //Đã giao
            DataTable tableIsSend = new DataTable("IsSend");
            tableIsSend.Columns.Add("IsSendID", typeof(Int32));
            tableIsSend.Columns.Add("IsSendName", typeof(string));

            DataRow IsSendRow1 = tableIsSend.NewRow();
            IsSendRow1["IsSendID"] = 0;
            IsSendRow1["IsSendName"] = "Chưa gửi";
            tableIsSend.Rows.Add(IsSendRow1);

            DataRow IsSendRow2 = tableIsSend.NewRow();
            IsSendRow2["IsSendID"] = 1;
            IsSendRow2["IsSendName"] = "Đã gửi";
            tableIsSend.Rows.Add(IsSendRow2);

            my_ComboBox.SetTitle(cboOrder_IsSend, tableIsSend, "--Tất cả--", "IsSendID", "IsSendName");

            dtpOrder_DateFrom.Value = DateTime.Now;
            dtpOrder_DateTo.Value = DateTime.Now;
        }

        #endregion end function
       

    }
}
