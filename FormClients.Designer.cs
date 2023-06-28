namespace Essai_Grand_Ordi_1
{
    partial class FormClients
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
            System.Windows.Forms.Label pHONE_NUMBERLabel;
            System.Windows.Forms.Label fIRST_NAMELabel;
            System.Windows.Forms.Label lAST_NAMELabel;
            System.Windows.Forms.Label sTREETLabel;
            System.Windows.Forms.Label aPARTMENT_NUMBERLabel;
            System.Windows.Forms.Label fLOORLabel;
            System.Windows.Forms.Label hOME_NUMBERLabel;
            System.Windows.Forms.Label cITYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.bAKERYDataSet = new Essai_Grand_Ordi_1.BAKERYDataSet();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTSTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.CLIENTSTableAdapter();
            this.tableAdapterManager = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager();
            this.cLIENTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pHONE_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.fIRST_NAMETextBox = new System.Windows.Forms.TextBox();
            this.lAST_NAMETextBox = new System.Windows.Forms.TextBox();
            this.sTREETTextBox = new System.Windows.Forms.TextBox();
            this.aPARTMENT_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.fLOORTextBox = new System.Windows.Forms.TextBox();
            this.hOME_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHomeClients = new System.Windows.Forms.Button();
            this.cITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cITYTableAdapter = new Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.CITYTableAdapter();
            this.cITYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pHONE_NUMBERLabel = new System.Windows.Forms.Label();
            fIRST_NAMELabel = new System.Windows.Forms.Label();
            lAST_NAMELabel = new System.Windows.Forms.Label();
            sTREETLabel = new System.Windows.Forms.Label();
            aPARTMENT_NUMBERLabel = new System.Windows.Forms.Label();
            fLOORLabel = new System.Windows.Forms.Label();
            hOME_NUMBERLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pHONE_NUMBERLabel
            // 
            pHONE_NUMBERLabel.AutoSize = true;
            pHONE_NUMBERLabel.BackColor = System.Drawing.Color.Transparent;
            pHONE_NUMBERLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            pHONE_NUMBERLabel.Location = new System.Drawing.Point(34, 108);
            pHONE_NUMBERLabel.Name = "pHONE_NUMBERLabel";
            pHONE_NUMBERLabel.Size = new System.Drawing.Size(101, 15);
            pHONE_NUMBERLabel.TabIndex = 0;
            pHONE_NUMBERLabel.Text = "PHONE NUMBER:";
            // 
            // fIRST_NAMELabel
            // 
            fIRST_NAMELabel.AutoSize = true;
            fIRST_NAMELabel.BackColor = System.Drawing.Color.Transparent;
            fIRST_NAMELabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            fIRST_NAMELabel.Location = new System.Drawing.Point(34, 134);
            fIRST_NAMELabel.Name = "fIRST_NAMELabel";
            fIRST_NAMELabel.Size = new System.Drawing.Size(78, 15);
            fIRST_NAMELabel.TabIndex = 2;
            fIRST_NAMELabel.Text = "FIRST NAME:";
            // 
            // lAST_NAMELabel
            // 
            lAST_NAMELabel.AutoSize = true;
            lAST_NAMELabel.BackColor = System.Drawing.Color.Transparent;
            lAST_NAMELabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lAST_NAMELabel.Location = new System.Drawing.Point(34, 160);
            lAST_NAMELabel.Name = "lAST_NAMELabel";
            lAST_NAMELabel.Size = new System.Drawing.Size(75, 15);
            lAST_NAMELabel.TabIndex = 4;
            lAST_NAMELabel.Text = "LAST NAME:";
            // 
            // sTREETLabel
            // 
            sTREETLabel.AutoSize = true;
            sTREETLabel.BackColor = System.Drawing.Color.Transparent;
            sTREETLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            sTREETLabel.Location = new System.Drawing.Point(34, 186);
            sTREETLabel.Name = "sTREETLabel";
            sTREETLabel.Size = new System.Drawing.Size(50, 15);
            sTREETLabel.TabIndex = 6;
            sTREETLabel.Text = "STREET:";
            // 
            // aPARTMENT_NUMBERLabel
            // 
            aPARTMENT_NUMBERLabel.AutoSize = true;
            aPARTMENT_NUMBERLabel.BackColor = System.Drawing.Color.Transparent;
            aPARTMENT_NUMBERLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            aPARTMENT_NUMBERLabel.Location = new System.Drawing.Point(34, 212);
            aPARTMENT_NUMBERLabel.Name = "aPARTMENT_NUMBERLabel";
            aPARTMENT_NUMBERLabel.Size = new System.Drawing.Size(130, 15);
            aPARTMENT_NUMBERLabel.TabIndex = 8;
            aPARTMENT_NUMBERLabel.Text = "APARTMENT NUMBER:";
            // 
            // fLOORLabel
            // 
            fLOORLabel.AutoSize = true;
            fLOORLabel.BackColor = System.Drawing.Color.Transparent;
            fLOORLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            fLOORLabel.Location = new System.Drawing.Point(34, 238);
            fLOORLabel.Name = "fLOORLabel";
            fLOORLabel.Size = new System.Drawing.Size(47, 15);
            fLOORLabel.TabIndex = 10;
            fLOORLabel.Text = "FLOOR:";
            // 
            // hOME_NUMBERLabel
            // 
            hOME_NUMBERLabel.AutoSize = true;
            hOME_NUMBERLabel.BackColor = System.Drawing.Color.Transparent;
            hOME_NUMBERLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            hOME_NUMBERLabel.Location = new System.Drawing.Point(34, 264);
            hOME_NUMBERLabel.Name = "hOME_NUMBERLabel";
            hOME_NUMBERLabel.Size = new System.Drawing.Size(96, 15);
            hOME_NUMBERLabel.TabIndex = 12;
            hOME_NUMBERLabel.Text = "HOME NUMBER:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.BackColor = System.Drawing.Color.Transparent;
            cITYLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            cITYLabel.Location = new System.Drawing.Point(34, 290);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(35, 15);
            cITYLabel.TabIndex = 14;
            cITYLabel.Text = "CITY:";
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
            this.tableAdapterManager.CITYTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = this.cLIENTSTableAdapter;
            this.tableAdapterManager.MENUTableAdapter = null;
            this.tableAdapterManager.ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.ORDER_METHODSTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.PAYMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Essai_Grand_Ordi_1.BAKERYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cLIENTSBindingSource1
            // 
            this.cLIENTSBindingSource1.DataMember = "CLIENTS";
            this.cLIENTSBindingSource1.DataSource = this.bAKERYDataSet;
            // 
            // pHONE_NUMBERTextBox
            // 
            this.pHONE_NUMBERTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pHONE_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "PHONE_NUMBER", true));
            this.pHONE_NUMBERTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pHONE_NUMBERTextBox.Location = new System.Drawing.Point(167, 105);
            this.pHONE_NUMBERTextBox.Name = "pHONE_NUMBERTextBox";
            this.pHONE_NUMBERTextBox.Size = new System.Drawing.Size(100, 16);
            this.pHONE_NUMBERTextBox.TabIndex = 1;
            // 
            // fIRST_NAMETextBox
            // 
            this.fIRST_NAMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fIRST_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "FIRST_NAME", true));
            this.fIRST_NAMETextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fIRST_NAMETextBox.Location = new System.Drawing.Point(167, 131);
            this.fIRST_NAMETextBox.Name = "fIRST_NAMETextBox";
            this.fIRST_NAMETextBox.Size = new System.Drawing.Size(100, 16);
            this.fIRST_NAMETextBox.TabIndex = 3;
            // 
            // lAST_NAMETextBox
            // 
            this.lAST_NAMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lAST_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "LAST_NAME", true));
            this.lAST_NAMETextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lAST_NAMETextBox.Location = new System.Drawing.Point(167, 157);
            this.lAST_NAMETextBox.Name = "lAST_NAMETextBox";
            this.lAST_NAMETextBox.Size = new System.Drawing.Size(100, 16);
            this.lAST_NAMETextBox.TabIndex = 5;
            // 
            // sTREETTextBox
            // 
            this.sTREETTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sTREETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "STREET", true));
            this.sTREETTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sTREETTextBox.Location = new System.Drawing.Point(167, 183);
            this.sTREETTextBox.Name = "sTREETTextBox";
            this.sTREETTextBox.Size = new System.Drawing.Size(100, 16);
            this.sTREETTextBox.TabIndex = 7;
            // 
            // aPARTMENT_NUMBERTextBox
            // 
            this.aPARTMENT_NUMBERTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aPARTMENT_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "APARTMENT_NUMBER", true));
            this.aPARTMENT_NUMBERTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aPARTMENT_NUMBERTextBox.Location = new System.Drawing.Point(167, 209);
            this.aPARTMENT_NUMBERTextBox.Name = "aPARTMENT_NUMBERTextBox";
            this.aPARTMENT_NUMBERTextBox.Size = new System.Drawing.Size(100, 16);
            this.aPARTMENT_NUMBERTextBox.TabIndex = 9;
            // 
            // fLOORTextBox
            // 
            this.fLOORTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fLOORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "FLOOR", true));
            this.fLOORTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fLOORTextBox.Location = new System.Drawing.Point(167, 235);
            this.fLOORTextBox.Name = "fLOORTextBox";
            this.fLOORTextBox.Size = new System.Drawing.Size(100, 16);
            this.fLOORTextBox.TabIndex = 11;
            // 
            // hOME_NUMBERTextBox
            // 
            this.hOME_NUMBERTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hOME_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "HOME_NUMBER", true));
            this.hOME_NUMBERTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hOME_NUMBERTextBox.Location = new System.Drawing.Point(167, 261);
            this.hOME_NUMBERTextBox.Name = "hOME_NUMBERTextBox";
            this.hOME_NUMBERTextBox.Size = new System.Drawing.Size(100, 16);
            this.hOME_NUMBERTextBox.TabIndex = 13;
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "CITY", true));
            this.cITYTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cITYTextBox.Location = new System.Drawing.Point(167, 287);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(100, 16);
            this.cITYTextBox.TabIndex = 15;
            // 
            // cLIENTSDataGridView
            // 
            this.cLIENTSDataGridView.AutoGenerateColumns = false;
            this.cLIENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cLIENTSDataGridView.DataSource = this.cLIENTSBindingSource;
            this.cLIENTSDataGridView.Location = new System.Drawing.Point(282, 105);
            this.cLIENTSDataGridView.Name = "cLIENTSDataGridView";
            this.cLIENTSDataGridView.Size = new System.Drawing.Size(842, 218);
            this.cLIENTSDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PHONE_NUMBER";
            this.dataGridViewTextBoxColumn1.HeaderText = "PHONE_NUMBER";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIRST_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "FIRST_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LAST_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "LAST_NAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "STREET";
            this.dataGridViewTextBoxColumn4.HeaderText = "STREET";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "APARTMENT_NUMBER";
            this.dataGridViewTextBoxColumn5.HeaderText = "APARTMENT_NUMBER";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FLOOR";
            this.dataGridViewTextBoxColumn6.HeaderText = "FLOOR";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HOME_NUMBER";
            this.dataGridViewTextBoxColumn7.HeaderText = "HOME_NUMBER";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CITY";
            this.dataGridViewTextBoxColumn8.HeaderText = "CITY";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnHomeClients
            // 
            this.btnHomeClients.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomeClients.Image = global::Essai_Grand_Ordi_1.Properties.Resources.icons8_home_32;
            this.btnHomeClients.Location = new System.Drawing.Point(1136, 23);
            this.btnHomeClients.Name = "btnHomeClients";
            this.btnHomeClients.Size = new System.Drawing.Size(36, 38);
            this.btnHomeClients.TabIndex = 17;
            this.btnHomeClients.UseVisualStyleBackColor = false;
            this.btnHomeClients.Click += new System.EventHandler(this.btnHomeClients_Click);
            // 
            // cITYBindingSource
            // 
            this.cITYBindingSource.DataMember = "CITY";
            this.cITYBindingSource.DataSource = this.bAKERYDataSet;
            // 
            // cITYTableAdapter
            // 
            this.cITYTableAdapter.ClearBeforeFill = true;
            // 
            // cITYDataGridView
            // 
            this.cITYDataGridView.AutoGenerateColumns = false;
            this.cITYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cITYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.cITYDataGridView.DataSource = this.cITYBindingSource;
            this.cITYDataGridView.Location = new System.Drawing.Point(583, 361);
            this.cITYDataGridView.Name = "cITYDataGridView";
            this.cITYDataGridView.Size = new System.Drawing.Size(242, 161);
            this.cITYDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CODE_CITY";
            this.dataGridViewTextBoxColumn9.HeaderText = "CODE_CITY";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NAME_CITY";
            this.dataGridViewTextBoxColumn10.HeaderText = "NAME_CITY";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Essai_Grand_Ordi_1.Properties.Resources.istockphoto_488010990_612x6123;
            this.ClientSize = new System.Drawing.Size(1209, 641);
            this.Controls.Add(this.cITYDataGridView);
            this.Controls.Add(this.btnHomeClients);
            this.Controls.Add(this.cLIENTSDataGridView);
            this.Controls.Add(pHONE_NUMBERLabel);
            this.Controls.Add(this.pHONE_NUMBERTextBox);
            this.Controls.Add(fIRST_NAMELabel);
            this.Controls.Add(this.fIRST_NAMETextBox);
            this.Controls.Add(lAST_NAMELabel);
            this.Controls.Add(this.lAST_NAMETextBox);
            this.Controls.Add(sTREETLabel);
            this.Controls.Add(this.sTREETTextBox);
            this.Controls.Add(aPARTMENT_NUMBERLabel);
            this.Controls.Add(this.aPARTMENT_NUMBERTextBox);
            this.Controls.Add(fLOORLabel);
            this.Controls.Add(this.fLOORTextBox);
            this.Controls.Add(hOME_NUMBERLabel);
            this.Controls.Add(this.hOME_NUMBERTextBox);
            this.Controls.Add(cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAKERYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BAKERYDataSet bAKERYDataSet;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private BAKERYDataSetTableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private BAKERYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource1;
        private System.Windows.Forms.TextBox pHONE_NUMBERTextBox;
        private System.Windows.Forms.TextBox fIRST_NAMETextBox;
        private System.Windows.Forms.TextBox lAST_NAMETextBox;
        private System.Windows.Forms.TextBox sTREETTextBox;
        private System.Windows.Forms.TextBox aPARTMENT_NUMBERTextBox;
        private System.Windows.Forms.TextBox fLOORTextBox;
        private System.Windows.Forms.TextBox hOME_NUMBERTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
        private System.Windows.Forms.DataGridView cLIENTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnHomeClients;
        private System.Windows.Forms.BindingSource cITYBindingSource;
        private BAKERYDataSetTableAdapters.CITYTableAdapter cITYTableAdapter;
        private System.Windows.Forms.DataGridView cITYDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}