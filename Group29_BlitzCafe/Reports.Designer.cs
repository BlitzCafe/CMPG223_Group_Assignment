
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
            this.lstDisplayMenuReport = new System.Windows.Forms.ListBox();
            this.btnConfirmMenu = new System.Windows.Forms.Button();
            this.btnPrintMenuItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDateDesc = new System.Windows.Forms.RadioButton();
            this.rdoDateMenuAsc = new System.Windows.Forms.RadioButton();
            this.rdoItemDesc = new System.Windows.Forms.RadioButton();
            this.rdoMenuAsc = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstDisplayIncomeReport = new System.Windows.Forms.ListBox();
            this.btnConfirmIncome = new System.Windows.Forms.Button();
            this.btnPrintIncome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoDateIncomeDesc = new System.Windows.Forms.RadioButton();
            this.rdoDateIncomeAsc = new System.Windows.Forms.RadioButton();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIncomeReport = new System.Windows.Forms.Label();
            this.lblTopMenuReport = new System.Windows.Forms.Label();
            this.dtpBeginDateMenu = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateMenu = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDateIncome = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateIncome = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTopMenuReport);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lstDisplayMenuReport);
            this.tabPage1.Controls.Add(this.btnConfirmMenu);
            this.tabPage1.Controls.Add(this.btnPrintMenuItem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1039, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Top 5 Menu Items Per Time Period";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstDisplayMenuReport
            // 
            this.lstDisplayMenuReport.FormattingEnabled = true;
            this.lstDisplayMenuReport.ItemHeight = 16;
            this.lstDisplayMenuReport.Location = new System.Drawing.Point(28, 394);
            this.lstDisplayMenuReport.Margin = new System.Windows.Forms.Padding(4);
            this.lstDisplayMenuReport.Name = "lstDisplayMenuReport";
            this.lstDisplayMenuReport.Size = new System.Drawing.Size(979, 260);
            this.lstDisplayMenuReport.TabIndex = 6;
            // 
            // btnConfirmMenu
            // 
            this.btnConfirmMenu.Location = new System.Drawing.Point(652, 249);
            this.btnConfirmMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmMenu.Name = "btnConfirmMenu";
            this.btnConfirmMenu.Size = new System.Drawing.Size(147, 52);
            this.btnConfirmMenu.TabIndex = 5;
            this.btnConfirmMenu.Text = "Display Report";
            this.btnConfirmMenu.UseVisualStyleBackColor = true;
            this.btnConfirmMenu.Click += new System.EventHandler(this.btnConfirmMenu_Click);
            // 
            // btnPrintMenuItem
            // 
            this.btnPrintMenuItem.Location = new System.Drawing.Point(659, 334);
            this.btnPrintMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintMenuItem.Name = "btnPrintMenuItem";
            this.btnPrintMenuItem.Size = new System.Drawing.Size(140, 52);
            this.btnPrintMenuItem.TabIndex = 4;
            this.btnPrintMenuItem.Text = "Print";
            this.btnPrintMenuItem.UseVisualStyleBackColor = true;
            this.btnPrintMenuItem.Click += new System.EventHandler(this.btnPrintMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Report status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEndDateMenu);
            this.groupBox2.Controls.Add(this.dtpBeginDateMenu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(398, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(401, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ending Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beginning Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDateDesc);
            this.groupBox1.Controls.Add(this.rdoDateMenuAsc);
            this.groupBox1.Controls.Add(this.rdoItemDesc);
            this.groupBox1.Controls.Add(this.rdoMenuAsc);
            this.groupBox1.Location = new System.Drawing.Point(28, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(352, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By";
            // 
            // rdoDateDesc
            // 
            this.rdoDateDesc.AutoSize = true;
            this.rdoDateDesc.Location = new System.Drawing.Point(23, 182);
            this.rdoDateDesc.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDateDesc.Name = "rdoDateDesc";
            this.rdoDateDesc.Size = new System.Drawing.Size(145, 21);
            this.rdoDateDesc.TabIndex = 3;
            this.rdoDateDesc.TabStop = true;
            this.rdoDateDesc.Text = "Dates Descending";
            this.rdoDateDesc.UseVisualStyleBackColor = true;
            // 
            // rdoDateMenuAsc
            // 
            this.rdoDateMenuAsc.AutoSize = true;
            this.rdoDateMenuAsc.Location = new System.Drawing.Point(23, 134);
            this.rdoDateMenuAsc.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDateMenuAsc.Name = "rdoDateMenuAsc";
            this.rdoDateMenuAsc.Size = new System.Drawing.Size(136, 21);
            this.rdoDateMenuAsc.TabIndex = 2;
            this.rdoDateMenuAsc.TabStop = true;
            this.rdoDateMenuAsc.Text = "Dates Ascending";
            this.rdoDateMenuAsc.UseVisualStyleBackColor = true;
            // 
            // rdoItemDesc
            // 
            this.rdoItemDesc.AutoSize = true;
            this.rdoItemDesc.Location = new System.Drawing.Point(23, 89);
            this.rdoItemDesc.Margin = new System.Windows.Forms.Padding(4);
            this.rdoItemDesc.Name = "rdoItemDesc";
            this.rdoItemDesc.Size = new System.Drawing.Size(213, 21);
            this.rdoItemDesc.TabIndex = 1;
            this.rdoItemDesc.TabStop = true;
            this.rdoItemDesc.Text = "Menu Items Descending(Z-A)";
            this.rdoItemDesc.UseVisualStyleBackColor = true;
            // 
            // rdoMenuAsc
            // 
            this.rdoMenuAsc.AutoSize = true;
            this.rdoMenuAsc.Location = new System.Drawing.Point(23, 41);
            this.rdoMenuAsc.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMenuAsc.Name = "rdoMenuAsc";
            this.rdoMenuAsc.Size = new System.Drawing.Size(204, 21);
            this.rdoMenuAsc.TabIndex = 0;
            this.rdoMenuAsc.TabStop = true;
            this.rdoMenuAsc.Text = "Menu Items Ascending(A-Z)";
            this.rdoMenuAsc.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblIncomeReport);
            this.tabPage2.Controls.Add(this.lstDisplayIncomeReport);
            this.tabPage2.Controls.Add(this.btnConfirmIncome);
            this.tabPage2.Controls.Add(this.btnPrintIncome);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1039, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Income Per Time Period";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstDisplayIncomeReport
            // 
            this.lstDisplayIncomeReport.FormattingEnabled = true;
            this.lstDisplayIncomeReport.ItemHeight = 16;
            this.lstDisplayIncomeReport.Location = new System.Drawing.Point(27, 362);
            this.lstDisplayIncomeReport.Margin = new System.Windows.Forms.Padding(4);
            this.lstDisplayIncomeReport.Name = "lstDisplayIncomeReport";
            this.lstDisplayIncomeReport.Size = new System.Drawing.Size(979, 292);
            this.lstDisplayIncomeReport.TabIndex = 13;
            // 
            // btnConfirmIncome
            // 
            this.btnConfirmIncome.Location = new System.Drawing.Point(671, 214);
            this.btnConfirmIncome.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmIncome.Name = "btnConfirmIncome";
            this.btnConfirmIncome.Size = new System.Drawing.Size(147, 52);
            this.btnConfirmIncome.TabIndex = 12;
            this.btnConfirmIncome.Text = "Confirrm";
            this.btnConfirmIncome.UseVisualStyleBackColor = true;
            this.btnConfirmIncome.Click += new System.EventHandler(this.btnConfirmIncome_Click);
            // 
            // btnPrintIncome
            // 
            this.btnPrintIncome.Location = new System.Drawing.Point(680, 302);
            this.btnPrintIncome.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintIncome.Name = "btnPrintIncome";
            this.btnPrintIncome.Size = new System.Drawing.Size(140, 52);
            this.btnPrintIncome.TabIndex = 11;
            this.btnPrintIncome.Text = "Print";
            this.btnPrintIncome.UseVisualStyleBackColor = true;
            this.btnPrintIncome.Click += new System.EventHandler(this.btnPrintIncome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Report status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpEndDateIncome);
            this.groupBox3.Controls.Add(this.dtpBeginDateIncome);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(417, 55);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(401, 151);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ending Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Beginning Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Report of Income per Time Period";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoDateIncomeDesc);
            this.groupBox4.Controls.Add(this.rdoDateIncomeAsc);
            this.groupBox4.Location = new System.Drawing.Point(26, 55);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(352, 151);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sort By";
            // 
            // rdoDateIncomeDesc
            // 
            this.rdoDateIncomeDesc.AutoSize = true;
            this.rdoDateIncomeDesc.Location = new System.Drawing.Point(23, 100);
            this.rdoDateIncomeDesc.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDateIncomeDesc.Name = "rdoDateIncomeDesc";
            this.rdoDateIncomeDesc.Size = new System.Drawing.Size(145, 21);
            this.rdoDateIncomeDesc.TabIndex = 3;
            this.rdoDateIncomeDesc.TabStop = true;
            this.rdoDateIncomeDesc.Text = "Dates Descending";
            this.rdoDateIncomeDesc.UseVisualStyleBackColor = true;
            // 
            // rdoDateIncomeAsc
            // 
            this.rdoDateIncomeAsc.AutoSize = true;
            this.rdoDateIncomeAsc.Location = new System.Drawing.Point(23, 46);
            this.rdoDateIncomeAsc.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDateIncomeAsc.Name = "rdoDateIncomeAsc";
            this.rdoDateIncomeAsc.Size = new System.Drawing.Size(136, 21);
            this.rdoDateIncomeAsc.TabIndex = 2;
            this.rdoDateIncomeAsc.TabStop = true;
            this.rdoDateIncomeAsc.Text = "Dates Ascending";
            this.rdoDateIncomeAsc.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Report of Top 5 Menu Items per Time Period";
            // 
            // lblIncomeReport
            // 
            this.lblIncomeReport.AutoSize = true;
            this.lblIncomeReport.Location = new System.Drawing.Point(24, 332);
            this.lblIncomeReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomeReport.Name = "lblIncomeReport";
            this.lblIncomeReport.Size = new System.Drawing.Size(0, 17);
            this.lblIncomeReport.TabIndex = 14;
            // 
            // lblTopMenuReport
            // 
            this.lblTopMenuReport.AutoSize = true;
            this.lblTopMenuReport.Location = new System.Drawing.Point(25, 362);
            this.lblTopMenuReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopMenuReport.Name = "lblTopMenuReport";
            this.lblTopMenuReport.Size = new System.Drawing.Size(0, 17);
            this.lblTopMenuReport.TabIndex = 8;
            // 
            // dtpBeginDateMenu
            // 
            this.dtpBeginDateMenu.Location = new System.Drawing.Point(173, 48);
            this.dtpBeginDateMenu.Name = "dtpBeginDateMenu";
            this.dtpBeginDateMenu.Size = new System.Drawing.Size(200, 22);
            this.dtpBeginDateMenu.TabIndex = 4;
            // 
            // dtpEndDateMenu
            // 
            this.dtpEndDateMenu.Location = new System.Drawing.Point(173, 100);
            this.dtpEndDateMenu.Name = "dtpEndDateMenu";
            this.dtpEndDateMenu.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDateMenu.TabIndex = 5;
            // 
            // dtpBeginDateIncome
            // 
            this.dtpBeginDateIncome.Location = new System.Drawing.Point(194, 45);
            this.dtpBeginDateIncome.Name = "dtpBeginDateIncome";
            this.dtpBeginDateIncome.Size = new System.Drawing.Size(200, 22);
            this.dtpBeginDateIncome.TabIndex = 4;
            // 
            // dtpEndDateIncome
            // 
            this.dtpEndDateIncome.Location = new System.Drawing.Point(194, 105);
            this.dtpEndDateIncome.Name = "dtpEndDateIncome";
            this.dtpEndDateIncome.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDateIncome.TabIndex = 5;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 719);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDateDesc;
        private System.Windows.Forms.RadioButton rdoDateMenuAsc;
        private System.Windows.Forms.RadioButton rdoItemDesc;
        private System.Windows.Forms.RadioButton rdoMenuAsc;
        private System.Windows.Forms.ListBox lstDisplayIncomeReport;
        private System.Windows.Forms.Button btnConfirmIncome;
        private System.Windows.Forms.Button btnPrintIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoDateIncomeDesc;
        private System.Windows.Forms.RadioButton rdoDateIncomeAsc;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTopMenuReport;
        private System.Windows.Forms.Label lblIncomeReport;
        private System.Windows.Forms.DateTimePicker dtpEndDateMenu;
        private System.Windows.Forms.DateTimePicker dtpBeginDateMenu;
        private System.Windows.Forms.DateTimePicker dtpEndDateIncome;
        private System.Windows.Forms.DateTimePicker dtpBeginDateIncome;
    }
}