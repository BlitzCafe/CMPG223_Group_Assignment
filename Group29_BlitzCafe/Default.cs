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
    public partial class Default : Form
    {


        public string connString = @"Data Source=HIGHPOWER;Initial Catalog=BlitzDB;Integrated Security=True";

        public Default()
        {
            InitializeComponent();
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

    }
}
