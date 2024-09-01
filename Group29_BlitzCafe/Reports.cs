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
using System.Data.SqlClient;

namespace Group29_BlitzCafe
{
    public partial class Reports : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlDataReader reader;
        DataSet ds;
        private String connString = "Data Source=blitzcafedatabase.c9uaw2k2s8lc.us-east-1.rds.amazonaws.com;Initial Catalog=BlitzDatabase;Persist Security Info=True;User ID=admin;Password=12345678";
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
            top5();
        }

        private void btnConfirmIncome_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtpBeginDateIncome.Value;
            DateTime endDate = dtpEndDateIncome.Value;

            lblTopMenuReport.Text = "Report of Revenue generate between " + beginDate.ToString("dd MMMM yyyy") + " and " + endDate.ToString("dd MMMM yyyy");
            incomeReport();
        }

        //Query to get the top 5 menu items sold
        private void top5()
        {
            DateTime beginDate = dtpBeginDateIncome.Value;
            DateTime endDate = dtpEndDateIncome.Value;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    adap = new SqlDataAdapter();
                    ds = new DataSet();
                    string query = @"SELECT OD.ItemID, I.Description, SUM(OD.Quantity_Sold) AS TotalQuantity FROM Order_Details OD JOIN [Order] O ON OD.OrderID = O.OrderID JOIN Items I ON OD.ItemID = I.ItemID WHERE O.Order_Date BETWEEN @beginDate AND @endDate GROUP BY OD.ItemID, I.Description ORDER BY TotalQuantity DESC ";
                    cmd = new SqlCommand(query, conn);

                    // Add parameters for the date range
                    cmd.Parameters.AddWithValue("@beginDate", beginDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    // Execute the command and read the data
                    reader = cmd.ExecuteReader();

                    // Clear the ListBox before adding new items
                    lstDisplayMenuReport.Items.Clear();

                    // Add a heading to the ListBox with columns aligned
                    lstDisplayMenuReport.Items.Add(string.Format("{0,-30} {1,10}", "Item Description", "Quantity Sold"));
                    lstDisplayMenuReport.Items.Add(new string('-', 100)); // Adds a separator line

                    // Loop through the results and add them to the ListBox
                    while (reader.Read())
                    {
                        string itemDescription = reader["Description"].ToString();
                        int totalQuantity = Convert.ToInt32(reader["TotalQuantity"]);

                        // Format and add to ListBox with aligned columns
                        lstDisplayMenuReport.Items.Add(string.Format("{0,-30} {1,10}", itemDescription, totalQuantity));
                    }

                    // Close the reader
                    reader.Close();

                    conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not load menu items: " + e);
                }

            }
        }

        //Query to get a summary on income
        private void incomeReport()
        {
            DateTime beginDate = dtpBeginDateIncome.Value;
            DateTime endDate = dtpEndDateIncome.Value;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    adap = new SqlDataAdapter();
                    ds = new DataSet();

                    // Determine the sorting criteria and order based on RadioButton selections
                    string orderByClause = "";

                    // Determine "Sort By" criteria
                    string sortBy = "";
                    if (rdoIncome.Checked)
                    {
                        sortBy = "SUM(I.Price * OD.Quantity_Sold)";
                    }
                    else if (rdoMonth.Checked)
                    {
                        sortBy = "YEAR(O.Order_Date), MONTH(O.Order_Date)";
                    }

                    // Determine "Sort Order"
                    string sortOrder = "";
                    if (rdoAsc.Checked)
                    {
                        sortOrder = "ASC";
                    }
                    else if (rdoDesc.Checked)
                    {
                        sortOrder = "DESC";
                    }

                    // Combine the sorting criteria and order
                    orderByClause = $"ORDER BY {sortBy} {sortOrder}";

                    string query = $@"
                SELECT YEAR(O.Order_Date) AS Year, 
                       DATENAME(MONTH,O.Order_Date) AS Month, 
                       SUM(I.Price * OD.Quantity_Sold) AS TotalIncome 
                FROM Order_Details OD 
                JOIN [Order] O ON OD.OrderID = O.OrderID 
                JOIN Items I ON OD.ItemID = I.ItemID 
                WHERE O.Order_Date BETWEEN @beginDate AND @endDate 
                GROUP BY YEAR(O.Order_Date), MONTH(O.Order_Date) 
                {orderByClause}";

                    cmd = new SqlCommand(query, conn);

                    // Add parameters for the date range
                    cmd.Parameters.AddWithValue("@beginDate", beginDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    // Execute the command and read the data
                    reader = cmd.ExecuteReader();

                    // Clear the ListBox before adding new items
                    lstDisplayIncomeReport.Items.Clear();

                    // Add a heading to the ListBox with columns aligned
                    lstDisplayIncomeReport.Items.Add(string.Format("{0,-10} {1,-10} {2,15}", "Year", "Month", "Total Income"));
                    lstDisplayIncomeReport.Items.Add(new string('-', 150)); // Adds a separator line line

                    // Variable to store the sum of all income
                    decimal sumTotalIncome = 0;


                    // Loop through the results and add them to the ListBox
                    while (reader.Read())
                    {
                        int year = Convert.ToInt32(reader["Year"]);
                        string month = reader["Month"].ToString();
                        decimal totalIncome = Convert.ToDecimal(reader["TotalIncome"]);

                        // Accumulate the total income
                        sumTotalIncome += totalIncome;

                        // Format and add to ListBox with aligned columns
                        lstDisplayIncomeReport.Items.Add(string.Format("{0,-10} {1,-10} {2,15:C2}", year, month, totalIncome.ToString("C", new System.Globalization.CultureInfo("en-ZA"))));
                    }

                    lstDisplayIncomeReport.Items.Add(new string('-', 150)); // Adds a separator line
                    lstDisplayIncomeReport.Items.Add(string.Format("{0,-20} {1,15:C2}", "Total Income:", sumTotalIncome.ToString("C", new System.Globalization.CultureInfo("en-ZA"))));

                    // Close the reader
                    reader.Close();

                    conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not load menu items: " + e);
                }

            }
        }

        private void rdoDateIncomeDesc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDateIncomeAsce_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbIncomeDesc_CheckedChanged(object sender, EventArgs e)
        {

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

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
