using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace BrusherLib
{
    partial class HelloControl : UserControl
    {
        public int BoxWidth = 0;
        public HelloControl()
        {
            InitializeComponent();
            this.Name = "Hello";
            this.cBAlgo.Items.Add("None");
            this.cBDS.Items.Add("None");
            this.cBGroup.Items.Add("None");
            this.cBDS.SelectedIndex = 0;
            this.cBAlgo.SelectedIndex = 0;
            this.cBGroup.SelectedIndex = 0;
            BoxWidth = this.tBQuestion.Width;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm to save source code?", "Confirm save", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!File.Exists(this.tBPath.Text))
                {
                    MessageBox.Show("File doesn't exist");
                    return;
                }
                    
                int existingVersion = Share.GetVersionsFromQuestion(Sheet1.SelectedQuestionID).Length;
                
                int last = Share.GetLastRowNumber(Globals.Code.Rows);
                object lastID = Globals.Code.Rows.Cells[last, Code.IDIndex].Value2;
                int newRowIndex = last + 1;
                int newID = 0;
                if (lastID.ToString() == "ID")
                    newID = 1;
                else
                    newID = Int32.Parse(lastID.ToString()) + 1;
                Globals.Code.Cells[newRowIndex, Code.IDIndex] = newID;
                Globals.Code.Cells[newRowIndex, Code.CodeIndex] = String.Join("\n",File.ReadAllText(this.tBPath.Text,Encoding.UTF8));
                Globals.Code.Cells[newRowIndex, Code.QuestionIDIndex] = Sheet1.SelectedQuestionID;
                Globals.Code.Cells[newRowIndex, Code.LanguageIndex] = Share.GetLanguageType(this.tBPath.Text);
                Globals.Code.Cells[newRowIndex, Code.CreateDateIndex] = DateTime.Today.ToString("D");
                
                Globals.Code.Cells[newRowIndex, Code.VersionIndex] = existingVersion + 1;
            }
            return;
        }

        

        private void cBDS_DropDown(object sender, EventArgs e)
        {
            if (this.cBDS.Items.Count <= 1)
            {
                object[] a = Share.GetTagOfType(Globals.Sheet2.UsedRange, "DataStructure");
                foreach (object o in a)
                {
                    this.cBDS.Items.Add(o);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm to write to the sheet?","Confirm save",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Excel.Range used = Globals.Sheet1.UsedRange;
                Excel.Range last = used.Rows[used.Rows.Count];
                object lastID = last.Cells[1, Sheet1.IDIndex].Value2;
                int newRowIndex = last.Row + 1;
                int newID = 0;
                if (lastID.ToString() == "ID")
                    newID = 1;
                else
                    newID = Int32.Parse(lastID.ToString()) + 1;
                Globals.Sheet1.Cells[newRowIndex, Sheet1.IDIndex] = newID;
                Globals.Sheet1.Cells[newRowIndex, Sheet1.ContentIndex] = this.tBQuestion.Text;
                Globals.Sheet1.Cells[newRowIndex, Sheet1.CommentIndex] = this.tBComment.Text;
                Globals.Sheet1.Cells[newRowIndex, Sheet1.WhereIndex] = this.tBWhere.Text;
                Globals.Sheet1.Cells[newRowIndex, Sheet1.DSIndex] = this.cBDS.Text;
                Globals.Sheet1.Cells[newRowIndex, Sheet1.AlgoIndex] = this.cBAlgo.Text;
                Globals.Sheet1.Cells[newRowIndex, Sheet1.GroupIndex] = this.cBGroup.Text;
                Globals.Sheet1.Cells[newRowIndex, Sheet1.DateTimeIndex] = DateTime.Today.ToString("D");
            }
            

            return;
        }

        private void cBAlgo_DropDown(object sender, EventArgs e)
        {
            if (this.cBAlgo.Items.Count <= 1)
            {
                object[] a = Share.GetTagOfType(Globals.Sheet2.UsedRange, "Algo");
                foreach (object o in a)
                {
                    this.cBAlgo.Items.Add(o);
                }
            }
        }

        public void FillBoxes(Excel.Range range)
        {
            int rowIdx = range.Row;
            this.textBox3.Text = Globals.Sheet1.Cells[rowIdx, Sheet1.ContentIndex].Value2.ToString();
            this.textBox2.Text = Globals.Sheet1.Cells[rowIdx, Sheet1.CommentIndex].Value2.ToString();
            this.textBox4.Text = Globals.Sheet1.Cells[rowIdx, Sheet1.WhereIndex].Value2.ToString();
            this.textBox6.Text = Globals.Sheet1.Cells[rowIdx, Sheet1.DSIndex].Value2.ToString();
            this.textBox7.Text = Globals.Sheet1.Cells[rowIdx, Sheet1.AlgoIndex].Value2.ToString();
            this.textBox5.Text = Globals.Sheet1.Cells[rowIdx, Sheet1.GroupIndex].Value2.ToString();
            this.lbelID.Text = Sheet1.SelectedQuestionID;
        }

        public void FillVersionBox(string qID)
        {
            if (this.lBVersion.Items.Count > 0)
                this.lBVersion.Items.Clear();
            Object[] r = Share.GetVersionsFromQuestion(qID);
            foreach (Object o in r)
            {
                this.lBVersion.Items.Add(o);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tBComment.Text = "";
            this.tBQuestion.Text = "";
            this.tBWhere.Text = "";
            this.cBDS.SelectedIndex = 0;
            this.cBAlgo.SelectedIndex = 0;
            this.cBGroup.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm to save to FILE?", "Confirm save", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!File.Exists(this.tBPath.Text))
                {
                    MessageBox.Show("File doesn't exist");
                    return;
                }
                if (this.lBVersion.Items.Count > 0)
                {
                    if (this.lBVersion.SelectedItem == null)
                        this.lBVersion.SelectedIndex = 0;
                    string version = this.lBVersion.SelectedItem.ToString().Split(':')[0];
                    string code = Share.GetCodeFromQIDandVersion(Globals.Code.UsedRange, Sheet1.SelectedQuestionID, version);
                    if (code == "")
                    {
                        MessageBox.Show(String.Format("Can't find code for QID:{0} and Version:{1}", Sheet1.SelectedQuestionID, version));
                        return;
                    }
                    File.WriteAllText(this.tBPath.Text, code, Encoding.UTF8);
                    MessageBox.Show("Save to file succeed");
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int l = Globals.Code.UsedRange.Rows.Count;
            MessageBox.Show(l.ToString());          
            MessageBox.Show(Share.cmb.Width.ToString());
           
        }

        private void cBGroup_DropDown(object sender, EventArgs e)
        {
            if (this.cBGroup.Items.Count <= 1)
            {
                object[] a = Share.GetTagOfType(Globals.Sheet2.UsedRange, "Group");
                foreach (object o in a)
                {
                    this.cBGroup.Items.Add(o);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = Globals.ThisWorkbook.FullName;
            File.Copy(s, tBSharePath.Text, true);
            MessageBox.Show("Sheet is copied to " + tBSharePath.Text);
        }
    }
}
