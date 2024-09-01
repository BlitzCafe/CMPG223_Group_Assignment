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
using System.Data.SqlClient;
using System.Globalization;

namespace Group29_BlitzCafe
{
    public partial class OrderPage : Form
    {
        private Default defaultFrm = new Default();
        private ItemPage itemPageFrm = new ItemPage();          //could use singleton
        private CustomerPage customerPageFrm = new CustomerPage();
        

        private List<MenuItem> receipt = new List<MenuItem>();
        private List<Order> orderList = new List<Order>();

        private decimal totalAmount = 0.0m;

        public OrderPage()
        {
            InitializeComponent();

            loadOrderHistory();
            customerPageFrm.load_Customer_Info();
            itemPageFrm.loadMenuItems();

            lblPhoneNumError.Text = "";
            lblDescriptionErrorMessage.Text = "";
            lblQtyErrorMessage.Text = "";
            lblItemIdErrorMessage.Text = "";

        }

        private void loadOrderHistory()
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT OrderID, Order_Date, CASE WHEN Is_Paid = 1 THEN 'True' ELSE 'False' END AS Is_Paid, CASE WHEN LoyaltyPoints_Used = 1 THEN 'True' ELSE 'False' END AS LoyaltyPoints_Used FROM [Order]"; // Ensure the table name is correct
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dbgOrderHistory.DataSource = dataTable; // Bind the DataGridView to the DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED. " + ex.Message);
                }
            }
        }

        private void LoadOrderDetails()
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Order_Details"; // Ensure the table name is correct
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dbgOrderDetails.DataSource = dataTable; // Bind the DataGridView to the DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED. " + ex.Message);
                }
            }
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            loadOrderHistory();
            LoadOrderDetails();
        }

        private void dbgOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private bool validateControls()
        {
            lblPhoneNumError.Text = "";
            lblDescriptionErrorMessage.Text = "";
            lblQtyErrorMessage.Text = "";
            lblItemIdErrorMessage.Text = "";

            bool canAdd = true;

            if (txtSearchItemID.Text == "")
            {
                txtSearchItemID.Focus();
                lblItemIdErrorMessage.ForeColor = Color.Red;
                lblItemIdErrorMessage.Text = "**";
                canAdd = false;

            }
            else if (txtSearchDescr.Text == "")
            {
                txtSearchDescr.Focus();
                lblDescriptionErrorMessage.ForeColor = Color.Red;
                lblDescriptionErrorMessage.Text = "**";
                canAdd = false;
            }
            else if (numQtyOrdered.Value <= 0)
            {
                numQtyOrdered.Focus();
                lblQtyErrorMessage.ForeColor = Color.Red;
                lblQtyErrorMessage.Text = "**";
                canAdd = false;

            }
           
            

            return canAdd;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (validateControls())
            {
                decimal itemAmount = 0.0m;

                string itemId = txtSearchItemID.Text;
                int quantity = (int)numQtyOrdered.Value;
                foreach (MenuItem item in itemPageFrm.menuItemList)
                {
                    string itemID = item.getItemID().ToString();
                    if (itemID.Contains(itemId))
                    {
                        item.setQtySold(quantity);
                        receipt.Add(item);
                        itemAmount = item.getPrice() * quantity;

                        string formattedItem = string.Format("{0,-20} {1,-10:C} {2,-10} {3,-10:C}",
                                                       item.getDescr(), item.getPrice().ToString("C", new CultureInfo("en-ZA")), quantity, itemAmount.ToString("C", new CultureInfo("en-ZA")));

                        lbxReceipt.Items.Add(formattedItem);

                        // Add a line separator between items
                        lbxReceipt.Items.Add(new string('-', 50));


                        totalAmount += itemAmount;
                        break;
                    }
                }

                txtTotalAmount.Text = totalAmount.ToString("C", new CultureInfo("en-ZA"));
                txtSearchItemID.Clear();
                txtSearchDescr.Clear();
                numQtyOrdered.ResetText();
                lbxItemSelection.Items.Clear();
            }
        }

        private void lbxItemSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxItemSelection.SelectedItem != null)
            {
                
                string selectedItem = lbxItemSelection.SelectedItem.ToString();

                
                string selectedItemID = selectedItem.Split(' ')[0]; // Assumes itemID is the first part

                
                foreach (MenuItem item in itemPageFrm.menuItemList)
                {
                    if (item.getItemID().ToString() == selectedItemID)
                    {
                        // Populate the text boxes with the details of the selected item
                        txtSearchDescr.Text = item.getDescr();
                        txtSearchItemID.Text = item.getItemID().ToString();
                        break;
                    }
                }
            }




        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string phoneNum = txtPhoneNum.Text;
            Customer currentCustomer = null;
           

            foreach (Customer customer in customerPageFrm.customerList) 
            {
                if (customer.getCellNo() == phoneNum)
                {
                    currentCustomer = customer;
                    break;
                }

            }
            if (currentCustomer != null)
            {
                //Confirmation confirmationForm = new Confirmation(receipt, currentCustomer, currentOrder);
                //confirmationForm.ShowDialog();
            }
            else
            {
                txtPhoneNum.Focus();
                lblPhoneNumError.ForeColor = Color.Red;
                lblPhoneNumError.Text = "**";
            }
            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            int orderID = orderList.getOrderID(); // Implement this method to get the OrderID from the user interface

            if (orderID <= 0)
            {
                MessageBox.Show("Please select a valid order to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();

                    // Delete the order from the Order_Details table first if there are foreign key constraints
                    string deleteOrderDetailsQuery = "DELETE FROM Order_Details WHERE OrderID = @OrderID";
                    using (SqlCommand deleteOrderDetailsCmd = new SqlCommand(deleteOrderDetailsQuery, conn))
                    {
                        deleteOrderDetailsCmd.Parameters.AddWithValue("@OrderID", orderID);
                        deleteOrderDetailsCmd.ExecuteNonQuery();
                    }

                    // Delete the order from the Orders table
                    string deleteOrderQuery = "DELETE FROM Orders WHERE OrderID = @OrderID";
                    using (SqlCommand deleteOrderCmd = new SqlCommand(deleteOrderQuery, conn))
                    {
                        deleteOrderCmd.Parameters.AddWithValue("@OrderID", orderID);
                        int rowsAffected = deleteOrderCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Order not found or could not be deleted.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting the order: " + ex.Message);
                }
            }
        }
        private void txtSearchDescr_TextChanged(object sender, EventArgs e)
        {
            string searchDescr = txtSearchDescr.Text;
            lbxItemSelection.Items.Clear();

            if (!string.IsNullOrWhiteSpace(searchDescr))
            {
                foreach (MenuItem item in itemPageFrm.menuItemList)
                {
                    string itemDescr = item.getDescr();
                    if (itemDescr.Contains(searchDescr)) // Search description case-insensitive
                    {
                        // Display itemID, description, and price
                        string displayText = string.Format("{0,-10} {1,-20} {2,-10:C}", item.getItemID(), item.getDescr(), item.getPrice().ToString("C", new CultureInfo("en-ZA")));

                        lbxItemSelection.Items.Add(displayText);
                    }
                }
            }
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchItemID_TextChanged(object sender, EventArgs e)
        {
            string searchID = txtSearchItemID.Text;
            lbxItemSelection.Items.Clear();

            if (!string.IsNullOrWhiteSpace(searchID))
            {
                foreach (MenuItem item in itemPageFrm.menuItemList)
                {
                    string itemID = item.getItemID().ToString();
                    if (itemID.Contains(searchID))
                    {
                        // Display itemID, description, and price
                        string displayText = string.Format("{0,-10} {1,-20} {2,-10:C}",item.getItemID(),item.getDescr(),item.getPrice().ToString("C", new CultureInfo("en-ZA")));

                        lbxItemSelection.Items.Add(displayText);
                    }
                }
            }
        }


        //ORDER HISTORY
        private void dtOrderDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtOrderDate.Value.Date;

            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT OrderID, Order_Date, CASE WHEN Is_Paid = 1 THEN 'True' ELSE 'False' END AS Is_Paid, " +
                                   "CASE WHEN LoyaltyPoints_Used = 1 THEN 'True' ELSE 'False' END AS LoyaltyPoints_Used " +
                                   "FROM [Order] WHERE Order_Date = @OrderDate";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OrderDate", selectedDate);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dbgOrderHistory.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED. " + ex.Message);
                }
            }
        }

        //ORDER HISTORY
        private void cbxLoyaltyPointsUsed_CheckedChanged(object sender, EventArgs e)
        {
            bool loyaltyPointsUsed = cbxLoyaltyPointsUsed.Checked;

            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT OrderID, Order_Date, CASE WHEN Is_Paid = 1 THEN 'True' ELSE 'False' END AS Is_Paid, " +
                                   "CASE WHEN LoyaltyPoints_Used = 1 THEN 'True' ELSE 'False' END AS LoyaltyPoints_Used " +
                                   "FROM [Order] WHERE LoyaltyPoints_Used = @LoyaltyPointsUsed";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LoyaltyPointsUsed", loyaltyPointsUsed);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dbgOrderHistory.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED. " + ex.Message);
                }
            }
        }

        //ORDER HISTORY
        private void txtOrderIDSearch_TextChanged(object sender, EventArgs e)

        {
            string orderIDSearch = txtOrderIDSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT OrderID, Order_Date, CASE WHEN Is_Paid = 1 THEN 'True' ELSE 'False' END AS Is_Paid, " +
                                   "CASE WHEN LoyaltyPoints_Used = 1 THEN 'True' ELSE 'False' END AS LoyaltyPoints_Used " +
                                   "FROM [Order] WHERE OrderID LIKE @OrderIDSearch";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OrderIDSearch", "%" + orderIDSearch + "%");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dbgOrderHistory.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED. " + ex.Message);
                }
            }
        }
    }
}
