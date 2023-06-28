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
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName1_Click(object sender, EventArgs e)
        {

        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();


        }

        private void cLIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bAKERYDataSet);

        }

        private void FormContact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAKERYDataSet.CITY' table. You can move, or remove it, as needed.
            this.cITYTableAdapter.Fill(this.bAKERYDataSet.CITY);
            // TODO: This line of code loads data into the 'bAKERYDataSet.CLIENTS' table. You can move, or remove it, as needed.
            this.cLIENTSTableAdapter.Fill(this.bAKERYDataSet.CLIENTS);

        }
    }
}
