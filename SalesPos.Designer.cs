namespace StoreInventoryPos
{
    partial class SalesPos
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
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPos));
            this.inventoryPosDataSet = new StoreInventoryPos.InventoryPosDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new StoreInventoryPos.InventoryPosDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new StoreInventoryPos.InventoryPosDataSetTableAdapters.TableAdapterManager();
            this.salesTableAdapter = new StoreInventoryPos.InventoryPosDataSetTableAdapters.SalesTableAdapter();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockLabel = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.CartLabel = new System.Windows.Forms.Label();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.SkuLabel = new System.Windows.Forms.Label();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.BtnGoToInventory = new System.Windows.Forms.Button();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.BtnRemoveFromCart = new System.Windows.Forms.Button();
            this.BtnCompleteSale = new System.Windows.Forms.Button();
            this.BtnGoToDashboard = new System.Windows.Forms.Button();
            this.ChkPaymentType = new System.Windows.Forms.CheckBox();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.skuComboBox = new System.Windows.Forms.ComboBox();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryPosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.Location = new System.Drawing.Point(1033, 271);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(48, 16);
            totalLabel.TabIndex = 7;
            totalLabel.Text = "Total:";
            // 
            // inventoryPosDataSet
            // 
            this.inventoryPosDataSet.DataSetName = "InventoryPosDataSet";
            this.inventoryPosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.inventoryPosDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.SaleLineItemsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StoreInventoryPos.InventoryPosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(1225, 27);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AutoGenerateColumns = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvInventory.DataSource = this.productsBindingSource;
            this.dgvInventory.Location = new System.Drawing.Point(204, 50);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(804, 203);
            this.dgvInventory.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SKU";
            this.dataGridViewTextBoxColumn2.HeaderText = "SKU";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn4.HeaderText = "Category";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity_Onhand";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity_Onhand";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(564, 31);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(80, 19);
            this.StockLabel.TabIndex = 2;
            this.StockLabel.Text = "Inventory";
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(204, 291);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(804, 150);
            this.dgvCart.TabIndex = 3;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartLabel.Location = new System.Drawing.Point(578, 256);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(45, 20);
            this.CartLabel.TabIndex = 4;
            this.CartLabel.Text = "Cart";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.inventoryPosDataSet;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Total", true));
            this.TotalTextBox.Location = new System.Drawing.Point(1087, 268);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 8;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(582, 468);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 22);
            this.numQty.TabIndex = 10;
            // 
            // SkuLabel
            // 
            this.SkuLabel.AutoSize = true;
            this.SkuLabel.Location = new System.Drawing.Point(203, 470);
            this.SkuLabel.Name = "SkuLabel";
            this.SkuLabel.Size = new System.Drawing.Size(37, 16);
            this.SkuLabel.TabIndex = 11;
            this.SkuLabel.Text = "SKU:";
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Location = new System.Drawing.Point(504, 470);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(58, 16);
            this.QtyLabel.TabIndex = 12;
            this.QtyLabel.Text = "Quantity:";
            // 
            // BtnGoToInventory
            // 
            this.BtnGoToInventory.Location = new System.Drawing.Point(204, 526);
            this.BtnGoToInventory.Name = "BtnGoToInventory";
            this.BtnGoToInventory.Size = new System.Drawing.Size(146, 23);
            this.BtnGoToInventory.TabIndex = 13;
            this.BtnGoToInventory.Text = "Inventory System";
            this.BtnGoToInventory.UseVisualStyleBackColor = true;
            this.BtnGoToInventory.Click += new System.EventHandler(this.BtnGoToInventory_Click);
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Location = new System.Drawing.Point(372, 526);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(127, 23);
            this.BtnAddToCart.TabIndex = 14;
            this.BtnAddToCart.Text = "Add to Cart";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // BtnRemoveFromCart
            // 
            this.BtnRemoveFromCart.Location = new System.Drawing.Point(541, 526);
            this.BtnRemoveFromCart.Name = "BtnRemoveFromCart";
            this.BtnRemoveFromCart.Size = new System.Drawing.Size(146, 23);
            this.BtnRemoveFromCart.TabIndex = 15;
            this.BtnRemoveFromCart.Text = "Remove From Cart";
            this.BtnRemoveFromCart.UseVisualStyleBackColor = true;
            this.BtnRemoveFromCart.Click += new System.EventHandler(this.BtnRemoveFromCart_Click);
            // 
            // BtnCompleteSale
            // 
            this.BtnCompleteSale.Location = new System.Drawing.Point(731, 526);
            this.BtnCompleteSale.Name = "BtnCompleteSale";
            this.BtnCompleteSale.Size = new System.Drawing.Size(136, 23);
            this.BtnCompleteSale.TabIndex = 16;
            this.BtnCompleteSale.Text = "Complete Sale";
            this.BtnCompleteSale.UseVisualStyleBackColor = true;
            this.BtnCompleteSale.Click += new System.EventHandler(this.BtnCompleteSale_Click);
            // 
            // BtnGoToDashboard
            // 
            this.BtnGoToDashboard.Location = new System.Drawing.Point(896, 526);
            this.BtnGoToDashboard.Name = "BtnGoToDashboard";
            this.BtnGoToDashboard.Size = new System.Drawing.Size(112, 23);
            this.BtnGoToDashboard.TabIndex = 17;
            this.BtnGoToDashboard.Text = "Dashboard";
            this.BtnGoToDashboard.UseVisualStyleBackColor = true;
            this.BtnGoToDashboard.Click += new System.EventHandler(this.BtnGoToDashboard_Click);
            // 
            // ChkPaymentType
            // 
            this.ChkPaymentType.AutoSize = true;
            this.ChkPaymentType.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkPaymentType.Location = new System.Drawing.Point(806, 470);
            this.ChkPaymentType.Name = "ChkPaymentType";
            this.ChkPaymentType.Size = new System.Drawing.Size(85, 20);
            this.ChkPaymentType.TabIndex = 18;
            this.ChkPaymentType.Text = "PayType";
            this.ChkPaymentType.UseVisualStyleBackColor = true;
            this.ChkPaymentType.CheckedChanged += new System.EventHandler(this.ChkPaymentType_CheckedChanged);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(1138, 534);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(75, 23);
            this.BtnQuit.TabIndex = 19;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(911, 471);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(97, 16);
            this.lblPaymentType.TabIndex = 20;
            this.lblPaymentType.Text = "Payment: Cash";
            // 
            // skuComboBox
            // 
            this.skuComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.skuComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.skuComboBox.FormattingEnabled = true;
            this.skuComboBox.Location = new System.Drawing.Point(246, 467);
            this.skuComboBox.Name = "skuComboBox";
            this.skuComboBox.Size = new System.Drawing.Size(121, 24);
            this.skuComboBox.TabIndex = 21;
            this.skuComboBox.SelectedIndexChanged += new System.EventHandler(this.skuComboBox_SelectedIndexChanged);
            // 
            // SalesPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 569);
            this.Controls.Add(this.skuComboBox);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.ChkPaymentType);
            this.Controls.Add(this.BtnGoToDashboard);
            this.Controls.Add(this.BtnCompleteSale);
            this.Controls.Add(this.BtnRemoveFromCart);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.BtnGoToInventory);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.SkuLabel);
            this.Controls.Add(this.numQty);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "SalesPos";
            this.Text = "Point of Sale System";
            this.Load += new System.EventHandler(this.SalesPos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryPosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventoryPosDataSet inventoryPosDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private InventoryPosDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private InventoryPosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label CartLabel;
        private InventoryPosDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label SkuLabel;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.Button BtnGoToInventory;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.Button BtnRemoveFromCart;
        private System.Windows.Forms.Button BtnCompleteSale;
        private System.Windows.Forms.Button BtnGoToDashboard;
        private System.Windows.Forms.CheckBox ChkPaymentType;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox skuComboBox;
    }
}