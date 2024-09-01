
namespace Group29_BlitzCafe
{
    partial class Confirmation
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
            this.cbxUseLoyaltyPoints = new System.Windows.Forms.CheckBox();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.lbxReceipt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbxUseLoyaltyPoints
            // 
            this.cbxUseLoyaltyPoints.AutoSize = true;
            this.cbxUseLoyaltyPoints.Location = new System.Drawing.Point(388, 247);
            this.cbxUseLoyaltyPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxUseLoyaltyPoints.Name = "cbxUseLoyaltyPoints";
            this.cbxUseLoyaltyPoints.Size = new System.Drawing.Size(157, 24);

            this.cbxUseLoyaltyPoints.TabIndex = 0;
            this.cbxUseLoyaltyPoints.Text = "UseLoyaltyPoints";
            this.cbxUseLoyaltyPoints.UseVisualStyleBackColor = true;
            this.cbxUseLoyaltyPoints.CheckedChanged += new System.EventHandler(this.cbxUseLoyaltyPoints_CheckedChanged);
            // 
            // btnConfirmPayment
            // 

            this.btnConfirmPayment.Location = new System.Drawing.Point(388, 120);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(200, 65);

            this.btnConfirmPayment.TabIndex = 1;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 

            this.btnPrintReceipt.Location = new System.Drawing.Point(388, 34);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(200, 65);

            this.btnPrintReceipt.TabIndex = 2;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // lbxReceipt
            // 
            this.lbxReceipt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxReceipt.FormattingEnabled = true;

            this.lbxReceipt.ItemHeight = 20;
            this.lbxReceipt.Location = new System.Drawing.Point(16, 34);
            this.lbxReceipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxReceipt.Name = "lbxReceipt";
            this.lbxReceipt.Size = new System.Drawing.Size(316, 324);

            this.lbxReceipt.TabIndex = 3;
            // 
            // Confirmation
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 388);

            this.Controls.Add(this.lbxReceipt);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.cbxUseLoyaltyPoints);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.Confirmation_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxUseLoyaltyPoints;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.ListBox lbxReceipt;
    }
}