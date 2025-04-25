using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreInventoryPos.InventoryPosDataSetTableAdapters;
using StoreInventoryPos.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StoreInventoryPos
{
    public partial class SalesPos : Form
    {
        
        private List<SaleLineItemModel> cartItems = new List<SaleLineItemModel>();
        private InventoryPosDataSetTableAdapters.SaleLineItemsTableAdapter saleLineItemsTableAdapter =
        new InventoryPosDataSetTableAdapters.SaleLineItemsTableAdapter();

        private System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

        public SalesPos()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryPosDataSet);

        }

        private void SalesPos_Load(object sender, EventArgs e)
        {
            
            this.salesTableAdapter.Fill(this.inventoryPosDataSet.Sales);
            
            this.productsTableAdapter.Fill(this.inventoryPosDataSet.Products);
            dgvCart.ReadOnly = true;
            UpdateButtonStates(); //disables 
            var displayList = inventoryPosDataSet.Products
            .Select(p => $"{p.SKU} - {p.Name}")
            .ToList();
            skuComboBox.DataSource = displayList;

        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            var fullText = skuComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullText) || !fullText.Contains("-"))
            {
                MessageBox.Show("Invalid SKU. Please select valid item.");
                return;
            }

            if (numQty.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            var sku = fullText.Split('-')[0].Trim();
            var product = inventoryPosDataSet.Products.FirstOrDefault(p => p.SKU == sku);

            if (product != null && product.Quantity_Onhand >= numQty.Value)
            {
                product.Quantity_Onhand -= (int)numQty.Value;
                productsTableAdapter.Update(inventoryPosDataSet.Products);

                cartItems.Add(new SaleLineItemModel
                {
                    Product_ID = product.Product_Id,
                    Name = product.Name,
                    Qty = (int)numQty.Value,
                    UnitPrice = product.Price
                });

                dgvCart.DataSource = null;
                dgvCart.DataSource = cartItems;

                TotalTextBox.Text = cartItems.Sum(i => i.SubTotal).ToString("C");

                UpdateButtonStates();

            }
            else
            {
                MessageBox.Show("Invalid SKU or insufficient stock.");
            }
        }
        private void BtnRemoveFromCart_Click(object sender, EventArgs e)
        {
            var fullText = skuComboBox.Text.Trim();
            int qtyToRemove = (int)numQty.Value;

            if (string.IsNullOrWhiteSpace(fullText) || !fullText.Contains("-") || qtyToRemove <= 0)
            {
                MessageBox.Show("Enter a valid SKU and quantity.");
                return;
            }

            var sku = fullText.Split('-')[0].Trim();

            // Find the product 
            var productRow = inventoryPosDataSet.Products.FirstOrDefault(p => p.SKU == sku);
            if (productRow == null)
            {
                MessageBox.Show("SKU not found for product.");
                return;
            }

            // Find matching item in cart
            var item = cartItems.FirstOrDefault(i => i.Product_ID == productRow.Product_Id);
            if (item == null)
            {
                MessageBox.Show("This item is not in the cart.");
                return;
            }

            if (qtyToRemove >= item.Qty &&
                MessageBox.Show("Remove entire item from cart?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (qtyToRemove >= item.Qty)
            {
                // Full removal
                cartItems.Remove(item);
                productRow.Quantity_Onhand += item.Qty;
            }
            else
            {
                // Partial removal
                item.Qty -= qtyToRemove;
                productRow.Quantity_Onhand += qtyToRemove;
            }

            // Update products table
            productsTableAdapter.Update(inventoryPosDataSet.Products);

            dgvCart.DataSource = null;
            dgvCart.DataSource = cartItems;

            TotalTextBox.Text = cartItems.Sum(i => i.SubTotal).ToString("C");
            UpdateButtonStates();

            skuComboBox.Text = "";
            numQty.Value = 1;
            skuComboBox.Focus();
        }

        private void BtnCompleteSale_Click(object sender, EventArgs e)
        {


            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            decimal total = cartItems.Sum(i => i.SubTotal);
            bool paymentType = ChkPaymentType.Checked;

            var salesTableAdapter = new InventoryPosDataSetTableAdapters.SalesTableAdapter();

            try
            {
                int saleId = Convert.ToInt32(salesTableAdapter.InsertReturnID(DateTime.Now, total, paymentType));

                foreach (var item in cartItems)
                {
                    saleLineItemsTableAdapter.Insert(
                        saleId,
                        item.Product_ID,
                        DateTime.Now,
                        item.Qty,
                        item.UnitPrice
                    );
                }

                // Generates and shows receipt
                StringBuilder receipt = new StringBuilder();
                receipt.AppendLine("=== ITEMIZED RECEIPT ===");
                foreach (var item in cartItems)
                {
                    receipt.AppendLine($"{item.Name} x{item.Qty} @ {item.UnitPrice:C} = {item.SubTotal:C}");
                }
                receipt.AppendLine("------------------------");
                receipt.AppendLine($"Total: {total:C}");
                receipt.AppendLine($"Payment: {(paymentType ? "Card" : "Cash")}");
                receipt.AppendLine($"Date: {DateTime.Now}");

                MessageBox.Show(receipt.ToString(), " Your reciept! Have a nice day!");
                
                //Saves reciepts to whatever folder
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.FileName = $"Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, receipt.ToString());
                    MessageBox.Show("Receipt saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                cartItems.Clear();
                dgvCart.DataSource = null;
                TotalTextBox.Text = "$0.00";
                skuComboBox.Text = "";
                skuComboBox.Items.Clear();
                numQty.Value = 1;
                skuComboBox.Focus();

                UpdateButtonStates();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error completing reciept printing\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BtnGoToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.StartPosition = FormStartPosition.CenterScreen;
            dashboardForm.Show();
            this.Hide();
        }

        private void BtnGoToInventory_Click(object sender, EventArgs e)
        {
            InventorySystem inventoryForm = new InventorySystem();
            inventoryForm.StartPosition = FormStartPosition.CenterScreen;
            inventoryForm.Show();
            this.Hide();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChkPaymentType_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPaymentType.Checked)
            {
                lblPaymentType.Text = "Payment: Credit";
            }
            else
            {
                lblPaymentType.Text = "Payment: Cash";
            }
        }

        private void skuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fullText = skuComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullText) || !fullText.Contains("-"))
                return;

            var sku = fullText.Split('-')[0].Trim();
            var product = inventoryPosDataSet.Products.FirstOrDefault(p => p.SKU == sku);

            if (product != null)
            {
                toolTip1.SetToolTip(skuComboBox, $"Name: {product.Name}\nPrice: {product.Price:C}");
            }
        }

        private void UpdateButtonStates()
        {
            BtnCompleteSale.Enabled = cartItems.Count > 0;
            BtnRemoveFromCart.Enabled = cartItems.Count > 0;
        }

    }
}
