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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void oRDERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bAKERYDataSet);

        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAKERYDataSet.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.bAKERYDataSet.ORDERS);

        }
    }
}
