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
        private Customer currentCustomer;
        private Order currentOrder;

        public Confirmation(List<MenuItem> receipt, Customer currentCustomer, Order currentOrder)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.currentCustomer = currentCustomer;
            PopulateReceipt();
        }

        private void PopulateReceipt()
        {
            lbxReceipt.Items.Add("\t\tBlitz Cafe");
            lbxReceipt.Items.Add("************************************************************");
            lbxReceipt.Items.Add("Receipt for: " + currentCustomer.getFirstName());
            lbxReceipt.Items.Add("************************************************************");
            LoadReceiptItems();
        }

        private void LoadReceiptItems()
        {
            foreach (MenuItem item in receipt)
            {
                lbxReceipt.Items.Add(item.getDescr() + " Quantity: " + item.getQtySold());
                totalAmount += item.getPrice();
            }
            lbxReceipt.Items.Add("************************************************************");
            lbxReceipt.Items.Add("Total Amount: " + totalAmount);
        }

        private void cbxUseLoyaltyPoints_CheckedChanged(object sender, EventArgs e)
        {
            LoyaltyDiscount();
        }

        private void LoyaltyDiscount()
        {
            decimal pointsToMoneyConversion = 0.1m;
            decimal currentPoints = GetLoyaltyPoints();
            decimal discountablePoints = currentPoints >= 100 ? currentPoints - 100 : 0;
            decimal discount = discountablePoints * pointsToMoneyConversion;
            decimal adjustedTotal = Math.Max(totalAmount - discount, 0);

            lbxReceipt.Items.Add("************************************************************");
            lbxReceipt.Items.Add("Loyalty points used: -" + discount.ToString("C"));
            lbxReceipt.Items.Add("New total: " + adjustedTotal.ToString("C"));

            decimal remainingPoints = currentPoints > 100 ? 100 : currentPoints - discountablePoints / pointsToMoneyConversion;
            UpdateLoyaltyPoints(remainingPoints);
            InsertLoyaltyTransaction(remainingPoints);
        }

        private decimal GetLoyaltyPoints()
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                conn.Open();
                string query = "SELECT Running_Point_Balance FROM LoyaltyTransactions WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", currentCustomer.getCustomerID());
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        private void UpdateLoyaltyPoints(decimal newBalance)
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                conn.Open();
                string query = "UPDATE LoyaltyTransactions SET Running_Point_Balance = @NewBalance WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", currentCustomer.getCustomerID());
                    cmd.Parameters.AddWithValue("@NewBalance", newBalance);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void InsertLoyaltyTransaction(decimal newBalance)
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                conn.Open();
                string query = "INSERT INTO LoyaltyTransactions (LoyaltyTransactionID, OrderID, CustomerID, Running_Point_Balance) VALUES (@LoyaltyTransactionID, @OrderID, @CustomerID, @NewBalance)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", currentOrder.getOrderID()); // Replace with your OrderID logic
                    cmd.Parameters.AddWithValue("@CustomerID", currentCustomer.getCustomerID());
                    cmd.Parameters.AddWithValue("@NewBalance", newBalance);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfirmPayment()
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();
                    foreach (MenuItem item in receipt)
                    {
                        InsertOrderDetails(conn, item);
                    }
                    MessageBox.Show("Order confirmed and saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error confirming the order: " + ex.Message);
                }
            }
        }

        private void InsertOrderDetails(SqlConnection conn, MenuItem item)
        {
            string query = "INSERT INTO Order_Details (ProductID, Quantity_Sold) VALUES (@ProductID, @Quantity)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ProductID", item.getItemID());
                cmd.Parameters.AddWithValue("@Quantity", item.getQtySold());
                cmd.ExecuteNonQuery();
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }

        private void PrintReceipt()
        {

            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Receipts");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, "Receipt.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in lbxReceipt.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("Receipt has been printed successfully.");
        }

        private void btnConfirmPayment_Click_1(object sender, EventArgs e)
        {
            ConfirmPayment();
        }
    }

}
