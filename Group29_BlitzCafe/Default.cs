using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group29_BlitzCafe
{
    public partial class Default : Form
    {


        public string connString = "Data Source=blitzcafedatabase.c9uaw2k2s8lc.us-east-1.rds.amazonaws.com;Initial Catalog=BlitzDatabase;Persist Security Info=True;User ID=admin;Password=12345678";

        public Default()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the Timer
            Timer timer = new Timer();
            timer.Interval = 50; // Set the interval for the timer (milliseconds)

            // Initialize the PictureBox
            movingPictureBox.SizeMode = PictureBoxSizeMode.AutoSize; // Adjust the PictureBox size to fit the image

            // Initialize the Label
            Label infoLabel = new Label();
            infoLabel.Text = "Katelyn Joynt  | Juané Schoeman | Kearabetswe Thekiso\n" +
                              "Dylan Rafferty | Sinovuyo Waqu | Schalk van Wyk";
            infoLabel.Font = new Font("Arial", 12); // Use a common font for testing
            infoLabel.ForeColor = Color.Black; // Ensure text color contrasts with background
            infoLabel.AutoSize = true; // Automatically adjust the label size

            // Set the starting position outside the panel on the right
            int startPositionX = panel1.Width;
            movingPictureBox.Location = new Point(startPositionX, (panel1.Height - movingPictureBox.Height) / 2);
            infoLabel.Location = new Point(startPositionX, (movingPictureBox.Height - infoLabel.Height) / 2); // Center label vertically in the PictureBox

            // Add the PictureBox and Label to the Panel
            panel1.Controls.Add(movingPictureBox);
            panel1.Controls.Add(infoLabel);

            // Define the Tick event for the Timer
            timer.Tick += (s, ev) =>
            {
                // Move the PictureBox and Label to the left
                movingPictureBox.Left -= 5; // Adjust the speed by changing the value (pixels per tick)
                infoLabel.Left -= 5; // Adjust the speed to match the PictureBox

                // If the PictureBox has completely moved out of the panel, reset its position
                if (movingPictureBox.Right < 0)
                {
                    movingPictureBox.Left = panel1.Width;
                }

                // If the Label has completely moved out of the panel, reset its position
                if (infoLabel.Right < 0)
                {
                    infoLabel.Left = panel1.Width;
                }

                // Center the Label in the middle of the PictureBox
                infoLabel.Location = new Point(movingPictureBox.Left + (movingPictureBox.Width - infoLabel.Width) / 2,
                                               movingPictureBox.Top + (movingPictureBox.Height - infoLabel.Height) / 2);
            };

            // Start the Timer when the form loads
            timer.Start();
        }


        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPage f1 = new CustomerPage();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;

            // Set the fixed size for the form
            f1.Size = new Size(850, 495);

            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);

            // Show the form to ensure it's added to the panel
            f1.Show();

            // Set the panel size to match the form size
            panel1.Size = f1.Size;

            // Adjust the main form's ClientSize to fit the panel
            this.ClientSize = new Size(panel1.Width, panel1.Height);

            // Center the form within the panel
            f1.Left = (panel1.Width - f1.Width) / 2;
            f1.Top = (panel1.Height - f1.Height) / 2;

            f1.BringToFront();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderPage f1 = new OrderPage();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;

            // Set the fixed size for the form
            f1.Size = new Size(1050, 495);

            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);

            // Show the form to ensure it's added to the panel
            f1.Show();

            // Set the panel size to match the form size
            panel1.Size = f1.Size;

            // Adjust the main form's ClientSize to fit the panel
            this.ClientSize = new Size(panel1.Width, panel1.Height);

            // Center the form within the panel
            f1.Left = (panel1.Width - f1.Width) / 2;
            f1.Top = (panel1.Height - f1.Height) / 2;

            f1.BringToFront();

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemPage f1 = new ItemPage();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;

            // Set the fixed size for the form
            f1.Size = new Size(850, 495);

            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);

            // Show the form to ensure it's added to the panel
            f1.Show();

            // Set the panel size to match the form size
            panel1.Size = f1.Size;

            // Adjust the main form's ClientSize to fit the panel
            this.ClientSize = new Size(panel1.Width, panel1.Height);

            // Center the form within the panel
            f1.Left = (panel1.Width - f1.Width) / 2;
            f1.Top = (panel1.Height - f1.Height) / 2;

            f1.BringToFront();

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports f1 = new Reports();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;

            // Set the fixed size for the form
            f1.Size = new Size(1050, 495);

            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);

            // Show the form to ensure it's added to the panel
            f1.Show();

            // Set the panel size to match the form size
            panel1.Size = f1.Size;

            // Adjust the main form's ClientSize to fit the panel
            this.ClientSize = new Size(panel1.Width, panel1.Height);

            // Center the form within the panel
            f1.Left = (panel1.Width - f1.Width) / 2;
            f1.Top = (panel1.Height - f1.Height) / 2;

            f1.BringToFront();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help f1 = new Help();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;

            // Set the fixed size for the form
            f1.Size = new Size(1050, 495);

            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);

            // Show the form to ensure it's added to the panel
            f1.Show();

            // Set the panel size to match the form size
            panel1.Size = f1.Size;

            // Adjust the main form's ClientSize to fit the panel
            this.ClientSize = new Size(panel1.Width, panel1.Height);

            // Center the form within the panel
            f1.Left = (panel1.Width - f1.Width) / 2;
            f1.Top = (panel1.Height - f1.Height) / 2;

            f1.BringToFront();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
