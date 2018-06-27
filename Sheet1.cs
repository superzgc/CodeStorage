using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace BrusherLib
{
    public partial class Sheet1
    {
        public static int IDIndex = 1;
        public static int ContentIndex = 2;
        public static int CommentIndex = 3;
        public static int WhereIndex = 4;
        public static int DSIndex = 5;
        public static int AlgoIndex = 6;
        public static int DateTimeIndex = 8;
        public static int GroupIndex = 7;
        public static string SelectedQuestionID = "";
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
           
         
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.formInput.Selected += new Microsoft.Office.Interop.Excel.DocEvents_SelectionChangeEventHandler(this.formInput_Selected);
            this.SelectionChange += new Microsoft.Office.Interop.Excel.DocEvents_SelectionChangeEventHandler(this.Sheet1_SelectionChange);
            this.Startup += new System.EventHandler(this.Sheet1_Startup);
            this.Shutdown += new System.EventHandler(this.Sheet1_Shutdown);

        }

        #endregion

        private void formInput_Selected(Excel.Range Target)
        {

        }

        private void Sheet1_SelectionChange(Excel.Range Target)
        {
            object temp = this.Cells[Target.Row, Sheet1.IDIndex].Value2;
            if (temp == null) return;
            string id = temp.ToString();
            if (id != "ID" && id != String.Empty)
            {
                Control[] ctls = Globals.ThisWorkbook.ActionsPane.Controls.Find("Hello", false);
                HelloControl user = (HelloControl)ctls[0];
                SelectedQuestionID = id;
                user.FillBoxes(Target);
                user.FillVersionBox(id);
            }
        }

    
    }
}
