using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Data;
using Entity;

namespace BANHANG
{
   public class LibCore
    {
       public string CreateId(string TableName)
       {
           DataTable data = new DataTable();
           string newId = "";
           try
           {

               data = AutomaticValuesCtr.GetAutoId(TableName);
               if (data.Rows.Count == 0)
               {
                   MessageBox.Show("Vui lòng cấu hình tạo mã tự động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return newId;
               }
               else
               {
                   string prefix = Convert.ToString(data.Rows[0]["PrefixOfDefaultValueForId"]).Trim();
                   int length = Convert.ToInt32(data.Rows[0]["LengthOfDefaultValueForId"]);
                   string lastValue = Convert.ToString(data.Rows[0]["LastValueOfColumnId"]).Trim();
                   int nextNumber = Convert.ToInt32(lastValue.Substring(prefix.Length)) + 1;
                   newId = "0000000000000000" + nextNumber.ToString();
                   newId = prefix + newId.Substring(newId.Length - length + prefix.Length);
                   AutomaticValuesCtr.UpdLastAutoId(TableName, newId);
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
           return newId;
       }
    }
}
