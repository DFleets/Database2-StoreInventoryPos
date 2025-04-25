namespace StoreInventoryPos
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnGoToSales = new System.Windows.Forms.Button();
            this.BtnGoToInventory = new System.Windows.Forms.Button();
            this.comboCategoryFilter = new System.Windows.Forms.ComboBox();
            this.BtnRefreshChart = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GoToSuppliers = new System.Windows.Forms.Button();
            this.RefreshLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGoToSales
            // 
            this.BtnGoToSales.Location = new System.Drawing.Point(2, 436);
            this.BtnGoToSales.Name = "BtnGoToSales";
            this.BtnGoToSales.Size = new System.Drawing.Size(120, 23);
            this.BtnGoToSales.TabIndex = 0;
            this.BtnGoToSales.Text = "Sales System";
            this.BtnGoToSales.UseVisualStyleBackColor = true;
            this.BtnGoToSales.Click += new System.EventHandler(this.BtnGoToSales_Click);
            // 
            // BtnGoToInventory
            // 
            this.BtnGoToInventory.Location = new System.Drawing.Point(2, 474);
            this.BtnGoToInventory.Name = "BtnGoToInventory";
            this.BtnGoToInventory.Size = new System.Drawing.Size(120, 23);
            this.BtnGoToInventory.TabIndex = 1;
            this.BtnGoToInventory.Text = "Inventory System";
            this.BtnGoToInventory.UseVisualStyleBackColor = true;
            this.BtnGoToInventory.Click += new System.EventHandler(this.BtnGoToInventory_Click);
            // 
            // comboCategoryFilter
            // 
            this.comboCategoryFilter.FormattingEnabled = true;
            this.comboCategoryFilter.Location = new System.Drawing.Point(834, 398);
            this.comboCategoryFilter.Name = "comboCategoryFilter";
            this.comboCategoryFilter.Size = new System.Drawing.Size(241, 24);
            this.comboCategoryFilter.TabIndex = 2;
            this.comboCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.comboCategoryFilter_SelectedIndexChanged);
            // 
            // BtnRefreshChart
            // 
            this.BtnRefreshChart.Location = new System.Drawing.Point(243, 397);
            this.BtnRefreshChart.Name = "BtnRefreshChart";
            this.BtnRefreshChart.Size = new System.Drawing.Size(111, 23);
            this.BtnRefreshChart.TabIndex = 3;
            this.BtnRefreshChart.Text = "Refresh Chart";
            this.BtnRefreshChart.UseVisualStyleBackColor = true;
            this.BtnRefreshChart.Click += new System.EventHandler(this.BtnRefreshChart_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(1199, 474);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(75, 23);
            this.BtnQuit.TabIndex = 4;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // chartRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(28, 27);
            this.chartRevenue.Name = "chartRevenue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(599, 336);
            this.chartRevenue.TabIndex = 5;
            this.chartRevenue.Text = "Revenue Chart";
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(651, 27);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(603, 336);
            this.dgvInventory.TabIndex = 6;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(925, 379);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(64, 16);
            this.FilterLabel.TabIndex = 7;
            this.FilterLabel.Text = "Item Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "*Highlighted Items running low.";
            // 
            // GoToSuppliers
            // 
            this.GoToSuppliers.Location = new System.Drawing.Point(585, 457);
            this.GoToSuppliers.Name = "GoToSuppliers";
            this.GoToSuppliers.Size = new System.Drawing.Size(116, 23);
            this.GoToSuppliers.TabIndex = 9;
            this.GoToSuppliers.Text = "Vendors";
            this.GoToSuppliers.UseVisualStyleBackColor = true;
            this.GoToSuppliers.Click += new System.EventHandler(this.GoToSuppliers_Click);
            // 
            // RefreshLabel
            // 
            this.RefreshLabel.AutoSize = true;
            this.RefreshLabel.Location = new System.Drawing.Point(201, 366);
            this.RefreshLabel.Name = "RefreshLabel";
            this.RefreshLabel.Size = new System.Drawing.Size(195, 16);
            this.RefreshLabel.TabIndex = 10;
            this.RefreshLabel.Text = "Refresh if chart does not update";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 509);
            this.Controls.Add(this.RefreshLabel);
            this.Controls.Add(this.GoToSuppliers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnRefreshChart);
            this.Controls.Add(this.comboCategoryFilter);
            this.Controls.Add(this.BtnGoToInventory);
            this.Controls.Add(this.BtnGoToSales);
            this.Name = "Dashboard";
            this.Text = "Sales Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGoToSales;
        private System.Windows.Forms.Button BtnGoToInventory;
        private System.Windows.Forms.ComboBox comboCategoryFilter;
        private System.Windows.Forms.Button BtnRefreshChart;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoToSuppliers;
        private System.Windows.Forms.Label RefreshLabel;
    }
}