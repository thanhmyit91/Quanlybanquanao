using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace DataAccess
{
    public interface IData
    {
        // Methods
        void AddParameter(Hashtable hstParameter);
        void AddParameter(params object[] objArrParam);
        void AddParameter(string strParameterName, object objValue);
        void AddParameter(string strParameterName, object objValue, Globals.DATATYPE enDataType);
        void BeginTransaction();
        void CommitTransaction();
        bool Connect();
        void CreateNewSqlText(string strSQL);
        void CreateNewStoredProcedure(string strStoreProName);
        void CreateNewStoredProcedure(string strStoreProName, int intTimeOut);
        bool Disconnect();
        void Dispose();
        int ExecNonQuery();
        ArrayList ExecQueryToArrayList(string strSQL);
        byte[] ExecQueryToBinary(string strSQL);
        IDataAdapter ExecQueryToDataAdapter(string strSQL);
        IDataReader ExecQueryToDataReader(string strSQL);
        DataSet ExecQueryToDataSet(string strSQL);
        DataTable ExecQueryToDataTable(string strSQL);
        Hashtable ExecQueryToHashtable(string strSQL);
        string ExecQueryToString(string strSQL);
        ArrayList ExecStoreToArrayList();
        ArrayList ExecStoreToArrayList(string strOutParameter);
        byte[] ExecStoreToBinary();
        byte[] ExecStoreToBinary(string strOutParameter);
        IDataAdapter ExecStoreToDataAdapter();
        IDataAdapter ExecStoreToDataAdapter(string strOutParameter);
        IDataReader ExecStoreToDataReader();
        IDataReader ExecStoreToDataReader(string strOutParameter);
        DataSet ExecStoreToDataSet();
        DataSet ExecStoreToDataSet(params string[] strOutParameter);
        DataTable ExecStoreToDataTable();
        DataTable ExecStoreToDataTable(string strOutParameter);
        Hashtable ExecStoreToHashtable();
        Hashtable ExecStoreToHashtable(string strOutParameter);
        string ExecStoreToString();
        string ExecStoreToString(string strOutParameter);
        void ExecUpdate(string strSQL);
        void ExecUpdate(string strSQL, ArrayList arrParameters);
        void ExecUpdate(string strSQL, params IDataParameter[] objParameters);
        bool IsConnected();
        void RollBackTransaction();

        // Properties
        IDbCommand ICommand { get; set; }
        IDbConnection IConnection { get; set; }
        IDbTransaction ITransaction { get; set; }
    }


}
