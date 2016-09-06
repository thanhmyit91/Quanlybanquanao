using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Liblary.Common
{
    public partial class frmOrderIndex : Form
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
        public frmOrderIndex()
        {
            InitializeComponent();
        }

        public void InitOrderList(DataTable dtbDataSource, String strValueMemberField, String strDisplayMemberField)
        {
            this.bolIsEdit = false;
            this.DataSource = dtbDataSource;
            this.ID = strValueMemberField;
            try
            {
                lstOrder.DataSource = dtbDataSource;
                lstOrder.ValueMember = strValueMemberField;
                lstOrder.DisplayMember = strDisplayMemberField;
                lstOrder.SelectedIndex = 0;
            }
            catch (Exception objExc)
            {
                MessageBox.Show(objExc.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrderIndex_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width/2 - this.Width/2, 0);
        }
    }
}
