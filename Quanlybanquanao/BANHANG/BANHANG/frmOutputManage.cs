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
    public partial class frmOutputManage : Form
    {
        DataTable data;
        private object[] objKeywords = null;

        public frmOutputManage()
        {
            InitializeComponent();
            InitControl();
        }

        #region Các sự kiện
        private void frmOutput_Load(object sender, EventArgs e)
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
            frmOutput frm = new frmOutput();
            frm.OutputID = grvDanhsach.CurrentRow.Cells["colOutput_ID"].Value.ToString();
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
                                         "@Fromdate ", Convert.ToDateTime(dtpOutput_DateFrom.Value),
                                         "@Todate ", Convert.ToDateTime(dtpOutput_DateTo.Value),
                                         "@IsDelete",chDaxoa.Checked};
            data = OutputCtr.Seach(objKeywords);
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
            tableTypeRow4["TypeName"] = "Mã chứng từ";
            tableType.Rows.Add(tableTypeRow4);

            my_ComboBox.SetDataSource(cboType, tableType, "TypeID", "TypeName");
         
            dtpOutput_DateFrom.Value = DateTime.Now;
            dtpOutput_DateTo.Value = DateTime.Now;
        }

        #endregion end function
       

    }
}
