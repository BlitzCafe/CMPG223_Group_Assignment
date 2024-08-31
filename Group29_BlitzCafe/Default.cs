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
using Group29_BlitzCafe;

namespace Group29_BlitzCafe
{
    public partial class Default : Form
    {
        
        private ItemPage itemPageFrm = new ItemPage();
        private CustomerPage customerPageFrm = new CustomerPage();
        private OrderPage orderPageFrm = new OrderPage();

        public List<Customer> customerList = new List<Customer>();
        public List<MenuItem> menuItemList = new List<MenuItem>();
        public List<Order> orderList = new List<Order>();

        public string connString = "Data Source=blitzcafedatabase.c9uaw2k2s8lc.us-east-1.rds.amazonaws.com;Initial Catalog=BlitzDatabase;Persist Security Info=True;User ID=admin;Password=12345678";

        public Default()
        {
            InitializeComponent();
            orderPageFrm.loadOrderHistory();
            customerPageFrm.load_Customer_Info();
            itemPageFrm.loadMenuItems();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPage f1 = new CustomerPage();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);
            f1.BringToFront();
            f1.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderPage f1 = new OrderPage();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);
            f1.BringToFront();
            f1.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemPage f1 = new ItemPage();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);
            f1.BringToFront();
            f1.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports f1 = new Reports();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);
            f1.BringToFront();
            f1.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help f1 = new Help();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(f1);
            f1.BringToFront();
            f1.Show();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
