using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccess
{
    [Serializable]
    internal class SQLData : Data, IData
    {
        // Fields
        private SqlCommand objCommand;
        private SqlConnection objConnection;
        private SqlTransaction objTransaction;
        private string strConnectionString;

        // Methods

        public SQLData(string strConnect)
        {
            this.objConnection = null;
            this.objCommand = null;
            this.objTransaction = null;
            this.strConnectionString = strConnect;
        }

        public void AddParameter(Hashtable hstParameter)
        {
            IDictionaryEnumerator enumerator = hstParameter.GetEnumerator();
            while (enumerator.MoveNext())
            {
                this.AddParameter(enumerator.Key.ToString(), enumerator.Value);
            }
        }

        public void AddParameter(params object[] objArrParam)
        {
            for (int i = 0; i < (objArrParam.Length / 2); i++)
            {
                this.AddParameter(objArrParam[i * 2].ToString().Trim(), objArrParam[(i * 2) + 1]);
            }
        }

        public void AddParameter(string strParameterName, object objValue)
        {
            this.objCommand.Parameters.AddWithValue(strParameterName, objValue);
        }

        public void AddParameter(string strParameterName, object objValue, Globals.DATATYPE enDataType)
        {
            SqlParameter parameter = new SqlParameter(strParameterName, this.GetSQLDataType(enDataType))
            {
                Value = objValue
            };
            this.objCommand.Parameters.Add(parameter);
        }

        public void BeginTransaction()
        {
            if (!this.IsConnected())
            {
                this.Connect();
            }
            this.objTransaction = this.objConnection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (this.objTransaction != null)
            {
                this.objTransaction.Commit();
            }
        }

        public bool Connect()
        {
            if (!this.IsConnected())
            {
                if (this.objConnection == null)
                {
                    this.objConnection = new SqlConnection(this.strConnectionString);
                }
                this.objConnection.Open();
            }
            return true;
        }

        public void CreateNewSqlText(string strSQL)
        {
            this.objCommand = this.SetCommand(strSQL);
            this.objCommand.CommandType = CommandType.Text;
        }

        public void CreateNewStoredProcedure(string strStoreProName)
        {
            this.objCommand = this.SetCommand(strStoreProName);
            this.objCommand.CommandType = CommandType.StoredProcedure;
        }

        public void CreateNewStoredProcedure(string strStoreProName, int intTimeOut)
        {
            this.objCommand = this.SetCommand(strStoreProName);
            this.objCommand.CommandTimeout = intTimeOut;
            this.objCommand.CommandType = CommandType.StoredProcedure;
        }

        public bool Disconnect()
        {
            try
            {
                if (this.objCommand != null)
                {
                    this.objCommand.Dispose();
                }
                this.objConnection.Close();
                SqlConnection.ClearPool(this.objConnection);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public int ExecNonQuery()
        {
            return this.objCommand.ExecuteNonQuery();
        }

        public ArrayList ExecQueryToArrayList(string strSQL)
        {
            IDataReader drReader = this.ExecQueryToDataReader(strSQL);
            ArrayList list = Globals.ConvertArrayList(drReader);
            drReader.Close();
            return list;
        }

        public byte[] ExecQueryToBinary(string strSQL)
        {
            return (byte[])this.SetCommand(strSQL).ExecuteScalar();
        }

        public IDataAdapter ExecQueryToDataAdapter(string strSQL)
        {
            return this.SetDataAdapter(strSQL);
        }

        public IDataReader ExecQueryToDataReader(string strSQL)
        {
            return this.SetCommand(strSQL).ExecuteReader();
        }

        public DataSet ExecQueryToDataSet(string strSQL)
        {
            DataSet dataSet = new DataSet();
            this.SetDataAdapter(strSQL).Fill(dataSet);
            return dataSet;
        }

        public DataTable ExecQueryToDataTable(string strSQL)
        {
            DataSet dataSet = new DataSet();
            this.SetDataAdapter(strSQL).Fill(dataSet);
            return dataSet.Tables[0];
        }

        public Hashtable ExecQueryToHashtable(string strSQL)
        {
            IDataReader drReader = this.ExecQueryToDataReader(strSQL);
            Hashtable hashtable = Globals.ConvertHashTable(drReader);
            drReader.Close();
            return hashtable;
        }

        public string ExecQueryToString(string strSQL)
        {
            object obj2 = this.SetCommand(strSQL).ExecuteScalar();
            if (obj2 == null)
            {
                return string.Empty;
            }
            return obj2.ToString().Trim();
        }

        public ArrayList ExecStoreToArrayList()
        {
            return this.ExecStoreToArrayList(string.Empty);
        }

        public ArrayList ExecStoreToArrayList(string strOutParameter)
        {
            return Globals.ConvertArrayList(this.objCommand.ExecuteReader());
        }

        public byte[] ExecStoreToBinary()
        {
            return this.ExecStoreToBinary(string.Empty);
        }

        public byte[] ExecStoreToBinary(string strOutParameter)
        {
            return (byte[])this.objCommand.ExecuteScalar();
        }

        public IDataAdapter ExecStoreToDataAdapter()
        {
            return this.ExecStoreToDataAdapter(string.Empty);
        }

        public IDataAdapter ExecStoreToDataAdapter(string strOutParameter)
        {
            return this.SetDataAdapter(this.objCommand);
        }

        public IDataReader ExecStoreToDataReader()
        {
            return this.ExecStoreToDataReader(string.Empty);
        }

        public IDataReader ExecStoreToDataReader(string strOutParameter)
        {
            return this.objCommand.ExecuteReader();
        }

        public DataSet ExecStoreToDataSet()
        {
            return this.ExecStoreToDataSet(new string[] { string.Empty });
        }

        public DataSet ExecStoreToDataSet(params string[] strOutParameter)
        {
            DataSet dataSet = new DataSet();
            this.SetDataAdapter(this.objCommand).Fill(dataSet);
            return dataSet;
        }

        public DataTable ExecStoreToDataTable()
        {
            return this.ExecStoreToDataTable(string.Empty);
        }

        public DataTable ExecStoreToDataTable(string strOutParameter)
        {
            DataSet dataSet = new DataSet();
            this.SetDataAdapter(this.objCommand).Fill(dataSet);
            return dataSet.Tables[0];
        }

        public Hashtable ExecStoreToHashtable()
        {
            return this.ExecStoreToHashtable(string.Empty);
        }

        public Hashtable ExecStoreToHashtable(string strOutParameter)
        {
            return Globals.ConvertHashTable(this.objCommand.ExecuteReader());
        }

        public string ExecStoreToString()
        {
            return this.ExecStoreToString(string.Empty);
        }

        public string ExecStoreToString(string strOutParameter)
        {
            object obj2 = this.objCommand.ExecuteScalar();
            if (obj2 == null)
            {
                return string.Empty;
            }
            return obj2.ToString().Trim();
        }

        public void ExecUpdate(string strSQL)
        {
            this.SetCommand(strSQL).ExecuteNonQuery();
        }

        public void ExecUpdate(string strSQL, params IDataParameter[] objParameters)
        {
            this.SetCommand(strSQL);
            foreach (IDataParameter parameter in objParameters)
            {
                this.objCommand.Parameters.Add(parameter);
            }
            this.objCommand.ExecuteNonQuery();
        }

        public void ExecUpdate(string strSQL, ArrayList arrParameters)
        {
            this.SetCommand(strSQL);
            foreach (IDataParameter parameter in arrParameters)
            {
                this.objCommand.Parameters.Add(parameter);
            }
            this.objCommand.ExecuteNonQuery();
        }

        ~SQLData()
        {
            if (this.IsConnected())
            {
                this.Disconnect();
            }
        }

        private SqlDbType GetSQLDataType(Globals.DATATYPE enDataType)
        {
            SqlDbType @int = SqlDbType.Int;
            switch (enDataType)
            {
                case Globals.DATATYPE.NUMBER:
                    return SqlDbType.Int;

                case Globals.DATATYPE.CHAR:
                    return SqlDbType.Char;

                case Globals.DATATYPE.VARCHAR:
                    return SqlDbType.VarChar;

                case Globals.DATATYPE.NVARCHAR:
                    return SqlDbType.NVarChar;

                case Globals.DATATYPE.NTEXT:
                    return SqlDbType.NText;

                case Globals.DATATYPE.BINARY:
                    return SqlDbType.Binary;
            }
            return @int;
        }

        public bool IsConnected()
        {
            if ((this.objConnection == null) || (this.objConnection.State != ConnectionState.Open))
            {
                return false;
            }
            return true;
        }

        public void RollBackTransaction()
        {
            if (this.objTransaction != null)
            {
                this.objTransaction.Rollback();
                this.objTransaction = null;
            }
        }

        private SqlCommand SetCommand(string strSQL)
        {
            if (this.objTransaction == null)
            {
                this.objCommand = new SqlCommand(strSQL, this.objConnection);
            }
            else
            {
                this.objCommand = new SqlCommand(strSQL, this.objConnection, this.objTransaction);
            }
            return this.objCommand;
        }

        private SqlDataAdapter SetDataAdapter(SqlCommand objCommand)
        {
            return new SqlDataAdapter(objCommand);
        }

        private SqlDataAdapter SetDataAdapter(string strSQL)
        {
            return new SqlDataAdapter(strSQL, this.objConnection);
        }

        // Properties
        IDbCommand IData.ICommand
        {
            get
            {
                return this.objCommand;
            }
            set
            {
                this.objCommand = (SqlCommand)value;
            }
        }

        IDbConnection IData.IConnection
        {
            get
            {
                return this.objConnection;
            }
            set
            {
                this.objConnection = (SqlConnection)value;
            }
        }

        IDbTransaction IData.ITransaction
        {
            get
            {
                return this.objTransaction;
            }
            set
            {
                this.objTransaction = (SqlTransaction)value;
            }
        }
    }

}
