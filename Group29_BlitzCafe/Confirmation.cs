using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Group29_BlitzCafe;

namespace Group29_BlitzCafe
{
    public partial class Confirmation : Form
    {
        private Default defaultFrm = new Default();
        private List<MenuItem> receipt = new List<MenuItem>();

        private decimal totalAmount = 0m;
        private decimal loyaltyUsed = 0m;
        private string customerId = "";

        public Confirmation(List<MenuItem> receipt, string customerId)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.customerId = customerId;
            loadReceipt();
        }

        private void loadReceipt() 
        {
            
            foreach (MenuItem item in receipt)
            {
                lbxReceipt.Items.Add(item.toString());
                totalAmount += item.getPrice();

            }
            lbxReceipt.Items.Add("Total amount owed: " + totalAmount);

        }

        

        private void cbxUseLoyaltyPoints_CheckedChanged(object sender, EventArgs e)
        {
            
            decimal pointsToMoneyConversion = 0.1m; // 100 points = R10, so 1 point = R0.10
            int pointsEarnedPerR5 = 1;
            decimal amountSpent = totalAmount; // Total amount before loyalty discount

            using (MySqlConnection conn = new MySqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();

                    // Retrieve the current loyalty points balance
                    string query = "SELECT Running_Point_Balance FROM tblLoyaltyTransactions WHERE CustomerID = @CustomerID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    object result = cmd.ExecuteScalar();
                    decimal currentPoints = 0;

                    if (result != null)
                    {
                        currentPoints = Convert.ToDecimal(result);
                    }

                    // If checkbox is checked, apply loyalty points
                    if (cbxUseLoyaltyPoints.Checked)
                    {
                        // Calculate discount
                        decimal discount = currentPoints * pointsToMoneyConversion;
                        decimal adjustedTotal = totalAmount - discount;

                        // Ensure total is not less than zero
                        if (adjustedTotal < 0)
                        {
                            adjustedTotal = 0;
                        }

                        // Display adjusted total
                        lbxReceipt.Items.Add("Loyalty points used: -" + discount.ToString("C"));
                        lbxReceipt.Items.Add("New total: " + adjustedTotal.ToString("C"));

                        // Deduct used points
                        currentPoints = 0;

                        // Update loyalty points in the database to 0
                        string updateQuery = "UPDATE tblLoyaltyTransactions SET Running_Point_Balance = @NewBalance WHERE CustomerID = @CustomerID";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@NewBalance", currentPoints);
                        updateCmd.Parameters.AddWithValue("@CustomerID", customerId);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // If points are not used, calculate points earned
                        decimal pointsEarned = Math.Floor(amountSpent / 5) * pointsEarnedPerR5;

                        lbxReceipt.Items.Add("Points earned: " + pointsEarned.ToString());

                        // Update loyalty points in the database
                        decimal newPointsBalance = currentPoints + pointsEarned;
                        string updateQuery = "UPDATE tblLoyaltyTransactions SET Running_Point_Balance = @NewBalance WHERE CustomerID = @CustomerID";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@NewBalance", newPointsBalance);
                        updateCmd.Parameters.AddWithValue("@CustomerID", customerId);
                        updateCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving or updating loyalty points: " + ex.Message);
                }

                conn.Close();
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            // laod loyalty point table

        }
    }
}
