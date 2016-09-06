using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Liblary
{
    public class Lib
    {

            /// <summary>
            /// Hàm kiểm tra chuỗi chỉ gồm a-zA-Z, số, dấu chấm, dấu gạch ngang
            /// </summary>
            /// <returns></returns>
            public static bool CheckStringID(string strInput)
            {
                return CheckStringDynamic(strInput, @"[a-zA-Z0-9\.\-]");
            }
            /// <summary>
            ///Hàm kiểm tra chuỗi chỉ gồm những ký tự được truyền vào theo dạng Regex
            ///Ví dụ chỉ nhập số và ký tự không dấu thì strParamCharacters=@"[a-zA-Z0-9]"
            /// </summary>
            /// <returns></returns>
            public static bool CheckStringDynamic(string strInput, string strParamCharacters)
            {
                bool result = false;

                strInput = strInput.Trim();
                string strExp = string.Empty;
                strExp = strParamCharacters.Trim() + "{" + strInput.Length.ToString() + "}";
                result = Regex.IsMatch(strInput, strExp, RegexOptions.IgnoreCase);
                return result;
            }
            /// <summary>
            /// Kiem tra ngay bat dau va ngay ket thuc
            /// </summary>
            /// <param name="startDate"> ngay bat dau</param>
            /// <param name="endDate">ngay ket thuc</param>
            /// <returns> true nieu hop le, false nieu ngay ket thuc nho hon ngay bat dau</returns>
            public static bool EndDateValidation(DateTime startDate, DateTime endDate)
            {
                return EndDateValidation(startDate, endDate, true);
            }
            /// <summary>
            /// Kiem tra ngay bat dau va ngay ket thuc
            /// </summary>
            /// <param name="startDate"> ngay bat dau</param>
            /// <param name="endDate">ngay ket thuc</param>
            /// <param name="isCalHour">có tinh giờ luôn không ?</param>
            /// <returns> true nieu hop le, false nieu ngay ket thuc nho hon ngay bat dau</returns>
            public static bool EndDateValidation(DateTime startDate, DateTime endDate, bool isCalHour)
            {
                if (!isCalHour)
                {
                    startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0, 0);
                    endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0, 0);
                }
                System.TimeSpan diffResult = startDate.Subtract(endDate);
                if (diffResult.TotalSeconds <= 0)
                    return true;
                return false;
            }
            public static void TextNumeric_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

            }

            /// <summary>
            /// kiem tra so hop le và > 0
            /// </summary>
            /// <param name="strNumber"></param>
            /// <returns></returns>
            public static string ValidateNumber(string strNumber)
            {
                return ValidateNumber(strNumber, string.Empty);
            }
            /// <summary>
            /// kiem tra so hop le và > 0
            /// </summary>
            /// <param name="strNumber"></param>
            /// <param name="strTitle">tiêu đề thông báo khi strNumber null</param>
            /// <returns></returns>
            public static string ValidateNumber(string strNumber, string strTitle)
            {
                return ValidateNumber(strNumber, strTitle, true);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="strNumber"></param>
            /// <param name="strTitle">tiêu đề thông báo khi strNumber null</param>
            /// <param name="bolCheckGreater0">kiem tra strNumber phải lon hon 0, default là true</param>
            /// <returns></returns>
            public static string ValidateNumber(string strNumber, string strTitle, bool bolCheckGreater0)
            {
                if (string.IsNullOrWhiteSpace(strNumber))
                    return "Vui lòng nhập " + strTitle + "!";// + " không được trống!";
                int id = 0;
                if (strTitle.Length > 0)
                    strTitle = strTitle[0].ToString().ToUpper() + strTitle.Substring(1);
                if (!Int32.TryParse(strNumber, out id))
                {
                    return strTitle + " không hợp lệ!";
                }
                if (!bolCheckGreater0)
                {
                    return string.Empty;
                }
                if (id <= 0)
                {
                    return strTitle + " không được nhỏ hơn hoặc bằng 0!";
                }
                return string.Empty;
            }
            /// <summary>
            /// Hàm bo khoang trang du thua va upper ki tu dau
            /// </summary>
            /// <returns></returns>
            public static void UpperFirstLetterAndRemoveSpace(ref string strInput)
            {
                try
                {
                    if (strInput.Trim().Length > 0)
                    {
                        // bo khoang trang dau, cuoi
                        strInput = strInput.Trim();
                        // bo khoang trang du thua o giua
                        strInput = System.Text.RegularExpressions.Regex.Replace(strInput, " +", " ");
                        // upper ki tu dau tien cua moi tu
                        strInput = strInput.ToUpper();
                        var rx = new System.Text.RegularExpressions.Regex(@"(?<=\w)\w");
                        strInput = rx.Replace(strInput, new MatchEvaluator(m => m.Value.ToLowerInvariant()));
                        //  strInput = Regex.Replace(strInput, "^[a-z]", m => m.Value.ToUpper());
                    }
                }
                catch (Exception objExce)
                {
                    throw objExce;
                }

            }

            public static String nextID(string prefix, int nextNumber, int length)
            {
                string newId = "";
                newId = "0000000000000000" + nextNumber.ToString();
                newId = newId.Substring(newId.Length - length + prefix.Length) + prefix;
                return newId;
            }
    }
}
