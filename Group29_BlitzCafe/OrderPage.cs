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

        private List<MenuItem> receipt = new List<MenuItem>();
        private List<Order> orderList = new List<Order>();

        public OrderPage()
        {
            InitializeComponent();
            loadOrderHistory();
        }

        private void loadOrderHistory()
        {

            int orderId;
            DateTime orderDate;
            bool loyaltyPointsUsed, isPayed;

           using (SqlConnection conn = new SqlConnection(defaultFrm.connString))          
            {
                try 
                {
                    conn.Open();
                    string query = "SELECT OrderId, OrderDate, Is_Paid, loyaltyPoints_Used FROM tblOrder";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dbgOrderHistory.DataSource = dataTable;


                    foreach (DataRow row in dataTable.Rows)
                    {
                        orderId = Convert.ToInt32(row["OrderId"]);
                        orderDate = Convert.ToDateTime(row["OrderDate"]);
                        isPayed = Convert.ToBoolean(row["IsPayed"]);
                        loyaltyPointsUsed = Convert.ToBoolean(row["loyaltypointsused"]);

                        // Create a new Order object using the data
                        Order order = new Order(orderId, orderDate, isPayed, loyaltyPointsUsed);

                        // Add the Order object to the list
                        orderList.Add(order);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED" + ex.Message);
                }
            }
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            
        }

        private void dbgOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchItemID_TextChanged(object sender, EventArgs e)
        {
            string searchID = txtSearchItemID.Text;
            if (searchID != "")
            {
                lbxItemSelection.Items.Clear();

                foreach (MenuItem item in itemPageFrm.menuItemList)
                {
                    string itemID = item.getItemID().ToString();
                    if (itemID.Contains(searchID))
                    {
                        lbxItemSelection.Items.Add(item);

                    }

                }
            }
            else lbxItemSelection.Items.Clear();

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0.0m;
            string itemId = txtSearchItemID.Text;
            foreach (MenuItem item in itemPageFrm.menuItemList)
            {
                string itemID = item.getItemID().ToString();
                if (itemID.Contains(itemId))
                {
                    receipt.Add(item);
                    lbxReceipt.Items.Add(item.toString());
                    totalAmount += item.getPrice();
                }
            }
            txtTotalAmount.Text = totalAmount.ToString();

        }

        private void lbxItemSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxItemSelection.SelectedIndex;

            if (index >= 0 && index <= itemPageFrm.menuItemList.Count)
            {
                MenuItem selectedItem = itemPageFrm.menuItemList[index];

                txtSearchDescr.Text = selectedItem.getDescr();
                txtSearchItemID.Text = selectedItem.getItemID().ToString();
            }

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Confirmation confirmationForm = new Confirmation(receipt, txtCellNumber.Text);
            confirmationForm.ShowDialog();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            //Code here

            DialogResult result = MessageBox.Show("Do you want to delete the selected record?", "Delete confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //If they want to delete
            }
        }

        private void txtOrderIDSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
