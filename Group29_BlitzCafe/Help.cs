using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group29_BlitzCafe
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            try
            {
                // Open the file and read it line by line
                using (StreamReader reader = new StreamReader("Help.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Append each line to the RichTextBox
                        rtbDisplay.AppendText(line + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
