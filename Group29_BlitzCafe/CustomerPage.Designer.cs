
namespace Group29_BlitzCafe
{
    partial class CustomerPage
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.cbxLoyaltyMem = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnConfirmUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(35, 33);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(173, 51);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New Customer";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(438, 346);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.lblDateJoined);
            this.groupBox1.Controls.Add(this.cbxLoyaltyMem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCellNo);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtCustID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblCustomerID);
            this.groupBox1.Controls.Add(this.btnConfirmUpdate);
            this.groupBox1.Location = new System.Drawing.Point(523, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(364, 419);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(178, 221);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 11;
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.AutoSize = true;
            this.lblDateJoined.Location = new System.Drawing.Point(18, 224);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(92, 17);
            this.lblDateJoined.TabIndex = 10;
            this.lblDateJoined.Text = "Date Joined: ";
            // 
            // cbxLoyaltyMem
            // 
            this.cbxLoyaltyMem.AutoSize = true;
            this.cbxLoyaltyMem.Location = new System.Drawing.Point(126, 280);
            this.cbxLoyaltyMem.Name = "cbxLoyaltyMem";
            this.cbxLoyaltyMem.Size = new System.Drawing.Size(152, 21);
            this.cbxLoyaltyMem.TabIndex = 9;
            this.cbxLoyaltyMem.Text = "Is Loyalty Member?";
            this.cbxLoyaltyMem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cellphone No.:";
            // 
            // txtCellNo
            // 
            this.txtCellNo.Location = new System.Drawing.Point(178, 167);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(100, 22);
            this.txtCellNo.TabIndex = 7;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(178, 118);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 22);
            this.txtLName.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(178, 73);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 22);
            this.txtFName.TabIndex = 5;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(178, 33);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 22);
            this.txtCustID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(18, 36);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(89, 17);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // btnConfirmUpdate
            // 
            this.btnConfirmUpdate.Location = new System.Drawing.Point(199, 366);
            this.btnConfirmUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmUpdate.Name = "btnConfirmUpdate";
            this.btnConfirmUpdate.Size = new System.Drawing.Size(159, 49);
            this.btnConfirmUpdate.TabIndex = 0;
            this.btnConfirmUpdate.Text = "Confirm Changes";
            this.btnConfirmUpdate.UseVisualStyleBackColor = true;
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddNew);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerPage";
            this.Text = "CustomerPage";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmUpdate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDateJoined;
        private System.Windows.Forms.CheckBox cbxLoyaltyMem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCustomerID;
    }
}