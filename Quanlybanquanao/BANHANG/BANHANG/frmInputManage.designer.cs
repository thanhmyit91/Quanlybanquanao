﻿namespace BANHANG
{
    partial class frmInputManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelDanhsach = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDanhsach = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvDanhsach = new System.Windows.Forms.DataGridView();
            this.groupTimkiem = new System.Windows.Forms.GroupBox();
            this.dtpInput_DateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpInput_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.cboInput_SendType = new System.Windows.Forms.ComboBox();
            this.cboInput_IsVoucher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.chDaxoa = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInput_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInput_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInput_TotalVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInput_IsVoucher = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInput_VoucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInput_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDanhsach.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDanhsach.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhsach)).BeginInit();
            this.groupTimkiem.SuspendLayout();
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
            // 
            // panelDanhsach
            // 
            this.panelDanhsach.Controls.Add(this.tabControl1);
            this.panelDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhsach.Location = new System.Drawing.Point(0, 0);
            this.panelDanhsach.Name = "panelDanhsach";
            this.panelDanhsach.Size = new System.Drawing.Size(949, 577);
            this.panelDanhsach.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDanhsach);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDanhsach
            // 
            this.tabDanhsach.Controls.Add(this.panel1);
            this.tabDanhsach.Controls.Add(this.groupTimkiem);
            this.tabDanhsach.Location = new System.Drawing.Point(4, 22);
            this.tabDanhsach.Name = "tabDanhsach";
            this.tabDanhsach.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhsach.Size = new System.Drawing.Size(941, 551);
            this.tabDanhsach.TabIndex = 0;
            this.tabDanhsach.Text = "Danh sách";
            this.tabDanhsach.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grvDanhsach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 465);
            this.panel1.TabIndex = 7;
            // 
            // grvDanhsach
            // 
            this.grvDanhsach.AllowUserToAddRows = false;
            this.grvDanhsach.AllowUserToDeleteRows = false;
            this.grvDanhsach.AllowUserToResizeRows = false;
            this.grvDanhsach.BackgroundColor = System.Drawing.Color.White;
            this.grvDanhsach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDanhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvDanhsach.ColumnHeadersHeight = 35;
            this.grvDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colInput_ID,
            this.colInput_Date,
            this.colSupplier_Name,
            this.colSupplier_Phone,
            this.colInput_TotalVAT,
            this.colInput_IsVoucher,
            this.colInput_VoucherID,
            this.colInput_Description,
            this.colCreatedDate,
            this.CreatedBy,
            this.ModifiedDate,
            this.ModifiedBy});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDanhsach.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDanhsach.EnableHeadersVisualStyles = false;
            this.grvDanhsach.Location = new System.Drawing.Point(0, 0);
            this.grvDanhsach.MultiSelect = false;
            this.grvDanhsach.Name = "grvDanhsach";
            this.grvDanhsach.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDanhsach.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grvDanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDanhsach.Size = new System.Drawing.Size(935, 465);
            this.grvDanhsach.TabIndex = 3;
            this.grvDanhsach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDanhsach_CellDoubleClick);
            this.grvDanhsach.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grvDanhsach_RowPrePaint);
            // 
            // groupTimkiem
            // 
            this.groupTimkiem.Controls.Add(this.dtpInput_DateTo);
            this.groupTimkiem.Controls.Add(this.dtpInput_DateFrom);
            this.groupTimkiem.Controls.Add(this.cboInput_SendType);
            this.groupTimkiem.Controls.Add(this.cboInput_IsVoucher);
            this.groupTimkiem.Controls.Add(this.label1);
            this.groupTimkiem.Controls.Add(this.cboType);
            this.groupTimkiem.Controls.Add(this.label3);
            this.groupTimkiem.Controls.Add(this.btnExcel);
            this.groupTimkiem.Controls.Add(this.btnTimkiem);
            this.groupTimkiem.Controls.Add(this.chDaxoa);
            this.groupTimkiem.Controls.Add(this.label8);
            this.groupTimkiem.Controls.Add(this.txtTukhoa);
            this.groupTimkiem.Controls.Add(this.label7);
            this.groupTimkiem.Controls.Add(this.label4);
            this.groupTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTimkiem.Location = new System.Drawing.Point(3, 3);
            this.groupTimkiem.Name = "groupTimkiem";
            this.groupTimkiem.Size = new System.Drawing.Size(935, 80);
            this.groupTimkiem.TabIndex = 6;
            this.groupTimkiem.TabStop = false;
            this.groupTimkiem.Text = "Thông tin tìm kiếm";
            // 
            // dtpInput_DateTo
            // 
            this.dtpInput_DateTo.CustomFormat = "dd/MM/yyyyy";
            this.dtpInput_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInput_DateTo.Location = new System.Drawing.Point(301, 48);
            this.dtpInput_DateTo.Name = "dtpInput_DateTo";
            this.dtpInput_DateTo.Size = new System.Drawing.Size(164, 20);
            this.dtpInput_DateTo.TabIndex = 4;
            this.dtpInput_DateTo.Value = new System.DateTime(2016, 6, 27, 22, 30, 31, 0);
            // 
            // dtpInput_DateFrom
            // 
            this.dtpInput_DateFrom.CustomFormat = "dd/MM/yyyyy";
            this.dtpInput_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInput_DateFrom.Location = new System.Drawing.Point(63, 48);
            this.dtpInput_DateFrom.Name = "dtpInput_DateFrom";
            this.dtpInput_DateFrom.Size = new System.Drawing.Size(164, 20);
            this.dtpInput_DateFrom.TabIndex = 3;
            this.dtpInput_DateFrom.Value = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            // 
            // cboInput_SendType
            // 
            this.cboInput_SendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInput_SendType.FormattingEnabled = true;
            this.cboInput_SendType.Location = new System.Drawing.Point(582, 22);
            this.cboInput_SendType.Name = "cboInput_SendType";
            this.cboInput_SendType.Size = new System.Drawing.Size(0, 21);
            this.cboInput_SendType.TabIndex = 2;
            // 
            // cboInput_IsVoucher
            // 
            this.cboInput_IsVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInput_IsVoucher.FormattingEnabled = true;
            this.cboInput_IsVoucher.Location = new System.Drawing.Point(532, 22);
            this.cboInput_IsVoucher.Name = "cboInput_IsVoucher";
            this.cboInput_IsVoucher.Size = new System.Drawing.Size(164, 21);
            this.cboInput_IsVoucher.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Đã thu:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(301, 22);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(164, 21);
            this.cboType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tìm theo:";
            // 
            // btnExcel
            // 
            this.btnExcel.ImageIndex = 6;
            this.btnExcel.ImageList = this.imageList1;
            this.btnExcel.Location = new System.Drawing.Point(813, 22);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(105, 37);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.Text = "Xuất excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ImageIndex = 5;
            this.btnTimkiem.ImageList = this.imageList1;
            this.btnTimkiem.Location = new System.Drawing.Point(702, 22);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(105, 37);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // chDaxoa
            // 
            this.chDaxoa.AutoSize = true;
            this.chDaxoa.Location = new System.Drawing.Point(532, 50);
            this.chDaxoa.Name = "chDaxoa";
            this.chDaxoa.Size = new System.Drawing.Size(60, 17);
            this.chDaxoa.TabIndex = 8;
            this.chDaxoa.Text = "Đã xóa";
            this.chDaxoa.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Đến ngày:";
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(63, 22);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(164, 20);
            this.txtTukhoa.TabIndex = 0;
            this.txtTukhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTukhoa_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Từ ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Từ khóa: ";
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSTT.FillWeight = 26.46421F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 40;
            // 
            // colInput_ID
            // 
            this.colInput_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInput_ID.DataPropertyName = "Input_ID";
            this.colInput_ID.FillWeight = 49.84961F;
            this.colInput_ID.HeaderText = "Mã";
            this.colInput_ID.Name = "colInput_ID";
            this.colInput_ID.ReadOnly = true;
            // 
            // colInput_Date
            // 
            this.colInput_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInput_Date.DataPropertyName = "Input_Date";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.colInput_Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.colInput_Date.FillWeight = 717.259F;
            this.colInput_Date.HeaderText = "Ngày nhập";
            this.colInput_Date.Name = "colInput_Date";
            this.colInput_Date.ReadOnly = true;
            // 
            // colSupplier_Name
            // 
            this.colSupplier_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Name.DataPropertyName = "Supplier_Name";
            this.colSupplier_Name.FillWeight = 10.64652F;
            this.colSupplier_Name.HeaderText = "Tên NCC";
            this.colSupplier_Name.Name = "colSupplier_Name";
            this.colSupplier_Name.ReadOnly = true;
            this.colSupplier_Name.Width = 200;
            // 
            // colSupplier_Phone
            // 
            this.colSupplier_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Phone.DataPropertyName = "Supplier_Phone";
            this.colSupplier_Phone.FillWeight = 10.64652F;
            this.colSupplier_Phone.HeaderText = "Số điện thoại";
            this.colSupplier_Phone.Name = "colSupplier_Phone";
            this.colSupplier_Phone.ReadOnly = true;
            this.colSupplier_Phone.Width = 90;
            // 
            // colInput_TotalVAT
            // 
            this.colInput_TotalVAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInput_TotalVAT.DataPropertyName = "Input_TotalVAT";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colInput_TotalVAT.DefaultCellStyle = dataGridViewCellStyle3;
            this.colInput_TotalVAT.HeaderText = "Tổng tiền";
            this.colInput_TotalVAT.Name = "colInput_TotalVAT";
            this.colInput_TotalVAT.ReadOnly = true;
            this.colInput_TotalVAT.Width = 70;
            // 
            // colInput_IsVoucher
            // 
            this.colInput_IsVoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInput_IsVoucher.DataPropertyName = "Input_IsVoucher";
            this.colInput_IsVoucher.FalseValue = "0";
            this.colInput_IsVoucher.HeaderText = "Đã thu";
            this.colInput_IsVoucher.Name = "colInput_IsVoucher";
            this.colInput_IsVoucher.ReadOnly = true;
            this.colInput_IsVoucher.Width = 60;
            // 
            // colInput_VoucherID
            // 
            this.colInput_VoucherID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInput_VoucherID.DataPropertyName = "Input_VoucherID";
            this.colInput_VoucherID.HeaderText = "Phiếu thu";
            this.colInput_VoucherID.Name = "colInput_VoucherID";
            this.colInput_VoucherID.ReadOnly = true;
            // 
            // colInput_Description
            // 
            this.colInput_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInput_Description.DataPropertyName = "Input_Description";
            this.colInput_Description.HeaderText = "Ghi chú";
            this.colInput_Description.Name = "colInput_Description";
            this.colInput_Description.ReadOnly = true;
            this.colInput_Description.Width = 150;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy hh:mm";
            this.colCreatedDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCreatedDate.HeaderText = "Ngày tạo";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.FillWeight = 10.64652F;
            this.CreatedBy.HeaderText = "Người tạo";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            this.CreatedBy.Width = 150;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ModifiedDate.DataPropertyName = "ModifiedDate";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy hh:mm";
            this.ModifiedDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ModifiedDate.FillWeight = 10.64652F;
            this.ModifiedDate.HeaderText = "Ngày cập nhật";
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.ReadOnly = true;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ModifiedBy.DataPropertyName = "ModifiedBy";
            this.ModifiedBy.FillWeight = 10.64652F;
            this.ModifiedBy.HeaderText = "Người cập nhật";
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.ReadOnly = true;
            this.ModifiedBy.Width = 150;
            // 
            // frmInputManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 577);
            this.Controls.Add(this.panelDanhsach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInputManage";
            this.Text = "Danh sách phiếu nhập";
            this.panelDanhsach.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDanhsach.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhsach)).EndInit();
            this.groupTimkiem.ResumeLayout(false);
            this.groupTimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelDanhsach;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDanhsach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grvDanhsach;
        private System.Windows.Forms.GroupBox groupTimkiem;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.CheckBox chDaxoa;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboInput_SendType;
        private System.Windows.Forms.ComboBox cboInput_IsVoucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpInput_DateTo;
        private System.Windows.Forms.DateTimePicker dtpInput_DateFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInput_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInput_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInput_TotalVAT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInput_IsVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInput_VoucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInput_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
    }
}