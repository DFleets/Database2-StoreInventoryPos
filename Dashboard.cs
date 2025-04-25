using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StoreInventoryPos
{
    public partial class Dashboard : Form
    {
        private InventoryPosDataSet inventoryPosDataSet = new InventoryPosDataSet();
        private InventoryPosDataSetTableAdapters.ProductsTableAdapter productsTableAdapter =
        new InventoryPosDataSetTableAdapters.ProductsTableAdapter();
        private InventoryPosDataSetTableAdapters.SalesTableAdapter salesTableAdapter =
        new InventoryPosDataSetTableAdapters.SalesTableAdapter();

        public Dashboard()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Dashboard_Load);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(inventoryPosDataSet.Products);
            salesTableAdapter.Fill(inventoryPosDataSet.Sales);

            dgvInventory.DataSource = inventoryPosDataSet.Products;
            dgvInventory.Columns["Price"].DefaultCellStyle.Format = "C";
            dgvInventory.Columns["Quantity_Onhand"].HeaderText = "Stock";
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.ReadOnly = true;
            dgvInventory.Columns["Product_ID"].Visible = false;

            HighlightLowStockRows();

            LoadRevenueChart();
            LoadCategories();
        }

        private void LoadRevenueChart()
        {
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();
            chartRevenue.ChartAreas[0].AxisX.Title = "Date";
            chartRevenue.ChartAreas[0].AxisY.Title = "Total Sales";
            chartRevenue.Titles.Add("Daily Revenue");
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd";

            Series series = new Series("Daily Total Revenue");
            series.ChartType = SeriesChartType.Column;
            chartRevenue.Series.Add(series);
            series.IsValueShownAsLabel = true;
            

            //  groups sales by date
            var salesGrouped = inventoryPosDataSet.Sales
                .GroupBy(s => s.Date.Date)
                .Select(g => new
                {
                    SaleDate = g.Key,
                    DailyTotal = g.Sum(s => s.Total)
                });

            foreach (var item in salesGrouped)
            {
                series.Points.AddXY(item.SaleDate.ToShortDateString(), item.DailyTotal);
            }
        }

        private void LoadCategories()
        {
            var categories = inventoryPosDataSet.Products
                .Select(p => p.Category)
                .Distinct()
                .ToList();

            comboCategoryFilter.Items.Clear();
            comboCategoryFilter.Items.Add("All");
            comboCategoryFilter.Items.AddRange(categories.ToArray());
            comboCategoryFilter.SelectedIndex = 0;
        }

        private void comboCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCategoryFilter.SelectedItem.ToString() == "All")
                dgvInventory.DataSource = inventoryPosDataSet.Products;
            else
            {
                string category = comboCategoryFilter.SelectedItem.ToString();
                var filteredRows = inventoryPosDataSet.Products
                    .Where(p => p.Category == category);

                if (filteredRows.Any())
                {
                    dgvInventory.DataSource = filteredRows.CopyToDataTable();

                    dgvInventory.Columns["Price"].DefaultCellStyle.Format = "C";
                    dgvInventory.Columns["Quantity_Onhand"].HeaderText = "Stock";

                    HighlightLowStockRows();
                }
                else
                {
                    dgvInventory.DataSource = null;
                    MessageBox.Show("Products not found in this category!", "Notice");
                }
            }

        }

        private void BtnRefreshChart_Click(object sender, EventArgs e)
        {
            //Refreshes if chart does not update.
            salesTableAdapter.Fill(inventoryPosDataSet.Sales);
            LoadRevenueChart();
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

        private void BtnGoToInventory_Click(object sender, EventArgs e)
        {
            InventorySystem inventoryForm = new InventorySystem();
            inventoryForm.StartPosition = FormStartPosition.CenterScreen;
            inventoryForm.Show();
            this.Hide();
        }

        private void HighlightLowStockRows()
        {
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["Quantity_Onhand"].Value != null &&
                    int.TryParse(row.Cells["Quantity_Onhand"].Value.ToString(), out int qty) &&
                    qty < 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
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
