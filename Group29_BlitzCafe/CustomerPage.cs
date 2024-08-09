using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group29_BlitzCafe
{
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            txtCustID.ReadOnly = true;
            txtDate.ReadOnly = true;
            txtCellNo.MaxLength = 10;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            fName = txtFName.Text;
            lName = txtLName.Text;
            cellNo = txtCellNo.Text;
            dateJoined = DateTime.Today;

            if (cellNo.Length == 10 && !string.IsNullOrWhiteSpace(txtFName.Text) && !string.IsNullOrWhiteSpace(txtLName.Text))
            {
                //Customer addNew = new Customer(1, lName, fName, cellNo, dateJoined);
                MessageBox.Show(lName + " " + fName + " " + cellNo + " "+ dateJoined.ToString());
            }
            else
            {
                MessageBox.Show("Please make sure all info is entered and correct.");
            }
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            string fName = txtFName.Text, lName = txtLName.Text, cellNo = txtCellNo.Text;

            if (cellNo.Length == 10 && !string.IsNullOrWhiteSpace(txtFName.Text) && !string.IsNullOrWhiteSpace(txtLName.Text))
            {
                //Customer addNew = new Customer(1, lName, fName, cellNo, dateJoined);
                MessageBox.Show(lName + " " + fName + " " + cellNo);
            }
            else
            {
                MessageBox.Show("Please make sure all info is entered and correct.");
            }
        }
    }
}
