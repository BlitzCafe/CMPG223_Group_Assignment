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

        private int choice = 0;
       

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

            using (SqlConnection conn = new SqlConnection(defaultFrm.connString)) 
            {
                try
                {
                    conn.Open();
                    string loadQry = "";
                    SqlCommand cmd = new SqlCommand(loadQry, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                   

                    while (reader.Read())
                    {
                        itemID = reader.GetInt32(0);
                        descr = reader.GetString(1);
                        price = reader.GetDecimal(3);

                        MenuItem item = new MenuItem(itemID, descr, price);
                        menuItemList.Add(item);
                    }
                    reader.Close();

                    dbgMenuItems.DataSource = menuItemList;


                    conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not load menu items: " + e);
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
            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;
            choice = 1;

            btnCancel.Visible = true;
            btnConfirm.Visible = true;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;

            btnCancel.Visible = true;
            btnConfirm.Visible = true;
        }

        //delete an item from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;

            btnCancel.Visible = true;
            btnConfirm.Visible = true;

            MenuItem removeItem = menuItemList[selectedItemIndex];

            //if the item to be removed is not zero, confirm deletion
            if (removeItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                    {
                       

                        menuItemList.Remove(removeItem);
                        //string query = "DELETE * FROM tblITems WHERE ItemID = " + selectedItemIndex;
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


       

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    {
                        //confirm_Add();
                        btnConfirm.Visible = false;
                        btnCancel.Visible = false;

                        choice = 1;
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

                        choice = 2;


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

                        choice = 0;

                        btnAddItem.Visible = true;
                        btnDelete.Visible = true;
                        btnEditItem.Visible = true;

                        //call load method to refresh dbgrid and reset objects to be the same as the database
                        loadMenuItems();
                        break;
                    }
                default:
                    {
                        break;

                    }
               
            }

            btnAddItem.Visible = true;
            btnDelete.Visible = true;
            btnEditItem.Visible = true;

            btnCancel.Visible = false;
            btnConfirm.Visible = false;

        }

        private void addItem()
        {
            //create temp variables for item attributes
            int newItemId;
            decimal price;
            string descr;

            btnAddItem.Visible = false;
            btnDelete.Visible = false;
            btnEditItem.Visible = false;


            btnConfirm.Visible = false;
            btnConfirm.Visible = true;


            //calll validate method, if valid execute code
            if (validateInput())
            {
                //assign temp values with valid user inputs
                descr = txtDesc.Text;
                price = Convert.ToDecimal(txtPrice.Text);

                //insert new item into database  DYLAN AND SINO
                using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                {
                    try
                    {
                       
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


            btnConfirm.Visible = false;
            btnCancel.Visible = false;

        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
           
        }

       


        private void btnCancel_Click(object sender, EventArgs e)
        {


        }
    }
}


