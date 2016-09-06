using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Liblary.Control
{
    public class my_ComboBox
    {
        #region Enum
        /// <summary>
        /// Biến Enum
        /// 0: Là giá trị mặc định
        /// 1: Là tên cột
        /// </summary>
        public enum DefaultValue
        {
            IsDefaultValue = 0,
            IsColumnName = 1
        }

        #endregion

        #region Load Default Value
        public static void LoadDefaultValue(DataTable dtbData, System.Windows.Forms.ComboBox cboDestination, DefaultValue enuDefaultValue, string strDefaultValue, int intColumnIndexValueMamber)
        {
            try
            {
                if (enuDefaultValue == DefaultValue.IsDefaultValue)
                {
                    for (int intIndex = 0; intIndex < cboDestination.Items.Count; intIndex++)
                    {
                        String str = dtbData.Rows[intIndex][intColumnIndexValueMamber].ToString().Trim();
                        if (strDefaultValue.Equals(str))
                        {
                            cboDestination.SelectedIndex = intIndex;
                            break;
                        }
                    }
                }
                else if (enuDefaultValue == DefaultValue.IsColumnName)
                {
                    DataRow[] rows = dtbData.Select(dtbData.Columns[strDefaultValue].ColumnName + " = 1");
                    if (rows.Length > 0)
                    {
                        cboDestination.SelectedValue = rows[0][intColumnIndexValueMamber].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Set DataSource
        public static void SetDataSource(System.Windows.Forms.ComboBox cboDestination,DataTable dtbData, string strColumnNameValueMamber, string strColumnNameDisplayMember)
        {
            try
            {
                cboDestination.DataSource = dtbData;
                cboDestination.ValueMember = strColumnNameValueMamber;
                cboDestination.DisplayMember = strColumnNameDisplayMember;
                if (cboDestination.Items.Count > 0)
                    cboDestination.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Set Title
        public static void SetTitle(System.Windows.Forms.ComboBox cboDestination, DataTable dtbData, string strTitle, string strColumnNameValueMamber, string strColumnNameDisplayMember)
        {
            DataRow dtrAllOption = dtbData.NewRow();
            dtrAllOption[strColumnNameValueMamber] = "-1";
            dtrAllOption[strColumnNameDisplayMember] = strTitle;
            dtbData.Rows.InsertAt(dtrAllOption, 0);
            cboDestination.DataSource = dtbData;
            cboDestination.ValueMember = strColumnNameValueMamber;
            cboDestination.DisplayMember = strColumnNameDisplayMember;
            cboDestination.SelectedValue = -1;
        }
        #endregion
    }
}
