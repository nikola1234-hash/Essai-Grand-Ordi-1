namespace Essai_Grand_Ordi_1
{
    partial class FormOrders
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
            System.Windows.Forms.Label oRDER_NUMBERLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.bAKERYDataSet = new Essai_Grand_Ordi_1.BAKERYDataSet();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERSTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.ORDERSTableAdapter();
            this.tableAdapterManager = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager();
            this.oRDERSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.oRDERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDER_NUMBERComboBox = new System.Windows.Forms.ComboBox();
            oRDER_NUMBERLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bAKERYDataSet
            // 
            this.bAKERYDataSet.DataSetName = "BAKERYDataSet";
            this.bAKERYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CITYTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = null;
            this.tableAdapterManager.MENUTableAdapter = null;
            this.tableAdapterManager.ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.ORDER_METHODSTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = this.oRDERSTableAdapter;
            this.tableAdapterManager.PAYMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oRDERSBindingSource1
            // 
            this.oRDERSBindingSource1.DataMember = "ORDERS";
            this.oRDERSBindingSource1.DataSource = this.bAKERYDataSet;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(50, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 336);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.oRDERSDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(oRDER_NUMBERLabel);
            this.tabPage2.Controls.Add(this.oRDER_NUMBERComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search By Phone";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(665, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search by Name";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // oRDERSDataGridView
            // 
            this.oRDERSDataGridView.AutoGenerateColumns = false;
            this.oRDERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oRDERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.oRDERSDataGridView.DataSource = this.oRDERSBindingSource;
            this.oRDERSDataGridView.Location = new System.Drawing.Point(60, 57);
            this.oRDERSDataGridView.Name = "oRDERSDataGridView";
            this.oRDERSDataGridView.Size = new System.Drawing.Size(539, 191);
            this.oRDERSDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ORDER_NUMBER";
            this.dataGridViewTextBoxColumn1.HeaderText = "ORDER_NUMBER";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLIENT_CODE";
            this.dataGridViewTextBoxColumn2.HeaderText = "CLIENT_CODE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATE_ORDER";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATE_ORDER";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RECIVE_ORDER_DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "RECIVE_ORDER_DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TYPE_ORDER";
            this.dataGridViewTextBoxColumn5.HeaderText = "TYPE_ORDER";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // oRDER_NUMBERLabel
            // 
            oRDER_NUMBERLabel.AutoSize = true;
            oRDER_NUMBERLabel.Location = new System.Drawing.Point(229, 102);
            oRDER_NUMBERLabel.Name = "oRDER_NUMBERLabel";
            oRDER_NUMBERLabel.Size = new System.Drawing.Size(99, 13);
            oRDER_NUMBERLabel.TabIndex = 0;
            oRDER_NUMBERLabel.Text = "ORDER NUMBER:";
            // 
            // oRDER_NUMBERComboBox
            // 
            this.oRDER_NUMBERComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERSBindingSource, "ORDER_NUMBER", true));
            this.oRDER_NUMBERComboBox.FormattingEnabled = true;
            this.oRDER_NUMBERComboBox.Location = new System.Drawing.Point(334, 99);
            this.oRDER_NUMBERComboBox.Name = "oRDER_NUMBERComboBox";
            this.oRDER_NUMBERComboBox.Size = new System.Drawing.Size(121, 21);
            this.oRDER_NUMBERComboBox.TabIndex = 1;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BAKERYDataSet bAKERYDataSet;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private BAKERYDataSetTableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private BAKERYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource oRDERSBindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView oRDERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox oRDER_NUMBERComboBox;
        private System.Windows.Forms.TabPage tabPage3;
    }
}