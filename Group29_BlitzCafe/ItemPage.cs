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
    public partial class ItemPage : Form
    {
        //create menuitem list, link to default form and create global index variable
        public List<MenuItem> menuItemList = new List<MenuItem>();
        private Default defaultFrm = new Default();
        private int selectedItemIndex;
        public string connString = @"Data Source=HIGHPOWER;Initial Catalog=BlitzDB;Integrated Security=True";
        SqlDataAdapter adap;
        SqlConnection conn;
        SqlCommand cmd;

        public ItemPage()
        {
            InitializeComponent();
            loadMenuItems();
        }

        //validate text box inputs to be of the same type as the database
        private bool validateInput()
        {
            if (!int.TryParse(txtItemID.Text, out int _))
            {
                MessageBox.Show("Item ID must be a valid integer.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal _))
            {
                MessageBox.Show("Price must be a valid decimal number.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Description cannot be empty.");
                return false;
            }

            return true;
        }

        //method to load items out of the database into the dbgrid and the menuItemList
        private void loadMenuItems()
        {
            menuItemList.Clear();
            int itemID;
            string descr;
            decimal price;


            using (conn = new SqlConnection(connString))

            {
                try
                {
                    //Dyaln and sino
                    conn.Open();
r
                    string query = "SELECT ItemsID, Description, Price FROM Items";
                    cmd = new SqlCommand(query, conn);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dbgMenuItems.DataSource = dataTable;

                    //create objects for each line in the dbgrid
                    foreach (DataRow row in dataTable.Rows)
                    {
                        itemID = Convert.ToInt32(row["ItemsID"]);
                        descr = row["Description"].ToString();
                        price = Convert.ToDecimal(row["Price"]);

                        // Create a new MenuItem object using the data
                        MenuItem menuItem = new MenuItem(itemID, descr, price);

                        // Add the MenuItem object to the list
                        menuItemList.Add(menuItem);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED " + ex.Message);
                }
            }

        }
        //method to populate text boxes as soon as the user selects a record
        private void dbgMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //determine if a valid record is selected
            if (e.RowIndex > 0)
            {
                //extract info of the selectedrow
                int selectedID;
                DataGridViewRow currentRow = dbgMenuItems.Rows[e.RowIndex];
                //determine selected items ID
                selectedID = Convert.ToInt32(currentRow.Cells["ItemsID"].Value);

                //initialize the index variable
                selectedItemIndex = 0;
                bool itemFound = false;

                //use a while loop to find the item with the matching ItemID
                while (selectedItemIndex < menuItemList.Count)
                {
                    if (menuItemList[selectedItemIndex].getItemID() == selectedID)
                    {
                        itemFound = true;
                        break; //exit the loop once the item is found
                    }
                    selectedItemIndex++;
                }

                //if the item is found, populate the textboxes using the index
                if (itemFound)
                {
                    txtItemID.Text = menuItemList[selectedItemIndex].getItemID().ToString();
                    txtDesc.Text = menuItemList[selectedItemIndex].getDescr();
                    txtPrice.Text = menuItemList[selectedItemIndex].getPrice().ToString();
                }
                else  //if the record is not found in the menuItemList, set index to -1 and return error message
                {
                    MessageBox.Show("Selected item not found in the list.");
                    selectedItemIndex = -1;
                }
            }
            else  //error message if row selected is out of bounds
            {
                MessageBox.Show("Error: Please select a valid item from the list.");
            }
        }
        //edit current items after selecting them fro the dbgrid
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;

            btnCancelEdit.Visible = true;
            btnConfirmEdit.Visible = true;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
        }

        //delete an item from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MenuItem removeItem = menuItemList[selectedItemIndex];

            //if the item to be removed is not zero, confirm deletion
            if (removeItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(defaultFrm.connString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM tblItems WHERE ItemID = @ItemID";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ItemID", removeItem.getItemID());

                            cmd.ExecuteNonQuery();

                            // Remove item from the list
                            menuItemList.Remove(removeItem);

                            // Refresh the data grid
                            loadMenuItems();
                            MessageBox.Show("Menu Item successfully deleted.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Item could not be deleted. " + ex.Message);
                        }

                        menuItemList.Remove(removeItem);
                        //string query = "DELETE * FROM tblItems WHERE ItemID = " + selectedItemIndex;
                        MessageBox.Show("Menu Item Succesfully deleted.");
                    }
                }
                else
                {
                    //delete canceled, do nothing
                    MessageBox.Show("Delete Aborted: No items were removed.");
                }

            }
            else
            {
                MessageBox.Show("No Item matching the selected ID was found. No action was taken.");
            }



        }

        private void lbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sort se3lection
            int sortType = lbSort.SelectedIndex;

            int itemID;
            string descr;
            decimal price;



                    conn.Open();
                    string query = "SELECT ItemsID, Description, Price FROM Items ORDER BY ItemsID";
                    cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dbgMenuItems.DataSource = dataTable;

                    //create objects for each line in the dbgrid
                    foreach (DataRow row in dataTable.Rows)
                    {
                        itemID = Convert.ToInt32(row["ItemsID"]);
                        descr = row["Description"].ToString();
                        price = Convert.ToDecimal(row["Price"]);

                        // Create a new MenuItem object using the data
                        MenuItem menuItem = new MenuItem(itemID, descr, price);

                        // Add the MenuItem object to the list
                        menuItemList.Add(menuItem);
                    }
                    conn.Close();

                    break;

                case 1:
                    lblSortHeading.Text = "Sorted by: ItemID Descending";

                    conn.Open();
                    string query1 = "SELECT ItemsID, Description, Price FROM Items ORDER BY ItemsID DESC";
                    cmd = new SqlCommand(query1, conn);
                    SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd);
                    DataTable dataTable1 = new DataTable();
                    dataAdapter1.Fill(dataTable1);

                    // Bind the DataGridView to the DataTable
                    dbgMenuItems.DataSource = dataTable1;

                    //create objects for each line in the dbgrid
                    foreach (DataRow row in dataTable1.Rows)
                    {
                        itemID = Convert.ToInt32(row["ItemsID"]);
                        descr = row["Description"].ToString();
                        price = Convert.ToDecimal(row["Price"]);

                        // Create a new MenuItem object using the data
                        MenuItem menuItem = new MenuItem(itemID, descr, price);

                        // Add the MenuItem object to the list
                        menuItemList.Add(menuItem);
                    }
                    conn.Close();

                    break;

                case 2:
                    lblSortHeading.Text = "Sorted by: Price Ascending";

                    conn.Open();
                    string query2 = "SELECT ItemsID, Description, Price FROM Items ORDER BY Price";
                    cmd = new SqlCommand(query2, conn);
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd);
                    DataTable dataTable2 = new DataTable();
                    dataAdapter2.Fill(dataTable2);

                    // Bind the DataGridView to the DataTable
                    dbgMenuItems.DataSource = dataTable2;

                    //create objects for each line in the dbgrid
                    foreach (DataRow row in dataTable2.Rows)
                    {
                        itemID = Convert.ToInt32(row["ItemsID"]);
                        descr = row["Description"].ToString();
                        price = Convert.ToDecimal(row["Price"]);

                        // Create a new MenuItem object using the data
                        MenuItem menuItem = new MenuItem(itemID, descr, price);

                        // Add the MenuItem object to the list
                        menuItemList.Add(menuItem);
                    }
                    conn.Close();
                    break;

                case 3:
                    lblSortHeading.Text = "Sorted by: Price Descending";
                    conn.Open();
                    string query3 = "SELECT ItemsID, Description, Price FROM Items ORDER BY Price DESC";
                    cmd = new SqlCommand(query3, conn);
                    SqlDataAdapter dataAdapter3 = new SqlDataAdapter(cmd);
                    DataTable dataTable3 = new DataTable();
                    dataAdapter3.Fill(dataTable3);
                    
                    // Bind the DataGridView to the DataTable
                    dbgMenuItems.DataSource = dataTable3;

                    //create objects for each line in the dbgrid
                    foreach (DataRow row in dataTable3.Rows)
                    {
                        itemID = Convert.ToInt32(row["ItemsID"]);
                        descr = row["Description"].ToString();
                        price = Convert.ToDecimal(row["Price"]);

                        // Create a new MenuItem object using the data
                        MenuItem menuItem = new MenuItem(itemID, descr, price);

                        // Add the MenuItem object to the list
                        menuItemList.Add(menuItem);
                    }
                    conn.Close();

                    break;

                default:
                    lblSortHeading.Text = "Sorted by: None";
                    query = "SELECT * FROM tblItem";
                    break;

            }
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            //test if item to be edited is within valid bounds
            if (selectedItemIndex >= 0 && selectedItemIndex < menuItemList.Count())
            {
                //create object to represent old object
                MenuItem originalItem = menuItemList[selectedItemIndex];

                //create new object with the same ID andd the textbox variables 
                MenuItem newItem = new MenuItem(originalItem.getItemID(), txtDesc.Text, Convert.ToDecimal(txtPrice.Text));

                //use class equals method to determine if the object was changed
                if (!originalItem.equals(newItem))
                {

                    using (conn = new SqlConnection(connString))
                    {

                        //append new object to database DYLAN & SINO
                        conn.Open();
                        string query = "UPDATE Items SET Description = "+txtDesc.Text+", Price = "+Convert.ToDecimal(txtPrice.Text)+" WHERE ItemsID = "+Convert.ToInt32(txtItemID.Text)+"";
                        cmd = new SqlCommand(query, conn);
                        adap.UpdateCommand = cmd;
                        adap.UpdateCommand.ExecuteNonQuery();

                        MessageBox.Show("Item has been appended.");
                        conn.Close();

                    }

                    //call load method to refresh dbgrid and reset objects to be the same as the database
                    loadMenuItems();
                }
                else  //if the values are the same, display that no changes were made
                {
                    MessageBox.Show("No changes were made.");
                }
            }

            btnAddItem.Visible = true;
            btnDelete.Visible = true;
            btnEditItem.Visible = true;

            btnCancelEdit.Visible = false;
            btnConfirmEdit.Visible = false;

        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            //create temp variables for item attributes
            int newItemId;
            decimal price;
            string desc;

            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;

            btnConfirmAdd.Visible = false;
            btnConfirmEdit.Visible = true;

            //calll validate method, if valid execute code
            if (validateInput())
            {
                //assign temp values with valid user inputs
                desc = txtDesc.Text;
                price = Convert.ToDecimal(txtPrice.Text);

                //insert new item into database  DYLAN AND SINO
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Items VALUES ("+desc+", '"+price+"')";
                        cmd = new SqlCommand(query, conn);
                        adap.InsertCommand = cmd;
                        adap.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Item has been added.");
                        conn.Close();

                        // !use this line to excecute command, ExecuteScalar() returns the value in the first field aka ItemID
                        //int newItemID = Convert.ToInt32(cmd.ExecuteScalar());  

                        /*  !This code wont run thill the database works...
                         
                        MenuItem newItem = new MenuItem(newItemID, desc, price);
                        menuItemList.Add(newItem);

                        */
                        loadMenuItems();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Item could not be added to database. " + ex.Message);
                    }
                }

            }

            btnAddItem.Visible = true;
            btnDelete.Visible = true;
            btnEditItem.Visible = true;

            btnConfirmAdd.Visible = false;
            btnConfirmEdit.Visible = false;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = true;
            btnDelete.Visible = true;
            btnEditItem.Visible = true;

            btnConfirmAdd.Visible = false;
            btnConfirmEdit.Visible = false;
            btnConfirmEdit.Visible = false;
        }
    }
}


