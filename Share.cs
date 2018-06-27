using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.IO;

namespace BrusherLib
{
    public static class Share
    {
        public static Excel.Application ExcelApp;
        public static Office.CommandBar cmb;
        public static Microsoft.Office.Tools.ActionsPane acp;


        public static int GetColumnIndex(Excel.Range range, String colName)
        {
           Excel.Range header = range.Rows[1];   
            int colIdx = 1;
           while( colIdx <= header.Columns.Count) 
            {
                if (header.Cells[1, colIdx].Value2.ToString() == colName)
                    break;
                colIdx++;
            }
           return colIdx;

        }

        public static Object[] GetTagOfType(Excel.Range range, String type)
        {
            int colIdx_Type = Sheet2.TypeColIndex;
            int colIdx_Name = Sheet2.NameColIndex;
            ArrayList result = new ArrayList();
            for ( int i =2;i<=range.Rows.Count;i++)
            {
                if (range.Rows[i].Cells[1, colIdx_Type].Value2.ToString() == type)
                    result.Add(range.Rows[i].Cells[1, colIdx_Name].Value2);
            }
            return result.ToArray();
        }

        public static Object[] GetVersionsFromQuestion(string qID)
        {
            ArrayList result = new ArrayList();
            Excel.Range range = Globals.Code.Rows;
           
            foreach (Excel.Range row in range.Rows)
            {
                if (row.Cells[1, Code.QuestionIDIndex].Value2 == null)
                    break;
                if (row.Cells[1,Code.QuestionIDIndex].Value2.ToString() == qID)
                {
                    string ls = row.Cells[1, Code.VersionIndex].Value2.ToString() + ": " +
                        row.Cells[1, Code.CreateDateIndex].Value2.ToString();
                    result.Add(ls);
                }
            }
            return result.ToArray();
        }

        public static string GetCodeFromQIDandVersion(Excel.Range range, string qID, string version)
        {
            foreach(Excel.Range row in range.Rows)
            {
                if (row.Cells[1, Code.CodeIndex].Value2 == null)
                    continue;
                string id = row.Cells[1, Code.QuestionIDIndex].Value2.ToString();
                string ver = row.Cells[1, Code.VersionIndex].Value2.ToString();
                if(id == qID && ver == version)
                {
                    return row.Cells[1, Code.CodeIndex].Value2.ToString();
                }
            }
            return "";
        }
        public static int GetLastRowNumber(Excel.Range sheet)
        {
            int result = 0;
            foreach (Excel.Range row in sheet.Rows)
            {
                if (row.Cells[1, 1].Value2 == null)
                    break;
                result++;
            }
            return result;
        }

        public static string GetLanguageType(string path)
        {
            string ext = Path.GetExtension(path).Substring(1);
            Excel.Range r = Globals.Sheet3.UsedRange;
            foreach(Excel.Range row in r.Rows)
            {
                
                if(row.Cells[1,Sheet3.PostFixIdx].Value2.ToString() == ext)
                {
                    return row.Cells[1, Sheet3.IDIndex].Value2.ToString();
                }
            }
            return "";

        }
    }
}
