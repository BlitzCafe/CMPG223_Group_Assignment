using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Group29_BlitzCafe
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        // This function now uses the SaveFileDialog added through the designer
        public void SaveListBoxItemsToCSV(ListBox listBox, SaveFileDialog saveFileDialog)
        {
            // Set up the SaveFileDialog properties (if not set in the designer)
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.Title = "Save ListBox Data";
            saveFileDialog.FileName = "report.csv"; // Default file name

            // Show the dialog and check if the user clicked 'Save'
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Write the ListBox items to the selected file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in listBox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Data successfully saved to " + filePath);
            }
        }

        private void btnPrintMenuItem_Click(object sender, EventArgs e)
        {
            SaveListBoxItemsToCSV(lstDisplayMenuReport, sfdSave);
        }

        private void btnPrintIncome_Click(object sender, EventArgs e)
        {
            SaveListBoxItemsToCSV(lstDisplayIncomeReport, sfdSave);
        }

        private void btnConfirmMenu_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtpBeginDateMenu.Value;
            DateTime endDate = dtpEndDateMenu.Value;
            
            lblTopMenuReport.Text = "Report of Top 5 Menu Items Sold between " + beginDate.ToString("dd MMMM yyyy") + " and " + endDate.ToString("dd MMMM yyyy");
        }

        private void btnConfirmIncome_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtpBeginDateIncome.Value;
            DateTime endDate = dtpEndDateIncome.Value;

            lblTopMenuReport.Text = "Report of Revenue generate between " + beginDate.ToString("dd MMMM yyyy") + " and " + endDate.ToString("dd MMMM yyyy");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
