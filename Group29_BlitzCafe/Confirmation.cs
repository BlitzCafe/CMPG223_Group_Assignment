using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Group29_BlitzCafe
{
    public partial class Confirmation : Form
    {
        private Default defaultFrm = new Default();
        private List<MenuItem> receipt = new List<MenuItem>();

        private decimal totalAmount = 0m;

        private decimal loyaltyUsed = 0m;
        private Customer currentCustomer;


        public Confirmation(List<MenuItem> receipt, Customer currentCustomer)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.currentCustomer = currentCustomer;
            PopulateReciept();
            
        }

        private void loadReceipt()
        {
            foreach (MenuItem item in receipt)
            {
                lbxReceipt.Items.Add(item.getDescr() + " Quantity: " + item.getQtySold());
                totalAmount += item.getPrice();
            }
            lbxReceipt.Items.Add("************************************************************");
            lbxReceipt.Items.Add("Total Amount: " + totalAmount);//loads the receipt
        }

        private void LoyaltyDiscount()
        {
            decimal pointsToMoneyConversion = 0.1m; // 100 points = R10, so 1 point = R0.10
            int pointsEarnedPerR5 = 1;
            decimal amountSpent = totalAmount; // Total amount before loyalty discount

            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();

                    // Retrieve the current loyalty points balance
                    decimal currentPoints = GetLoyaltyPoints(conn);

                    if (cbxUseLoyaltyPoints.Checked)
                    {
                        // Calculate discount
                        decimal discountablePoints = currentPoints >= 100 ? currentPoints - 100 : 0; // Only use points above 100
                        decimal discount = discountablePoints * pointsToMoneyConversion;
                        decimal adjustedTotal = totalAmount - discount;

                        // Ensure total is not less than zero
                        if (adjustedTotal < 0)
                        {
                            adjustedTotal = 0;
                        }

                        // Display adjusted total
                        lbxReceipt.Items.Add("************************************************************");
                        lbxReceipt.Items.Add("Loyalty points used: -" + discount.ToString("C"));
                        lbxReceipt.Items.Add("New total: " + adjustedTotal.ToString("C"));

                        // Update remaining loyalty points
                        decimal remainingPoints = currentPoints > 100 ? 100 : currentPoints - discountablePoints / pointsToMoneyConversion;

                        // Update loyalty points in the database
                        UpdateLoyaltyPoints(conn, remainingPoints);
                    }
                    else
                    {
                        decimal pointsEarned = Math.Floor(amountSpent / 5) * pointsEarnedPerR5; // adds the points into the database
                        // Update loyalty points in the database
                        decimal newPointsBalance = currentPoints + pointsEarned;
                        UpdateLoyaltyPoints(conn, newPointsBalance);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving or updating loyalty points: " + ex.Message);
                }
            }
        }

        private void cbxUseLoyaltyPoints_CheckedChanged(object sender, EventArgs e)
        {
            LoyaltyDiscount();
        }

        private decimal GetLoyaltyPoints(SqlConnection conn)
        {
            string query = "SELECT Running_Point_Balance FROM LoyaltyTransactions WHERE CustomerID = @CustomerID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", currentCustomer.getCustomerID());

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        private void ApplyLoyaltyPoints(SqlConnection conn, decimal currentPoints, decimal pointsToMoneyConversion)
        {
            decimal discount = currentPoints * pointsToMoneyConversion;
            decimal adjustedTotal = Math.Max(totalAmount - discount, 0);

            lbxReceipt.Items.Add("Loyalty points used: -" + discount.ToString("C"));
            lbxReceipt.Items.Add("New total: " + adjustedTotal.ToString("C"));

            UpdateLoyaltyPoints(conn, 0); // Deduct used points
        }

        private void UpdateLoyaltyPoints(SqlConnection conn, decimal newBalance)
        {
            /*
            string insertQuery = "INSERT INTO LoyaltyTransactions (LoyaltyTransactionID, OrderID, CustomerID, Running_Point_Balance) " +
                     "VALUES (@LoyaltyTransactionID, @OrderID, @CustomerID, @NewBalance)";
            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
            {
                // Generate a new ID for the loyalty transaction (assuming it's an integer and auto-incremented in some cases)
                insertCmd.Parameters.AddWithValue("@LoyaltyTransactionID", newBalance); // Replace this with your actual method to generate a new ID
                insertCmd.Parameters.AddWithValue("@OrderID", orderID); // You should have the OrderID from the order process
                insertCmd.Parameters.AddWithValue("@CustomerID", currentCustomer.getCustomerID());
                insertCmd.Parameters.AddWithValue("@NewBalance", newBalance);

                insertCmd.ExecuteNonQuery();
            }
            */
        }


        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();

                    // Insert into Order_Details table
                    foreach (MenuItem item in receipt)
                    {
                        string insertOrderDetailsQuery = "INSERT INTO Order_Details (OrderID, ProductID, Quantity_Sold) VALUES (@OrderID, @ProductID, @Quantity)";
                        SqlCommand insertOrderDetailsCmd = new SqlCommand(insertOrderDetailsQuery, conn);
                        insertOrderDetailsCmd.Parameters.AddWithValue("@ProductID", item.getItemID());
                        insertOrderDetailsCmd.Parameters.AddWithValue("@Quantity", item.getQtySold());

                        insertOrderDetailsCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order confirmed and saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error confirming the order: " + ex.Message);
                }
            }
        }

        private void PopulateReciept()
        {
            lbxReceipt.Items.Add("\t\tBlitz Cafe");
            lbxReceipt.Items.Add("************************************************************");
            lbxReceipt.Items.Add("Receipt for: " + currentCustomer.getFirstName());
            lbxReceipt.Items.Add("************************************************************");
            loadReceipt();
            
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

            // Load loyalty point table or other initializations
        }

        private void Confirmation_Load_1(object sender, EventArgs e)
        {

        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            // Define the directory path
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources");

            // Ensure the directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Define the full file path
            string filePath = Path.Combine(directoryPath, "Receipt.txt");

            // Write the ListBox items to the specified file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in lbxReceipt.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("Receipt has been printed successfully.");
        }
    }
}