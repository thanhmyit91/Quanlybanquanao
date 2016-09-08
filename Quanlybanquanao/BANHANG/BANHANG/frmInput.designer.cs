namespace BANHANG
{
    partial class frmInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInput));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelDieukhien = new System.Windows.Forms.Panel();
            this.btnThutien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.grvInputdetail = new System.Windows.Forms.DataGridView();
            this.colInputDetail_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputDetail_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputDetail_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputDetail_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputDetail_InputID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputDetail_QuantityOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtpInput_Date = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.chkInput_IsVoucher = new System.Windows.Forms.CheckBox();
            this.groupThongtin = new System.Windows.Forms.GroupBox();
            this.txtInput_Description = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInput_TotalVAT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInput_SaleMoney = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInput_VAT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSelectProduct = new System.Windows.Forms.Button();
            this.ucProductsSelect = new BANHANG.UCProducts();
            this.panelDieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvInputdetail)).BeginInit();
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
            this.panelDieukhien.Controls.Add(this.btnHuy);
            this.panelDieukhien.Controls.Add(this.btnCapnhat);
            this.panelDieukhien.Location = new System.Drawing.Point(4, 630);
            this.panelDieukhien.Name = "panelDieukhien";
            this.panelDieukhien.Size = new System.Drawing.Size(759, 45);
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
            this.btnThutien.Text = "Chi tiền";
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
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHuy.ImageIndex = 7;
            this.btnHuy.ImageList = this.imageList1;
            this.btnHuy.Location = new System.Drawing.Point(665, 6);
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
            this.btnCapnhat.Location = new System.Drawing.Point(577, 6);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(82, 34);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapnhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // grvInputdetail
            // 
            this.grvInputdetail.AllowUserToAddRows = false;
            this.grvInputdetail.AllowUserToDeleteRows = false;
            this.grvInputdetail.AllowUserToResizeRows = false;
            this.grvInputdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grvInputdetail.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvInputdetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvInputdetail.ColumnHeadersHeight = 35;
            this.grvInputdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInputDetail_ProductID,
            this.colProduct_Name,
            this.colColor_Name,
            this.colInputDetail_Quantity,
            this.colInputDetail_Price,
            this.colInputDetail_Total,
            this.colFlat,
            this.colInputDetail_InputID,
            this.InputDetail_QuantityOld});
            this.grvInputdetail.ContextMenuStrip = this.contextMenuStrip1;
            this.grvInputdetail.EnableHeadersVisualStyles = false;
            this.grvInputdetail.Location = new System.Drawing.Point(4, 202);
            this.grvInputdetail.MultiSelect = false;
            this.grvInputdetail.Name = "grvInputdetail";
            this.grvInputdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvInputdetail.Size = new System.Drawing.Size(759, 347);
            this.grvInputdetail.TabIndex = 4;
            this.grvInputdetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvInputdetail_CellEndEdit);
            this.grvInputdetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grvInputdetail_CellValidating);
            this.grvInputdetail.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grvInputdetail_RowPrePaint);
            // 
            // colInputDetail_ProductID
            // 
            this.colInputDetail_ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInputDetail_ProductID.DataPropertyName = "InputDetail_ProductID";
            this.colInputDetail_ProductID.FillWeight = 49.84961F;
            this.colInputDetail_ProductID.HeaderText = "Mã sản phẩm";
            this.colInputDetail_ProductID.Name = "colInputDetail_ProductID";
            this.colInputDetail_ProductID.ReadOnly = true;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProduct_Name.DataPropertyName = "Product_Name";
            this.colProduct_Name.FillWeight = 717.259F;
            this.colProduct_Name.HeaderText = "Tên sản phẩm";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.ReadOnly = true;
            this.colProduct_Name.Width = 250;
            // 
            // colColor_Name
            // 
            this.colColor_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colColor_Name.DataPropertyName = "Color_Name";
            this.colColor_Name.FillWeight = 10.64652F;
            this.colColor_Name.HeaderText = "Màu sắc";
            this.colColor_Name.Name = "colColor_Name";
            this.colColor_Name.ReadOnly = true;
            this.colColor_Name.Width = 70;
            // 
            // colInputDetail_Quantity
            // 
            this.colInputDetail_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInputDetail_Quantity.DataPropertyName = "InputDetail_Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.colInputDetail_Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.colInputDetail_Quantity.FillWeight = 10.64652F;
            this.colInputDetail_Quantity.HeaderText = "Số lượng";
            this.colInputDetail_Quantity.Name = "colInputDetail_Quantity";
            this.colInputDetail_Quantity.Width = 65;
            // 
            // colInputDetail_Price
            // 
            this.colInputDetail_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInputDetail_Price.DataPropertyName = "InputDetail_Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.colInputDetail_Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.colInputDetail_Price.FillWeight = 10.64652F;
            this.colInputDetail_Price.HeaderText = "Đơn giá";
            this.colInputDetail_Price.Name = "colInputDetail_Price";
            // 
            // colInputDetail_Total
            // 
            this.colInputDetail_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInputDetail_Total.DataPropertyName = "InputDetail_Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.colInputDetail_Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.colInputDetail_Total.FillWeight = 10.64652F;
            this.colInputDetail_Total.HeaderText = "Thành tiền";
            this.colInputDetail_Total.Name = "colInputDetail_Total";
            this.colInputDetail_Total.ReadOnly = true;
            // 
            // colFlat
            // 
            this.colFlat.DataPropertyName = "Flat";
            this.colFlat.HeaderText = "Flat";
            this.colFlat.Name = "colFlat";
            this.colFlat.Visible = false;
            // 
            // colInputDetail_InputID
            // 
            this.colInputDetail_InputID.DataPropertyName = "InputDetail_InputID";
            this.colInputDetail_InputID.HeaderText = "InputDetail_InputID";
            this.colInputDetail_InputID.Name = "colInputDetail_InputID";
            this.colInputDetail_InputID.Visible = false;
            // 
            // InputDetail_QuantityOld
            // 
            this.InputDetail_QuantityOld.DataPropertyName = "InputDetail_QuantityOld";
            this.InputDetail_QuantityOld.HeaderText = "InputDetail_QuantityOld";
            this.InputDetail_QuantityOld.Name = "InputDetail_QuantityOld";
            this.InputDetail_QuantityOld.Visible = false;
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
            this.groupBox1.Size = new System.Drawing.Size(759, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.ImageIndex = 2;
            this.btnDeleteCustomer.ImageList = this.imageList1;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(211, 14);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(31, 28);
            this.btnDeleteCustomer.TabIndex = 19;
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txtCustomer_Address
            // 
            this.txtCustomer_Address.Location = new System.Drawing.Point(83, 97);
            this.txtCustomer_Address.MaxLength = 499;
            this.txtCustomer_Address.Multiline = true;
            this.txtCustomer_Address.Name = "txtCustomer_Address";
            this.txtCustomer_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomer_Address.Size = new System.Drawing.Size(664, 34);
            this.txtCustomer_Address.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa chỉ:";
            // 
            // btnSeachKH
            // 
            this.btnSeachKH.ImageIndex = 5;
            this.btnSeachKH.ImageList = this.imageList1;
            this.btnSeachKH.Location = new System.Drawing.Point(178, 14);
            this.btnSeachKH.Name = "btnSeachKH";
            this.btnSeachKH.Size = new System.Drawing.Size(31, 28);
            this.btnSeachKH.TabIndex = 1;
            this.btnSeachKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeachKH.UseVisualStyleBackColor = true;
            this.btnSeachKH.Click += new System.EventHandler(this.btnSeachKH_Click);
            // 
            // txtCustomer_Zalo
            // 
            this.txtCustomer_Zalo.Location = new System.Drawing.Point(435, 70);
            this.txtCustomer_Zalo.MaxLength = 249;
            this.txtCustomer_Zalo.Name = "txtCustomer_Zalo";
            this.txtCustomer_Zalo.Size = new System.Drawing.Size(312, 20);
            this.txtCustomer_Zalo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Zalo:";
            // 
            // txtCustomer_Facbook
            // 
            this.txtCustomer_Facbook.Location = new System.Drawing.Point(83, 70);
            this.txtCustomer_Facbook.MaxLength = 249;
            this.txtCustomer_Facbook.Name = "txtCustomer_Facbook";
            this.txtCustomer_Facbook.Size = new System.Drawing.Size(312, 20);
            this.txtCustomer_Facbook.TabIndex = 3;
            // 
            // Facbook
            // 
            this.Facbook.AutoSize = true;
            this.Facbook.Location = new System.Drawing.Point(13, 74);
            this.Facbook.Name = "Facbook";
            this.Facbook.Size = new System.Drawing.Size(52, 13);
            this.Facbook.TabIndex = 13;
            this.Facbook.Text = "Facbook:";
            // 
            // txtCustomer_Email
            // 
            this.txtCustomer_Email.Location = new System.Drawing.Point(307, 44);
            this.txtCustomer_Email.MaxLength = 249;
            this.txtCustomer_Email.Name = "txtCustomer_Email";
            this.txtCustomer_Email.Size = new System.Drawing.Size(440, 20);
            this.txtCustomer_Email.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // txtCustomer_Phone
            // 
            this.txtCustomer_Phone.Location = new System.Drawing.Point(83, 44);
            this.txtCustomer_Phone.MaxLength = 19;
            this.txtCustomer_Phone.Name = "txtCustomer_Phone";
            this.txtCustomer_Phone.Size = new System.Drawing.Size(159, 20);
            this.txtCustomer_Phone.TabIndex = 1;
            this.txtCustomer_Phone.Leave += new System.EventHandler(this.txtCustomer_Phone_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Điện thoại:";
            // 
            // txtCustomer_Name
            // 
            this.txtCustomer_Name.Location = new System.Drawing.Point(307, 18);
            this.txtCustomer_Name.MaxLength = 49;
            this.txtCustomer_Name.Name = "txtCustomer_Name";
            this.txtCustomer_Name.Size = new System.Drawing.Size(440, 20);
            this.txtCustomer_Name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên NCC:";
            // 
            // txtCustomer_ID
            // 
            this.txtCustomer_ID.Enabled = false;
            this.txtCustomer_ID.Location = new System.Drawing.Point(83, 18);
            this.txtCustomer_ID.MaxLength = 49;
            this.txtCustomer_ID.Name = "txtCustomer_ID";
            this.txtCustomer_ID.ReadOnly = true;
            this.txtCustomer_ID.Size = new System.Drawing.Size(89, 20);
            this.txtCustomer_ID.TabIndex = 5;
            this.txtCustomer_ID.TextChanged += new System.EventHandler(this.txtCustomer_ID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã NCC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpInput_Date);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.chkInput_IsVoucher);
            this.groupBox2.Location = new System.Drawing.Point(4, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtpInput_Date
            // 
            this.dtpInput_Date.CustomFormat = "dd/MM/yyyyy";
            this.dtpInput_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInput_Date.Location = new System.Drawing.Point(83, 15);
            this.dtpInput_Date.Name = "dtpInput_Date";
            this.dtpInput_Date.Size = new System.Drawing.Size(157, 20);
            this.dtpInput_Date.TabIndex = 23;
            this.dtpInput_Date.Value = new System.DateTime(2016, 6, 27, 22, 30, 31, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ngày nhập:";
            // 
            // chkInput_IsVoucher
            // 
            this.chkInput_IsVoucher.AutoSize = true;
            this.chkInput_IsVoucher.Enabled = false;
            this.chkInput_IsVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInput_IsVoucher.ForeColor = System.Drawing.Color.Red;
            this.chkInput_IsVoucher.Location = new System.Drawing.Point(658, 17);
            this.chkInput_IsVoucher.Name = "chkInput_IsVoucher";
            this.chkInput_IsVoucher.Size = new System.Drawing.Size(88, 17);
            this.chkInput_IsVoucher.TabIndex = 12;
            this.chkInput_IsVoucher.Text = "Đã chi tiền";
            this.chkInput_IsVoucher.UseVisualStyleBackColor = true;
            // 
            // groupThongtin
            // 
            this.groupThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupThongtin.Controls.Add(this.txtInput_Description);
            this.groupThongtin.Controls.Add(this.label12);
            this.groupThongtin.Controls.Add(this.txtInput_TotalVAT);
            this.groupThongtin.Controls.Add(this.label11);
            this.groupThongtin.Controls.Add(this.txtInput_SaleMoney);
            this.groupThongtin.Controls.Add(this.label10);
            this.groupThongtin.Controls.Add(this.txtInput_VAT);
            this.groupThongtin.Controls.Add(this.label9);
            this.groupThongtin.Location = new System.Drawing.Point(4, 555);
            this.groupThongtin.Name = "groupThongtin";
            this.groupThongtin.Size = new System.Drawing.Size(759, 75);
            this.groupThongtin.TabIndex = 2;
            this.groupThongtin.TabStop = false;
            this.groupThongtin.Text = "Thông tin phiếu nhập";
            // 
            // txtInput_Description
            // 
            this.txtInput_Description.Location = new System.Drawing.Point(71, 19);
            this.txtInput_Description.MaxLength = 499;
            this.txtInput_Description.Multiline = true;
            this.txtInput_Description.Name = "txtInput_Description";
            this.txtInput_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput_Description.Size = new System.Drawing.Size(228, 48);
            this.txtInput_Description.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ghi chú:";
            // 
            // txtInput_TotalVAT
            // 
            this.txtInput_TotalVAT.BackColor = System.Drawing.SystemColors.Info;
            this.txtInput_TotalVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput_TotalVAT.ForeColor = System.Drawing.Color.Red;
            this.txtInput_TotalVAT.Location = new System.Drawing.Point(590, 16);
            this.txtInput_TotalVAT.MaxLength = 19;
            this.txtInput_TotalVAT.Multiline = true;
            this.txtInput_TotalVAT.Name = "txtInput_TotalVAT";
            this.txtInput_TotalVAT.ReadOnly = true;
            this.txtInput_TotalVAT.Size = new System.Drawing.Size(157, 48);
            this.txtInput_TotalVAT.TabIndex = 11;
            this.txtInput_TotalVAT.Text = "0";
            this.txtInput_TotalVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tổng tiền:";
            // 
            // txtInput_SaleMoney
            // 
            this.txtInput_SaleMoney.Location = new System.Drawing.Point(366, 44);
            this.txtInput_SaleMoney.MaxLength = 19;
            this.txtInput_SaleMoney.Name = "txtInput_SaleMoney";
            this.txtInput_SaleMoney.Size = new System.Drawing.Size(157, 20);
            this.txtInput_SaleMoney.TabIndex = 3;
            this.txtInput_SaleMoney.Text = "0";
            this.txtInput_SaleMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput_SaleMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_SaleMoney_KeyPress);
            this.txtInput_SaleMoney.Leave += new System.EventHandler(this.txtInput_SaleMoney_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Giảm giá:";
            // 
            // txtInput_VAT
            // 
            this.txtInput_VAT.Location = new System.Drawing.Point(366, 19);
            this.txtInput_VAT.MaxLength = 19;
            this.txtInput_VAT.Name = "txtInput_VAT";
            this.txtInput_VAT.Size = new System.Drawing.Size(157, 20);
            this.txtInput_VAT.TabIndex = 1;
            this.txtInput_VAT.Text = "0";
            this.txtInput_VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput_VAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_VAT_KeyPress);
            this.txtInput_VAT.Leave += new System.EventHandler(this.txtInput_VAT_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "VAT:";
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
            this.splitContainer1.Panel2.Controls.Add(this.grvInputdetail);
            this.splitContainer1.Panel2.Controls.Add(this.panelDieukhien);
            this.splitContainer1.Panel2.Controls.Add(this.groupThongtin);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1165, 680);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectProduct.ImageIndex = 11;
            this.btnSelectProduct.ImageList = this.imageList1;
            this.btnSelectProduct.Location = new System.Drawing.Point(351, 321);
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
            this.ucProductsSelect.Size = new System.Drawing.Size(343, 669);
            this.ucProductsSelect.TabIndex = 0;
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.frmInput_Load);
            this.panelDieukhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvInputdetail)).EndInit();
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
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThutien;
        private System.Windows.Forms.Panel panelDieukhien;
        private System.Windows.Forms.DataGridView grvInputdetail;
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
        private System.Windows.Forms.CheckBox chkInput_IsVoucher;
        private System.Windows.Forms.Button btnSeachKH;
        private System.Windows.Forms.GroupBox groupThongtin;
        private System.Windows.Forms.TextBox txtInput_TotalVAT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInput_SaleMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInput_VAT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInput_Description;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputDetail_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputDetail_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputDetail_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputDetail_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputDetail_InputID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputDetail_QuantityOld;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSelectProduct;
        private UCProducts ucProductsSelect;
        private System.Windows.Forms.DateTimePicker dtpInput_Date;
        private System.Windows.Forms.Label label14;
    }
}