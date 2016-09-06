using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Liblary.Common
{
    public partial class ucOrderIndex : UserControl
    {
        private bool bolIsEdit = false;
        private string _ID = string.Empty;
        DataTable DataSource = null;
        private List<object> lstValueMemberList;

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public List<object> ValueMemberList
        {
            get
            {
                lstValueMemberList = new List<object>();
                if (bolIsEdit)
                {
                    DataSource.AcceptChanges();
                    foreach (DataRow row in DataSource.Rows)
                    {
                        lstValueMemberList.Add(row[ID]);
                    }
                }
                return lstValueMemberList;
            }
        }

        public ucOrderIndex()
        {
            InitializeComponent();
        }

        public void InitOrderList(DataTable dtbDataSource, String strValueMemberField, String strDisplayMemberField,
            String strOrderIndexField, object objSelectedValue)
        {
            this.bolIsEdit = false;
            this.DataSource = dtbDataSource;
            this.ID = strValueMemberField;
            try
            {
                lstOrder.DataSource = dtbDataSource;
                lstOrder.ValueMember = strValueMemberField;
                lstOrder.DisplayMember = strDisplayMemberField;
                lstOrder.SelectedValue = objSelectedValue;
            }
            catch (Exception objExc)
            {
                MessageBox.Show(objExc.ToString(), "Thông báo lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex > 0)
            {
                int intIndex = lstOrder.SelectedIndex;
                object[] objTemp = DataSource.Rows[intIndex].ItemArray;
                DataSource.Rows.RemoveAt(intIndex);
                DataRow objRow = DataSource.NewRow();
                objRow.ItemArray = objTemp;
                DataSource.Rows.InsertAt(objRow, intIndex - 1);
                lstOrder.SelectedIndex = intIndex - 1;
                bolIsEdit = true;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            if (lstOrder.SelectedIndex < lstOrder.Items.Count - 1 && lstOrder.SelectedIndex >= 0)
            {
                int intIndex = lstOrder.SelectedIndex;
                object[] objTemp = DataSource.Rows[intIndex].ItemArray;
                DataSource.Rows.RemoveAt(intIndex);
                DataRow objRow = DataSource.NewRow();
                objRow.ItemArray = objTemp;
                DataSource.Rows.InsertAt(objRow, intIndex + 1);
                lstOrder.SelectedIndex = intIndex + 1;
                bolIsEdit = true;
            }
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUp.Enabled = (lstOrder.SelectedIndex > 0);
            btnDown.Enabled = (lstOrder.SelectedIndex < lstOrder.Items.Count - 1);
        }
    }
}
