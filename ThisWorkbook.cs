using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace BrusherLib
{
    public partial class ThisWorkbook
    {
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            Share.ExcelApp = this.Application;
            this.ActionsPane.Controls.Add(hello);
            Share.cmb = Share.ExcelApp.CommandBars["Task Pane"];
            
            Share.cmb.Position = Microsoft.Office.Core.MsoBarPosition.msoBarRight;
            Share.acp = this.ActionsPane;
            hello.Anchor = AnchorStyles.Right;
            hello.Dock = DockStyle.Fill;
            hello.AutoSize = true;
            hello.AutoSizeMode = AutoSizeMode.GrowOnly;
            Share.acp.AutoSize = true;
            Share.acp.AutoSizeMode = AutoSizeMode.GrowOnly;

            Share.acp.Dock = DockStyle.Fill;
            Share.cmb.Width = hello.BoxWidth + 65; 
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void Workbook_Open()
        {
            
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(this.ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(this.ThisWorkbook_Shutdown);

        }

        #endregion
        private HelloControl hello = new HelloControl();

    
    }
}
