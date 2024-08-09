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
        private List<MenuItem> menuItemList = new List<MenuItem>();
        private Default defaultFrm = new Default();

        public ItemPage()
        {
            InitializeComponent();
        }

        private void LoadMenuItems()
        {
            int itemID;
            string descr;
            decimal price;

            using (MySqlConnection conn = new MySqlConnection(defaultFrm.connString))          
            {
                try 
                {
                    conn.Open();
                    string query = "SELECT ItemID, Descr, Price FROM Item";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dbgMenuItems.DataSource = dataTable;

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
    }
}
