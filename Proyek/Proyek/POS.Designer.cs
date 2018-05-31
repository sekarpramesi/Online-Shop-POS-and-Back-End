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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMenuPos = new MetroFramework.Controls.MetroTabControl();
            this.tabTransaction = new MetroFramework.Controls.MetroTabPage();
            this.cbCategory = new MetroFramework.Controls.MetroCheckBox();
            this.cbBrand = new MetroFramework.Controls.MetroCheckBox();
            this.cbName = new MetroFramework.Controls.MetroCheckBox();
            this.cbId = new MetroFramework.Controls.MetroCheckBox();
            this.btnClearAll = new MetroFramework.Controls.MetroTile();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.panelProductInfo = new MetroFramework.Controls.MetroPanel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.lblCategory = new MetroFramework.Controls.MetroLabel();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblBrand = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
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
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTotalPrice = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalItems = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tabMember = new MetroFramework.Controls.MetroTabPage();
            this.btnUpload = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.btnMemberBaru = new MetroFramework.Controls.MetroTile();
            this.cbPerempuan = new MetroFramework.Controls.MetroRadioButton();
            this.cbLakiLaki = new MetroFramework.Controls.MetroRadioButton();
            this.dtpTanggalLahir = new MetroFramework.Controls.MetroDateTime();
            this.txtAlamat = new MetroFramework.Controls.MetroTextBox();
            this.txtNama = new MetroFramework.Controls.MetroTextBox();
            this.txtIdMember = new MetroFramework.Controls.MetroTextBox();
            this.txtCariMember = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.btnSimpan = new MetroFramework.Controls.MetroTile();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.pbFotoMember = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTransactionNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblCashierName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.txtJumlahPoint = new MetroFramework.Controls.MetroTextBox();
            this.tabMenuPos.SuspendLayout();
            this.tabTransaction.SuspendLayout();
            this.panelProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).BeginInit();
            this.tabMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoMember)).BeginInit();
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
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(94, 111);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(90, 19);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "metroLabel23";
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
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(94, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 19);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "metroLabel21";
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 19);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "metroLabel19";
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
            this.gridDTrans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridDTrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dId,
            this.dName,
            this.dQty,
            this.dPlus,
            this.dMinus,
            this.dPrice,
            this.dSubtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDTrans.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDTrans.EnableHeadersVisualStyles = false;
            this.gridDTrans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridDTrans.Location = new System.Drawing.Point(371, 33);
            this.gridDTrans.Name = "gridDTrans";
            this.gridDTrans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDTrans.Size = new System.Drawing.Size(526, 312);
            this.gridDTrans.TabIndex = 17;
            this.gridDTrans.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.gridProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Picture});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductList.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridProductList.EnableHeadersVisualStyles = false;
            this.gridProductList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridProductList.Location = new System.Drawing.Point(3, 55);
            this.gridProductList.Name = "gridProductList";
            this.gridProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductList.Size = new System.Drawing.Size(342, 427);
            this.gridProductList.TabIndex = 16;
            this.gridProductList.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Picture
            // 
            this.Picture.HeaderText = "-";
            this.Picture.Name = "Picture";
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Picture.Width = 300;
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
            this.tabMember.Controls.Add(this.txtJumlahPoint);
            this.tabMember.Controls.Add(this.metroLabel23);
            this.tabMember.Controls.Add(this.btnUpload);
            this.tabMember.Controls.Add(this.metroTile3);
            this.tabMember.Controls.Add(this.btnMemberBaru);
            this.tabMember.Controls.Add(this.cbPerempuan);
            this.tabMember.Controls.Add(this.cbLakiLaki);
            this.tabMember.Controls.Add(this.dtpTanggalLahir);
            this.tabMember.Controls.Add(this.txtAlamat);
            this.tabMember.Controls.Add(this.txtNama);
            this.tabMember.Controls.Add(this.txtIdMember);
            this.tabMember.Controls.Add(this.txtCariMember);
            this.tabMember.Controls.Add(this.metroLabel22);
            this.tabMember.Controls.Add(this.metroLabel21);
            this.tabMember.Controls.Add(this.metroLabel20);
            this.tabMember.Controls.Add(this.metroLabel19);
            this.tabMember.Controls.Add(this.metroLabel18);
            this.tabMember.Controls.Add(this.btnSimpan);
            this.tabMember.Controls.Add(this.metroLabel11);
            this.tabMember.Controls.Add(this.metroLabel9);
            this.tabMember.Controls.Add(this.pbFotoMember);
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
            // btnUpload
            // 
            this.btnUpload.ActiveControl = null;
            this.btnUpload.Location = new System.Drawing.Point(237, 290);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(138, 39);
            this.btnUpload.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Upload Foto";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpload.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(37, 315);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(0, 0);
            this.metroTile3.TabIndex = 24;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.UseSelectable = true;
            // 
            // btnMemberBaru
            // 
            this.btnMemberBaru.ActiveControl = null;
            this.btnMemberBaru.Location = new System.Drawing.Point(398, 408);
            this.btnMemberBaru.Name = "btnMemberBaru";
            this.btnMemberBaru.Size = new System.Drawing.Size(138, 39);
            this.btnMemberBaru.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnMemberBaru.TabIndex = 23;
            this.btnMemberBaru.Text = "Member Baru";
            this.btnMemberBaru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMemberBaru.UseSelectable = true;
            // 
            // cbPerempuan
            // 
            this.cbPerempuan.AutoSize = true;
            this.cbPerempuan.Location = new System.Drawing.Point(602, 207);
            this.cbPerempuan.Name = "cbPerempuan";
            this.cbPerempuan.Size = new System.Drawing.Size(84, 15);
            this.cbPerempuan.TabIndex = 22;
            this.cbPerempuan.Text = "Perempuan";
            this.cbPerempuan.UseSelectable = true;
            // 
            // cbLakiLaki
            // 
            this.cbLakiLaki.AutoSize = true;
            this.cbLakiLaki.Location = new System.Drawing.Point(479, 207);
            this.cbLakiLaki.Name = "cbLakiLaki";
            this.cbLakiLaki.Size = new System.Drawing.Size(70, 15);
            this.cbLakiLaki.TabIndex = 21;
            this.cbLakiLaki.Text = "Laki-Laki";
            this.cbLakiLaki.UseSelectable = true;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(479, 166);
            this.dtpTanggalLahir.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(207, 29);
            this.dtpTanggalLahir.TabIndex = 20;
            // 
            // txtAlamat
            // 
            // 
            // 
            // 
            this.txtAlamat.CustomButton.Image = null;
            this.txtAlamat.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtAlamat.CustomButton.Name = "";
            this.txtAlamat.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtAlamat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlamat.CustomButton.TabIndex = 1;
            this.txtAlamat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlamat.CustomButton.UseSelectable = true;
            this.txtAlamat.CustomButton.Visible = false;
            this.txtAlamat.Lines = new string[0];
            this.txtAlamat.Location = new System.Drawing.Point(479, 233);
            this.txtAlamat.MaxLength = 32767;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.PasswordChar = '\0';
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlamat.SelectedText = "";
            this.txtAlamat.SelectionLength = 0;
            this.txtAlamat.SelectionStart = 0;
            this.txtAlamat.ShortcutsEnabled = true;
            this.txtAlamat.Size = new System.Drawing.Size(207, 50);
            this.txtAlamat.TabIndex = 19;
            this.txtAlamat.UseSelectable = true;
            this.txtAlamat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlamat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNama
            // 
            // 
            // 
            // 
            this.txtNama.CustomButton.Image = null;
            this.txtNama.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtNama.CustomButton.Name = "";
            this.txtNama.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNama.CustomButton.TabIndex = 1;
            this.txtNama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNama.CustomButton.UseSelectable = true;
            this.txtNama.CustomButton.Visible = false;
            this.txtNama.Lines = new string[0];
            this.txtNama.Location = new System.Drawing.Point(479, 136);
            this.txtNama.MaxLength = 32767;
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNama.SelectedText = "";
            this.txtNama.SelectionLength = 0;
            this.txtNama.SelectionStart = 0;
            this.txtNama.ShortcutsEnabled = true;
            this.txtNama.Size = new System.Drawing.Size(207, 23);
            this.txtNama.TabIndex = 18;
            this.txtNama.UseSelectable = true;
            this.txtNama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIdMember
            // 
            // 
            // 
            // 
            this.txtIdMember.CustomButton.Image = null;
            this.txtIdMember.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtIdMember.CustomButton.Name = "";
            this.txtIdMember.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdMember.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdMember.CustomButton.TabIndex = 1;
            this.txtIdMember.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdMember.CustomButton.UseSelectable = true;
            this.txtIdMember.CustomButton.Visible = false;
            this.txtIdMember.Lines = new string[0];
            this.txtIdMember.Location = new System.Drawing.Point(479, 107);
            this.txtIdMember.MaxLength = 32767;
            this.txtIdMember.Name = "txtIdMember";
            this.txtIdMember.PasswordChar = '\0';
            this.txtIdMember.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdMember.SelectedText = "";
            this.txtIdMember.SelectionLength = 0;
            this.txtIdMember.SelectionStart = 0;
            this.txtIdMember.ShortcutsEnabled = true;
            this.txtIdMember.Size = new System.Drawing.Size(207, 23);
            this.txtIdMember.TabIndex = 17;
            this.txtIdMember.UseSelectable = true;
            this.txtIdMember.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdMember.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCariMember
            // 
            // 
            // 
            // 
            this.txtCariMember.CustomButton.Image = null;
            this.txtCariMember.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.txtCariMember.CustomButton.Name = "";
            this.txtCariMember.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCariMember.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCariMember.CustomButton.TabIndex = 1;
            this.txtCariMember.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCariMember.CustomButton.UseSelectable = true;
            this.txtCariMember.CustomButton.Visible = false;
            this.txtCariMember.Lines = new string[0];
            this.txtCariMember.Location = new System.Drawing.Point(342, 34);
            this.txtCariMember.MaxLength = 32767;
            this.txtCariMember.Name = "txtCariMember";
            this.txtCariMember.PasswordChar = '\0';
            this.txtCariMember.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCariMember.SelectedText = "";
            this.txtCariMember.SelectionLength = 0;
            this.txtCariMember.SelectionStart = 0;
            this.txtCariMember.ShortcutsEnabled = true;
            this.txtCariMember.Size = new System.Drawing.Size(344, 23);
            this.txtCariMember.TabIndex = 16;
            this.txtCariMember.UseSelectable = true;
            this.txtCariMember.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCariMember.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(237, 34);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(99, 19);
            this.metroLabel22.TabIndex = 15;
            this.metroLabel22.Text = "Cari Member : ";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(417, 233);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(51, 19);
            this.metroLabel21.TabIndex = 14;
            this.metroLabel21.Text = "Alamat";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(382, 204);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(86, 19);
            this.metroLabel20.TabIndex = 13;
            this.metroLabel20.Text = "Jenis Kelamin";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(382, 171);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(86, 19);
            this.metroLabel19.TabIndex = 12;
            this.metroLabel19.Text = "Tanggal Lahir";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(423, 138);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(45, 19);
            this.metroLabel18.TabIndex = 11;
            this.metroLabel18.Text = "Nama";
            // 
            // btnSimpan
            // 
            this.btnSimpan.ActiveControl = null;
            this.btnSimpan.Location = new System.Drawing.Point(548, 408);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(138, 39);
            this.btnSimpan.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimpan.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(392, 107);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(76, 19);
            this.metroLabel11.TabIndex = 9;
            this.metroLabel11.Text = "ID Member";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(237, 75);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(118, 19);
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "Informasi Member";
            // 
            // pbFotoMember
            // 
            this.pbFotoMember.Location = new System.Drawing.Point(237, 107);
            this.pbFotoMember.Name = "pbFotoMember";
            this.pbFotoMember.Size = new System.Drawing.Size(138, 176);
            this.pbFotoMember.TabIndex = 5;
            this.pbFotoMember.TabStop = false;
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
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(385, 292);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(83, 19);
            this.metroLabel23.TabIndex = 26;
            this.metroLabel23.Text = "Jumlah Point";
            // 
            // txtJumlahPoint
            // 
            // 
            // 
            // 
            this.txtJumlahPoint.CustomButton.Image = null;
            this.txtJumlahPoint.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtJumlahPoint.CustomButton.Name = "";
            this.txtJumlahPoint.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJumlahPoint.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJumlahPoint.CustomButton.TabIndex = 1;
            this.txtJumlahPoint.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJumlahPoint.CustomButton.UseSelectable = true;
            this.txtJumlahPoint.CustomButton.Visible = false;
            this.txtJumlahPoint.Lines = new string[0];
            this.txtJumlahPoint.Location = new System.Drawing.Point(479, 290);
            this.txtJumlahPoint.MaxLength = 32767;
            this.txtJumlahPoint.Name = "txtJumlahPoint";
            this.txtJumlahPoint.PasswordChar = '\0';
            this.txtJumlahPoint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJumlahPoint.SelectedText = "";
            this.txtJumlahPoint.SelectionLength = 0;
            this.txtJumlahPoint.SelectionStart = 0;
            this.txtJumlahPoint.ShortcutsEnabled = true;
            this.txtJumlahPoint.Size = new System.Drawing.Size(207, 23);
            this.txtJumlahPoint.TabIndex = 27;
            this.txtJumlahPoint.UseSelectable = true;
            this.txtJumlahPoint.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJumlahPoint.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tabMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoMember)).EndInit();
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
        private System.Windows.Forms.PictureBox pbFotoMember;
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
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTile btnUpload;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile btnMemberBaru;
        private MetroFramework.Controls.MetroRadioButton cbPerempuan;
        private MetroFramework.Controls.MetroRadioButton cbLakiLaki;
        private MetroFramework.Controls.MetroDateTime dtpTanggalLahir;
        private MetroFramework.Controls.MetroTextBox txtAlamat;
        private MetroFramework.Controls.MetroTextBox txtNama;
        private MetroFramework.Controls.MetroTextBox txtIdMember;
        private MetroFramework.Controls.MetroTextBox txtCariMember;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTile btnSimpan;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtJumlahPoint;
        private MetroFramework.Controls.MetroLabel metroLabel23;

    }
}