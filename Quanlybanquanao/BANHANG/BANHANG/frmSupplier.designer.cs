﻿namespace BANHANG
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDieukhien = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.panelDanhsach = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDanhsach = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvDanhsach = new System.Windows.Forms.DataGridView();
            this.groupTimkiem = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.chDaxoa = new System.Windows.Forms.CheckBox();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabChitiet = new System.Windows.Forms.TabPage();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.txtSupplier_Description = new System.Windows.Forms.TextBox();
            this.txtSupplier_ID = new System.Windows.Forms.TextBox();
            this.txtSupplier_Zalo = new System.Windows.Forms.TextBox();
            this.txtSupplier_Facbook = new System.Windows.Forms.TextBox();
            this.txtSupplier_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSupplier_Address = new System.Windows.Forms.TextBox();
            this.Facbook = new System.Windows.Forms.Label();
            this.txtSupplier_Phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupplier_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colSupplier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Facbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Zalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDieukhien.SuspendLayout();
            this.panelDanhsach.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDanhsach.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhsach)).BeginInit();
            this.groupTimkiem.SuspendLayout();
            this.tabChitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDieukhien
            // 
            this.panelDieukhien.Controls.Add(this.btnExcel);
            this.panelDieukhien.Controls.Add(this.btnThem);
            this.panelDieukhien.Controls.Add(this.btnXoa);
            this.panelDieukhien.Controls.Add(this.btnSua);
            this.panelDieukhien.Controls.Add(this.btnHuy);
            this.panelDieukhien.Controls.Add(this.btnCapnhat);
            this.panelDieukhien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDieukhien.Location = new System.Drawing.Point(0, 538);
            this.panelDieukhien.Name = "panelDieukhien";
            this.panelDieukhien.Size = new System.Drawing.Size(949, 39);
            this.panelDieukhien.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcel.ImageIndex = 6;
            this.btnExcel.ImageList = this.imageList1;
            this.btnExcel.Location = new System.Drawing.Point(12, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(105, 34);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Xuất excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
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
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(381, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.ImageIndex = 2;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(603, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.ImageIndex = 1;
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(492, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHuy.ImageIndex = 4;
            this.btnHuy.ImageList = this.imageList1;
            this.btnHuy.Location = new System.Drawing.Point(824, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 34);
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
            this.btnCapnhat.Location = new System.Drawing.Point(713, 3);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(105, 34);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapnhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // panelDanhsach
            // 
            this.panelDanhsach.Controls.Add(this.tabControl1);
            this.panelDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhsach.Location = new System.Drawing.Point(0, 0);
            this.panelDanhsach.Name = "panelDanhsach";
            this.panelDanhsach.Size = new System.Drawing.Size(949, 538);
            this.panelDanhsach.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDanhsach);
            this.tabControl1.Controls.Add(this.tabChitiet);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 538);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabDanhsach
            // 
            this.tabDanhsach.Controls.Add(this.panel1);
            this.tabDanhsach.Controls.Add(this.groupTimkiem);
            this.tabDanhsach.Location = new System.Drawing.Point(4, 22);
            this.tabDanhsach.Name = "tabDanhsach";
            this.tabDanhsach.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhsach.Size = new System.Drawing.Size(941, 512);
            this.tabDanhsach.TabIndex = 0;
            this.tabDanhsach.Text = "Danh sách";
            this.tabDanhsach.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grvDanhsach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 437);
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
            this.colSupplier_ID,
            this.colSupplier_Name,
            this.colSupplier_Phone,
            this.colSupplier_Address,
            this.colSupplier_Email,
            this.colSupplier_Facbook,
            this.colSupplier_Zalo,
            this.colSupplier_Description,
            this.colTrangthai,
            this.IsDelete,
            this.CreatedDate,
            this.CreatedBy,
            this.ModifiedDate,
            this.ModifiedBy});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDanhsach.DefaultCellStyle = dataGridViewCellStyle4;
            this.grvDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDanhsach.EnableHeadersVisualStyles = false;
            this.grvDanhsach.Location = new System.Drawing.Point(0, 0);
            this.grvDanhsach.MultiSelect = false;
            this.grvDanhsach.Name = "grvDanhsach";
            this.grvDanhsach.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDanhsach.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grvDanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDanhsach.Size = new System.Drawing.Size(935, 437);
            this.grvDanhsach.TabIndex = 3;
            this.grvDanhsach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDanhsach_CellDoubleClick);
            // 
            // groupTimkiem
            // 
            this.groupTimkiem.Controls.Add(this.btnTimkiem);
            this.groupTimkiem.Controls.Add(this.chDaxoa);
            this.groupTimkiem.Controls.Add(this.txtTukhoa);
            this.groupTimkiem.Controls.Add(this.label4);
            this.groupTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTimkiem.Location = new System.Drawing.Point(3, 3);
            this.groupTimkiem.Name = "groupTimkiem";
            this.groupTimkiem.Size = new System.Drawing.Size(935, 69);
            this.groupTimkiem.TabIndex = 6;
            this.groupTimkiem.TabStop = false;
            this.groupTimkiem.Text = "Thông tin tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ImageIndex = 5;
            this.btnTimkiem.ImageList = this.imageList1;
            this.btnTimkiem.Location = new System.Drawing.Point(348, 20);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(105, 34);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // chDaxoa
            // 
            this.chDaxoa.AutoSize = true;
            this.chDaxoa.Location = new System.Drawing.Point(282, 29);
            this.chDaxoa.Name = "chDaxoa";
            this.chDaxoa.Size = new System.Drawing.Size(60, 17);
            this.chDaxoa.TabIndex = 1;
            this.chDaxoa.Text = "Đã xóa";
            this.chDaxoa.UseVisualStyleBackColor = true;
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(69, 27);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(197, 20);
            this.txtTukhoa.TabIndex = 0;
            this.txtTukhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTukhoa_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Từ khóa: ";
            // 
            // tabChitiet
            // 
            this.tabChitiet.AutoScroll = true;
            this.tabChitiet.Controls.Add(this.chIsActive);
            this.tabChitiet.Controls.Add(this.txtSupplier_Description);
            this.tabChitiet.Controls.Add(this.txtSupplier_ID);
            this.tabChitiet.Controls.Add(this.txtSupplier_Zalo);
            this.tabChitiet.Controls.Add(this.txtSupplier_Facbook);
            this.tabChitiet.Controls.Add(this.txtSupplier_Email);
            this.tabChitiet.Controls.Add(this.label8);
            this.tabChitiet.Controls.Add(this.txtSupplier_Address);
            this.tabChitiet.Controls.Add(this.Facbook);
            this.tabChitiet.Controls.Add(this.txtSupplier_Phone);
            this.tabChitiet.Controls.Add(this.label7);
            this.tabChitiet.Controls.Add(this.txtSupplier_Name);
            this.tabChitiet.Controls.Add(this.label5);
            this.tabChitiet.Controls.Add(this.label1);
            this.tabChitiet.Controls.Add(this.label3);
            this.tabChitiet.Controls.Add(this.label6);
            this.tabChitiet.Controls.Add(this.label2);
            this.tabChitiet.Location = new System.Drawing.Point(4, 22);
            this.tabChitiet.Name = "tabChitiet";
            this.tabChitiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChitiet.Size = new System.Drawing.Size(941, 512);
            this.tabChitiet.TabIndex = 1;
            this.tabChitiet.Text = "Chi tiết";
            this.tabChitiet.UseVisualStyleBackColor = true;
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Checked = true;
            this.chIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chIsActive.Location = new System.Drawing.Point(107, 303);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(62, 17);
            this.chIsActive.TabIndex = 7;
            this.chIsActive.Text = "Hiển thị";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // txtSupplier_Description
            // 
            this.txtSupplier_Description.Location = new System.Drawing.Point(107, 211);
            this.txtSupplier_Description.MaxLength = 499;
            this.txtSupplier_Description.Multiline = true;
            this.txtSupplier_Description.Name = "txtSupplier_Description";
            this.txtSupplier_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSupplier_Description.Size = new System.Drawing.Size(278, 86);
            this.txtSupplier_Description.TabIndex = 6;
            // 
            // txtSupplier_ID
            // 
            this.txtSupplier_ID.Enabled = false;
            this.txtSupplier_ID.Location = new System.Drawing.Point(107, 15);
            this.txtSupplier_ID.MaxLength = 49;
            this.txtSupplier_ID.Name = "txtSupplier_ID";
            this.txtSupplier_ID.ReadOnly = true;
            this.txtSupplier_ID.Size = new System.Drawing.Size(278, 20);
            this.txtSupplier_ID.TabIndex = 0;
            // 
            // txtSupplier_Zalo
            // 
            this.txtSupplier_Zalo.Location = new System.Drawing.Point(107, 185);
            this.txtSupplier_Zalo.MaxLength = 249;
            this.txtSupplier_Zalo.Name = "txtSupplier_Zalo";
            this.txtSupplier_Zalo.Size = new System.Drawing.Size(278, 20);
            this.txtSupplier_Zalo.TabIndex = 5;
            // 
            // txtSupplier_Facbook
            // 
            this.txtSupplier_Facbook.Location = new System.Drawing.Point(107, 159);
            this.txtSupplier_Facbook.MaxLength = 249;
            this.txtSupplier_Facbook.Name = "txtSupplier_Facbook";
            this.txtSupplier_Facbook.Size = new System.Drawing.Size(278, 20);
            this.txtSupplier_Facbook.TabIndex = 4;
            // 
            // txtSupplier_Email
            // 
            this.txtSupplier_Email.Location = new System.Drawing.Point(107, 133);
            this.txtSupplier_Email.MaxLength = 249;
            this.txtSupplier_Email.Name = "txtSupplier_Email";
            this.txtSupplier_Email.Size = new System.Drawing.Size(278, 20);
            this.txtSupplier_Email.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Zalo:";
            // 
            // txtSupplier_Address
            // 
            this.txtSupplier_Address.Location = new System.Drawing.Point(107, 94);
            this.txtSupplier_Address.MaxLength = 499;
            this.txtSupplier_Address.Multiline = true;
            this.txtSupplier_Address.Name = "txtSupplier_Address";
            this.txtSupplier_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSupplier_Address.Size = new System.Drawing.Size(278, 34);
            this.txtSupplier_Address.TabIndex = 2;
            // 
            // Facbook
            // 
            this.Facbook.AutoSize = true;
            this.Facbook.Location = new System.Drawing.Point(39, 163);
            this.Facbook.Name = "Facbook";
            this.Facbook.Size = new System.Drawing.Size(52, 13);
            this.Facbook.TabIndex = 4;
            this.Facbook.Text = "Facbook:";
            // 
            // txtSupplier_Phone
            // 
            this.txtSupplier_Phone.Location = new System.Drawing.Point(107, 67);
            this.txtSupplier_Phone.MaxLength = 19;
            this.txtSupplier_Phone.Name = "txtSupplier_Phone";
            this.txtSupplier_Phone.Size = new System.Drawing.Size(278, 20);
            this.txtSupplier_Phone.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email:";
            // 
            // txtSupplier_Name
            // 
            this.txtSupplier_Name.Location = new System.Drawing.Point(107, 41);
            this.txtSupplier_Name.MaxLength = 49;
            this.txtSupplier_Name.Name = "txtSupplier_Name";
            this.txtSupplier_Name.Size = new System.Drawing.Size(278, 20);
            this.txtSupplier_Name.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên:";
            // 
            // colSupplier_ID
            // 
            this.colSupplier_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_ID.DataPropertyName = "Supplier_ID";
            this.colSupplier_ID.FillWeight = 49.84961F;
            this.colSupplier_ID.HeaderText = "Mã";
            this.colSupplier_ID.Name = "colSupplier_ID";
            this.colSupplier_ID.ReadOnly = true;
            // 
            // colSupplier_Name
            // 
            this.colSupplier_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Name.DataPropertyName = "Supplier_Name";
            this.colSupplier_Name.FillWeight = 717.259F;
            this.colSupplier_Name.HeaderText = "Tên";
            this.colSupplier_Name.Name = "colSupplier_Name";
            this.colSupplier_Name.ReadOnly = true;
            this.colSupplier_Name.Width = 250;
            // 
            // colSupplier_Phone
            // 
            this.colSupplier_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Phone.DataPropertyName = "Supplier_Phone";
            this.colSupplier_Phone.HeaderText = "Điện thoại";
            this.colSupplier_Phone.Name = "colSupplier_Phone";
            this.colSupplier_Phone.ReadOnly = true;
            // 
            // colSupplier_Address
            // 
            this.colSupplier_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Address.DataPropertyName = "Supplier_Address";
            this.colSupplier_Address.HeaderText = "Địa chỉ";
            this.colSupplier_Address.Name = "colSupplier_Address";
            this.colSupplier_Address.ReadOnly = true;
            // 
            // colSupplier_Email
            // 
            this.colSupplier_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Email.DataPropertyName = "Supplier_Email";
            this.colSupplier_Email.HeaderText = "Email";
            this.colSupplier_Email.Name = "colSupplier_Email";
            this.colSupplier_Email.ReadOnly = true;
            // 
            // colSupplier_Facbook
            // 
            this.colSupplier_Facbook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Facbook.DataPropertyName = "Supplier_Facbook";
            this.colSupplier_Facbook.HeaderText = "Facbook";
            this.colSupplier_Facbook.Name = "colSupplier_Facbook";
            this.colSupplier_Facbook.ReadOnly = true;
            // 
            // colSupplier_Zalo
            // 
            this.colSupplier_Zalo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Zalo.DataPropertyName = "Supplier_Zalo";
            this.colSupplier_Zalo.HeaderText = "Zalo";
            this.colSupplier_Zalo.Name = "colSupplier_Zalo";
            this.colSupplier_Zalo.ReadOnly = true;
            // 
            // colSupplier_Description
            // 
            this.colSupplier_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSupplier_Description.DataPropertyName = "Supplier_Description";
            this.colSupplier_Description.FillWeight = 10.64652F;
            this.colSupplier_Description.HeaderText = "Ghi chú";
            this.colSupplier_Description.Name = "colSupplier_Description";
            this.colSupplier_Description.ReadOnly = true;
            this.colSupplier_Description.Width = 300;
            // 
            // colTrangthai
            // 
            this.colTrangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTrangthai.DataPropertyName = "IsActive";
            this.colTrangthai.FalseValue = "0";
            this.colTrangthai.FillWeight = 53.19462F;
            this.colTrangthai.HeaderText = "Trạng thái";
            this.colTrangthai.Name = "colTrangthai";
            this.colTrangthai.ReadOnly = true;
            this.colTrangthai.TrueValue = "1";
            this.colTrangthai.Width = 40;
            // 
            // IsDelete
            // 
            this.IsDelete.DataPropertyName = "IsDelete";
            this.IsDelete.HeaderText = "IsDelete";
            this.IsDelete.Name = "IsDelete";
            this.IsDelete.ReadOnly = true;
            this.IsDelete.Visible = false;
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreatedDate.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm";
            this.CreatedDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.CreatedDate.FillWeight = 10.64652F;
            this.CreatedDate.HeaderText = "Ngày tạo";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 150;
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
            dataGridViewCellStyle3.Format = "dd/MM/yyyy hh:mm";
            this.ModifiedDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ModifiedDate.FillWeight = 10.64652F;
            this.ModifiedDate.HeaderText = "Ngày cập nhật";
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.ReadOnly = true;
            this.ModifiedDate.Width = 150;
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
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 577);
            this.Controls.Add(this.panelDanhsach);
            this.Controls.Add(this.panelDieukhien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupplier";
            this.Text = "Danh sách nhà cung cấp";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.panelDieukhien.ResumeLayout(false);
            this.panelDanhsach.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDanhsach.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhsach)).EndInit();
            this.groupTimkiem.ResumeLayout(false);
            this.groupTimkiem.PerformLayout();
            this.tabChitiet.ResumeLayout(false);
            this.tabChitiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDieukhien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Panel panelDanhsach;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDanhsach;
        private System.Windows.Forms.TabPage tabChitiet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grvDanhsach;
        private System.Windows.Forms.GroupBox groupTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.CheckBox chDaxoa;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chIsActive;
        private System.Windows.Forms.TextBox txtSupplier_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplier_Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtSupplier_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplier_Zalo;
        private System.Windows.Forms.TextBox txtSupplier_Facbook;
        private System.Windows.Forms.TextBox txtSupplier_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSupplier_Address;
        private System.Windows.Forms.Label Facbook;
        private System.Windows.Forms.TextBox txtSupplier_Phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Facbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Zalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier_Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
    }
}