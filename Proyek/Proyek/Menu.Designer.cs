namespace Proyek
{
    partial class Menu
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
            this.btnReport = new MetroFramework.Controls.MetroTile();
            this.btnMaster = new MetroFramework.Controls.MetroTile();
            this.btnPointOfSales = new MetroFramework.Controls.MetroTile();
            this.btnInventory = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.ActiveControl = null;
            this.btnReport.Location = new System.Drawing.Point(461, 91);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(182, 135);
            this.btnReport.Style = MetroFramework.MetroColorStyle.Green;
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report";
            this.btnReport.UseSelectable = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.ActiveControl = null;
            this.btnMaster.Location = new System.Drawing.Point(151, 91);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(182, 135);
            this.btnMaster.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnMaster.TabIndex = 1;
            this.btnMaster.Text = "Master";
            this.btnMaster.UseSelectable = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnPointOfSales
            // 
            this.btnPointOfSales.ActiveControl = null;
            this.btnPointOfSales.Location = new System.Drawing.Point(151, 252);
            this.btnPointOfSales.Name = "btnPointOfSales";
            this.btnPointOfSales.Size = new System.Drawing.Size(182, 135);
            this.btnPointOfSales.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnPointOfSales.TabIndex = 2;
            this.btnPointOfSales.Text = "Point of Sales";
            this.btnPointOfSales.UseSelectable = true;
            this.btnPointOfSales.Click += new System.EventHandler(this.btnPointOfSales_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.ActiveControl = null;
            this.btnInventory.Location = new System.Drawing.Point(461, 252);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(182, 135);
            this.btnInventory.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseSelectable = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 464);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnPointOfSales);
            this.Controls.Add(this.btnMaster);
            this.Controls.Add(this.btnReport);
            this.Name = "Menu";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnReport;
        private MetroFramework.Controls.MetroTile btnMaster;
        private MetroFramework.Controls.MetroTile btnPointOfSales;
        private MetroFramework.Controls.MetroTile btnInventory;

    }
}