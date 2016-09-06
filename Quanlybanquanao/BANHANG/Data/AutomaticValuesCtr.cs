using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;

namespace Data
{
    public class AutomaticValuesCtr
    {
        public static DataTable GetAutoId(string TableName)
        {
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_GetAutoId");
                objIData.AddParameter("@TableName", TableName);
                data = objIData.ExecStoreToDataTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objIData.Disconnect();
            }
            return data;
        }

        public static void UpdLastAutoId(string TableName, string LastId)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_UpdLastAutoId");
                objIData.AddParameter("@TableName", TableName);
                objIData.AddParameter("@LastId", LastId);
                objIData.ExecNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objIData.Disconnect();
            }
        }
    }
}
