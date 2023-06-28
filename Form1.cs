using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai_Grand_Ordi_1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.ShowDialog();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients();
            formClients.ShowDialog();
       

       
           


              
                
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContact formContact = new FormContact();
            formContact.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure to want to exit?", "Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)

            {
                Close();

            }
        }

        private void ordersDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormOrdersDetails formOrdersDetails = new FormOrdersDetails();
            formOrdersDetails.ShowDialog();

        }

        private void ordersToValidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}