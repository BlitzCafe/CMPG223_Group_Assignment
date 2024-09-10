using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group29_BlitzCafe
{
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        //Variables
        private Default defaultFrm = new Default();


        private SqlConnection conn;
        private String connString = "Data Source=HIGHPOWER;Initial Catalog=BlitzDB;Integrated Security=True";


        public List<Customer> customerList = new List<Customer>();

        private int choice = 0, selectedItemIndex;

        private int customerID;
        private string fName, lName, sqlQuery, cellNo;
        private DateTime dateJoined = new DateTime();

        //Method for validating input
        private bool validateInput()
        {
            if(txtCellNo.Text.Length != 10)
            {
                lblValidCellNo.Text = "**";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                lblValidFName.Text = "**";
                return false;
            }
            else if(string.IsNullOrWhiteSpace(txtLName.Text))
            {
                lblValidLName.Text = "**";
                return false;
            }
            else
            {
                lblValidCellNo.Text = "";
                lblValidFName.Text = "";
                lblValidLName.Text = "";
                return true;
            }
        }

        public void clearAndEnable()
        {
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            choice = 0;

            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAddNew.Visible = true;

            txtCellNo.Clear();
            txtCustID.Clear();
            txtFName.Clear();
            txtLName.Clear();

            dtpDate.Value = DateTime.Today;
        }


        //Load from info from database
        public void load_Customer_Info()
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
                try
                {
                    conn.Open();

                    sqlQuery = "SELECT * FROM Customers";//SQL Goes here
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dbgCustomerInfo.DataSource = dataTable;

                    //Reading data into List
                    foreach (DataRow row in dataTable.Rows)
                    {
                        customerID = Convert.ToInt32(row["CustomerID"]);
                        lName = Convert.ToString(row["Last_Name"]);
                        fName = Convert.ToString(row["First_Name"]);
                        cellNo = Convert.ToString(row["CellNo"]);
                        dateJoined = Convert.ToDateTime(row["Date_Joined"]);

                        // Create a new Customer object using the data
                        Customer customerObj = new Customer(customerID, lName, fName, cellNo, dateJoined);

                        // Add the Customer object to the list
                        customerList.Add(customerObj);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED" + ex.Message);
                }
            }
        }

        private bool confirm_Add()
        {
            //Add new customer to database

            fName = txtFName.Text;
            lName = txtLName.Text;
            cellNo = txtCellNo.Text;
            dateJoined = dtpDate.Value;

            if (validateInput())
            { 
                // Define the SQL query with parameters
                string query = @"INSERT INTO Customers (Last_Name, First_Name, CellNo, Date_Joined) 
                         VALUES (@fName, @lName, @cellNo, @dateJoined)";

                // Use 'using' statements to ensure proper disposal of resources
                using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Define parameters and their values
                        cmd.Parameters.AddWithValue("@fName", fName);
                        cmd.Parameters.AddWithValue("@lName", lName);
                        cmd.Parameters.AddWithValue("@cellNo", cellNo);
                        cmd.Parameters.AddWithValue("@dateJoined", dateJoined);

                        // Open the connection
                        conn.Open();

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully.");
                            load_Customer_Info(); // Refresh or reload customer info as needed
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Insert failed. No rows affected.");
                        }
                        conn.Close();

                        load_Customer_Info();
                        return true;
                    }
                    catch (SqlException sqlEx)
                    {
                        // Handle SQL-specific exceptions
                        MessageBox.Show("Database error: " + sqlEx.Message);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Handle all other exceptions
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled correctly. " +
                                "First Name and Last Name cannot be empty, and Cell No must be 10 digits.");
                return false;
            }            
        }

        private void confirm_Delete()
        {
            if (selectedItemIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Deleting Customer", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = @"DELETE FROM Customers WHERE CustomerID = '" + Convert.ToInt32(txtCustID.Text) + "'";
                    using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        //Delete customer from databse
                        try
                        {
                            conn.Open();

                            //Execute the command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Check if the insert was successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item Deleted successfully.");
                                txtCustID.Clear();
                                txtFName.Clear();
                                txtLName.Clear();
                                txtCellNo.Clear();
                                load_Customer_Info(); // Refresh or reload customer info as needed
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
            }
        }
        private bool confirm_Update()
        {
            string newFName = txtFName.Text;
            string newLName = txtLName.Text;
            string newCellNo = txtCellNo.Text;


            if (validateInput())
            {
                // Define the SQL query with parameters
                string query = @"UPDATE Customers SET Last_Name = @newLName, First_Name = @newFName, CellNo = @newCellNo WHERE CustomerID = '" + Convert.ToInt32(txtCustID.Text) + "'";

                // Use 'using' statements to ensure proper disposal of resources
                using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Define parameters and their values
                        cmd.Parameters.AddWithValue("@newFName", newFName);
                        cmd.Parameters.AddWithValue("@newLName", newLName);
                        cmd.Parameters.AddWithValue("@newCellNo", newCellNo);

                        // Open the connection
                        conn.Open();

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer edited successfully.");
                            load_Customer_Info(); // Refresh or reload customer info as needed

                        }
                        else
                        {
                            MessageBox.Show("Insert failed. No rows affected.");
                        }
                        conn.Close();

                        return true;
                    }
                    catch (SqlException sqlEx)
                    {
                        // Handle SQL-specific exceptions
                        MessageBox.Show("Database error: " + sqlEx.Message);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Handle all other exceptions
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure all info is entered and correct.");
                return false;
            }
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(defaultFrm.connString);


            load_Customer_Info();

            //Make changing ID and Date Joined impossible for user
            txtCustID.ReadOnly = true;
            dtpDate.Enabled = false;

            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            //Max length for any cellphone number
            txtCellNo.MaxLength = 10;
        }

        private void dbgCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //determine if a valid record is selected
            if (e.RowIndex > -1 && e.RowIndex < dbgCustomerInfo.Rows.Count)
            {
                DataGridViewRow currentRow = dbgCustomerInfo.Rows[e.RowIndex];

                if (currentRow.Cells["CustomerID"].Value != DBNull.Value)
                {

                    //extract info of the selectedrow
                    int selectedID;

                    //determine selected items ID
                    selectedID = Convert.ToInt32(currentRow.Cells["CustomerID"].Value);

                    //initialize the index variable
                    selectedItemIndex = 0;
                    bool itemFound = false;

                    //use a while loop to find the item with the matching ItemID
                    while (selectedItemIndex < customerList.Count)
                    {
                        if (customerList[selectedItemIndex].getCustomerID() == selectedID)
                        {
                            itemFound = true;
                            break; //exit the loop once the item is found
                        }
                        selectedItemIndex++;
                    }

                    //if the item is found, populate the textboxes using the index
                    if (itemFound)
                    {
                        txtCustID.Text = customerList[selectedItemIndex].getCustomerID().ToString();
                        txtLName.Text = customerList[selectedItemIndex].getLastName();
                        txtFName.Text = customerList[selectedItemIndex].getFirstName();
                        txtCellNo.Text = customerList[selectedItemIndex].getCellNo();
                        dtpDate.Value = customerList[selectedItemIndex].getDateJoined();
                    }
                    else  //if the record is not found in the menuItemList, set index to -1 and return error message
                    {
                        MessageBox.Show("Selected item not found in the list.");
                        selectedItemIndex = -1;
                    }
                }
                else  //error message if row selected is out of bounds
                {
                    MessageBox.Show("Error: Please select a valid customer from the list.");
                }
                
            }
        }

        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    {
                        if(confirm_Add())
                        {
                            clearAndEnable();
                        }
                        break;
                    }
                case 2:
                    {
                        confirm_Delete();

                        clearAndEnable();

                        txtFName.ReadOnly = false;
                        txtLName.ReadOnly = false;
                        txtCellNo.ReadOnly = false;

                        break;
                        
                    }
                case 3:
                    {
                        if (confirm_Update())
                        {
                            clearAndEnable();
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            choice = 0;

            txtFName.ReadOnly = false;
            txtLName.ReadOnly = false;
            txtCellNo.ReadOnly = false;

            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAddNew.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            dtpDate.Enabled = false;

            choice = 3;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAddNew.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            dtpDate.Enabled = false;

            choice = 2;

            txtFName.ReadOnly = true;
            txtLName.ReadOnly = true;
            txtCellNo.ReadOnly = true;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAddNew.Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            dtpDate.Enabled = true;

            choice = 1;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAddNew.Visible = false;
        }
    }
}
