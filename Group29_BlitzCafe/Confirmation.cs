using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group29_BlitzCafe
{
    public partial class Confirmation : Form
    {
        private Default defaultFrm = new Default();
        private List<MenuItem> receipt = new List<MenuItem>();

        private decimal totalAmount = 0m;
        private string customerCell = "";
        OrderPage OrderDetails = new OrderPage();

        public Confirmation(List<MenuItem> receipt, string customerId)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.customerCell = customerId;
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

            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();

                    decimal currentPoints = GetLoyaltyPoints(conn);

                    if (cbxUseLoyaltyPoints.Checked)
                    {
                        ApplyLoyaltyPoints(conn, currentPoints, pointsToMoneyConversion);
                    }
                    else
                    {
                        decimal pointsEarned = Math.Floor(amountSpent / 5) * pointsEarnedPerR5;
                        lbxReceipt.Items.Add("Points earned: " + pointsEarned);
                        UpdateLoyaltyPoints(conn, currentPoints + pointsEarned);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving or updating loyalty points: " + ex.Message);
                }
            }
        }

        private decimal GetLoyaltyPoints(SqlConnection conn)
        {
            string query = "SELECT Running_Point_Balance FROM tblLoyaltyTransactions WHERE CellNo = @CellNo";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CellNo", customerCell);
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
            string updateQuery = "UPDATE LoyaltyTransactions SET Running_Point_Balance = @NewBalance WHERE CellNo = @CellNo";
            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
            {
                updateCmd.Parameters.AddWithValue("@NewBalance", newBalance);
                updateCmd.ExecuteNonQuery();
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                   /* conn.Open();

                    // Insert into Order_Details table
                    foreach (MenuItem item in receipt)
                    {
                        string insertOrderDetailsQuery = "INSERT INTO Order_Details (OrderID, ProductID, Quantity, Price) VALUES (@OrderID, @ProductID, @Quantity, @Price)";
                        SqlCommand insertOrderDetailsCmd = new SqlCommand(insertOrderDetailsQuery, conn);
                        insertOrderDetailsCmd.Parameters.AddWithValue("@OrderID", orderId);
                        insertOrderDetailsCmd.Parameters.AddWithValue("@ProductID", item.getItemID());
                        insertOrderDetailsCmd.Parameters.AddWithValue("@Quantity", item.getQuantity());
                        insertOrderDetailsCmd.Parameters.AddWithValue("@Price", item.getPrice());

                        insertOrderDetailsCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order confirmed and saved successfully.");
                */}
                catch (Exception ex)
                {
                    MessageBox.Show("Error confirming the order: " + ex.Message);
                }
            }
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

            // Load loyalty point table or other initializations
        }
        private void Confirmation_Load_1(object sender, EventArgs e)
        {

        }
    }
}