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
        private Default defaultFrm = new Default();

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(defaultFrm.connString))          
            {
                try
                {
                    conn.Open();
                    string query = " ";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED" + ex.Message);
                }
            }

            //Make changing ID and Date Joined impossible for user
            txtCustID.ReadOnly = true;
            txtDate.ReadOnly = true;

            //Max length for any cellphone number
            txtCellNo.MaxLength = 10;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string fName = txtFName.Text, lName = txtLName.Text, cellNo = txtCellNo.Text;
            bool isLoylMem = cbxLoyaltyMem.Checked;
            DateTime dateJoined = new DateTime();

            dateJoined = DateTime.Today;

            if (cellNo.Length == 10 && !string.IsNullOrWhiteSpace(txtFName.Text) && !string.IsNullOrWhiteSpace(txtLName.Text))
            {
                //Customer addNew = new Customer(1, lName, fName, cellNo, isLoylMem, dateJoined);
                MessageBox.Show(lName + " " + fName + " " + cellNo +" " + isLoylMem.ToString() + " "+ dateJoined.ToString());
            }
            else
            {
                MessageBox.Show("Please make sure all info is entered and correct.");
            }
        }
    }
}
