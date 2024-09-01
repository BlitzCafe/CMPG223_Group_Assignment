
namespace Group29_BlitzCafe
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTopMenuReport = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstDisplayMenuReport = new System.Windows.Forms.ListBox();
            this.btnConfirmMenu = new System.Windows.Forms.Button();
            this.btnPrintMenuItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpEndDateMenu = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDateMenu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbSortOrder = new System.Windows.Forms.GroupBox();
            this.rdoAsc = new System.Windows.Forms.RadioButton();
            this.rdoDesc = new System.Windows.Forms.RadioButton();
            this.lblIncomeReport = new System.Windows.Forms.Label();
            this.lstDisplayIncomeReport = new System.Windows.Forms.ListBox();
            this.btnConfirmIncome = new System.Windows.Forms.Button();
            this.btnPrintIncome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpEndDateIncome = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDateIncome = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.cmbSortBy = new System.Windows.Forms.GroupBox();
            this.rdoMonth = new System.Windows.Forms.RadioButton();
            this.rdoIncome = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.cmbSortOrder.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.cmbSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 679);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblTopMenuReport);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lstDisplayMenuReport);
            this.tabPage1.Controls.Add(this.btnConfirmMenu);
            this.tabPage1.Controls.Add(this.btnPrintMenuItem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1173, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Top 5 Menu Items Per Time Period";
            // 
            // lblTopMenuReport
            // 
            this.lblTopMenuReport.AutoSize = true;
            this.lblTopMenuReport.Location = new System.Drawing.Point(25, 362);
            this.lblTopMenuReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopMenuReport.Name = "lblTopMenuReport";
            this.lblTopMenuReport.Size = new System.Drawing.Size(0, 22);
            this.lblTopMenuReport.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bauhaus 93", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(601, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Report of Top 5 Menu Items per Time Period";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lstDisplayMenuReport
            // 
            this.lstDisplayMenuReport.FormattingEnabled = true;
            this.lstDisplayMenuReport.ItemHeight = 22;
            this.lstDisplayMenuReport.Location = new System.Drawing.Point(32, 305);
            this.lstDisplayMenuReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDisplayMenuReport.Name = "lstDisplayMenuReport";
            this.lstDisplayMenuReport.Size = new System.Drawing.Size(1117, 312);
            this.lstDisplayMenuReport.TabIndex = 6;
            // 
            // btnConfirmMenu
            // 
            this.btnConfirmMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.btnConfirmMenu.Location = new System.Drawing.Point(918, 191);
            this.btnConfirmMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmMenu.Name = "btnConfirmMenu";
            this.btnConfirmMenu.Size = new System.Drawing.Size(231, 65);
            this.btnConfirmMenu.TabIndex = 5;
            this.btnConfirmMenu.Text = "Display Report";
            this.btnConfirmMenu.UseVisualStyleBackColor = false;
            this.btnConfirmMenu.Click += new System.EventHandler(this.btnConfirmMenu_Click);
            // 
            // btnPrintMenuItem
            // 
            this.btnPrintMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(100)))));
            this.btnPrintMenuItem.Location = new System.Drawing.Point(918, 80);
            this.btnPrintMenuItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintMenuItem.Name = "btnPrintMenuItem";
            this.btnPrintMenuItem.Size = new System.Drawing.Size(231, 65);
            this.btnPrintMenuItem.TabIndex = 4;
            this.btnPrintMenuItem.Text = "Print";
            this.btnPrintMenuItem.UseVisualStyleBackColor = false;
            this.btnPrintMenuItem.Click += new System.EventHandler(this.btnPrintMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Report status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEndDateMenu);
            this.groupBox2.Controls.Add(this.dtpBeginDateMenu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(32, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(840, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dates";
            // 
            // dtpEndDateMenu
            // 
            this.dtpEndDateMenu.Location = new System.Drawing.Point(240, 111);
            this.dtpEndDateMenu.Name = "dtpEndDateMenu";
            this.dtpEndDateMenu.Size = new System.Drawing.Size(200, 29);
            this.dtpEndDateMenu.TabIndex = 5;
            // 
            // dtpBeginDateMenu
            // 
            this.dtpBeginDateMenu.Location = new System.Drawing.Point(240, 49);
            this.dtpBeginDateMenu.Name = "dtpBeginDateMenu";
            this.dtpBeginDateMenu.Size = new System.Drawing.Size(200, 29);
            this.dtpBeginDateMenu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ending Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beginning Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.cmbSortBy);
            this.tabPage2.Controls.Add(this.cmbSortOrder);
            this.tabPage2.Controls.Add(this.lblIncomeReport);
            this.tabPage2.Controls.Add(this.lstDisplayIncomeReport);
            this.tabPage2.Controls.Add(this.btnConfirmIncome);
            this.tabPage2.Controls.Add(this.btnPrintIncome);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1173, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Income Per Time Period";
            // 
            // cmbSortOrder
            // 
            this.cmbSortOrder.Controls.Add(this.rdoAsc);
            this.cmbSortOrder.Controls.Add(this.rdoDesc);
            this.cmbSortOrder.Location = new System.Drawing.Point(694, 69);
            this.cmbSortOrder.Name = "cmbSortOrder";
            this.cmbSortOrder.Size = new System.Drawing.Size(200, 189);
            this.cmbSortOrder.TabIndex = 15;
            this.cmbSortOrder.TabStop = false;
            this.cmbSortOrder.Text = "Sort Order";
            // 
            // rdoAsc
            // 
            this.rdoAsc.AutoSize = true;
            this.rdoAsc.Location = new System.Drawing.Point(40, 47);
            this.rdoAsc.Name = "rdoAsc";
            this.rdoAsc.Size = new System.Drawing.Size(120, 26);
            this.rdoAsc.TabIndex = 5;
            this.rdoAsc.TabStop = true;
            this.rdoAsc.Text = "Ascending";
            this.rdoAsc.UseVisualStyleBackColor = true;
            this.rdoAsc.CheckedChanged += new System.EventHandler(this.rdbDateIncomeAsce_CheckedChanged);
            // 
            // rdoDesc
            // 
            this.rdoDesc.AutoSize = true;
            this.rdoDesc.Location = new System.Drawing.Point(40, 108);
            this.rdoDesc.Name = "rdoDesc";
            this.rdoDesc.Size = new System.Drawing.Size(130, 26);
            this.rdoDesc.TabIndex = 4;
            this.rdoDesc.TabStop = true;
            this.rdoDesc.Text = "Descending";
            this.rdoDesc.UseVisualStyleBackColor = true;
            this.rdoDesc.CheckedChanged += new System.EventHandler(this.rdbIncomeDesc_CheckedChanged);
            // 
            // lblIncomeReport
            // 
            this.lblIncomeReport.AutoSize = true;
            this.lblIncomeReport.Location = new System.Drawing.Point(24, 332);
            this.lblIncomeReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomeReport.Name = "lblIncomeReport";
            this.lblIncomeReport.Size = new System.Drawing.Size(0, 22);
            this.lblIncomeReport.TabIndex = 14;
            // 
            // lstDisplayIncomeReport
            // 
            this.lstDisplayIncomeReport.FormattingEnabled = true;
            this.lstDisplayIncomeReport.ItemHeight = 22;
            this.lstDisplayIncomeReport.Location = new System.Drawing.Point(29, 307);
            this.lstDisplayIncomeReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDisplayIncomeReport.Name = "lstDisplayIncomeReport";
            this.lstDisplayIncomeReport.Size = new System.Drawing.Size(1114, 312);
            this.lstDisplayIncomeReport.TabIndex = 13;
            // 
            // btnConfirmIncome
            // 
            this.btnConfirmIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.btnConfirmIncome.Location = new System.Drawing.Point(912, 193);
            this.btnConfirmIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmIncome.Name = "btnConfirmIncome";
            this.btnConfirmIncome.Size = new System.Drawing.Size(231, 65);
            this.btnConfirmIncome.TabIndex = 12;
            this.btnConfirmIncome.Text = "Display Report";
            this.btnConfirmIncome.UseVisualStyleBackColor = false;
            this.btnConfirmIncome.Click += new System.EventHandler(this.btnConfirmIncome_Click);
            // 
            // btnPrintIncome
            // 
            this.btnPrintIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(100)))));
            this.btnPrintIncome.Location = new System.Drawing.Point(912, 80);
            this.btnPrintIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintIncome.Name = "btnPrintIncome";
            this.btnPrintIncome.Size = new System.Drawing.Size(231, 65);
            this.btnPrintIncome.TabIndex = 11;
            this.btnPrintIncome.Text = "Print";
            this.btnPrintIncome.UseVisualStyleBackColor = false;
            this.btnPrintIncome.Click += new System.EventHandler(this.btnPrintIncome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Report status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpEndDateIncome);
            this.groupBox3.Controls.Add(this.dtpBeginDateIncome);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(31, 69);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(461, 189);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dates";
            // 
            // dtpEndDateIncome
            // 
            this.dtpEndDateIncome.Location = new System.Drawing.Point(218, 105);
            this.dtpEndDateIncome.Name = "dtpEndDateIncome";
            this.dtpEndDateIncome.Size = new System.Drawing.Size(200, 29);
            this.dtpEndDateIncome.TabIndex = 5;
            // 
            // dtpBeginDateIncome
            // 
            this.dtpBeginDateIncome.Location = new System.Drawing.Point(218, 47);
            this.dtpBeginDateIncome.Name = "dtpBeginDateIncome";
            this.dtpBeginDateIncome.Size = new System.Drawing.Size(200, 29);
            this.dtpBeginDateIncome.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ending Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Beginning Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(467, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Report of Income per Time Period";
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.Controls.Add(this.rdoMonth);
            this.cmbSortBy.Controls.Add(this.rdoIncome);
            this.cmbSortBy.Location = new System.Drawing.Point(509, 69);
            this.cmbSortBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Padding = new System.Windows.Forms.Padding(4);
            this.cmbSortBy.Size = new System.Drawing.Size(178, 189);
            this.cmbSortBy.TabIndex = 16;
            this.cmbSortBy.TabStop = false;
            this.cmbSortBy.Text = "Sort By";
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.Location = new System.Drawing.Point(42, 108);
            this.rdoMonth.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(85, 26);
            this.rdoMonth.TabIndex = 3;
            this.rdoMonth.TabStop = true;
            this.rdoMonth.Text = "Month";
            this.rdoMonth.UseVisualStyleBackColor = true;
            // 
            // rdoIncome
            // 
            this.rdoIncome.AutoSize = true;
            this.rdoIncome.Location = new System.Drawing.Point(42, 47);
            this.rdoIncome.Margin = new System.Windows.Forms.Padding(4);
            this.rdoIncome.Name = "rdoIncome";
            this.rdoIncome.Size = new System.Drawing.Size(94, 26);
            this.rdoIncome.TabIndex = 2;
            this.rdoIncome.TabStop = true;
            this.rdoIncome.Text = "Income";
            this.rdoIncome.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1200, 697);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reports";
            this.Text = "Reports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.cmbSortOrder.ResumeLayout(false);
            this.cmbSortOrder.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.cmbSortBy.ResumeLayout(false);
            this.cmbSortBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstDisplayMenuReport;
        private System.Windows.Forms.Button btnConfirmMenu;
        private System.Windows.Forms.Button btnPrintMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDisplayIncomeReport;
        private System.Windows.Forms.Button btnConfirmIncome;
        private System.Windows.Forms.Button btnPrintIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTopMenuReport;
        private System.Windows.Forms.Label lblIncomeReport;
        private System.Windows.Forms.DateTimePicker dtpEndDateMenu;
        private System.Windows.Forms.DateTimePicker dtpBeginDateMenu;
        private System.Windows.Forms.DateTimePicker dtpEndDateIncome;
        private System.Windows.Forms.DateTimePicker dtpBeginDateIncome;
        private System.Windows.Forms.RadioButton rdoDesc;
        private System.Windows.Forms.RadioButton rdoAsc;
        private System.Windows.Forms.GroupBox cmbSortOrder;
        private System.Windows.Forms.GroupBox cmbSortBy;
        private System.Windows.Forms.RadioButton rdoMonth;
        private System.Windows.Forms.RadioButton rdoIncome;
    }
}