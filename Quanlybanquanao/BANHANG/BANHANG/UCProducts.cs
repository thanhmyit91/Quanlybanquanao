using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Liblary.Control;
using Data;
using Entity;

namespace BANHANG
{
    public partial class UCProducts : UserControl
    {
        DataTable data;
        private List<string> lisProducts = null;

        public List<string> LisProducts
        {
            get { return lisProducts; }
            set { lisProducts = value; }
        }
        private int _IsQuantity = -1;

        public int IsQuantity
        {
            get { return _IsQuantity; }
            set 
            { 
                _IsQuantity = value;
                cboIsQuantity.SelectedValue = IsQuantity;
            }
        }

        private object[] objKeywords = null;
        public UCProducts()
        {
            InitializeComponent();
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            InitControl();
            LisProducts = new List<string>();
        }

        private void InitControl()
        {
            //Tìm theo
            DataTable tableType = new DataTable("Type");
            tableType.Columns.Add("TypeID", typeof(Int32));
            tableType.Columns.Add("TypeName", typeof(string));
            DataRow tableTypeRow1 = tableType.NewRow();
            tableTypeRow1["TypeID"] = 0;
            tableTypeRow1["TypeName"] = "Sản phẩm";

            tableType.Rows.Add(tableTypeRow1);
            DataRow tableTypeRow2 = tableType.NewRow();
            tableTypeRow2["TypeID"] = 1;
            tableTypeRow2["TypeName"] = "Model";
            tableType.Rows.Add(tableTypeRow2);

            DataRow tableTypeRow3 = tableType.NewRow();
            tableTypeRow3["TypeID"] = 2;
            tableTypeRow3["TypeName"] = "Màu sắc";
            tableType.Rows.Add(tableTypeRow3);

            my_ComboBox.SetTitle(cboType, tableType, "--Tất cả--", "TypeID", "TypeName");

            //Đã thu
            DataTable tableIsQuantity = new DataTable("IsQuantity");
            tableIsQuantity.Columns.Add("IsQuantityID", typeof(Int32));
            tableIsQuantity.Columns.Add("IsQuantityName", typeof(string));

            DataRow IsQuantityRow1 = tableIsQuantity.NewRow();
            IsQuantityRow1["IsQuantityID"] = 0;
            IsQuantityRow1["IsQuantityName"] = "Còn tồn";
            tableIsQuantity.Rows.Add(IsQuantityRow1);

            DataRow IsQuantityRow2 = tableIsQuantity.NewRow();
            IsQuantityRow2["IsQuantityID"] = 1;
            IsQuantityRow2["IsQuantityName"] = "Hết hàng";
            tableIsQuantity.Rows.Add(IsQuantityRow2);

            my_ComboBox.SetTitle(cboIsQuantity, tableIsQuantity, "--Tất cả--", "IsQuantityID", "IsQuantityName");
        }
        public void LoadData()
        {
            data = new DataTable();

            int iType = -1;
            int.TryParse(cboType.SelectedValue.ToString(), out iType);

            int iIsQuantity = 0;
            int.TryParse(cboIsQuantity.SelectedValue.ToString(), out iIsQuantity);

            objKeywords = new object[] { "@Keyword", this.txtTukhoa.Text.Trim(),
                                         "@Type",iType,
                                          "@IsQuantity",iIsQuantity};
            data = ProductQuantityCtr.Seach(objKeywords);
            grvDanhsach.DataSource = data;
        }

        private void txtTukhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
                txtTukhoa.Focus();
                txtTukhoa.SelectAll();
            }
           
        }

        private void grvDanhsach_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grvDanhsach.Columns[e.ColumnIndex].Name == "colISSELECT")
            {
                if ((int)grvDanhsach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == 1)
                {
                    if (lisProducts.Contains(grvDanhsach.Rows[e.RowIndex].Cells["colProduct_ID"].Value.ToString()))
                        return;
                    LisProducts.Add(grvDanhsach.Rows[e.RowIndex].Cells["colProduct_ID"].Value.ToString());
                }
                else
                {
                    LisProducts.Remove(grvDanhsach.Rows[e.RowIndex].Cells["colProduct_ID"].Value.ToString());
                }
            }
        }

        private void grvDanhsach_DataSourceChanged(object sender, EventArgs e)
        {
            LisProducts.Clear();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTukhoa.Focus();
            txtTukhoa.SelectAll();
        }

    }
}
