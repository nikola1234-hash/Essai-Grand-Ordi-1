namespace Essai_Grand_Ordi_1
{
    partial class FormContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContact));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.bAKERYDataSet = new Essai_Grand_Ordi_1.BAKERYDataSet();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTSTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.CLIENTSTableAdapter();
            this.tableAdapterManager = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager();
            this.cITYTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.CITYTableAdapter();
            this.cLIENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cLIENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingNavigator)).BeginInit();
            this.cLIENTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Essai_Grand_Ordi_1.Properties.Resources.istockphoto_530583274_612x612;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblName2);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.lblName1);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.lblAdress);
            this.panel1.Controls.Add(this.btnHome1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 665);
            this.panel1.TabIndex = 0;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMail.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMail.Location = new System.Drawing.Point(25, 525);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(273, 21);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail : Contact@cohensbakery.com";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTel.Location = new System.Drawing.Point(25, 490);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(161, 21);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "Phone : 0549915456";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAdress.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAdress.Location = new System.Drawing.Point(25, 457);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(224, 20);
            this.lblAdress.TabIndex = 8;
            this.lblAdress.Text = "Adress : IbnGvirol 125 Tel Aviv";
            // 
            // btnHome1
            // 
            this.btnHome1.BackColor = System.Drawing.Color.Transparent;
            this.btnHome1.BackgroundImage = global::Essai_Grand_Ordi_1.Properties.Resources.icons8_home_32;
            this.btnHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome1.Location = new System.Drawing.Point(962, 38);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(44, 41);
            this.btnHome1.TabIndex = 5;
            this.btnHome1.UseVisualStyleBackColor = false;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // bAKERYDataSet
            // 
            this.bAKERYDataSet.DataSetName = "BAKERYDataSet";
            this.bAKERYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTSBindingSource
            // 
            this.cLIENTSBindingSource.DataMember = "CLIENTS";
            this.cLIENTSBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // cLIENTSTableAdapter
            // 
            this.cLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CITYTableAdapter = this.cITYTableAdapter;
            this.tableAdapterManager.CLIENTSTableAdapter = this.cLIENTSTableAdapter;
            this.tableAdapterManager.MENUTableAdapter = null;
            this.tableAdapterManager.ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.ORDER_METHODSTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.PAYMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cITYTableAdapter
            // 
            this.cITYTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTSBindingNavigator
            // 
            this.cLIENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLIENTSBindingNavigator.BindingSource = this.cLIENTSBindingSource;
            this.cLIENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLIENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLIENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cLIENTSBindingNavigatorSaveItem});
            this.cLIENTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cLIENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLIENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLIENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLIENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLIENTSBindingNavigator.Name = "cLIENTSBindingNavigator";
            this.cLIENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLIENTSBindingNavigator.Size = new System.Drawing.Size(1026, 25);
            this.cLIENTSBindingNavigator.TabIndex = 1;
            this.cLIENTSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cLIENTSBindingNavigatorSaveItem
            // 
            this.cLIENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLIENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLIENTSBindingNavigatorSaveItem.Image")));
            this.cLIENTSBindingNavigatorSaveItem.Name = "cLIENTSBindingNavigatorSaveItem";
            this.cLIENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cLIENTSBindingNavigatorSaveItem.Text = "Save Data";
            this.cLIENTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLIENTSBindingNavigatorSaveItem_Click);
            // 
            // cITYBindingSource
            // 
            this.cITYBindingSource.DataMember = "CITY";
            this.cITYBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.BackColor = System.Drawing.Color.Transparent;
            this.lblName2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblName2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblName2.Location = new System.Drawing.Point(181, 154);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(368, 128);
            this.lblName2.TabIndex = 5;
            this.lblName2.Text = "Bakery";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.BackColor = System.Drawing.Color.Transparent;
            this.lblName1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblName1.Location = new System.Drawing.Point(82, 86);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(269, 86);
            this.lblName1.TabIndex = 4;
            this.lblName1.Text = "Cohen\'s";
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1026, 665);
            this.Controls.Add(this.cLIENTSBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContact";
            this.Load += new System.EventHandler(this.FormContact_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingNavigator)).EndInit();
            this.cLIENTSBindingNavigator.ResumeLayout(false);
            this.cLIENTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome1;
        private BAKERYDataSet bAKERYDataSet;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private BAKERYDataSetTableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private BAKERYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLIENTSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cLIENTSBindingNavigatorSaveItem;
        private BAKERYDataSetTableAdapters.CITYTableAdapter cITYTableAdapter;
        private System.Windows.Forms.BindingSource cITYBindingSource;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName1;
    }
}