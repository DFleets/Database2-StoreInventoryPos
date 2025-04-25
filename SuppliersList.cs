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
    public partial class SuppliersList : Form
    {
        public SuppliersList()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryPosDataSet);

        }

        private void SuppliersList_Load(object sender, EventArgs e)
        {
            
            this.suppliersTableAdapter.Fill(this.inventoryPosDataSet.Suppliers);

            dgvSuppliers.DataSource = suppliersBindingSource;

            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.AllowUserToOrderColumns = false;

            dgvSuppliers.DataBindingComplete += (s, args) =>
            {
                if (dgvSuppliers.Columns.Contains("Suppliers_Id"))
                {
                    dgvSuppliers.Columns["Suppliers_Id"].Visible = false;
                }
            };

            nameTextBox.DataBindings.Clear();
            phoneTextBox.DataBindings.Clear();
            emailTextBox.DataBindings.Clear();

            nameTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            string name = nameTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter a name, phone number, and email address.");
                return;
            }

            try
            {
                suppliersTableAdapter.Insert(name, phone, email);
                suppliersTableAdapter.Fill(inventoryPosDataSet.Suppliers);
                nameTextBox.Clear();
                phoneTextBox.Clear();
                emailTextBox.Clear();
                nameTextBox.Focus();
                MessageBox.Show("Supplier added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier: " + ex.Message);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var row = (dgvSuppliers.SelectedRows[0].DataBoundItem as DataRowView).Row as InventoryPosDataSet.SuppliersRow;

                    suppliersTableAdapter.Delete(
                        row.Suppliers_Id,
                        row.Name,
                        row.Phone,
                        row.Email
                    );

                    suppliersTableAdapter.Fill(inventoryPosDataSet.Suppliers);
                    MessageBox.Show("Supplier removed successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier to remove.");
            }
        }

        private void BtnGoToInventory_Click(object sender, EventArgs e)
        {
            InventorySystem inventoryForm = new InventorySystem();
            inventoryForm.StartPosition = FormStartPosition.CenterScreen;
            inventoryForm.Show();
            this.Hide();
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
    }
}
