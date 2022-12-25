namespace excel_loader_cs
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label segmentLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label discount_BandLabel;
            System.Windows.Forms.Label units_SoldLabel;
            System.Windows.Forms.Label manufacturing_PriceLabel;
            System.Windows.Forms.Label sale_PriceLabel;
            System.Windows.Forms.Label gross_SalesLabel;
            System.Windows.Forms.Label discountsLabel;
            System.Windows.Forms.Label salesLabel;
            System.Windows.Forms.Label cOGSLabel;
            System.Windows.Forms.Label profitLabel;
            System.Windows.Forms.Label dateeLabel;
            System.Windows.Forms.Label month_NumberLabel;
            System.Windows.Forms.Label month_NameLabel;
            System.Windows.Forms.Label yearrLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.excel_ds = new excel_loader_cs.dataset.excel_ds();
            this.financial_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financial_DataTableAdapter = new excel_loader_cs.dataset.excel_dsTableAdapters.Financial_DataTableAdapter();
            this.financial_DataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.financial_DataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new excel_loader_cs.dataset.excel_dsTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.segmentTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.discount_BandTextBox = new System.Windows.Forms.TextBox();
            this.units_SoldTextBox = new System.Windows.Forms.TextBox();
            this.manufacturing_PriceTextBox = new System.Windows.Forms.TextBox();
            this.sale_PriceTextBox = new System.Windows.Forms.TextBox();
            this.gross_SalesTextBox = new System.Windows.Forms.TextBox();
            this.discountsTextBox = new System.Windows.Forms.TextBox();
            this.salesTextBox = new System.Windows.Forms.TextBox();
            this.cOGSTextBox = new System.Windows.Forms.TextBox();
            this.profitTextBox = new System.Windows.Forms.TextBox();
            this.dateeTextBox = new System.Windows.Forms.TextBox();
            this.month_NumberTextBox = new System.Windows.Forms.TextBox();
            this.month_NameTextBox = new System.Windows.Forms.TextBox();
            this.yearrTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.new_recored_button3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progress_panel2 = new System.Windows.Forms.Panel();
            this.prog_label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loading_label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            idLabel = new System.Windows.Forms.Label();
            segmentLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            productLabel = new System.Windows.Forms.Label();
            discount_BandLabel = new System.Windows.Forms.Label();
            units_SoldLabel = new System.Windows.Forms.Label();
            manufacturing_PriceLabel = new System.Windows.Forms.Label();
            sale_PriceLabel = new System.Windows.Forms.Label();
            gross_SalesLabel = new System.Windows.Forms.Label();
            discountsLabel = new System.Windows.Forms.Label();
            salesLabel = new System.Windows.Forms.Label();
            cOGSLabel = new System.Windows.Forms.Label();
            profitLabel = new System.Windows.Forms.Label();
            dateeLabel = new System.Windows.Forms.Label();
            month_NumberLabel = new System.Windows.Forms.Label();
            month_NameLabel = new System.Windows.Forms.Label();
            yearrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.excel_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financial_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financial_DataBindingNavigator)).BeginInit();
            this.financial_DataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financial_DataDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.progress_panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(19, 10);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "id:";
            // 
            // segmentLabel
            // 
            segmentLabel.AutoSize = true;
            segmentLabel.Location = new System.Drawing.Point(19, 36);
            segmentLabel.Name = "segmentLabel";
            segmentLabel.Size = new System.Drawing.Size(52, 13);
            segmentLabel.TabIndex = 2;
            segmentLabel.Text = "Segment:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(19, 62);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "Country:";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(19, 88);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(47, 13);
            productLabel.TabIndex = 6;
            productLabel.Text = "Product:";
            // 
            // discount_BandLabel
            // 
            discount_BandLabel.AutoSize = true;
            discount_BandLabel.Location = new System.Drawing.Point(19, 114);
            discount_BandLabel.Name = "discount_BandLabel";
            discount_BandLabel.Size = new System.Drawing.Size(80, 13);
            discount_BandLabel.TabIndex = 8;
            discount_BandLabel.Text = "Discount Band:";
            // 
            // units_SoldLabel
            // 
            units_SoldLabel.AutoSize = true;
            units_SoldLabel.Location = new System.Drawing.Point(19, 140);
            units_SoldLabel.Name = "units_SoldLabel";
            units_SoldLabel.Size = new System.Drawing.Size(58, 13);
            units_SoldLabel.TabIndex = 10;
            units_SoldLabel.Text = "Units Sold:";
            // 
            // manufacturing_PriceLabel
            // 
            manufacturing_PriceLabel.AutoSize = true;
            manufacturing_PriceLabel.Location = new System.Drawing.Point(19, 166);
            manufacturing_PriceLabel.Name = "manufacturing_PriceLabel";
            manufacturing_PriceLabel.Size = new System.Drawing.Size(105, 13);
            manufacturing_PriceLabel.TabIndex = 12;
            manufacturing_PriceLabel.Text = "Manufacturing Price:";
            // 
            // sale_PriceLabel
            // 
            sale_PriceLabel.AutoSize = true;
            sale_PriceLabel.Location = new System.Drawing.Point(19, 192);
            sale_PriceLabel.Name = "sale_PriceLabel";
            sale_PriceLabel.Size = new System.Drawing.Size(58, 13);
            sale_PriceLabel.TabIndex = 14;
            sale_PriceLabel.Text = "Sale Price:";
            // 
            // gross_SalesLabel
            // 
            gross_SalesLabel.AutoSize = true;
            gross_SalesLabel.Location = new System.Drawing.Point(19, 218);
            gross_SalesLabel.Name = "gross_SalesLabel";
            gross_SalesLabel.Size = new System.Drawing.Size(66, 13);
            gross_SalesLabel.TabIndex = 16;
            gross_SalesLabel.Text = "Gross Sales:";
            // 
            // discountsLabel
            // 
            discountsLabel.AutoSize = true;
            discountsLabel.Location = new System.Drawing.Point(19, 244);
            discountsLabel.Name = "discountsLabel";
            discountsLabel.Size = new System.Drawing.Size(57, 13);
            discountsLabel.TabIndex = 18;
            discountsLabel.Text = "Discounts:";
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Location = new System.Drawing.Point(19, 270);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new System.Drawing.Size(36, 13);
            salesLabel.TabIndex = 20;
            salesLabel.Text = "Sales:";
            // 
            // cOGSLabel
            // 
            cOGSLabel.AutoSize = true;
            cOGSLabel.Location = new System.Drawing.Point(19, 296);
            cOGSLabel.Name = "cOGSLabel";
            cOGSLabel.Size = new System.Drawing.Size(40, 13);
            cOGSLabel.TabIndex = 22;
            cOGSLabel.Text = "COGS:";
            // 
            // profitLabel
            // 
            profitLabel.AutoSize = true;
            profitLabel.Location = new System.Drawing.Point(19, 322);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new System.Drawing.Size(34, 13);
            profitLabel.TabIndex = 24;
            profitLabel.Text = "Profit:";
            // 
            // dateeLabel
            // 
            dateeLabel.AutoSize = true;
            dateeLabel.Location = new System.Drawing.Point(19, 348);
            dateeLabel.Name = "dateeLabel";
            dateeLabel.Size = new System.Drawing.Size(39, 13);
            dateeLabel.TabIndex = 26;
            dateeLabel.Text = "Datee:";
            // 
            // month_NumberLabel
            // 
            month_NumberLabel.AutoSize = true;
            month_NumberLabel.Location = new System.Drawing.Point(19, 374);
            month_NumberLabel.Name = "month_NumberLabel";
            month_NumberLabel.Size = new System.Drawing.Size(80, 13);
            month_NumberLabel.TabIndex = 28;
            month_NumberLabel.Text = "Month Number:";
            // 
            // month_NameLabel
            // 
            month_NameLabel.AutoSize = true;
            month_NameLabel.Location = new System.Drawing.Point(19, 400);
            month_NameLabel.Name = "month_NameLabel";
            month_NameLabel.Size = new System.Drawing.Size(71, 13);
            month_NameLabel.TabIndex = 30;
            month_NameLabel.Text = "Month Name:";
            // 
            // yearrLabel
            // 
            yearrLabel.AutoSize = true;
            yearrLabel.Location = new System.Drawing.Point(19, 426);
            yearrLabel.Name = "yearrLabel";
            yearrLabel.Size = new System.Drawing.Size(35, 13);
            yearrLabel.TabIndex = 32;
            yearrLabel.Text = "Yearr:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // excel_ds
            // 
            this.excel_ds.DataSetName = "excel_ds";
            this.excel_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financial_DataBindingSource
            // 
            this.financial_DataBindingSource.DataMember = "Financial_Data";
            this.financial_DataBindingSource.DataSource = this.excel_ds;
            // 
            // financial_DataTableAdapter
            // 
            this.financial_DataTableAdapter.ClearBeforeFill = true;
            // 
            // financial_DataBindingNavigator
            // 
            this.financial_DataBindingNavigator.AddNewItem = null;
            this.financial_DataBindingNavigator.BindingSource = this.financial_DataBindingSource;
            this.financial_DataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.financial_DataBindingNavigator.DeleteItem = null;
            this.financial_DataBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.financial_DataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.financial_DataBindingNavigator.Location = new System.Drawing.Point(0, 532);
            this.financial_DataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.financial_DataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.financial_DataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.financial_DataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.financial_DataBindingNavigator.Name = "financial_DataBindingNavigator";
            this.financial_DataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.financial_DataBindingNavigator.Size = new System.Drawing.Size(894, 25);
            this.financial_DataBindingNavigator.TabIndex = 2;
            this.financial_DataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // financial_DataDataGridView
            // 
            this.financial_DataDataGridView.AutoGenerateColumns = false;
            this.financial_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.financial_DataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.financial_DataDataGridView.DataSource = this.financial_DataBindingSource;
            this.financial_DataDataGridView.Location = new System.Drawing.Point(0, 67);
            this.financial_DataDataGridView.Name = "financial_DataDataGridView";
            this.financial_DataDataGridView.Size = new System.Drawing.Size(610, 462);
            this.financial_DataDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Segment";
            this.dataGridViewTextBoxColumn2.HeaderText = "Segment";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn3.HeaderText = "Country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discount_Band";
            this.dataGridViewTextBoxColumn5.HeaderText = "Discount_Band";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Units_Sold";
            this.dataGridViewTextBoxColumn6.HeaderText = "Units_Sold";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Manufacturing_Price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Manufacturing_Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sale_Price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sale_Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Gross_Sales";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gross_Sales";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Discounts";
            this.dataGridViewTextBoxColumn10.HeaderText = "Discounts";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Sales";
            this.dataGridViewTextBoxColumn11.HeaderText = "Sales";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "COGS";
            this.dataGridViewTextBoxColumn12.HeaderText = "COGS";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Profit";
            this.dataGridViewTextBoxColumn13.HeaderText = "Profit";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Datee";
            this.dataGridViewTextBoxColumn14.HeaderText = "Datee";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Month_Number";
            this.dataGridViewTextBoxColumn15.HeaderText = "Month_Number";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Month_Name";
            this.dataGridViewTextBoxColumn16.HeaderText = "Month_Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Yearr";
            this.dataGridViewTextBoxColumn17.HeaderText = "Yearr";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Financial_DataTableAdapter = this.financial_DataTableAdapter;
            this.tableAdapterManager.UpdateOrder = excel_loader_cs.dataset.excel_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(segmentLabel);
            this.panel1.Controls.Add(this.segmentTextBox);
            this.panel1.Controls.Add(countryLabel);
            this.panel1.Controls.Add(this.countryTextBox);
            this.panel1.Controls.Add(productLabel);
            this.panel1.Controls.Add(this.productTextBox);
            this.panel1.Controls.Add(discount_BandLabel);
            this.panel1.Controls.Add(this.discount_BandTextBox);
            this.panel1.Controls.Add(units_SoldLabel);
            this.panel1.Controls.Add(this.units_SoldTextBox);
            this.panel1.Controls.Add(manufacturing_PriceLabel);
            this.panel1.Controls.Add(this.manufacturing_PriceTextBox);
            this.panel1.Controls.Add(sale_PriceLabel);
            this.panel1.Controls.Add(this.sale_PriceTextBox);
            this.panel1.Controls.Add(gross_SalesLabel);
            this.panel1.Controls.Add(this.gross_SalesTextBox);
            this.panel1.Controls.Add(discountsLabel);
            this.panel1.Controls.Add(this.discountsTextBox);
            this.panel1.Controls.Add(salesLabel);
            this.panel1.Controls.Add(this.salesTextBox);
            this.panel1.Controls.Add(cOGSLabel);
            this.panel1.Controls.Add(this.cOGSTextBox);
            this.panel1.Controls.Add(profitLabel);
            this.panel1.Controls.Add(this.profitTextBox);
            this.panel1.Controls.Add(dateeLabel);
            this.panel1.Controls.Add(this.dateeTextBox);
            this.panel1.Controls.Add(month_NumberLabel);
            this.panel1.Controls.Add(this.month_NumberTextBox);
            this.panel1.Controls.Add(month_NameLabel);
            this.panel1.Controls.Add(this.month_NameTextBox);
            this.panel1.Controls.Add(yearrLabel);
            this.panel1.Controls.Add(this.yearrTextBox);
            this.panel1.Location = new System.Drawing.Point(619, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 465);
            this.panel1.TabIndex = 38;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(130, 7);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // segmentTextBox
            // 
            this.segmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Segment", true));
            this.segmentTextBox.Location = new System.Drawing.Point(130, 33);
            this.segmentTextBox.Name = "segmentTextBox";
            this.segmentTextBox.ReadOnly = true;
            this.segmentTextBox.Size = new System.Drawing.Size(121, 20);
            this.segmentTextBox.TabIndex = 3;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(130, 59);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(121, 20);
            this.countryTextBox.TabIndex = 5;
            // 
            // productTextBox
            // 
            this.productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Product", true));
            this.productTextBox.Location = new System.Drawing.Point(130, 85);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            this.productTextBox.Size = new System.Drawing.Size(121, 20);
            this.productTextBox.TabIndex = 7;
            // 
            // discount_BandTextBox
            // 
            this.discount_BandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Discount_Band", true));
            this.discount_BandTextBox.Location = new System.Drawing.Point(130, 111);
            this.discount_BandTextBox.Name = "discount_BandTextBox";
            this.discount_BandTextBox.ReadOnly = true;
            this.discount_BandTextBox.Size = new System.Drawing.Size(121, 20);
            this.discount_BandTextBox.TabIndex = 9;
            // 
            // units_SoldTextBox
            // 
            this.units_SoldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Units_Sold", true));
            this.units_SoldTextBox.Location = new System.Drawing.Point(130, 137);
            this.units_SoldTextBox.Name = "units_SoldTextBox";
            this.units_SoldTextBox.ReadOnly = true;
            this.units_SoldTextBox.Size = new System.Drawing.Size(121, 20);
            this.units_SoldTextBox.TabIndex = 11;
            // 
            // manufacturing_PriceTextBox
            // 
            this.manufacturing_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Manufacturing_Price", true));
            this.manufacturing_PriceTextBox.Location = new System.Drawing.Point(130, 163);
            this.manufacturing_PriceTextBox.Name = "manufacturing_PriceTextBox";
            this.manufacturing_PriceTextBox.ReadOnly = true;
            this.manufacturing_PriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.manufacturing_PriceTextBox.TabIndex = 13;
            // 
            // sale_PriceTextBox
            // 
            this.sale_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Sale_Price", true));
            this.sale_PriceTextBox.Location = new System.Drawing.Point(130, 189);
            this.sale_PriceTextBox.Name = "sale_PriceTextBox";
            this.sale_PriceTextBox.ReadOnly = true;
            this.sale_PriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.sale_PriceTextBox.TabIndex = 15;
            // 
            // gross_SalesTextBox
            // 
            this.gross_SalesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Gross_Sales", true));
            this.gross_SalesTextBox.Location = new System.Drawing.Point(130, 215);
            this.gross_SalesTextBox.Name = "gross_SalesTextBox";
            this.gross_SalesTextBox.ReadOnly = true;
            this.gross_SalesTextBox.Size = new System.Drawing.Size(121, 20);
            this.gross_SalesTextBox.TabIndex = 17;
            // 
            // discountsTextBox
            // 
            this.discountsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Discounts", true));
            this.discountsTextBox.Location = new System.Drawing.Point(130, 241);
            this.discountsTextBox.Name = "discountsTextBox";
            this.discountsTextBox.ReadOnly = true;
            this.discountsTextBox.Size = new System.Drawing.Size(121, 20);
            this.discountsTextBox.TabIndex = 19;
            // 
            // salesTextBox
            // 
            this.salesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Sales", true));
            this.salesTextBox.Location = new System.Drawing.Point(130, 267);
            this.salesTextBox.Name = "salesTextBox";
            this.salesTextBox.ReadOnly = true;
            this.salesTextBox.Size = new System.Drawing.Size(121, 20);
            this.salesTextBox.TabIndex = 21;
            // 
            // cOGSTextBox
            // 
            this.cOGSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "COGS", true));
            this.cOGSTextBox.Location = new System.Drawing.Point(130, 293);
            this.cOGSTextBox.Name = "cOGSTextBox";
            this.cOGSTextBox.ReadOnly = true;
            this.cOGSTextBox.Size = new System.Drawing.Size(121, 20);
            this.cOGSTextBox.TabIndex = 23;
            // 
            // profitTextBox
            // 
            this.profitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Profit", true));
            this.profitTextBox.Location = new System.Drawing.Point(130, 319);
            this.profitTextBox.Name = "profitTextBox";
            this.profitTextBox.ReadOnly = true;
            this.profitTextBox.Size = new System.Drawing.Size(121, 20);
            this.profitTextBox.TabIndex = 25;
            // 
            // dateeTextBox
            // 
            this.dateeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Datee", true));
            this.dateeTextBox.Location = new System.Drawing.Point(130, 345);
            this.dateeTextBox.Name = "dateeTextBox";
            this.dateeTextBox.ReadOnly = true;
            this.dateeTextBox.Size = new System.Drawing.Size(121, 20);
            this.dateeTextBox.TabIndex = 27;
            // 
            // month_NumberTextBox
            // 
            this.month_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Month_Number", true));
            this.month_NumberTextBox.Location = new System.Drawing.Point(130, 371);
            this.month_NumberTextBox.Name = "month_NumberTextBox";
            this.month_NumberTextBox.ReadOnly = true;
            this.month_NumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.month_NumberTextBox.TabIndex = 29;
            // 
            // month_NameTextBox
            // 
            this.month_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Month_Name", true));
            this.month_NameTextBox.Location = new System.Drawing.Point(130, 397);
            this.month_NameTextBox.Name = "month_NameTextBox";
            this.month_NameTextBox.ReadOnly = true;
            this.month_NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.month_NameTextBox.TabIndex = 31;
            // 
            // yearrTextBox
            // 
            this.yearrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financial_DataBindingSource, "Yearr", true));
            this.yearrTextBox.Location = new System.Drawing.Point(130, 423);
            this.yearrTextBox.Name = "yearrTextBox";
            this.yearrTextBox.ReadOnly = true;
            this.yearrTextBox.Size = new System.Drawing.Size(121, 20);
            this.yearrTextBox.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Load All Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // new_recored_button3
            // 
            this.new_recored_button3.Location = new System.Drawing.Point(12, 32);
            this.new_recored_button3.Name = "new_recored_button3";
            this.new_recored_button3.Size = new System.Drawing.Size(75, 23);
            this.new_recored_button3.TabIndex = 40;
            this.new_recored_button3.Text = "New Record";
            this.new_recored_button3.UseVisualStyleBackColor = true;
            this.new_recored_button3.Click += new System.EventHandler(this.new_recored_button3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Add To Datatable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "Cancel Changes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progress_panel2
            // 
            this.progress_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progress_panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progress_panel2.Controls.Add(this.prog_label3);
            this.progress_panel2.Controls.Add(this.progressBar1);
            this.progress_panel2.Controls.Add(this.loading_label2);
            this.progress_panel2.Controls.Add(this.label1);
            this.progress_panel2.Location = new System.Drawing.Point(262, 234);
            this.progress_panel2.Name = "progress_panel2";
            this.progress_panel2.Size = new System.Drawing.Size(234, 140);
            this.progress_panel2.TabIndex = 43;
            this.progress_panel2.Visible = false;
            // 
            // prog_label3
            // 
            this.prog_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.prog_label3.ForeColor = System.Drawing.Color.Maroon;
            this.prog_label3.Location = new System.Drawing.Point(3, 96);
            this.prog_label3.Name = "prog_label3";
            this.prog_label3.Size = new System.Drawing.Size(226, 20);
            this.prog_label3.TabIndex = 3;
            this.prog_label3.Text = "0 of 700";
            this.prog_label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 19);
            this.progressBar1.TabIndex = 2;
            // 
            // loading_label2
            // 
            this.loading_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loading_label2.ForeColor = System.Drawing.Color.Maroon;
            this.loading_label2.Location = new System.Drawing.Point(7, 52);
            this.loading_label2.Name = "loading_label2";
            this.loading_label2.Size = new System.Drawing.Size(222, 20);
            this.loading_label2.TabIndex = 1;
            this.loading_label2.Text = "Loading Excel Data...";
            this.loading_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loading_label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Wait...";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(324, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 44;
            this.button5.Text = "Save in SQL DB";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(677, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 45;
            this.button6.Text = "Save All in SQL DB";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Xlsx Files|*.xlsx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(894, 557);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.progress_panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.new_recored_button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.financial_DataDataGridView);
            this.Controls.Add(this.financial_DataBindingNavigator);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel File Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excel_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financial_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financial_DataBindingNavigator)).EndInit();
            this.financial_DataBindingNavigator.ResumeLayout(false);
            this.financial_DataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financial_DataDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progress_panel2.ResumeLayout(false);
            this.progress_panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private dataset.excel_ds excel_ds;
        private System.Windows.Forms.BindingSource financial_DataBindingSource;
        private dataset.excel_dsTableAdapters.Financial_DataTableAdapter financial_DataTableAdapter;
        private System.Windows.Forms.BindingNavigator financial_DataBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView financial_DataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private dataset.excel_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button new_recored_button3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox segmentTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox discount_BandTextBox;
        private System.Windows.Forms.TextBox units_SoldTextBox;
        private System.Windows.Forms.TextBox manufacturing_PriceTextBox;
        private System.Windows.Forms.TextBox sale_PriceTextBox;
        private System.Windows.Forms.TextBox gross_SalesTextBox;
        private System.Windows.Forms.TextBox discountsTextBox;
        private System.Windows.Forms.TextBox salesTextBox;
        private System.Windows.Forms.TextBox cOGSTextBox;
        private System.Windows.Forms.TextBox profitTextBox;
        private System.Windows.Forms.TextBox dateeTextBox;
        private System.Windows.Forms.TextBox month_NumberTextBox;
        private System.Windows.Forms.TextBox month_NameTextBox;
        private System.Windows.Forms.TextBox yearrTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel progress_panel2;
        private System.Windows.Forms.Label loading_label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label prog_label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

