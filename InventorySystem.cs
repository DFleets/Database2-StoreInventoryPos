using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventoryPos
{


    public partial class InventorySystem : Form
    {
        private void skuTextBox_TextChanged(object sender, EventArgs e) => UpdateAddButtonState();
        private void nameTextBox_TextChanged(object sender, EventArgs e) => UpdateAddButtonState();
        private void priceTextBox_TextChanged(object sender, EventArgs e) => UpdateAddButtonState();

        private bool suppressSelectionChanged = false;


        public InventorySystem()
        {
            InitializeComponent();
            this.skuTextBox.TextChanged += new System.EventHandler(this.skuTextBox_TextChanged);
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            this.dgvInventory.SelectionChanged += new EventHandler(this.dgvInventory_SelectionChanged);
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryPosDataSet);

        }

        private void InventorySystem_Load(object sender, EventArgs e)
        {
           
            this.productsTableAdapter.Fill(this.inventoryPosDataSet.Products);
            dgvInventory.DataSource = inventoryPosDataSet.Products;
            dgvInventory.Columns[4].DefaultCellStyle.Format = "C";
            dgvInventory.ReadOnly = true;                          
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;                     
            dgvInventory.ClearSelection();                         
            dgvInventory.DefaultCellStyle.SelectionBackColor = dgvInventory.DefaultCellStyle.BackColor;
            dgvInventory.DefaultCellStyle.SelectionForeColor = dgvInventory.DefaultCellStyle.ForeColor;

            skuTextBox.DataBindings.Clear();
            nameTextBox.DataBindings.Clear();
            categoryTextBox.DataBindings.Clear();
            priceTextBox.DataBindings.Clear();
            quantity_OnhandTextBox.DataBindings.Clear();

            skuTextBox.Clear();
            nameTextBox.Clear();
            categoryTextBox.Clear();
            priceTextBox.Clear();
            quantity_OnhandTextBox.Clear();

            BtnAdd.Enabled = false;

            UpdateAddButtonState();
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            dgvInventory.ClearSelection();
        }


        private void DgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (suppressSelectionChanged) return;

            BtnUpdate.Enabled = dgvInventory.CurrentRow != null;
            if (dgvInventory.CurrentRow != null)
            {
                var row = ((DataRowView)dgvInventory.CurrentRow.DataBoundItem).Row as InventoryPosDataSet.ProductsRow;
                skuTextBox.Text = row.SKU;
                nameTextBox.Text = row.Name;
                categoryTextBox.Text = row.Category;
                priceTextBox.Text = row.Price.ToString();
                quantity_OnhandTextBox.Text = row.Quantity_Onhand.ToString();
                skuTextBox.ReadOnly = true;
            }


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(priceTextBox.Text, out decimal price) ||
                    !int.TryParse(quantity_OnhandTextBox.Text, out int quantity))
                {
                    MessageBox.Show("Please enter a valid value for Price and Quantity.");
                    return;
                }

                string sku = skuTextBox.Text.ToUpper().Trim();

                bool skuExists = inventoryPosDataSet.Products.Any(p => p.SKU == sku);
                if (skuExists)
                {
                    MessageBox.Show("A product with this SKU already exists.");
                    return;
                }

                inventoryPosDataSet.Products.AddProductsRow(
                    sku,
                    nameTextBox.Text,
                    categoryTextBox.Text,
                    price,
                    quantity
                );

                productsTableAdapter.Update(inventoryPosDataSet.Products);
                MessageBox.Show("Product added successfully.");
                RefreshInventory();

                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }



        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventory.CurrentRow != null)
                {
                    if (MessageBox.Show("Are you sure you want to update this product?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                    var row = ((DataRowView)dgvInventory.CurrentRow.DataBoundItem).Row as InventoryPosDataSet.ProductsRow;

                    string sku = skuTextBox.Text.ToUpper().Trim();

                    row.SKU = sku;
                    row.Name = nameTextBox.Text;
                    row.Category = categoryTextBox.Text;

                    if (!decimal.TryParse(priceTextBox.Text, out decimal price) ||
                        !int.TryParse(quantity_OnhandTextBox.Text, out int quantity))
                    {
                        MessageBox.Show("Please enter valid values for Price and/or Quantity.");
                        return;
                    }

                    row.Price = price;
                    row.Quantity_Onhand = quantity;

                    this.Validate();
                    this.productsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.inventoryPosDataSet);

                    MessageBox.Show("Product updated successfully.");
                    RefreshInventory();
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }

        }

        private void UpdateAddButtonState()
        {
            BtnAdd.Enabled =
                !string.IsNullOrWhiteSpace(skuTextBox.Text) &&
                !string.IsNullOrWhiteSpace(nameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(priceTextBox.Text);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow != null)
            {
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    var row = ((DataRowView)dgvInventory.CurrentRow.DataBoundItem).Row as InventoryPosDataSet.ProductsRow;
                    row.Delete();
                    productsTableAdapter.Update(inventoryPosDataSet.Products);
                    MessageBox.Show("Product deleted successfully.");
                    RefreshInventory();
                }
            }

            
            ClearFormFields();
        }

        private void ClearFormFields()
        {
            skuTextBox.Clear();
            nameTextBox.Clear();
            categoryTextBox.Clear();
            priceTextBox.Clear();
            quantity_OnhandTextBox.Clear();
            skuTextBox.ReadOnly = false;
            skuTextBox.Focus();
            UpdateAddButtonState();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            productsBindingSource.CancelEdit();  
        }

        private void RefreshInventory()
        {
            productsTableAdapter.Fill(inventoryPosDataSet.Products);
            dgvInventory.DataSource = inventoryPosDataSet.Products;
        }
       

        private void BtnGoToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.StartPosition = FormStartPosition.CenterScreen;
            dashboardForm.Show();
            this.Hide();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGoToSales_Click(object sender, EventArgs e)
        {
            SalesPos salesForm = new SalesPos();
            salesForm.StartPosition = FormStartPosition.CenterScreen;
            salesForm.Show();
            this.Hide();
        }

        private void GoToSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersList suppliersForm = new SuppliersList();
            suppliersForm.StartPosition = FormStartPosition.CenterScreen;
            suppliersForm.Show();
            this.Hide();
        }
    }

}
