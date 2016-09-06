using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Liblary.Excel
{
    public class my_Excel
    {
        public static DataTable getDataExcel(string Sheet)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Excell File(*.xls)|*.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"", dialog.FileName));
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    command = new OleDbCommand("SELECT * FROM [" + Sheet + "$] ", connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
                catch
                {

                }
            }
            return null;
        }

        public static DataTable getDataExcel(string Sheet, string filename)
        {
           
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Excell File(*.xls)|*.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"", filename));
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    command = new OleDbCommand("SELECT * FROM [" + Sheet + "$] ", connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
                catch
                {

                }
            }
            return null;
        }
    }
}
