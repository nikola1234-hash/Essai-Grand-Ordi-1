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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }

        private void cLIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bAKERYDataSet);

        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAKERYDataSet.CITY' table. You can move, or remove it, as needed.
            this.cITYTableAdapter.Fill(this.bAKERYDataSet.CITY);
            // TODO: This line of code loads data into the 'bAKERYDataSet.CLIENTS' table. You can move, or remove it, as needed.
            this.cLIENTSTableAdapter.Fill(this.bAKERYDataSet.CLIENTS);

        }

       



private void btnHomeClients_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Hide();
           
   
        }
    }
}
