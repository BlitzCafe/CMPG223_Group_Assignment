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
    public partial class OrderPage : Form
    {
        private Default defaultFrm = new Default();


        private List<Order> orderList = new List<Order>();

        public OrderPage()
        {
            InitializeComponent();
            loadOrderHistory();
        }

        private void loadOrderHistory()
        {

            int orderId;
            DateTime orderDate;
            bool loyaltyPointsUsed, isPayed;

           using (SqlConnection conn = new SqlConnection(defaultFrm.connString))          
            {
                try 
                {
                    conn.Open();
                    string query = "SELECT OrderId, OrderDate, Is_Paid, loyaltyPoints_Used FROM tblOrder";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataGridView to the DataTable
                    dbgOrderHistory.DataSource = dataTable;


                    foreach (DataRow row in dataTable.Rows)
                    {
                        orderId = Convert.ToInt32(row["OrderId"]);
                        orderDate = Convert.ToDateTime(row["OrderDate"]);
                        isPayed = Convert.ToBoolean(row["IsPayed"]);
                        loyaltyPointsUsed = Convert.ToBoolean(row["loyaltypointsused"]);

                        // Create a new Order object using the data
                        Order order = new Order(orderId, orderDate, isPayed, loyaltyPointsUsed);

                        // Add the Order object to the list
                        orderList.Add(order);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: DATABASE COULD NOT BE RETRIEVED" + ex.Message);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            
        }

        private void dbgOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchItemID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
