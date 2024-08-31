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
        private String connString = "Data Source=blitzcafedatabase.c9uaw2k2s8lc.us-east-1.rds.amazonaws.com;Initial Catalog=BlitzDatabase;Persist Security Info=True;User ID=admin;Password=12345678";


        private List<Customer> customerList = new List<Customer>();

        private int choice = 0;

        private int customerID;
        private string fName, lName, cellNo, sqlQuery;
        private DateTime dateJoined = new DateTime();

        //Load from info from database
        public void load_Customer_Info()
        {
            using (conn)
            {
                try
                {
                    conn.Open();

                    sqlQuery = "SELECT * FROM Customer";//SQL Goes here
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

        private void confirm_Add()
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
                load_Customer_Info();
            }
            else
            {
                MessageBox.Show("Please make sure all info is entered and correct.");
            }
        }

        private void confirm_Delete()
        {

        }


        private void confirm_Update()
        {
            if (dbgCustomerInfo.SelectedRows.Count > 0)
            {
                if (cellNo.Length == 10 && !string.IsNullOrWhiteSpace(txtFName.Text) && !string.IsNullOrWhiteSpace(txtLName.Text))

                {

                }
                else
                {
                    MessageBox.Show("Please make sure all info is entered and correct.");
                }
            }
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(defaultFrm.connString);


            load_Customer_Info();

            //Make changing ID and Date Joined impossible for user
            txtCustID.ReadOnly = true;
            txtDate.ReadOnly = true;

            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            //Max length for any cellphone number
            txtCellNo.MaxLength = 10;
        }

        private void dbgCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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


                        choice = 0;


                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;
                        btnAddNew.Visible = true;
                        break;
                    }
                case 2:
                    {
                        //confirm_Delete();
                        btnConfirm.Visible = false;
                        btnCancel.Visible = false;

                        choice = 0;

                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;
                        btnAddNew.Visible = true;

                        txtFName.ReadOnly = false;
                        txtLName.ReadOnly = false;
                        txtCellNo.ReadOnly = false;

                        break;
                        
                    }
                case 3:
                    {
                        //confirm_Update();
                        btnConfirm.Visible = false;
                        btnCancel.Visible = false;

                        choice = 0;

                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;
                        btnAddNew.Visible = true;
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

            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAddNew.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
            btnCancel.Visible = true;

            choice = 3;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAddNew.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
            btnCancel.Visible = true;

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

            choice = 1;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAddNew.Visible = false;
        }
    }
}
