
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUseLoyaltyPoints
            // 
            this.cbxUseLoyaltyPoints.AutoSize = true;
            this.cbxUseLoyaltyPoints.Location = new System.Drawing.Point(416, 369);
            this.cbxUseLoyaltyPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxUseLoyaltyPoints.Name = "cbxUseLoyaltyPoints";
            this.cbxUseLoyaltyPoints.Size = new System.Drawing.Size(176, 26);
            this.cbxUseLoyaltyPoints.TabIndex = 0;
            this.cbxUseLoyaltyPoints.Text = "UseLoyaltyPoints";
            this.cbxUseLoyaltyPoints.UseVisualStyleBackColor = true;
            this.cbxUseLoyaltyPoints.CheckedChanged += new System.EventHandler(this.cbxUseLoyaltyPoints_CheckedChanged);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(100)))));
            this.btnConfirmPayment.Location = new System.Drawing.Point(416, 139);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(222, 75);
            this.btnConfirmPayment.TabIndex = 1;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click_1);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.btnPrintReceipt.Location = new System.Drawing.Point(416, 39);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(222, 75);
            this.btnPrintReceipt.TabIndex = 2;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // lbxReceipt
            // 
            this.lbxReceipt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxReceipt.FormattingEnabled = true;
            this.lbxReceipt.ItemHeight = 22;
            this.lbxReceipt.Location = new System.Drawing.Point(16, 34);
            this.lbxReceipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxReceipt.Name = "lbxReceipt";
            this.lbxReceipt.Size = new System.Drawing.Size(316, 290);
            this.lbxReceipt.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group29_BlitzCafe.Properties.Resources.Untitled_design__7_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 168);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(681, 449);
            this.Controls.Add(this.lbxReceipt);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.cbxUseLoyaltyPoints);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxUseLoyaltyPoints;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.ListBox lbxReceipt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}