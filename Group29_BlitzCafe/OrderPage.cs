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

        private void txtSearchItemID_TextChanged(object sender, EventArgs e)
        {
            string searchID = txtSearchItemID.Text;
            lbxItemSelection.Items.Clear();
            if (searchID != "")
            {
                foreach (MenuItem item in itemPageFrm.menuItemList)
                {
                    string itemID = item.getItemID().ToString();
                    if (itemID.Contains(searchID))
                    {
                        lbxItemSelection.Items.Add(item.toString());
                        break;

                    }

                }
            }
            else lbxItemSelection.Items.Clear();

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            decimal itemAmount = 0.0m; 
            string itemId = txtSearchItemID.Text;
            int quantity = int.Parse(txtQtyIItemOrdered.Text);
            foreach (MenuItem item in itemPageFrm.menuItemList)
            {
                string itemID = item.getItemID().ToString();
                if (itemID.Contains(itemId))
                {
                    item.setQtySold(quantity);
                    receipt.Add(item);
                    itemAmount = item.getPrice() * quantity;
                    lbxReceipt.Items.Add(item.toString() + "Order Amount: "  +itemAmount.ToString());

                    totalAmount += itemAmount;
                    break;
                }
            }

            txtTotalAmount.Text = totalAmount.ToString();
            txtSearchItemID.Clear();
            txtSearchDescr.Clear();
            txtQtyIItemOrdered.Clear();
            lbxItemSelection.Items.Clear();

        }

        private void lbxItemSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxItemSelection.SelectedItem != null)
            {

                string selectedItemInfo = lbxItemSelection.SelectedItem.ToString();

                // Loop through the menuItemList to find the matching item
                foreach (MenuItem item in itemPageFrm.menuItemList)
                {
                    // Check for matching criteria (here we assume the `ToString` method returns a unique representation)
                    if (item.toString() == selectedItemInfo)
                    {
                        // Set the description and item ID in the text boxes
                        txtSearchDescr.Text = item.getDescr();
                        txtSearchItemID.Text = item.getItemID().ToString();
                        break; // Exit the loop once a match is found

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
                Confirmation confirmationForm = new Confirmation(receipt, currentCustomer);
                confirmationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phone number does not exist. Please try again.");
            }
            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderIDSearch_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtQtyIItemOrdered_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
