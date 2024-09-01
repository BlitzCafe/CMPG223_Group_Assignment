using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Group29_BlitzCafe
{
    public partial class ItemPage : Form
    {
        //create menuitem list, link to default form and create global index variable
        public List<MenuItem> menuItemList = new List<MenuItem>();
        private Default defaultFrm = new Default();
        private int selectedItemIndex;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        private int choice = 0;
       

        public ItemPage()
        {
            InitializeComponent();
            loadMenuItems();
        }

        //validate text box inputs to be of the same type as the database
        private bool validateInput()
        {
           
            
                if (!decimal.TryParse(numPrice.Text, out decimal _))
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
        public void loadMenuItems()
        {
            menuItemList.Clear();
            int itemID;
            string descr;
            decimal price;

           
                using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT ItemID, Description, Price FROM Items";
                        cmd = new SqlCommand(query, conn);


                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the DataGridView to the DataTable
                        dbgMenuItems.DataSource = dataTable;


                        //create objects for each line in the dbgrid
                        foreach (DataRow row in dataTable.Rows)
                        {
                            itemID = Convert.ToInt32(row["ItemID"]);
                            descr = row["Description"].ToString();
                            price = Convert.ToDecimal(row["Price"]);

                            // Create a new MenuItem object using the data
                            MenuItem menuItem = new MenuItem(itemID, descr, price);

                            // Add the MenuItem object to the list
                            menuItemList.Add(menuItem);
                        }

                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Could not load menu items: " + e);
                    }
                
            }

        }
        
        //edit current items after selecting them fro the dbgrid
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;

            choice = 3;

            btnCancel.Visible = true;
            btnConfirm.Visible = true;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;

            choice = 1;

            btnCancel.Visible = true;
            btnConfirm.Visible = true;
        }

        //delete an item from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;

            txtDesc.ReadOnly = true;
            txtItemID.ReadOnly = true;
            numPrice.ReadOnly = true;

            choice = 2;

            btnCancel.Visible = true;
            btnConfirm.Visible = true;


        }


       

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "")
            {
                txtDesc.Focus();
                lblDescriptionError.Text = "**";
                lblDescriptionError.ForeColor = Color.Red;

            }
            else if (numPrice.Value <= 0)
            {
                numPrice.Focus();
                lblPriceError.Text = "**";
                lblPriceError.ForeColor = Color.Red;

            }
            else
            {
                switch (choice)
                {
                    case 1:
                        {
                            //confirm_Add();
                            btnConfirm.Visible = false;
                            btnCancel.Visible = false;


                            addItem();

                            btnAddItem.Visible = true;
                            btnDelete.Visible = true;
                            btnEditItem.Visible = true;
                            break;
                        }
                    case 2:
                        {
                            //confirm_Delete();
                            btnConfirm.Visible = false;
                            btnCancel.Visible = false;


                            deleteItem();


                            txtDesc.ReadOnly = false;
                            txtItemID.ReadOnly = false;
                            numPrice.ReadOnly = false;

                            btnAddItem.Visible = true;
                            btnDelete.Visible = true;
                            btnEditItem.Visible = true;
                            break;
                        }
                    case 3:
                        {
                            //confirm_Update();
                            btnConfirm.Visible = false;
                            btnCancel.Visible = false;

                            editItem();

                            btnAddItem.Visible = true;
                            btnDelete.Visible = true;
                            btnEditItem.Visible = true;

                            //call load method to refresh dbgrid and reset objects to be the same as the database
                            loadMenuItems();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Something went wrong :(");

                            break;

                        }

                }

                btnAddItem.Visible = true;
                btnDelete.Visible = true;
                btnEditItem.Visible = true;

                btnCancel.Visible = false;
                btnConfirm.Visible = false;

            }

        }


           

        private void editItem()
        {
            if (validateInput())
            {
                string newDescri = txtDesc.Text;
                decimal newPrice = Convert.ToDecimal(numPrice.Text);

                string query = @"UPDATE Items SET Description = @newDescri, Price = @newPrice WHERE ItemID = '" + Convert.ToInt32(txtItemID.Text) + "'";
                //Update new item into database  DYLAN AND SINO
                using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                using (cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Define parameters and their values
                        cmd.Parameters.AddWithValue("@newDescri", newDescri);
                        cmd.Parameters.AddWithValue("@newPrice", newPrice);

                        conn.Open();

                        //Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item edited successfully.");
                            loadMenuItems(); // Refresh or reload menu items info as needed
                        }
                        else
                        {
                            MessageBox.Show("Edit failed. No rows affected.");
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Item could not be edited to database. " + ex.Message);
                    }

                    menuItemList[selectedItemIndex].setDescr(newDescri);
                    menuItemList[selectedItemIndex].setPrice(newPrice);

                    btnConfirm.Visible = false;
                    btnCancel.Visible = false;

                    btnAddItem.Visible = true;
                    btnDelete.Visible = true;
                    btnEditItem.Visible = true;
                    loadMenuItems();
                }
            }
        }

        private void addItem()
        {
            //create temp variables for item attributes
            int newItemId;
            decimal price;
            string descri;


            //calll validate method, if valid execute code
            if (validateInput())
            {
                //assign temp values with valid user inputs
                descri = txtDesc.Text;
                price = Convert.ToDecimal(numPrice.Text);
                string query = @"INSERT INTO Items (Description, Price) VALUES (@descri, @price)";
                //insert new item into database  DYLAN AND SINO
                using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                using (cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Define parameters and their values
                        cmd.Parameters.AddWithValue("@descri", descri);
                        cmd.Parameters.AddWithValue("@price", price);

                        conn.Open();

                        //Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added successfully.");
                            loadMenuItems(); // Refresh or reload menu items info as needed
                        }
                        else
                        {
                            MessageBox.Show("Insert failed. No rows affected.");
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Item could not be added to database. " + ex.Message);
                    }
                }

            }
            else 
            {
                MessageBox.Show("Please ensure all fields are filled correctly. " +
                        "Description and Price cannot be empty.");
            }

            btnAddItem.Visible = true;
            btnDelete.Visible = true;
            btnEditItem.Visible = true;


            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            loadMenuItems();
        }

        private void deleteItem()
        {

            if (selectedItemIndex != -1)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = @"DELETE FROM Items WHERE ItemID = '"+Convert.ToInt32(txtItemID.Text)+"'";
                    using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                    using (cmd = new SqlCommand(query, conn))
                    {
                        //Delete item from databse
                        try
                        {
                            conn.Open();

                            //Execute the command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Check if the insert was successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item Deleted successfully.");
                                txtDesc.Clear();
                                txtItemID.Clear();
                                numPrice.ResetText();
                                loadMenuItems(); // Refresh or reload menu items info as needed
                            }
                            else
                            {
                                MessageBox.Show("Delete failed. No rows affected.");
                            }

                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Item could not be deleted from database. " + ex.Message);
                        }
                    }
                    

                    
                    

                }
                else
                {
                    //delete canceled, do nothing
                    MessageBox.Show("Delete Aborted: No items were removed.");
                }

            }
            

            loadMenuItems();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = true;
            btnDelete.Visible = true;
            btnEditItem.Visible = true;

            

            btnCancel.Visible = false;
            btnConfirm.Visible = false;

        }

        private void ItemPage_Load(object sender, EventArgs e)
        {
            btnAddItem.Visible = true;
            btnDelete.Visible = true;
            btnEditItem.Visible = true;

            btnCancel.Visible = false;
            btnConfirm.Visible = false;

            lblDescriptionError.Text = "";
            lblPriceError.Text = "";
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        //method to populate text boxes as soon as the user selects a record
        private void dbgMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //determine if a valid record is selected
            if (e.RowIndex > -1 && e.RowIndex < dbgMenuItems.Rows.Count)
            {
                DataGridViewRow currentRow = dbgMenuItems.Rows[e.RowIndex];

                if (currentRow.Cells["ItemID"].Value != DBNull.Value)
                { 
                    //extract info of the selectedrow
                    int selectedID = Convert.ToInt32(currentRow.Cells["ItemID"].Value);

                    //determine selected items ID
                    selectedID = Convert.ToInt32(currentRow.Cells["ItemID"].Value);

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
                        numPrice.Text = menuItemList[selectedItemIndex].getPrice().ToString();
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
            else
            {
                // Error message if row selected is out of bounds
                MessageBox.Show("Error: Please select a valid item from the list.");
            }

        }

        private void lblQtyErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblItemIdErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


