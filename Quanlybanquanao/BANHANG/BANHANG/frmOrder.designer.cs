namespace BANHANG
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelDieukhien = new System.Windows.Forms.Panel();
            this.btnThutien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGiao = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.grvOrderdetail = new System.Windows.Forms.DataGridView();
            this.colOrderDetail_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colOrderDetail_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDetail_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDetail_Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDetail_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDetail_OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetail_QuantityOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txtCustomer_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeachKH = new System.Windows.Forms.Button();
            this.txtCustomer_Zalo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomer_Facbook = new System.Windows.Forms.TextBox();
            this.Facbook = new System.Windows.Forms.Label();
            this.txtCustomer_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomer_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomer_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpOrder_Date = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cdkOrder_IsSend = new System.Windows.Forms.CheckBox();
            this.chkOrder_IsOutput = new System.Windows.Forms.CheckBox();
            this.chkOrder_IsVoucher = new System.Windows.Forms.CheckBox();
            this.groupThongtin = new System.Windows.Forms.GroupBox();
            this.txtOrder_Description = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrder_TotalVAT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrder_SaleMoney = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrder_VAT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrder_SendMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOrder_SendType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSelectProduct = new System.Windows.Forms.Button();
            this.ucProductsSelect = new BANHANG.UCProducts();
            this.panelDieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrderdetail)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add_24x24.png");
            this.imageList1.Images.SetKeyName(1, "Edit_24x24.png");
            this.imageList1.Images.SetKeyName(2, "Remove_24x24.png");
            this.imageList1.Images.SetKeyName(3, "Save_24x24.png");
            this.imageList1.Images.SetKeyName(4, "Redo_24x24.png");
            this.imageList1.Images.SetKeyName(5, "Search_24x24.png");
            this.imageList1.Images.SetKeyName(6, "msexcel1_cameleonhelp_software.png");
            this.imageList1.Images.SetKeyName(7, "Refresh_24x24.png");
            this.imageList1.Images.SetKeyName(8, "money.png");
            this.imageList1.Images.SetKeyName(9, "car.png");
            this.imageList1.Images.SetKeyName(10, "arrow_out.png");
            this.imageList1.Images.SetKeyName(11, "Check_24x24.png");
            // 
            // panelDieukhien
            // 
            this.panelDieukhien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDieukhien.Controls.Add(this.btnThutien);
            this.panelDieukhien.Controls.Add(this.btnXoa);
            this.panelDieukhien.Controls.Add(this.btnGiao);
            this.panelDieukhien.Controls.Add(this.btnXuat);
            this.panelDieukhien.Controls.Add(this.btnHuy);
            this.panelDieukhien.Controls.Add(this.btnCapnhat);
            this.panelDieukhien.Location = new System.Drawing.Point(4, 630);
            this.panelDieukhien.Name = "panelDieukhien";
            this.panelDieukhien.Size = new System.Drawing.Size(815, 45);
            this.panelDieukhien.TabIndex = 3;
            // 
            // btnThutien
            // 
            this.btnThutien.ImageIndex = 8;
            this.btnThutien.ImageList = this.imageList1;
            this.btnThutien.Location = new System.Drawing.Point(101, 6);
            this.btnThutien.Name = "btnThutien";
            this.btnThutien.Size = new System.Drawing.Size(82, 34);
            this.btnThutien.TabIndex = 1;
            this.btnThutien.Text = "Thu tiền";
            this.btnThutien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThutien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThutien.UseVisualStyleBackColor = true;
            this.btnThutien.Click += new System.EventHandler(this.btnThutien_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageIndex = 2;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(13, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 34);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Hủy";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGiao
            // 
            this.btnGiao.ImageIndex = 9;
            this.btnGiao.ImageList = this.imageList1;
            this.btnGiao.Location = new System.Drawing.Point(277, 6);
            this.btnGiao.Name = "btnGiao";
            this.btnGiao.Size = new System.Drawing.Size(82, 34);
            this.btnGiao.TabIndex = 3;
            this.btnGiao.Text = "Giao";
            this.btnGiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiao.UseVisualStyleBackColor = true;
            this.btnGiao.Click += new System.EventHandler(this.btnGiao_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.ImageIndex = 10;
            this.btnXuat.ImageList = this.imageList1;
            this.btnXuat.Location = new System.Drawing.Point(189, 6);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(82, 34);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHuy.ImageIndex = 7;
            this.btnHuy.ImageList = this.imageList1;
            this.btnHuy.Location = new System.Drawing.Point(721, 6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 34);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy thao tác";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCapnhat.ImageIndex = 3;
            this.btnCapnhat.ImageList = this.imageList1;
            this.btnCapnhat.Location = new System.Drawing.Point(633, 6);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(82, 34);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapnhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // grvOrderdetail
            // 
            this.grvOrderdetail.AllowUserToAddRows = false;
            this.grvOrderdetail.AllowUserToDeleteRows = false;
            this.grvOrderdetail.AllowUserToResizeRows = false;
            this.grvOrderdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grvOrderdetail.BackgroundColor = System.Drawing.Color.White;
            this.grvOrderdetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrderdetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvOrderdetail.ColumnHeadersHeight = 35;
            this.grvOrderdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderDetail_ProductID,
            this.colProduct_Name,
            this.colColor_Name,
            this.colPriceType,
            this.colOrderDetail_Quantity,
            this.colOrderDetail_Price,
            this.colOrderDetail_Sale,
            this.colOrderDetail_Total,
            this.colFlat,
            this.colOrderDetail_OrderID,
            this.OrderDetail_QuantityOld});
            this.grvOrderdetail.ContextMenuStrip = this.contextMenuStrip1;
            this.grvOrderdetail.EnableHeadersVisualStyles = false;
            this.grvOrderdetail.Location = new System.Drawing.Point(4, 170);
            this.grvOrderdetail.MultiSelect = false;
            this.grvOrderdetail.Name = "grvOrderdetail";
            this.grvOrderdetail.RowHeadersVisible = false;
            this.grvOrderdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grvOrderdetail.Size = new System.Drawing.Size(815, 374);
            this.grvOrderdetail.TabIndex = 4;
            this.grvOrderdetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOrderdetail_CellEndEdit);
            this.grvOrderdetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grvOrderdetail_CellValidating);
            this.grvOrderdetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grvOrderdetail_DataError);
            this.grvOrderdetail.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grvOrderdetail_RowPrePaint);
            // 
            // colOrderDetail_ProductID
            // 
            this.colOrderDetail_ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderDetail_ProductID.DataPropertyName = "OrderDetail_ProductID";
            this.colOrderDetail_ProductID.FillWeight = 49.84961F;
            this.colOrderDetail_ProductID.Frozen = true;
            this.colOrderDetail_ProductID.HeaderText = "Mã sản phẩm";
            this.colOrderDetail_ProductID.Name = "colOrderDetail_ProductID";
            this.colOrderDetail_ProductID.ReadOnly = true;
            this.colOrderDetail_ProductID.Width = 90;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProduct_Name.DataPropertyName = "Product_Name";
            this.colProduct_Name.FillWeight = 717.259F;
            this.colProduct_Name.Frozen = true;
            this.colProduct_Name.HeaderText = "Tên sản phẩm";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.ReadOnly = true;
            this.colProduct_Name.Width = 230;
            // 
            // colColor_Name
            // 
            this.colColor_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colColor_Name.DataPropertyName = "Color_Name";
            this.colColor_Name.FillWeight = 10.64652F;
            this.colColor_Name.Frozen = true;
            this.colColor_Name.HeaderText = "Màu sắc";
            this.colColor_Name.Name = "colColor_Name";
            this.colColor_Name.ReadOnly = true;
            this.colColor_Name.Width = 60;
            // 
            // colPriceType
            // 
            this.colPriceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPriceType.DataPropertyName = "OrderDetail_PriceType";
            this.colPriceType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colPriceType.Frozen = true;
            this.colPriceType.HeaderText = "Loại giá";
            this.colPriceType.Name = "colPriceType";
            this.colPriceType.Width = 110;
            // 
            // colOrderDetail_Quantity
            // 
            this.colOrderDetail_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderDetail_Quantity.DataPropertyName = "OrderDetail_Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.colOrderDetail_Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOrderDetail_Quantity.FillWeight = 10.64652F;
            this.colOrderDetail_Quantity.Frozen = true;
            this.colOrderDetail_Quantity.HeaderText = "Số lượng";
            this.colOrderDetail_Quantity.MaxInputLength = 10;
            this.colOrderDetail_Quantity.Name = "colOrderDetail_Quantity";
            this.colOrderDetail_Quantity.Width = 50;
            // 
            // colOrderDetail_Price
            // 
            this.colOrderDetail_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderDetail_Price.DataPropertyName = "OrderDetail_Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.colOrderDetail_Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.colOrderDetail_Price.FillWeight = 10.64652F;
            this.colOrderDetail_Price.Frozen = true;
            this.colOrderDetail_Price.HeaderText = "Đơn giá";
            this.colOrderDetail_Price.MaxInputLength = 10;
            this.colOrderDetail_Price.Name = "colOrderDetail_Price";
            this.colOrderDetail_Price.Width = 90;
            // 
            // colOrderDetail_Sale
            // 
            this.colOrderDetail_Sale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderDetail_Sale.DataPropertyName = "OrderDetail_Sale";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.colOrderDetail_Sale.DefaultCellStyle = dataGridViewCellStyle4;
            this.colOrderDetail_Sale.FillWeight = 10.64652F;
            this.colOrderDetail_Sale.HeaderText = "Chiết khấu";
            this.colOrderDetail_Sale.MaxInputLength = 10;
            this.colOrderDetail_Sale.Name = "colOrderDetail_Sale";
            this.colOrderDetail_Sale.Width = 90;
            // 
            // colOrderDetail_Total
            // 
            this.colOrderDetail_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderDetail_Total.DataPropertyName = "OrderDetail_Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.colOrderDetail_Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.colOrderDetail_Total.FillWeight = 10.64652F;
            this.colOrderDetail_Total.HeaderText = "Thành tiền";
            this.colOrderDetail_Total.MaxInputLength = 10;
            this.colOrderDetail_Total.Name = "colOrderDetail_Total";
            this.colOrderDetail_Total.ReadOnly = true;
            this.colOrderDetail_Total.Width = 90;
            // 
            // colFlat
            // 
            this.colFlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFlat.DataPropertyName = "Flat";
            this.colFlat.HeaderText = "Flat";
            this.colFlat.Name = "colFlat";
            this.colFlat.Visible = false;
            // 
            // colOrderDetail_OrderID
            // 
            this.colOrderDetail_OrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderDetail_OrderID.DataPropertyName = "OrderDetail_OrderID";
            this.colOrderDetail_OrderID.HeaderText = "OrderDetail_OrderID";
            this.colOrderDetail_OrderID.Name = "colOrderDetail_OrderID";
            this.colOrderDetail_OrderID.Visible = false;
            // 
            // OrderDetail_QuantityOld
            // 
            this.OrderDetail_QuantityOld.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OrderDetail_QuantityOld.DataPropertyName = "OrderDetail_QuantityOld";
            this.OrderDetail_QuantityOld.HeaderText = "OrderDetail_QuantityOld";
            this.OrderDetail_QuantityOld.Name = "OrderDetail_QuantityOld";
            this.OrderDetail_QuantityOld.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolXoa
            // 
            this.toolXoa.Name = "toolXoa";
            this.toolXoa.Size = new System.Drawing.Size(94, 22);
            this.toolXoa.Text = "Xóa";
            this.toolXoa.Click += new System.EventHandler(this.toolXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteCustomer);
            this.groupBox1.Controls.Add(this.txtCustomer_Address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSeachKH);
            this.groupBox1.Controls.Add(this.txtCustomer_Zalo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCustomer_Facbook);
            this.groupBox1.Controls.Add(this.Facbook);
            this.groupBox1.Controls.Add(this.txtCustomer_Email);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCustomer_Phone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomer_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustomer_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.ImageIndex = 2;
            this.btnDeleteCustomer.ImageList = this.imageList1;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(228, 13);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(31, 28);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txtCustomer_Address
            // 
            this.txtCustomer_Address.Location = new System.Drawing.Point(83, 70);
            this.txtCustomer_Address.MaxLength = 499;
            this.txtCustomer_Address.Multiline = true;
            this.txtCustomer_Address.Name = "txtCustomer_Address";
            this.txtCustomer_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomer_Address.Size = new System.Drawing.Size(720, 34);
            this.txtCustomer_Address.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa chỉ:";
            // 
            // btnSeachKH
            // 
            this.btnSeachKH.ImageIndex = 5;
            this.btnSeachKH.ImageList = this.imageList1;
            this.btnSeachKH.Location = new System.Drawing.Point(195, 13);
            this.btnSeachKH.Name = "btnSeachKH";
            this.btnSeachKH.Size = new System.Drawing.Size(31, 28);
            this.btnSeachKH.TabIndex = 1;
            this.btnSeachKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeachKH.UseVisualStyleBackColor = true;
            this.btnSeachKH.Click += new System.EventHandler(this.btnSeachKH_Click);
            // 
            // txtCustomer_Zalo
            // 
            this.txtCustomer_Zalo.Location = new System.Drawing.Point(288, 44);
            this.txtCustomer_Zalo.MaxLength = 249;
            this.txtCustomer_Zalo.Name = "txtCustomer_Zalo";
            this.txtCustomer_Zalo.Size = new System.Drawing.Size(165, 20);
            this.txtCustomer_Zalo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Zalo:";
            // 
            // txtCustomer_Facbook
            // 
            this.txtCustomer_Facbook.Location = new System.Drawing.Point(83, 44);
            this.txtCustomer_Facbook.MaxLength = 249;
            this.txtCustomer_Facbook.Name = "txtCustomer_Facbook";
            this.txtCustomer_Facbook.Size = new System.Drawing.Size(165, 20);
            this.txtCustomer_Facbook.TabIndex = 5;
            // 
            // Facbook
            // 
            this.Facbook.AutoSize = true;
            this.Facbook.Location = new System.Drawing.Point(13, 48);
            this.Facbook.Name = "Facbook";
            this.Facbook.Size = new System.Drawing.Size(52, 13);
            this.Facbook.TabIndex = 13;
            this.Facbook.Text = "Facbook:";
            // 
            // txtCustomer_Email
            // 
            this.txtCustomer_Email.Location = new System.Drawing.Point(512, 44);
            this.txtCustomer_Email.MaxLength = 249;
            this.txtCustomer_Email.Name = "txtCustomer_Email";
            this.txtCustomer_Email.Size = new System.Drawing.Size(291, 20);
            this.txtCustomer_Email.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // txtCustomer_Phone
            // 
            this.txtCustomer_Phone.Location = new System.Drawing.Point(329, 18);
            this.txtCustomer_Phone.MaxLength = 19;
            this.txtCustomer_Phone.Name = "txtCustomer_Phone";
            this.txtCustomer_Phone.Size = new System.Drawing.Size(124, 20);
            this.txtCustomer_Phone.TabIndex = 3;
            this.txtCustomer_Phone.Leave += new System.EventHandler(this.txtCustomer_Phone_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Điện thoại:";
            // 
            // txtCustomer_Name
            // 
            this.txtCustomer_Name.Location = new System.Drawing.Point(512, 18);
            this.txtCustomer_Name.MaxLength = 49;
            this.txtCustomer_Name.Name = "txtCustomer_Name";
            this.txtCustomer_Name.Size = new System.Drawing.Size(291, 20);
            this.txtCustomer_Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên KH:";
            // 
            // txtCustomer_ID
            // 
            this.txtCustomer_ID.Enabled = false;
            this.txtCustomer_ID.Location = new System.Drawing.Point(83, 18);
            this.txtCustomer_ID.MaxLength = 49;
            this.txtCustomer_ID.Name = "txtCustomer_ID";
            this.txtCustomer_ID.ReadOnly = true;
            this.txtCustomer_ID.Size = new System.Drawing.Size(106, 20);
            this.txtCustomer_ID.TabIndex = 0;
            this.txtCustomer_ID.TextChanged += new System.EventHandler(this.txtCustomer_ID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã KH:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpOrder_Date);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cdkOrder_IsSend);
            this.groupBox2.Controls.Add(this.chkOrder_IsOutput);
            this.groupBox2.Controls.Add(this.chkOrder_IsVoucher);
            this.groupBox2.Location = new System.Drawing.Point(4, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtpOrder_Date
            // 
            this.dtpOrder_Date.CustomFormat = "dd/MM/yyyyy";
            this.dtpOrder_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrder_Date.Location = new System.Drawing.Point(83, 16);
            this.dtpOrder_Date.Name = "dtpOrder_Date";
            this.dtpOrder_Date.Size = new System.Drawing.Size(157, 20);
            this.dtpOrder_Date.TabIndex = 0;
            this.dtpOrder_Date.Value = new System.DateTime(2016, 6, 27, 22, 30, 31, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ngày bán:";
            // 
            // cdkOrder_IsSend
            // 
            this.cdkOrder_IsSend.AutoSize = true;
            this.cdkOrder_IsSend.Enabled = false;
            this.cdkOrder_IsSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdkOrder_IsSend.ForeColor = System.Drawing.Color.Red;
            this.cdkOrder_IsSend.Location = new System.Drawing.Point(709, 18);
            this.cdkOrder_IsSend.Name = "cdkOrder_IsSend";
            this.cdkOrder_IsSend.Size = new System.Drawing.Size(102, 17);
            this.cdkOrder_IsSend.TabIndex = 3;
            this.cdkOrder_IsSend.Text = "Đã giao hàng";
            this.cdkOrder_IsSend.UseVisualStyleBackColor = true;
            // 
            // chkOrder_IsOutput
            // 
            this.chkOrder_IsOutput.AutoSize = true;
            this.chkOrder_IsOutput.Enabled = false;
            this.chkOrder_IsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrder_IsOutput.ForeColor = System.Drawing.Color.Red;
            this.chkOrder_IsOutput.Location = new System.Drawing.Point(604, 18);
            this.chkOrder_IsOutput.Name = "chkOrder_IsOutput";
            this.chkOrder_IsOutput.Size = new System.Drawing.Size(102, 17);
            this.chkOrder_IsOutput.TabIndex = 2;
            this.chkOrder_IsOutput.Text = "Đã xuất hàng";
            this.chkOrder_IsOutput.UseVisualStyleBackColor = true;
            // 
            // chkOrder_IsVoucher
            // 
            this.chkOrder_IsVoucher.AutoSize = true;
            this.chkOrder_IsVoucher.Enabled = false;
            this.chkOrder_IsVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrder_IsVoucher.ForeColor = System.Drawing.Color.Red;
            this.chkOrder_IsVoucher.Location = new System.Drawing.Point(512, 18);
            this.chkOrder_IsVoucher.Name = "chkOrder_IsVoucher";
            this.chkOrder_IsVoucher.Size = new System.Drawing.Size(89, 17);
            this.chkOrder_IsVoucher.TabIndex = 1;
            this.chkOrder_IsVoucher.Text = "Đã thu tiền";
            this.chkOrder_IsVoucher.UseVisualStyleBackColor = true;
            // 
            // groupThongtin
            // 
            this.groupThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupThongtin.Controls.Add(this.txtOrder_Description);
            this.groupThongtin.Controls.Add(this.label12);
            this.groupThongtin.Controls.Add(this.txtOrder_TotalVAT);
            this.groupThongtin.Controls.Add(this.label11);
            this.groupThongtin.Controls.Add(this.txtOrder_SaleMoney);
            this.groupThongtin.Controls.Add(this.label10);
            this.groupThongtin.Controls.Add(this.txtOrder_VAT);
            this.groupThongtin.Controls.Add(this.label9);
            this.groupThongtin.Controls.Add(this.txtOrder_SendMoney);
            this.groupThongtin.Controls.Add(this.label6);
            this.groupThongtin.Controls.Add(this.cboOrder_SendType);
            this.groupThongtin.Controls.Add(this.label4);
            this.groupThongtin.Location = new System.Drawing.Point(4, 550);
            this.groupThongtin.Name = "groupThongtin";
            this.groupThongtin.Size = new System.Drawing.Size(815, 80);
            this.groupThongtin.TabIndex = 2;
            this.groupThongtin.TabStop = false;
            this.groupThongtin.Text = "Thông tin đơn hàng";
            // 
            // txtOrder_Description
            // 
            this.txtOrder_Description.Location = new System.Drawing.Point(72, 17);
            this.txtOrder_Description.MaxLength = 499;
            this.txtOrder_Description.Multiline = true;
            this.txtOrder_Description.Name = "txtOrder_Description";
            this.txtOrder_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrder_Description.Size = new System.Drawing.Size(229, 51);
            this.txtOrder_Description.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ghi chú:";
            // 
            // txtOrder_TotalVAT
            // 
            this.txtOrder_TotalVAT.BackColor = System.Drawing.SystemColors.Info;
            this.txtOrder_TotalVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrder_TotalVAT.ForeColor = System.Drawing.Color.Red;
            this.txtOrder_TotalVAT.Location = new System.Drawing.Point(646, 43);
            this.txtOrder_TotalVAT.MaxLength = 19;
            this.txtOrder_TotalVAT.Multiline = true;
            this.txtOrder_TotalVAT.Name = "txtOrder_TotalVAT";
            this.txtOrder_TotalVAT.ReadOnly = true;
            this.txtOrder_TotalVAT.Size = new System.Drawing.Size(157, 30);
            this.txtOrder_TotalVAT.TabIndex = 11;
            this.txtOrder_TotalVAT.Text = "0";
            this.txtOrder_TotalVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(585, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tổng tiền:";
            // 
            // txtOrder_SaleMoney
            // 
            this.txtOrder_SaleMoney.Location = new System.Drawing.Point(646, 17);
            this.txtOrder_SaleMoney.MaxLength = 19;
            this.txtOrder_SaleMoney.Name = "txtOrder_SaleMoney";
            this.txtOrder_SaleMoney.Size = new System.Drawing.Size(157, 20);
            this.txtOrder_SaleMoney.TabIndex = 3;
            this.txtOrder_SaleMoney.Text = "0";
            this.txtOrder_SaleMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrder_SaleMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrder_SaleMoney_KeyPress);
            this.txtOrder_SaleMoney.Leave += new System.EventHandler(this.txtOrder_SaleMoney_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Giảm giá:";
            // 
            // txtOrder_VAT
            // 
            this.txtOrder_VAT.Location = new System.Drawing.Point(493, 48);
            this.txtOrder_VAT.MaxLength = 19;
            this.txtOrder_VAT.Name = "txtOrder_VAT";
            this.txtOrder_VAT.Size = new System.Drawing.Size(86, 20);
            this.txtOrder_VAT.TabIndex = 1;
            this.txtOrder_VAT.Text = "0";
            this.txtOrder_VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrder_VAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrder_VAT_KeyPress);
            this.txtOrder_VAT.Leave += new System.EventHandler(this.txtOrder_VAT_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "VAT:";
            // 
            // txtOrder_SendMoney
            // 
            this.txtOrder_SendMoney.Location = new System.Drawing.Point(364, 48);
            this.txtOrder_SendMoney.MaxLength = 19;
            this.txtOrder_SendMoney.Name = "txtOrder_SendMoney";
            this.txtOrder_SendMoney.Size = new System.Drawing.Size(86, 20);
            this.txtOrder_SendMoney.TabIndex = 2;
            this.txtOrder_SendMoney.Text = "0";
            this.txtOrder_SendMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrder_SendMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrder_SendMoney_KeyPress);
            this.txtOrder_SendMoney.Leave += new System.EventHandler(this.txtOrder_SendMoney_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phí giao:";
            // 
            // cboOrder_SendType
            // 
            this.cboOrder_SendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrder_SendType.FormattingEnabled = true;
            this.cboOrder_SendType.Location = new System.Drawing.Point(364, 17);
            this.cboOrder_SendType.Name = "cboOrder_SendType";
            this.cboOrder_SendType.Size = new System.Drawing.Size(215, 21);
            this.cboOrder_SendType.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gửi:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectProduct);
            this.splitContainer1.Panel1.Controls.Add(this.ucProductsSelect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grvOrderdetail);
            this.splitContainer1.Panel2.Controls.Add(this.panelDieukhien);
            this.splitContainer1.Panel2.Controls.Add(this.groupThongtin);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1244, 680);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectProduct.ImageIndex = 11;
            this.btnSelectProduct.ImageList = this.imageList1;
            this.btnSelectProduct.Location = new System.Drawing.Point(376, 321);
            this.btnSelectProduct.Name = "btnSelectProduct";
            this.btnSelectProduct.Size = new System.Drawing.Size(41, 38);
            this.btnSelectProduct.TabIndex = 19;
            this.btnSelectProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectProduct.UseVisualStyleBackColor = true;
            this.btnSelectProduct.Click += new System.EventHandler(this.btnSelectProduct_Click);
            // 
            // ucProductsSelect
            // 
            this.ucProductsSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductsSelect.IsQuantity = -1;
            this.ucProductsSelect.LisProducts = ((System.Collections.Generic.List<string>)(resources.GetObject("ucProductsSelect.LisProducts")));
            this.ucProductsSelect.Location = new System.Drawing.Point(3, 6);
            this.ucProductsSelect.Name = "ucProductsSelect";
            this.ucProductsSelect.Size = new System.Drawing.Size(368, 669);
            this.ucProductsSelect.TabIndex = 0;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panelDieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrderdetail)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupThongtin.ResumeLayout(false);
            this.groupThongtin.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThutien;
        private System.Windows.Forms.Panel panelDieukhien;
        private System.Windows.Forms.DataGridView grvOrderdetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomer_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomer_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomer_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomer_Facbook;
        private System.Windows.Forms.Label Facbook;
        private System.Windows.Forms.TextBox txtCustomer_Zalo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomer_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGiao;
        private System.Windows.Forms.CheckBox cdkOrder_IsSend;
        private System.Windows.Forms.CheckBox chkOrder_IsOutput;
        private System.Windows.Forms.CheckBox chkOrder_IsVoucher;
        private System.Windows.Forms.Button btnSeachKH;
        private System.Windows.Forms.GroupBox groupThongtin;
        private System.Windows.Forms.ComboBox cboOrder_SendType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrder_TotalVAT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOrder_SaleMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrder_VAT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrder_SendMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrder_Description;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSelectProduct;
        private UCProducts ucProductsSelect;
        private System.Windows.Forms.DateTimePicker dtpOrder_Date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDetail_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPriceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDetail_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDetail_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDetail_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDetail_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDetail_OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetail_QuantityOld;
    }
}