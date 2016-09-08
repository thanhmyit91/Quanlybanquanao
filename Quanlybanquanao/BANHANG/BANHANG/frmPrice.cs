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
    public partial class frmPrice : Form
    {
        DataTable data;
        private object[] objKeywords = null;

        public frmPrice()
        {
            InitializeComponent();
        }

        private void frmPrice_Load(object sender, EventArgs e)
        {
            my_ComboBox.SetTitle(cboProduct_ModelID, Datacache.GetModelCache().Copy(), "--Chọn model--", "Model_ID", "Model_Name");
            my_ComboBox.SetDataSource(cboPriceType, Datacache.GetPriceTypeCache().Copy(), "PriceType_ID", "PriceType_Name");
        }

        public void LoadData()
        {
            data = new DataTable();
            objKeywords = new object[] { "@Keyword", this.txtTukhoa.Text.Trim(),
                                         "@Price_Type",Convert.ToInt32(cboPriceType.SelectedValue),
                                         "@Product_ModelID",cboProduct_ModelID.SelectedValue.ToString()};
            data = PriceCtr.Seach(objKeywords);
            grvDanhsach.DataSource = data;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cboPriceType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grvDanhsach_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (grvDanhsach.Columns[e.ColumnIndex].Name == "colPrice_Now")
            {
                decimal newDecimal;
                if (!decimal.TryParse(e.FormattedValue.ToString(), out newDecimal))
                {
                    e.Cancel = true;
                    grvDanhsach.Rows[e.RowIndex].ErrorText = "Vui lòng nhập đơn giá đúng định dạng số!";
                    MessageBox.Show("Vui lòng nhập đơn giá đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newDecimal < 0)
                {
                    e.Cancel = true;
                    grvDanhsach.Rows[e.RowIndex].ErrorText = "Vui lòng nhập đơn giá lớn hơn hoặc 0!";
                    MessageBox.Show("Vui lòng nhập đơn giá lớn hơn hoặc bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void grvDanhsach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grvDanhsach.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;

            DataRow row;
            row = data.Rows[e.RowIndex];
            if (Convert.ToInt32(row["ISSELECT"]) == 1)
            {
                grvDanhsach.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            else
            {
                grvDanhsach.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void grvDanhsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (grvDanhsach.Columns[e.ColumnIndex].Name == "colPrice_Now")
            {
                    DataRow row;
                    row = data.Rows[e.RowIndex];
                    row["ISSELECT"] = 1;
                    data.AcceptChanges();
                    grvDanhsach.Refresh();
            }
            else if (grvDanhsach.Columns[e.ColumnIndex].Name == "colPrice_Description")
            {
                DataRow row;
                row = data.Rows[e.RowIndex];
                data.AcceptChanges();
                row["ISSELECT"] = 1;
                grvDanhsach.Refresh();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (data.Select("ISSELECT = 1").Count() == 0)
            {
                MessageBox.Show("Không có thông tin thay đổi để cập nhât", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn muốn lưu thây đổi!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (Save())
                {
                    MessageBox.Show("Cập nhật giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private bool Save()
        {
            bool kq = false;
            try
            {
                DataRow[] dtChange = data.Select("ISSELECT = 1");
                foreach (DataRow row in dtChange)
                {
                    decimal iPrice_Now = 0;
                    decimal iPrice_Old = 0;
                    decimal.TryParse(row["Price_Now"].ToString(), out iPrice_Now);
                    decimal.TryParse(row["OLD"].ToString(), out iPrice_Old);

                    objKeywords = new object[] { "@Price_Product", row["Product_ID"].ToString().Trim(),
                                         "@Price_Type",Convert.ToInt32(cboPriceType.SelectedValue),
                                         "@Price_Now",iPrice_Now,
                                         "@Price_Old",iPrice_Old,
                                         "@Price_Description",row["Price_Description"].ToString().Trim(),
                                         "@ModifiedBy", frmMain.obUser.User_ID};
                    PriceCtr.Update(objKeywords);
                }
                kq = true;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }

        private void cboPriceType_Validating(object sender, CancelEventArgs e)
        {
            //if (MessageBox.Show("Khi thay đổi loại giá tất cả thông tin vừa thay đổi sẽ bị mất\n Nhấn OK để tiếp tục, Cancel để giữ nguyên loại giá.!", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }
     
    }
}
