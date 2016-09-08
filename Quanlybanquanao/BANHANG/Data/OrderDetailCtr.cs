using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class OrderDetailCtr
    {
        public static void Insert(IData objIData,OrderDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_OrderDetail_Add");
                objIData.AddParameter("@OrderDetail_ProductID", ob.OrderDetail_ProductID);
                objIData.AddParameter("@OrderDetail_OrderID", ob.OrderDetail_OrderID);
                objIData.AddParameter("@OrderDetail_Price", ob.OrderDetail_Price);
                objIData.AddParameter("@OrderDetail_Sale ", ob.OrderDetail_Sale);
                objIData.AddParameter("@OrderDetail_Quantity", ob.OrderDetail_Quantity);
                objIData.AddParameter("@OrderDetail_PriceType", ob.OrderDetail_PriceType);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static void Update(IData objIData, OrderDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_OrderDetail_Update");
                objIData.AddParameter("@OrderDetail_ProductID", ob.OrderDetail_ProductID);
                objIData.AddParameter("@OrderDetail_OrderID", ob.OrderDetail_OrderID);
                objIData.AddParameter("@OrderDetail_Price", ob.OrderDetail_Price);
                objIData.AddParameter("@OrderDetail_Sale ", ob.OrderDetail_Sale);  
                objIData.AddParameter("@OrderDetail_Quantity", ob.OrderDetail_Quantity);
                objIData.AddParameter("@OrderDetail_PriceType", ob.OrderDetail_PriceType);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static void Delete(IData objIData, OrderDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_OrderDetail_Delete");
                objIData.AddParameter("@OrderDetail_ProductID", ob.OrderDetail_ProductID);
                objIData.AddParameter("@OrderDetail_OrderID", ob.OrderDetail_OrderID);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static OrderDetailOB Select(string OrderDetail_ProductID, string OrderDetail_OrderID)
        {
            OrderDetailOB ob = new OrderDetailOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_OrderDetail_Select");
                objIData.AddParameter("@OrderDetail_ProductID", OrderDetail_ProductID);
                objIData.AddParameter("@OrderDetail_OrderID", OrderDetail_OrderID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new OrderDetailOB(data.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objIData.Disconnect();
            }
            return ob;
        }
        public static List<OrderDetailOB> SelectList(string OrderDetail_OrderID)
        {
            List<OrderDetailOB> lst = new List<OrderDetailOB>();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_OrderDetail_SelectLIST");
                objIData.AddParameter("@OrderDetail_OrderID", OrderDetail_OrderID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    OrderDetailOB ob;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        ob = new OrderDetailOB(data.Rows[i]);
                        lst.Add(ob);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objIData.Disconnect();
            }
            return lst;
        }
    }
}
