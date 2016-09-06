using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CarlosAg.ExcelXmlWriter;

namespace Liblary.Excel
{
    public class my_ExcelGenerator
    {
        public static Workbook Generate(DataGridView dataGridView)
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add("Sheet 1");
            WorksheetRow row = new WorksheetRow();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                worksheet.Table.Columns.Add(new WorksheetColumn(column.Width));
                row.Cells.Add(new WorksheetCell(column.HeaderText));
            }
            worksheet.Table.Rows.Insert(0, row);
            WorksheetStyle worksheetStyle = GetWorksheetStyle(dataGridView.DefaultCellStyle, "Default");
            workbook.Styles.Add(worksheetStyle);
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                row = worksheet.Table.Rows.Add();
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    DataGridViewCell cell = dataGridView[j, i];
                    WorksheetStyle style = GetWorksheetStyle(cell.InheritedStyle, string.Concat(new object[] { "column", j, "row", i }));
                    if (style != null)
                    {
                        workbook.Styles.Add(style);
                    }
                    else
                    {
                        style = worksheetStyle;
                    }
                    DataType dataType = GetDataType(cell.ValueType);
                    row.Cells.Add(cell.FormattedValue.ToString(), dataType, style.ID);
                }
            }
            return workbook;
        }

        private static string GetColorName(Color color)
        {
            return ("#" + color.ToArgb().ToString("X").Substring(2));
        }

        private static DataType GetDataType(Type valueType)
        {
            if (valueType == typeof(DateTime))
            {
                return DataType.String;
            }
            if (valueType == typeof(string))
            {
                return DataType.String;
            }
            if ((((valueType != typeof(sbyte)) && (valueType != typeof(byte))) && ((valueType != typeof(short)) && (valueType != typeof(ushort)))) && ((((valueType != typeof(int)) && (valueType != typeof(uint))) && ((valueType != typeof(long)) && (valueType != typeof(ulong)))) && (((valueType != typeof(float)) && (valueType != typeof(double))) && (valueType != typeof(decimal)))))
            {
                return DataType.String;
            }
            return DataType.Number;
        }

        private static WorksheetStyle GetWorksheetStyle(DataGridViewCellStyle dataGridViewCellStyle, string id)
        {
            WorksheetStyle style = null;
            if (dataGridViewCellStyle != null)
            {
                style = new WorksheetStyle(id);
                if (!dataGridViewCellStyle.BackColor.IsEmpty)
                {
                    style.Interior.Color = GetColorName(dataGridViewCellStyle.BackColor);
                }
                if (!dataGridViewCellStyle.ForeColor.IsEmpty)
                {
                    style.Font.Color = GetColorName(dataGridViewCellStyle.ForeColor);
                }
                if (dataGridViewCellStyle.Font != null)
                {
                    style.Font.Bold = dataGridViewCellStyle.Font.Bold;
                    style.Font.FontName = dataGridViewCellStyle.Font.Name;
                    style.Font.Italic = dataGridViewCellStyle.Font.Italic;
                    style.Font.Size = (int)dataGridViewCellStyle.Font.Size;
                    style.Font.Strikethrough = dataGridViewCellStyle.Font.Strikeout;
                    style.Font.Underline = dataGridViewCellStyle.Font.Underline ? UnderlineStyle.Single : UnderlineStyle.None;
                }
            }
            return style;
        }
    }
}
