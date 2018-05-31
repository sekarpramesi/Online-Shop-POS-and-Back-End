namespace Proyek
{
    partial class POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMenuPos = new MetroFramework.Controls.MetroTabControl();
            this.tabTransaction = new MetroFramework.Controls.MetroTabPage();
            this.cbCategory = new MetroFramework.Controls.MetroCheckBox();
            this.cbBrand = new MetroFramework.Controls.MetroCheckBox();
            this.cbName = new MetroFramework.Controls.MetroCheckBox();
            this.cbId = new MetroFramework.Controls.MetroCheckBox();
            this.btnClearAll = new MetroFramework.Controls.MetroTile();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.panelProductInfo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gridDTrans = new MetroFramework.Controls.MetroGrid();
            this.dId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPlus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridProductList = new MetroFramework.Controls.MetroGrid();
            this.lblTotalPrice = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalItems = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tabMember = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTransactionNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblCashierName = new MetroFramework.Controls.MetroLabel();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblBrand = new MetroFramework.Controls.MetroLabel();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblCategory = new MetroFramework.Controls.MetroLabel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.tabMenuPos.SuspendLayout();
            this.tabTransaction.SuspendLayout();
            this.panelProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).BeginInit();
            this.tabMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenuPos
            // 
            this.tabMenuPos.Controls.Add(this.tabTransaction);
            this.tabMenuPos.Controls.Add(this.tabMember);
            this.tabMenuPos.Location = new System.Drawing.Point(-1, 46);
            this.tabMenuPos.Name = "tabMenuPos";
            this.tabMenuPos.SelectedIndex = 1;
            this.tabMenuPos.Size = new System.Drawing.Size(908, 537);
            this.tabMenuPos.TabIndex = 0;
            this.tabMenuPos.UseSelectable = true;
            // 
            // tabTransaction
            // 
            this.tabTransaction.Controls.Add(this.cbCategory);
            this.tabTransaction.Controls.Add(this.cbBrand);
            this.tabTransaction.Controls.Add(this.cbName);
            this.tabTransaction.Controls.Add(this.cbId);
            this.tabTransaction.Controls.Add(this.btnClearAll);
            this.tabTransaction.Controls.Add(this.btnNext);
            this.tabTransaction.Controls.Add(this.panelProductInfo);
            this.tabTransaction.Controls.Add(this.gridDTrans);
            this.tabTransaction.Controls.Add(this.gridProductList);
            this.tabTransaction.Controls.Add(this.lblTotalPrice);
            this.tabTransaction.Controls.Add(this.metroLabel14);
            this.tabTransaction.Controls.Add(this.lblTotalItems);
            this.tabTransaction.Controls.Add(this.metroLabel12);
            this.tabTransaction.Controls.Add(this.metroLabel8);
            this.tabTransaction.Controls.Add(this.metroLabel7);
            this.tabTransaction.Controls.Add(this.txtSearch);
            this.tabTransaction.HorizontalScrollbarBarColor = true;
            this.tabTransaction.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTransaction.HorizontalScrollbarSize = 10;
            this.tabTransaction.Location = new System.Drawing.Point(4, 38);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Size = new System.Drawing.Size(900, 495);
            this.tabTransaction.TabIndex = 0;
            this.tabTransaction.Text = "Transaction";
            this.tabTransaction.VerticalScrollbarBarColor = true;
            this.tabTransaction.VerticalScrollbarHighlightOnWheel = false;
            this.tabTransaction.VerticalScrollbarSize = 10;
            this.tabTransaction.Click += new System.EventHandler(this.tabTransaction_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.AutoSize = true;
            this.cbCategory.Location = new System.Drawing.Point(256, 34);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(71, 15);
            this.cbCategory.TabIndex = 24;
            this.cbCategory.Text = "Category";
            this.cbCategory.UseSelectable = true;
            // 
            // cbBrand
            // 
            this.cbBrand.AutoSize = true;
            this.cbBrand.Location = new System.Drawing.Point(195, 34);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(54, 15);
            this.cbBrand.TabIndex = 23;
            this.cbBrand.Text = "Brand";
            this.cbBrand.UseSelectable = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(134, 34);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(55, 15);
            this.cbName.TabIndex = 22;
            this.cbName.Text = "Name";
            this.cbName.UseSelectable = true;
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Location = new System.Drawing.Point(94, 34);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(34, 15);
            this.cbId.TabIndex = 21;
            this.cbId.Text = "ID";
            this.cbId.UseSelectable = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.ActiveControl = null;
            this.btnClearAll.Location = new System.Drawing.Point(767, 412);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(130, 38);
            this.btnClearAll.Style = MetroFramework.MetroColorStyle.Red;
            this.btnClearAll.TabIndex = 20;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearAll.UseSelectable = true;
            // 
            // btnNext
            // 
            this.btnNext.ActiveControl = null;
            this.btnNext.Location = new System.Drawing.Point(767, 457);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 37);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseSelectable = true;
            // 
            // panelProductInfo
            // 
            this.panelProductInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelProductInfo.Controls.Add(this.lblStock);
            this.panelProductInfo.Controls.Add(this.lblCategory);
            this.panelProductInfo.Controls.Add(this.lblPrice);
            this.panelProductInfo.Controls.Add(this.lblBrand);
            this.panelProductInfo.Controls.Add(this.lblName);
            this.panelProductInfo.Controls.Add(this.lblId);
            this.panelProductInfo.Controls.Add(this.metroLabel17);
            this.panelProductInfo.Controls.Add(this.metroLabel16);
            this.panelProductInfo.Controls.Add(this.metroLabel15);
            this.panelProductInfo.Controls.Add(this.metroLabel13);
            this.panelProductInfo.Controls.Add(this.metroLabel6);
            this.panelProductInfo.Controls.Add(this.metroLabel4);
            this.panelProductInfo.Controls.Add(this.metroLabel2);
            this.panelProductInfo.HorizontalScrollbarBarColor = true;
            this.panelProductInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.panelProductInfo.HorizontalScrollbarSize = 10;
            this.panelProductInfo.Location = new System.Drawing.Point(371, 356);
            this.panelProductInfo.Name = "panelProductInfo";
            this.panelProductInfo.Size = new System.Drawing.Size(390, 139);
            this.panelProductInfo.TabIndex = 18;
            this.panelProductInfo.VerticalScrollbarBarColor = true;
            this.panelProductInfo.VerticalScrollbarHighlightOnWheel = false;
            this.panelProductInfo.VerticalScrollbarSize = 10;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(20, 75);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(38, 19);
            this.metroLabel17.TabIndex = 8;
            this.metroLabel17.Text = "Price";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(20, 111);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(54, 19);
            this.metroLabel16.TabIndex = 7;
            this.metroLabel16.Text = "In Stock";
            this.metroLabel16.Click += new System.EventHandler(this.metroLabel16_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(20, 93);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(64, 19);
            this.metroLabel15.TabIndex = 6;
            this.metroLabel15.Text = "Category";
            this.metroLabel15.Click += new System.EventHandler(this.metroLabel15_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(20, 56);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(44, 19);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "Brand";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 37);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(21, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Product Details : ";
            // 
            // gridDTrans
            // 
            this.gridDTrans.AllowUserToResizeRows = false;
            this.gridDTrans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDTrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridDTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dId,
            this.dName,
            this.dQty,
            this.dPlus,
            this.dMinus,
            this.dPrice,
            this.dSubtotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDTrans.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridDTrans.EnableHeadersVisualStyles = false;
            this.gridDTrans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDTrans.Location = new System.Drawing.Point(371, 33);
            this.gridDTrans.Name = "gridDTrans";
            this.gridDTrans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridDTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDTrans.Size = new System.Drawing.Size(526, 312);
            this.gridDTrans.TabIndex = 17;
            // 
            // dId
            // 
            this.dId.HeaderText = "ID";
            this.dId.Name = "dId";
            this.dId.Width = 50;
            // 
            // dName
            // 
            this.dName.HeaderText = "Name";
            this.dName.Name = "dName";
            this.dName.Width = 150;
            // 
            // dQty
            // 
            this.dQty.HeaderText = "Qty";
            this.dQty.Name = "dQty";
            this.dQty.Width = 30;
            // 
            // dPlus
            // 
            this.dPlus.HeaderText = "+";
            this.dPlus.Name = "dPlus";
            this.dPlus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dPlus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dPlus.Width = 25;
            // 
            // dMinus
            // 
            this.dMinus.HeaderText = "-";
            this.dMinus.Name = "dMinus";
            this.dMinus.Width = 25;
            // 
            // dPrice
            // 
            this.dPrice.HeaderText = "Price";
            this.dPrice.Name = "dPrice";
            this.dPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dSubtotal
            // 
            this.dSubtotal.HeaderText = "Subtotal";
            this.dSubtotal.Name = "dSubtotal";
            this.dSubtotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dSubtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridProductList
            // 
            this.gridProductList.AllowUserToResizeRows = false;
            this.gridProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Picture});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductList.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridProductList.EnableHeadersVisualStyles = false;
            this.gridProductList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProductList.Location = new System.Drawing.Point(3, 55);
            this.gridProductList.Name = "gridProductList";
            this.gridProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductList.Size = new System.Drawing.Size(342, 427);
            this.gridProductList.TabIndex = 16;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(655, 6);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(88, 19);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "metroLabel15";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(577, 6);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(80, 19);
            this.metroLabel14.TabIndex = 14;
            this.metroLabel14.Text = "Total Price : ";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(447, 5);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(88, 19);
            this.lblTotalItems.TabIndex = 13;
            this.lblTotalItems.Text = "metroLabel13";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(371, 5);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(82, 19);
            this.metroLabel12.TabIndex = 12;
            this.metroLabel12.Text = "Total Items : ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(21, 31);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(67, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Filter by : ";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 5);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(105, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Search Product :";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(113, 5);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(219, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabMember
            // 
            this.tabMember.Controls.Add(this.pictureBox1);
            this.tabMember.HorizontalScrollbarBarColor = true;
            this.tabMember.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMember.HorizontalScrollbarSize = 10;
            this.tabMember.Location = new System.Drawing.Point(4, 38);
            this.tabMember.Name = "tabMember";
            this.tabMember.Size = new System.Drawing.Size(900, 495);
            this.tabMember.TabIndex = 2;
            this.tabMember.Text = "Member";
            this.tabMember.VerticalScrollbarBarColor = true;
            this.tabMember.VerticalScrollbarHighlightOnWheel = false;
            this.tabMember.VerticalScrollbarSize = 10;
            this.tabMember.Click += new System.EventHandler(this.metroTabPage3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 155);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(424, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Transaction No : ";
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Location = new System.Drawing.Point(536, 21);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(83, 19);
            this.lblTransactionNo.TabIndex = 2;
            this.lblTransactionNo.Text = "metroLabel2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(51, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "ELXtore";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(702, 21);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(83, 19);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "metroLabel4";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(199, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Cashier : ";
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.Location = new System.Drawing.Point(256, 21);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(83, 19);
            this.lblCashierName.TabIndex = 6;
            this.lblCashierName.Text = "metroLabel6";
            // 
            // Picture
            // 
            this.Picture.HeaderText = "-";
            this.Picture.Name = "Picture";
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Picture.Width = 300;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(94, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(88, 19);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "metroLabel18";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 19);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "metroLabel19";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(94, 56);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(90, 19);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "metroLabel20";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(94, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 19);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "metroLabel21";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(94, 93);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 19);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "metroLabel22";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(94, 111);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(90, 19);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "metroLabel23";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 598);
            this.Controls.Add(this.lblCashierName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblTransactionNo);
            this.Controls.Add(this.tabMenuPos);
            this.Controls.Add(this.metroLabel1);
            this.Name = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.tabMenuPos.ResumeLayout(false);
            this.tabTransaction.ResumeLayout(false);
            this.tabTransaction.PerformLayout();
            this.panelProductInfo.ResumeLayout(false);
            this.panelProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).EndInit();
            this.tabMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabMenuPos;
        private MetroFramework.Controls.MetroTabPage tabTransaction;
        private MetroFramework.Controls.MetroTabPage tabMember;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblTransactionNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblCashierName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblTotalPrice;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel lblTotalItems;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroPanel panelProductInfo;
        private MetroFramework.Controls.MetroGrid gridDTrans;
        private MetroFramework.Controls.MetroGrid gridProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dQty;
        private System.Windows.Forms.DataGridViewButtonColumn dPlus;
        private System.Windows.Forms.DataGridViewButtonColumn dMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroCheckBox cbCategory;
        private MetroFramework.Controls.MetroCheckBox cbBrand;
        private MetroFramework.Controls.MetroCheckBox cbName;
        private MetroFramework.Controls.MetroCheckBox cbId;
        private MetroFramework.Controls.MetroTile btnClearAll;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroLabel lblCategory;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblBrand;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblId;

    }
}