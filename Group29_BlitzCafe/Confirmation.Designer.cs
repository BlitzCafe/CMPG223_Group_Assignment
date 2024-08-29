
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
            this.cbxUseLoyaltyPoints.Location = new System.Drawing.Point(266, 94);
            this.cbxUseLoyaltyPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxUseLoyaltyPoints.Name = "cbxUseLoyaltyPoints";
            this.cbxUseLoyaltyPoints.Size = new System.Drawing.Size(139, 21);
            this.cbxUseLoyaltyPoints.TabIndex = 0;
            this.cbxUseLoyaltyPoints.Text = "UseLoyaltyPoints";
            this.cbxUseLoyaltyPoints.UseVisualStyleBackColor = true;
            this.cbxUseLoyaltyPoints.CheckedChanged += new System.EventHandler(this.cbxUseLoyaltyPoints_CheckedChanged);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(266, 164);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(178, 52);
            this.btnConfirmPayment.TabIndex = 1;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(266, 235);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(178, 52);
            this.btnPrintReceipt.TabIndex = 2;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // lbxReceipt
            // 
            this.lbxReceipt.FormattingEnabled = true;
            this.lbxReceipt.ItemHeight = 16;
            this.lbxReceipt.Location = new System.Drawing.Point(14, 27);
            this.lbxReceipt.Name = "lbxReceipt";
            this.lbxReceipt.Size = new System.Drawing.Size(233, 260);
            this.lbxReceipt.TabIndex = 3;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 310);
            this.Controls.Add(this.lbxReceipt);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.cbxUseLoyaltyPoints);
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