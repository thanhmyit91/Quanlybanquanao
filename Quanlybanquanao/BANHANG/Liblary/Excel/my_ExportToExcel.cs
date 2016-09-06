using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Liblary.Excel
{
    public class my_ExportToExcel
    {
        // Methods
        public static void Export_GridView(DataGridView dtgView)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Excel file (*.xls)|*.xls",
                FileName = "Book1.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                my_ExcelGenerator.Generate(dtgView).Save(fileName);
                Process.Start(fileName);
            }
        }

    }
}
