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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void mENUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mENUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bAKERYDataSet);

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAKERYDataSet.MENU' table. You can move, or remove it, as needed.
            this.mENUTableAdapter.Fill(this.bAKERYDataSet.MENU);

        }

        private void btnHomeProducts_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Hide();
        }
    }
}
