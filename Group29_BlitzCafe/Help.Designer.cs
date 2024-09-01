
namespace Group29_BlitzCafe
{
    partial class Help
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.movingPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.BackColor = System.Drawing.Color.White;
            this.rtbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDisplay.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplay.Location = new System.Drawing.Point(14, 15);
            this.rtbDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbDisplay.Size = new System.Drawing.Size(1073, 445);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.movingPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 145);
            this.panel1.TabIndex = 3;
            // 
            // movingPictureBox
            // 
            this.movingPictureBox.BackgroundImage = global::Group29_BlitzCafe.Properties.Resources.Untitled_design__9_;
            this.movingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.movingPictureBox.Location = new System.Drawing.Point(-69, 0);
            this.movingPictureBox.Name = "movingPictureBox";
            this.movingPictureBox.Size = new System.Drawing.Size(683, 145);
            this.movingPictureBox.TabIndex = 2;
            this.movingPictureBox.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1099, 678);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.PictureBox movingPictureBox;
        private System.Windows.Forms.Panel panel1;
    }
}