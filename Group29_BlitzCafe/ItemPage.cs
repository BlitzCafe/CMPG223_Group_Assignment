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

namespace Group29_BlitzCafe
{
    public partial class ItemPage : Form
    {
        //create menuitem list, link to default form and create global index variable
        private List<MenuItem> menuItemList = new List<MenuItem>();
        private Default defaultFrm = new Default();
        private int selectedItemIndex;

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

            using (MySqlConnection conn = new MySqlConnection(defaultFrm.connString))
            {
                try
                {
                    //Dyaln and sino
                    conn.Open();
                    string query = "SELECT ItemID, Descr, Price FROM Item";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dbgMenuItems.DataSource = dataTable;

                    //create objects for each line in the dbgrid
                    foreach (DataRow row in dataTable.Rows)
                    {
                        itemID = Convert.ToInt32(row["ItemID"]);
                        descr = row["Descr"].ToString();
                        price = Convert.ToDecimal(row["Price"]);

                        // Create a new MenuItem object using the data
                        MenuItem menuItem = new MenuItem(itemID, descr, price);

                        // Add the MenuItem object to the list
                        menuItemList.Add(menuItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED" + ex.Message);
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

                    using (MySqlConnection conn = new MySqlConnection(defaultFrm.connString))
                    {
                        //append new object to database DYLAN & SINO
                    }

                    //call load method to refresh dbgrid and reset objects to be the same as the database
                    loadMenuItems();
                }
                else  //if the values are the same, display that no changes were made
                {
                    MessageBox.Show("No changes were made.");
                }

            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //create temp variables for item attributes
            int newItemId;
            decimal price;
            string desc;

            //calll validate method, if valid execute code
            if (validateInput())
            {
                //assign temp values with valid user inputs
                desc = txtDesc.Text;
                price = Convert.ToDecimal(txtPrice.Text);

                //insert new item into database  DYLAN AND SINO
                using (MySqlConnection conn = new MySqlConnection(defaultFrm.connString))
                {
                    try
                    {
                        

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
        }
    }
}

