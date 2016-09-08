using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Liblary.Control;
using Data;
using Entity;

namespace BANHANG
{
    public partial class frmCustomer_Use : Form
    {
        DataTable data;
        private object[] objKeywords = null;

        private string _CustomerID = string.Empty;

        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        public frmCustomer_Use()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void frmCustomer_Use_Load(object sender, EventArgs e)
        {
            InitControl();
            CustomerID = string.Empty;
            //LoadData();
        }

        public void LoadData()
        {
            data = new DataTable();
            objKeywords = new object[] { "@Keyword", this.txtTukhoa.Text.Trim(),
                                         "@Type", (int)cboType.SelectedValue};
            data = CustomerCtr.Seach_Use(objKeywords);
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
            tableTypeRow1["TypeName"] = "Mã khách hàng";

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
            tableTypeRow4["TypeName"] = "Facbook";
            tableType.Rows.Add(tableTypeRow4);

            DataRow tableTypeRow5 = tableType.NewRow();
            tableTypeRow5["TypeID"] = 4;
            tableTypeRow5["TypeName"] = "Zalo";
            tableType.Rows.Add(tableTypeRow5);

            my_ComboBox.SetTitle(cboType, tableType,"--Tất cả--", "TypeID", "TypeName");
        }

        private void grvDanhsach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Select();
            }
        }

        private void grvDanhsach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Select();
        }

        private void Select()
        {
            if (grvDanhsach.SelectedRows.Count < 0)
                return;
            if (grvDanhsach.CurrentRow.Cells["colCustomer_ID"].Value.ToString() != string.Empty)
            {
                CustomerID = grvDanhsach.CurrentRow.Cells["colCustomer_ID"].Value.ToString();
                this.Close();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTukhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }
    }
}
