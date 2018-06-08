namespace Proyek
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabInventory = new MetroFramework.Controls.MetroTabControl();
            this.tabPageOrders = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gridDbeli = new MetroFramework.Controls.MetroGrid();
            this.btnSimpanOrders = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gridHbeli = new MetroFramework.Controls.MetroGrid();
            this.tabPageCatalogue = new MetroFramework.Controls.MetroTabPage();
            this.btnSimpanBarang = new MetroFramework.Controls.MetroTile();
            this.gridBarang = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabInventory.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDbeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHbeli)).BeginInit();
            this.tabPageCatalogue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.tabPageOrders);
            this.tabInventory.Controls.Add(this.tabPageCatalogue);
            this.tabInventory.Location = new System.Drawing.Point(1, 53);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.SelectedIndex = 0;
            this.tabInventory.Size = new System.Drawing.Size(915, 470);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.UseSelectable = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.metroLabel3);
            this.tabPageOrders.Controls.Add(this.gridDbeli);
            this.tabPageOrders.Controls.Add(this.btnSimpanOrders);
            this.tabPageOrders.Controls.Add(this.metroLabel2);
            this.tabPageOrders.Controls.Add(this.gridHbeli);
            this.tabPageOrders.HorizontalScrollbarBarColor = true;
            this.tabPageOrders.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageOrders.HorizontalScrollbarSize = 10;
            this.tabPageOrders.Location = new System.Drawing.Point(4, 38);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Size = new System.Drawing.Size(907, 428);
            this.tabPageOrders.TabIndex = 0;
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.VerticalScrollbarBarColor = true;
            this.tabPageOrders.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageOrders.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(458, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Dbeli";
            // 
            // gridDbeli
            // 
            this.gridDbeli.AllowUserToResizeRows = false;
            this.gridDbeli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridDbeli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDbeli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDbeli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDbeli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDbeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDbeli.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDbeli.EnableHeadersVisualStyles = false;
            this.gridDbeli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDbeli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridDbeli.Location = new System.Drawing.Point(458, 45);
            this.gridDbeli.Name = "gridDbeli";
            this.gridDbeli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDbeli.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDbeli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDbeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDbeli.Size = new System.Drawing.Size(429, 337);
            this.gridDbeli.TabIndex = 5;
            this.gridDbeli.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnSimpanOrders
            // 
            this.btnSimpanOrders.ActiveControl = null;
            this.btnSimpanOrders.Location = new System.Drawing.Point(331, 387);
            this.btnSimpanOrders.Name = "btnSimpanOrders";
            this.btnSimpanOrders.Size = new System.Drawing.Size(121, 38);
            this.btnSimpanOrders.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSimpanOrders.TabIndex = 4;
            this.btnSimpanOrders.Text = "Simpan";
            this.btnSimpanOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimpanOrders.UseSelectable = true;
            this.btnSimpanOrders.Click += new System.EventHandler(this.btnSimpanOrders_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Hbeli";
            // 
            // gridHbeli
            // 
            this.gridHbeli.AllowUserToResizeRows = false;
            this.gridHbeli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridHbeli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHbeli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridHbeli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHbeli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridHbeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHbeli.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridHbeli.EnableHeadersVisualStyles = false;
            this.gridHbeli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridHbeli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridHbeli.Location = new System.Drawing.Point(18, 45);
            this.gridHbeli.Name = "gridHbeli";
            this.gridHbeli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHbeli.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridHbeli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridHbeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHbeli.Size = new System.Drawing.Size(434, 337);
            this.gridHbeli.TabIndex = 2;
            this.gridHbeli.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gridHbeli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHbeli_CellClick);
            // 
            // tabPageCatalogue
            // 
            this.tabPageCatalogue.Controls.Add(this.btnSimpanBarang);
            this.tabPageCatalogue.Controls.Add(this.gridBarang);
            this.tabPageCatalogue.Controls.Add(this.metroLabel1);
            this.tabPageCatalogue.HorizontalScrollbarBarColor = true;
            this.tabPageCatalogue.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageCatalogue.HorizontalScrollbarSize = 10;
            this.tabPageCatalogue.Location = new System.Drawing.Point(4, 38);
            this.tabPageCatalogue.Name = "tabPageCatalogue";
            this.tabPageCatalogue.Size = new System.Drawing.Size(907, 428);
            this.tabPageCatalogue.TabIndex = 2;
            this.tabPageCatalogue.Text = "Catalogue";
            this.tabPageCatalogue.VerticalScrollbarBarColor = true;
            this.tabPageCatalogue.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageCatalogue.VerticalScrollbarSize = 10;
            // 
            // btnSimpanBarang
            // 
            this.btnSimpanBarang.ActiveControl = null;
            this.btnSimpanBarang.Location = new System.Drawing.Point(759, 380);
            this.btnSimpanBarang.Name = "btnSimpanBarang";
            this.btnSimpanBarang.Size = new System.Drawing.Size(128, 45);
            this.btnSimpanBarang.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSimpanBarang.TabIndex = 4;
            this.btnSimpanBarang.Text = "Simpan";
            this.btnSimpanBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimpanBarang.UseSelectable = true;
            this.btnSimpanBarang.Click += new System.EventHandler(this.btnSimpanBarang_Click);
            // 
            // gridBarang
            // 
            this.gridBarang.AllowUserToResizeRows = false;
            this.gridBarang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBarang.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridBarang.EnableHeadersVisualStyles = false;
            this.gridBarang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridBarang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridBarang.Location = new System.Drawing.Point(19, 37);
            this.gridBarang.Name = "gridBarang";
            this.gridBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBarang.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBarang.Size = new System.Drawing.Size(868, 337);
            this.gridBarang.TabIndex = 3;
            this.gridBarang.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Katalog Barang";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 524);
            this.Controls.Add(this.tabInventory);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.tabInventory.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDbeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHbeli)).EndInit();
            this.tabPageCatalogue.ResumeLayout(false);
            this.tabPageCatalogue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabInventory;
        private MetroFramework.Controls.MetroTabPage tabPageOrders;
        private MetroFramework.Controls.MetroTabPage tabPageCatalogue;
        private MetroFramework.Controls.MetroTile btnSimpanBarang;
        private MetroFramework.Controls.MetroGrid gridBarang;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid gridHbeli;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnSimpanOrders;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid gridDbeli;

    }
}