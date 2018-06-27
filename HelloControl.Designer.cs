namespace BrusherLib
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class HelloControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.lbelID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBSharePath = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lBVersion = new System.Windows.Forms.ListBox();
            this.tBPath = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabSave = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cBGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBAlgo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBDS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBWhere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBQuestion = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabLoad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLoad);
            this.tabControl1.Controls.Add(this.tabSave);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 774);
            this.tabControl1.TabIndex = 1;
            // 
            // tabLoad
            // 
            this.tabLoad.AutoScroll = true;
            this.tabLoad.Controls.Add(this.lbelID);
            this.tabLoad.Controls.Add(this.groupBox1);
            this.tabLoad.Controls.Add(this.textBox7);
            this.tabLoad.Controls.Add(this.label13);
            this.tabLoad.Controls.Add(this.textBox6);
            this.tabLoad.Controls.Add(this.label12);
            this.tabLoad.Controls.Add(this.textBox5);
            this.tabLoad.Controls.Add(this.label11);
            this.tabLoad.Controls.Add(this.textBox4);
            this.tabLoad.Controls.Add(this.label10);
            this.tabLoad.Controls.Add(this.label8);
            this.tabLoad.Controls.Add(this.textBox2);
            this.tabLoad.Controls.Add(this.label9);
            this.tabLoad.Controls.Add(this.textBox3);
            this.tabLoad.Location = new System.Drawing.Point(4, 25);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoad.Size = new System.Drawing.Size(734, 745);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "LoadFromQuestion";
            this.tabLoad.UseVisualStyleBackColor = true;
            // 
            // lbelID
            // 
            this.lbelID.AutoSize = true;
            this.lbelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbelID.Location = new System.Drawing.Point(104, 3);
            this.lbelID.Name = "lbelID";
            this.lbelID.Size = new System.Drawing.Size(0, 17);
            this.lbelID.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBSharePath);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lBVersion);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tBPath);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(6, 543);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 196);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source File";
            // 
            // tBSharePath
            // 
            this.tBSharePath.Location = new System.Drawing.Point(6, 101);
            this.tBSharePath.Name = "tBSharePath";
            this.tBSharePath.Size = new System.Drawing.Size(437, 22);
            this.tBSharePath.TabIndex = 21;
            this.tBSharePath.Text = "C:\\Users\\Guangchao\\OneDrive\\Coding\\BrusherLib\\BrusherLib1.xlsx";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(6, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 36);
            this.button5.TabIndex = 20;
            this.button5.Text = "Save to Share";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.Location = new System.Drawing.Point(335, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "Load to File";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Version";
            // 
            // lBVersion
            // 
            this.lBVersion.FormattingEnabled = true;
            this.lBVersion.ItemHeight = 16;
            this.lBVersion.Location = new System.Drawing.Point(464, 41);
            this.lBVersion.Name = "lBVersion";
            this.lBVersion.Size = new System.Drawing.Size(238, 132);
            this.lBVersion.TabIndex = 17;
            // 
            // tBPath
            // 
            this.tBPath.Location = new System.Drawing.Point(6, 21);
            this.tBPath.Name = "tBPath";
            this.tBPath.Size = new System.Drawing.Size(437, 22);
            this.tBPath.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(376, 513);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(279, 22);
            this.textBox7.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Algorithm";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(114, 513);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(183, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 513);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "DataStructure";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(527, 463);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Group";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 466);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(322, 22);
            this.textBox4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Where";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Comment";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(18, 326);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(693, 118);
            this.textBox2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Question";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(21, 31);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(693, 260);
            this.textBox3.TabIndex = 4;
            // 
            // tabSave
            // 
            this.tabSave.AutoScroll = true;
            this.tabSave.Controls.Add(this.button4);
            this.tabSave.Controls.Add(this.button2);
            this.tabSave.Controls.Add(this.btnSave);
            this.tabSave.Controls.Add(this.label6);
            this.tabSave.Controls.Add(this.cBGroup);
            this.tabSave.Controls.Add(this.label5);
            this.tabSave.Controls.Add(this.cBAlgo);
            this.tabSave.Controls.Add(this.label4);
            this.tabSave.Controls.Add(this.cBDS);
            this.tabSave.Controls.Add(this.label3);
            this.tabSave.Controls.Add(this.tBWhere);
            this.tabSave.Controls.Add(this.label2);
            this.tabSave.Controls.Add(this.tBComment);
            this.tabSave.Controls.Add(this.label1);
            this.tabSave.Controls.Add(this.tBQuestion);
            this.tabSave.Location = new System.Drawing.Point(4, 25);
            this.tabSave.Name = "tabSave";
            this.tabSave.Padding = new System.Windows.Forms.Padding(3);
            this.tabSave.Size = new System.Drawing.Size(734, 745);
            this.tabSave.TabIndex = 1;
            this.tabSave.Text = "Add Question";
            this.tabSave.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(338, 647);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 647);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 647);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Group";
            // 
            // cBGroup
            // 
            this.cBGroup.FormattingEnabled = true;
            this.cBGroup.Location = new System.Drawing.Point(558, 594);
            this.cBGroup.Name = "cBGroup";
            this.cBGroup.Size = new System.Drawing.Size(121, 24);
            this.cBGroup.TabIndex = 10;
            this.cBGroup.DropDown += new System.EventHandler(this.cBGroup_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Algo";
            // 
            // cBAlgo
            // 
            this.cBAlgo.FormattingEnabled = true;
            this.cBAlgo.Location = new System.Drawing.Point(229, 594);
            this.cBAlgo.Name = "cBAlgo";
            this.cBAlgo.Size = new System.Drawing.Size(281, 24);
            this.cBAlgo.TabIndex = 8;
            this.cBAlgo.DropDown += new System.EventHandler(this.cBAlgo_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "DataStructure";
            // 
            // cBDS
            // 
            this.cBDS.FormattingEnabled = true;
            this.cBDS.Location = new System.Drawing.Point(17, 594);
            this.cBDS.Name = "cBDS";
            this.cBDS.Size = new System.Drawing.Size(182, 24);
            this.cBDS.TabIndex = 6;
            this.cBDS.DropDown += new System.EventHandler(this.cBDS_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Where";
            // 
            // tBWhere
            // 
            this.tBWhere.Location = new System.Drawing.Point(20, 519);
            this.tBWhere.Name = "tBWhere";
            this.tBWhere.Size = new System.Drawing.Size(364, 22);
            this.tBWhere.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comment";
            // 
            // tBComment
            // 
            this.tBComment.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBComment.Location = new System.Drawing.Point(20, 360);
            this.tBComment.Multiline = true;
            this.tBComment.Name = "tBComment";
            this.tBComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBComment.Size = new System.Drawing.Size(694, 105);
            this.tBComment.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // tBQuestion
            // 
            this.tBQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBQuestion.Location = new System.Drawing.Point(20, 34);
            this.tBQuestion.Multiline = true;
            this.tBQuestion.Name = "tBQuestion";
            this.tBQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBQuestion.Size = new System.Drawing.Size(694, 294);
            this.tBQuestion.TabIndex = 0;
            // 
            // HelloControl
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.tabControl1);
            this.Name = "HelloControl";
            this.Size = new System.Drawing.Size(745, 778);
            this.tabControl1.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.tabLoad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSave.ResumeLayout(false);
            this.tabSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLoad;
        private System.Windows.Forms.TabPage tabSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBAlgo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBDS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBWhere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBQuestion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lBVersion;
        private System.Windows.Forms.Label lbelID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tBSharePath;
    }
}
