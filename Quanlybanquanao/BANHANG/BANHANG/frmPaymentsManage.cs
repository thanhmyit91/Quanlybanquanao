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
    public partial class frmPaymentsManage : Form
    {
        DataTable data;
        private object[] objKeywords = null;

        public frmPaymentsManage()
        {
            InitializeComponent();
            InitControl();
        }

        #region Các sự kiện
        private void frmPayments_Load(object sender, EventArgs e)
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
            frmPayments frm = new frmPayments();
            frm.Payments_ID = grvDanhsach.CurrentRow.Cells["colPayments_ID"].Value.ToString();
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
                                         "@Fromdate ", Convert.ToDateTime(dtpPayments_DateFrom.Value),
                                         "@Todate ", Convert.ToDateTime(dtpPayments_DateTo.Value),
                                         "@Payments_Type", (int)cboPayments_Type.SelectedValue,
                                         "@IsDelete",chDaxoa.Checked};
            data = PaymentsCtr.Seach(objKeywords);
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
            tableTypeRow2["TypeName"] = "Mã chứng từ";
            tableType.Rows.Add(tableTypeRow2);

            DataRow tableTypeRow3 = tableType.NewRow();
            tableTypeRow3["TypeID"] = 2;
            tableTypeRow3["TypeName"] = "Số điện thoại";
            tableType.Rows.Add(tableTypeRow3);

            DataRow tableTypeRow4 = tableType.NewRow();
            tableTypeRow4["TypeID"] = 3;
            tableTypeRow4["TypeName"] = "Tên khách hàng";
            tableType.Rows.Add(tableTypeRow4);

            my_ComboBox.SetDataSource(cboType, tableType, "TypeID", "TypeName");

            //Loại phiếu 0 thu; 1 chi
            DataTable tablePayments_Type = new DataTable("Payments_Type");
            tablePayments_Type.Columns.Add("Payments_TypeID", typeof(Int32));
            tablePayments_Type.Columns.Add("Payments_TypeName", typeof(string));

            DataRow IsVoucherRow1 = tablePayments_Type.NewRow();
            IsVoucherRow1["Payments_TypeID"] = 0;
            IsVoucherRow1["Payments_TypeName"] = "Phiếu thu";
            tablePayments_Type.Rows.Add(IsVoucherRow1);

            DataRow IsVoucherRow2 = tablePayments_Type.NewRow();
            IsVoucherRow2["Payments_TypeID"] = 1;
            IsVoucherRow2["Payments_TypeName"] = "Phiếu chi";
            tablePayments_Type.Rows.Add(IsVoucherRow2);

            my_ComboBox.SetDataSource(cboPayments_Type, tablePayments_Type, "Payments_TypeID", "Payments_TypeName");

            dtpPayments_DateFrom.Value = DateTime.Now;
            dtpPayments_DateTo.Value = DateTime.Now;
        }
        #endregion end function

        private void btnThemthu_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments();
            frm.Payments_Type = 0;
            frm.ShowDialog();
        }

        private void btnThemchi_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments();
            frm.Payments_Type = 1;
            frm.ShowDialog();
        }
       

    }
}
