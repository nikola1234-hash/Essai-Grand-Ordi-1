namespace Essai_Grand_Ordi_1
{
    partial class FormProducts
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
            System.Windows.Forms.Label dISH_CODELabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label dish_priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.bAKERYDataSet = new Essai_Grand_Ordi_1.BAKERYDataSet();
            this.mENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mENUTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.MENUTableAdapter();
            this.tableAdapterManager = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager();
            this.mENUBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mENUBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mENUDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISH_CODETextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.dish_priceTextBox = new System.Windows.Forms.TextBox();
            this.btnHomeProducts = new System.Windows.Forms.Button();
            dISH_CODELabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            dish_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingNavigator)).BeginInit();
            this.mENUBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mENUDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dISH_CODELabel
            // 
            dISH_CODELabel.AutoSize = true;
            dISH_CODELabel.BackColor = System.Drawing.Color.Transparent;
            dISH_CODELabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dISH_CODELabel.ForeColor = System.Drawing.Color.SteelBlue;
            dISH_CODELabel.Location = new System.Drawing.Point(71, 92);
            dISH_CODELabel.Name = "dISH_CODELabel";
            dISH_CODELabel.Size = new System.Drawing.Size(91, 20);
            dISH_CODELabel.TabIndex = 2;
            dISH_CODELabel.Text = "DISH CODE:";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.BackColor = System.Drawing.Color.Transparent;
            dESCRIPTIONLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dESCRIPTIONLabel.ForeColor = System.Drawing.Color.SteelBlue;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(71, 125);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(110, 20);
            dESCRIPTIONLabel.TabIndex = 4;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // dish_priceLabel
            // 
            dish_priceLabel.AutoSize = true;
            dish_priceLabel.BackColor = System.Drawing.Color.Transparent;
            dish_priceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dish_priceLabel.ForeColor = System.Drawing.Color.SteelBlue;
            dish_priceLabel.Location = new System.Drawing.Point(71, 158);
            dish_priceLabel.Name = "dish_priceLabel";
            dish_priceLabel.Size = new System.Drawing.Size(80, 20);
            dish_priceLabel.TabIndex = 6;
            dish_priceLabel.Text = "dish price:";
            // 
            // bAKERYDataSet
            // 
            this.bAKERYDataSet.DataSetName = "BAKERYDataSet";
            this.bAKERYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mENUBindingSource
            // 
            this.mENUBindingSource.DataMember = "MENU";
            this.mENUBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // mENUTableAdapter
            // 
            this.mENUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CITYTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = null;
            this.tableAdapterManager.MENUTableAdapter = this.mENUTableAdapter;
            this.tableAdapterManager.ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.ORDER_METHODSTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.PAYMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mENUBindingNavigator
            // 
            this.mENUBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mENUBindingNavigator.BindingSource = this.mENUBindingSource;
            this.mENUBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mENUBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mENUBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mENUBindingNavigatorSaveItem});
            this.mENUBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mENUBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mENUBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mENUBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mENUBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mENUBindingNavigator.Name = "mENUBindingNavigator";
            this.mENUBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mENUBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.mENUBindingNavigator.TabIndex = 0;
            this.mENUBindingNavigator.Text = "bindingNavigator1";
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
            // mENUBindingNavigatorSaveItem
            // 
            this.mENUBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mENUBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mENUBindingNavigatorSaveItem.Image")));
            this.mENUBindingNavigatorSaveItem.Name = "mENUBindingNavigatorSaveItem";
            this.mENUBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mENUBindingNavigatorSaveItem.Text = "Save Data";
            this.mENUBindingNavigatorSaveItem.Click += new System.EventHandler(this.mENUBindingNavigatorSaveItem_Click);
            // 
            // mENUDataGridView
            // 
            this.mENUDataGridView.AutoGenerateColumns = false;
            this.mENUDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mENUDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mENUDataGridView.DataSource = this.mENUBindingSource;
            this.mENUDataGridView.Location = new System.Drawing.Point(371, 76);
            this.mENUDataGridView.Name = "mENUDataGridView";
            this.mENUDataGridView.Size = new System.Drawing.Size(339, 307);
            this.mENUDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DISH_CODE";
            this.dataGridViewTextBoxColumn1.HeaderText = "DISH_CODE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPTION";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dish_price";
            this.dataGridViewTextBoxColumn3.HeaderText = "dish_price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dISH_CODETextBox
            // 
            this.dISH_CODETextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dISH_CODETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dISH_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mENUBindingSource, "DISH_CODE", true));
            this.dISH_CODETextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dISH_CODETextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.dISH_CODETextBox.Location = new System.Drawing.Point(197, 89);
            this.dISH_CODETextBox.Name = "dISH_CODETextBox";
            this.dISH_CODETextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dISH_CODETextBox.Size = new System.Drawing.Size(135, 20);
            this.dISH_CODETextBox.TabIndex = 3;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dESCRIPTIONTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mENUBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dESCRIPTIONTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(197, 122);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(135, 20);
            this.dESCRIPTIONTextBox.TabIndex = 5;
            // 
            // dish_priceTextBox
            // 
            this.dish_priceTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dish_priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dish_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mENUBindingSource, "dish_price", true));
            this.dish_priceTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dish_priceTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.dish_priceTextBox.Location = new System.Drawing.Point(197, 155);
            this.dish_priceTextBox.Name = "dish_priceTextBox";
            this.dish_priceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dish_priceTextBox.Size = new System.Drawing.Size(135, 20);
            this.dish_priceTextBox.TabIndex = 7;
            // 
            // btnHomeProducts
            // 
            this.btnHomeProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomeProducts.Image = global::Essai_Grand_Ordi_1.Properties.Resources.icons8_home_32;
            this.btnHomeProducts.Location = new System.Drawing.Point(749, 28);
            this.btnHomeProducts.Name = "btnHomeProducts";
            this.btnHomeProducts.Size = new System.Drawing.Size(39, 38);
            this.btnHomeProducts.TabIndex = 8;
            this.btnHomeProducts.UseVisualStyleBackColor = false;
            this.btnHomeProducts.Click += new System.EventHandler(this.btnHomeProducts_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::Essai_Grand_Ordi_1.Properties.Resources.istockphoto_488010990_612x6123;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHomeProducts);
            this.Controls.Add(dISH_CODELabel);
            this.Controls.Add(this.dISH_CODETextBox);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(dish_priceLabel);
            this.Controls.Add(this.dish_priceTextBox);
            this.Controls.Add(this.mENUDataGridView);
            this.Controls.Add(this.mENUBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingNavigator)).EndInit();
            this.mENUBindingNavigator.ResumeLayout(false);
            this.mENUBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mENUDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BAKERYDataSet bAKERYDataSet;
        private System.Windows.Forms.BindingSource mENUBindingSource;
        private BAKERYDataSetTableAdapters.MENUTableAdapter mENUTableAdapter;
        private BAKERYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mENUBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mENUBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mENUDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox dISH_CODETextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox dish_priceTextBox;
        private System.Windows.Forms.Button btnHomeProducts;
    }
}