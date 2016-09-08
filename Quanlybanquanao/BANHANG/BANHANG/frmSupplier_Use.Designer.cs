namespace BANHANG
{
    partial class frmSupplier_Use
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier_Use));
            this.grvDanhsach = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupTimkiem = new System.Windows.Forms.GroupBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhsach)).BeginInit();
            this.groupTimkiem.SuspendLayout();
            this.SuspendLayout();
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
            this.grvDanhsach.Location = new System.Drawing.Point(0, 69);
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
            this.grvDanhsach.RowHeadersVisible = false;
            this.grvDanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDanhsach.Size = new System.Drawing.Size(895, 445);
            this.grvDanhsach.TabIndex = 7;
            this.grvDanhsach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvDanhsach_KeyDown);
            this.grvDanhsach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grvDanhsach_MouseDoubleClick);
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
            // groupTimkiem
            // 
            this.groupTimkiem.Controls.Add(this.cboType);
            this.groupTimkiem.Controls.Add(this.label3);
            this.groupTimkiem.Controls.Add(this.btnTimkiem);
            this.groupTimkiem.Controls.Add(this.txtTukhoa);
            this.groupTimkiem.Controls.Add(this.label4);
            this.groupTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTimkiem.Location = new System.Drawing.Point(0, 0);
            this.groupTimkiem.Name = "groupTimkiem";
            this.groupTimkiem.Size = new System.Drawing.Size(895, 69);
            this.groupTimkiem.TabIndex = 8;
            this.groupTimkiem.TabStop = false;
            this.groupTimkiem.Text = "Thông tin tìm kiếm";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(300, 27);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(195, 21);
            this.cboType.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tìm theo:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ImageIndex = 5;
            this.btnTimkiem.ImageList = this.imageList1;
            this.btnTimkiem.Location = new System.Drawing.Point(501, 20);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(105, 34);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
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
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(69, 27);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(168, 20);
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
            // frmSupplier_Use
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 514);
            this.Controls.Add(this.grvDanhsach);
            this.Controls.Add(this.groupTimkiem);
            this.Name = "frmSupplier_Use";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm nhà cung cấp";
            this.Load += new System.EventHandler(this.frmSupplier_Use_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhsach)).EndInit();
            this.groupTimkiem.ResumeLayout(false);
            this.groupTimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDanhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
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
        private System.Windows.Forms.GroupBox groupTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label3;
    }
}