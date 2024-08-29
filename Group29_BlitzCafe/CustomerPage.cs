using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
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

        private String connString = "Data Source=blitzcafedatabase.c9uaw2k2s8lc.us-east-1.rds.amazonaws.com;Initial Catalog=BlitzCafeDatabase;User ID=admin;Password=12345678";

        private List<Customer> customerList = new List<Customer>();

        private int customerID;
        private string fName, lName, cellNo, sqlQuery;
        private DateTime dateJoined = new DateTime();

        //Load from info from database
        private void Load_Customer_Info()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    sqlQuery = "SELECT * FROM tblCustomer";//SQL Goes here
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable); // Fill the DataTable once

                    dbgCustomerInfo.DataSource = dataTable; // Bind the DataTable to the DataGridView

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

        private void UpdateCustomerInDatabase(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {
               
                conn.Open();

                sqlQuery = " ";//SQL Goes here

                using (SqlCommand cmd = new SqlCommand(sqlQuery,conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customer.getCustomerID());
                    cmd.Parameters.AddWithValue("@LastName",customer.getLastName());
                    cmd.Parameters.AddWithValue("@FirstName", customer.getFirstName());
                    cmd.Parameters.AddWithValue("@CellNo", customer.getCellNo());
                    cmd.Parameters.AddWithValue("@Date_Joined", customer.getDateJoined());

                    cmd.ExecuteNonQuery();
                }


            }
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C__USERS_USER_DOCUMENTS_BLITZCAFEDATABASE_MDFDataSet.tblCustomer' table. You can move, or remove it, as needed.
            //this.tblCustomerTableAdapter.Fill(this.BLITZCAFEDATA.tblCustomer);
            using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
            {

                Load_Customer_Info();

                //Make changing ID and Date Joined impossible for user
                txtCustID.ReadOnly = true;
                txtDate.ReadOnly = true;
                //Max length for any cellphone number
                txtCellNo.MaxLength = 10;
            }
        }

        private void dbgCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow selectedRow = dbgCustomerInfo.Rows[e.RowIndex];

                txtCustID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
                txtFName.Text = selectedRow.Cells["First_Name"].Value.ToString();
                txtLName.Text = selectedRow.Cells["Last_Name"].Value.ToString();
                txtCellNo.Text = selectedRow.Cells["CellNo"].Value.ToString();
                txtDate.Text = selectedRow.Cells["Date_Joined"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dbgCustomerInfo.SelectedRows.Count > 0)
            {
                //Get the primary key of the selected row
                int selectedID = Convert.ToInt32(dbgCustomerInfo.SelectedRows[0].Cells["CustomerID"].Value);

                //Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(defaultFrm.connString))
                    {
                        try
                        {
                            conn.Open();

                            //Double check SQL
                            sqlQuery = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

                            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                            {

                            }

                            conn.Close();

                            Load_Customer_Info();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No row selected to delete: " + ex.Message);
                        }
                    }

                }

            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //Add new customer to database

            fName = txtFName.Text;
            lName = txtLName.Text;
            cellNo = txtCellNo.Text;
            dateJoined = DateTime.Today;

            if (cellNo.Length == 10 && !string.IsNullOrWhiteSpace(txtFName.Text) && !string.IsNullOrWhiteSpace(txtLName.Text))
            {
                //Save info in database
                sqlQuery = "";

                Load_Customer_Info();
            }
            else
            {
                MessageBox.Show("Please make sure all info is entered and correct.");
            }
        }


        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            if (dbgCustomerInfo.SelectedRows.Count > 0)
            {
                if (cellNo.Length == 10 && !string.IsNullOrWhiteSpace(txtFName.Text) && !string.IsNullOrWhiteSpace(txtLName.Text))
                {
                    //Get the primary key of the selected row
                    int selectedID = Convert.ToInt32(dbgCustomerInfo.SelectedRows[0].Cells["CustomerID"].Value);

                    string fName = txtFName.Text, lName = txtLName.Text, cellNo = txtCellNo.Text;

                    if (DateTime.TryParse(txtDate.Text, out DateTime parsedDate))
                    {
                        Customer customer = new Customer(selectedID, lName, fName, cellNo, parsedDate);

                        UpdateCustomerInDatabase(customer);

                        Load_Customer_Info();

                        MessageBox.Show("Customer Updated successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure all info is entered and correct.");
                }
            }
        }
    }
}
