
namespace Group29_BlitzCafe
{
    partial class OrderPage
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQtyErrorMessage = new System.Windows.Forms.Label();
            this.lblDescriptionErrorMessage = new System.Windows.Forms.Label();
            this.lblItemIdErrorMessage = new System.Windows.Forms.Label();
            this.numQtyOrdered = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchDescr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxItemSelection = new System.Windows.Forms.ListBox();
            this.txtSearchItemID = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lbxReceipt = new System.Windows.Forms.ListBox();
            this.lblPhoneNumError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dbgOrderDetails = new System.Windows.Forms.DataGridView();
            this.cbxLoyaltyPointsUsed = new System.Windows.Forms.CheckBox();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderIDSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.dbgOrderHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtyOrdered)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1367, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtPhoneNum);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblPhoneNumError);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtTotalAmount);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnCheckout);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1359, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Order";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(812, 578);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(217, 29);
            this.txtPhoneNum.TabIndex = 29;
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtPhoneNum_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.lbxReceipt);
            this.groupBox1.Location = new System.Drawing.Point(8, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1330, 515);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQtyErrorMessage);
            this.groupBox2.Controls.Add(this.lblDescriptionErrorMessage);
            this.groupBox2.Controls.Add(this.lblItemIdErrorMessage);
            this.groupBox2.Controls.Add(this.numQtyOrdered);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSearchDescr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbxItemSelection);
            this.groupBox2.Controls.Add(this.txtSearchItemID);
            this.groupBox2.Location = new System.Drawing.Point(778, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(536, 294);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Properties";
            // 
            // lblQtyErrorMessage
            // 
            this.lblQtyErrorMessage.AutoSize = true;
            this.lblQtyErrorMessage.Location = new System.Drawing.Point(294, 262);
            this.lblQtyErrorMessage.Name = "lblQtyErrorMessage";
            this.lblQtyErrorMessage.Size = new System.Drawing.Size(55, 22);
            this.lblQtyErrorMessage.TabIndex = 34;
            this.lblQtyErrorMessage.Text = "Error";
            // 
            // lblDescriptionErrorMessage
            // 
            this.lblDescriptionErrorMessage.AutoSize = true;
            this.lblDescriptionErrorMessage.Location = new System.Drawing.Point(294, 112);
            this.lblDescriptionErrorMessage.Name = "lblDescriptionErrorMessage";
            this.lblDescriptionErrorMessage.Size = new System.Drawing.Size(55, 22);
            this.lblDescriptionErrorMessage.TabIndex = 32;
            this.lblDescriptionErrorMessage.Text = "Error";
            // 
            // lblItemIdErrorMessage
            // 
            this.lblItemIdErrorMessage.AutoSize = true;
            this.lblItemIdErrorMessage.Location = new System.Drawing.Point(294, 58);
            this.lblItemIdErrorMessage.Name = "lblItemIdErrorMessage";
            this.lblItemIdErrorMessage.Size = new System.Drawing.Size(55, 22);
            this.lblItemIdErrorMessage.TabIndex = 31;
            this.lblItemIdErrorMessage.Text = "Error";
            // 
            // numQtyOrdered
            // 
            this.numQtyOrdered.Location = new System.Drawing.Point(298, 229);
            this.numQtyOrdered.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQtyOrdered.Name = "numQtyOrdered";
            this.numQtyOrdered.Size = new System.Drawing.Size(61, 29);
            this.numQtyOrdered.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Search Description (Optional)";
            // 
            // txtSearchDescr
            // 
            this.txtSearchDescr.Location = new System.Drawing.Point(298, 82);
            this.txtSearchDescr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchDescr.Name = "txtSearchDescr";
            this.txtSearchDescr.Size = new System.Drawing.Size(209, 29);
            this.txtSearchDescr.TabIndex = 26;
            this.txtSearchDescr.TextChanged += new System.EventHandler(this.txtSearchDescr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Search ItemsID";
            // 
            // lbxItemSelection
            // 
            this.lbxItemSelection.FormattingEnabled = true;
            this.lbxItemSelection.ItemHeight = 22;
            this.lbxItemSelection.Location = new System.Drawing.Point(27, 148);
            this.lbxItemSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxItemSelection.Name = "lbxItemSelection";
            this.lbxItemSelection.Size = new System.Drawing.Size(480, 70);
            this.lbxItemSelection.TabIndex = 21;
            this.lbxItemSelection.SelectedIndexChanged += new System.EventHandler(this.lbxItemSelection_SelectedIndexChanged);
            // 
            // txtSearchItemID
            // 
            this.txtSearchItemID.Location = new System.Drawing.Point(298, 28);
            this.txtSearchItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchItemID.Name = "txtSearchItemID";
            this.txtSearchItemID.Size = new System.Drawing.Size(209, 29);
            this.txtSearchItemID.TabIndex = 20;
            this.txtSearchItemID.TextChanged += new System.EventHandler(this.txtSearchItemID_TextChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.btnAddItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.Location = new System.Drawing.Point(1076, 448);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(237, 49);
            this.btnAddItem.TabIndex = 25;
            this.btnAddItem.Text = "Add item to order";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lbxReceipt
            // 
            this.lbxReceipt.FormattingEnabled = true;
            this.lbxReceipt.ItemHeight = 22;
            this.lbxReceipt.Location = new System.Drawing.Point(18, 50);
            this.lbxReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxReceipt.Name = "lbxReceipt";
            this.lbxReceipt.Size = new System.Drawing.Size(743, 334);
            this.lbxReceipt.TabIndex = 19;
            // 
            // lblPhoneNumError
            // 
            this.lblPhoneNumError.AutoSize = true;
            this.lblPhoneNumError.Location = new System.Drawing.Point(1072, 375);
            this.lblPhoneNumError.Name = "lblPhoneNumError";
            this.lblPhoneNumError.Size = new System.Drawing.Size(55, 22);
            this.lblPhoneNumError.TabIndex = 35;
            this.lblPhoneNumError.Text = "Error";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(106, 578);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(184, 29);
            this.txtTotalAmount.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(637, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Phone Number";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(100)))));
            this.btnCheckout.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.Location = new System.Drawing.Point(1084, 555);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(237, 76);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dbgOrderDetails);
            this.tabPage2.Controls.Add(this.cbxLoyaltyPointsUsed);
            this.tabPage2.Controls.Add(this.dtOrderDate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtOrderIDSearch);
            this.tabPage2.Controls.Add(this.btnDeleteOrder);
            this.tabPage2.Controls.Add(this.dbgOrderHistory);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1359, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order History";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(100)))));
            this.btnReset.Location = new System.Drawing.Point(1029, 369);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(248, 39);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset Filters";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Order Details";
            // 
            // dbgOrderDetails
            // 
            this.dbgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgOrderDetails.Location = new System.Drawing.Point(63, 369);
            this.dbgOrderDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbgOrderDetails.Name = "dbgOrderDetails";
            this.dbgOrderDetails.RowHeadersWidth = 62;
            this.dbgOrderDetails.RowTemplate.Height = 28;
            this.dbgOrderDetails.Size = new System.Drawing.Size(778, 229);
            this.dbgOrderDetails.TabIndex = 25;
            // 
            // cbxLoyaltyPointsUsed
            // 
            this.cbxLoyaltyPointsUsed.AutoSize = true;
            this.cbxLoyaltyPointsUsed.Location = new System.Drawing.Point(1029, 230);
            this.cbxLoyaltyPointsUsed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxLoyaltyPointsUsed.Name = "cbxLoyaltyPointsUsed";
            this.cbxLoyaltyPointsUsed.Size = new System.Drawing.Size(188, 26);
            this.cbxLoyaltyPointsUsed.TabIndex = 24;
            this.cbxLoyaltyPointsUsed.Text = "Loyalty Poins used";
            this.cbxLoyaltyPointsUsed.UseVisualStyleBackColor = true;
            this.cbxLoyaltyPointsUsed.CheckedChanged += new System.EventHandler(this.cbxLoyaltyPointsUsed_CheckedChanged);
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(1029, 172);
            this.dtOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(248, 29);
            this.dtOrderDate.TabIndex = 22;
            this.dtOrderDate.ValueChanged += new System.EventHandler(this.dtOrderDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(915, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Order date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(915, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "OrderID";
            // 
            // txtOrderIDSearch
            // 
            this.txtOrderIDSearch.Location = new System.Drawing.Point(1029, 116);
            this.txtOrderIDSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderIDSearch.Name = "txtOrderIDSearch";
            this.txtOrderIDSearch.Size = new System.Drawing.Size(248, 29);
            this.txtOrderIDSearch.TabIndex = 19;
            this.txtOrderIDSearch.TextChanged += new System.EventHandler(this.txtOrderIDSearch_TextChanged);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.btnDeleteOrder.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteOrder.Location = new System.Drawing.Point(1156, 688);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(248, 48);
            this.btnDeleteOrder.TabIndex = 18;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // dbgOrderHistory
            // 
            this.dbgOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgOrderHistory.Location = new System.Drawing.Point(63, 62);
            this.dbgOrderHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbgOrderHistory.Name = "dbgOrderHistory";
            this.dbgOrderHistory.RowHeadersWidth = 62;
            this.dbgOrderHistory.RowTemplate.Height = 28;
            this.dbgOrderHistory.Size = new System.Drawing.Size(778, 229);
            this.dbgOrderHistory.TabIndex = 1;
            this.dbgOrderHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgOrderHistory_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order History";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1590, 958);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderPage";
            this.Text = "OrderPage";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtyOrdered)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dbgOrderHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbxLoyaltyPointsUsed;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderIDSearch;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DataGridView dbgOrderDetails;
        private System.Windows.Forms.Label label10;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchDescr;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxItemSelection;
        private System.Windows.Forms.TextBox txtSearchItemID;
        private System.Windows.Forms.ListBox lbxReceipt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.NumericUpDown numQtyOrdered;
        private System.Windows.Forms.Label lblPhoneNumError;
        private System.Windows.Forms.Label lblQtyErrorMessage;
        private System.Windows.Forms.Label lblDescriptionErrorMessage;
        private System.Windows.Forms.Label lblItemIdErrorMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnReset;
    }
}