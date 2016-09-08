namespace BANHANG
{
    partial class frmPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
            this.panelDieukhien = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.panelDanhsach = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChitiet = new System.Windows.Forms.TabPage();
            this.groupThongtin = new System.Windows.Forms.GroupBox();
            this.txtPayments_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayments_Amount = new System.Windows.Forms.TextBox();
            this.dtpPayments_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPayments_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayments_Vouchers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeachKH = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txtCustomer_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomer_Zalo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomer_Facbook = new System.Windows.Forms.TextBox();
            this.Facbook = new System.Windows.Forms.Label();
            this.txtCustomer_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomer_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomer_Name = new System.Windows.Forms.TextBox();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.txtCustomer_ID = new System.Windows.Forms.TextBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.panelDieukhien.SuspendLayout();
            this.panelDanhsach.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabChitiet.SuspendLayout();
            this.groupThongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDieukhien
            // 
            this.panelDieukhien.Controls.Add(this.btnXoa);
            this.panelDieukhien.Controls.Add(this.btnCapnhat);
            this.panelDieukhien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDieukhien.Location = new System.Drawing.Point(0, 332);
            this.panelDieukhien.Name = "panelDieukhien";
            this.panelDieukhien.Size = new System.Drawing.Size(793, 39);
            this.panelDieukhien.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageIndex = 2;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(13, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            // btnCapnhat
            // 
            this.btnCapnhat.ImageIndex = 3;
            this.btnCapnhat.ImageList = this.imageList1;
            this.btnCapnhat.Location = new System.Drawing.Point(667, 3);
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
            this.panelDanhsach.Size = new System.Drawing.Size(793, 332);
            this.panelDanhsach.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChitiet);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabChitiet
            // 
            this.tabChitiet.AutoScroll = true;
            this.tabChitiet.Controls.Add(this.groupThongtin);
            this.tabChitiet.Controls.Add(this.groupBox1);
            this.tabChitiet.Location = new System.Drawing.Point(4, 22);
            this.tabChitiet.Name = "tabChitiet";
            this.tabChitiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChitiet.Size = new System.Drawing.Size(785, 306);
            this.tabChitiet.TabIndex = 1;
            this.tabChitiet.Text = "Chi tiết";
            this.tabChitiet.UseVisualStyleBackColor = true;
            // 
            // groupThongtin
            // 
            this.groupThongtin.Controls.Add(this.txtPayments_ID);
            this.groupThongtin.Controls.Add(this.label1);
            this.groupThongtin.Controls.Add(this.txtPayments_Amount);
            this.groupThongtin.Controls.Add(this.dtpPayments_Date);
            this.groupThongtin.Controls.Add(this.label3);
            this.groupThongtin.Controls.Add(this.label14);
            this.groupThongtin.Controls.Add(this.txtPayments_Description);
            this.groupThongtin.Controls.Add(this.label2);
            this.groupThongtin.Controls.Add(this.txtPayments_Vouchers);
            this.groupThongtin.Controls.Add(this.label6);
            this.groupThongtin.Location = new System.Drawing.Point(12, 154);
            this.groupThongtin.Name = "groupThongtin";
            this.groupThongtin.Size = new System.Drawing.Size(760, 144);
            this.groupThongtin.TabIndex = 27;
            this.groupThongtin.TabStop = false;
            this.groupThongtin.Text = "Thông tin phiếu thu/chi";
            // 
            // txtPayments_ID
            // 
            this.txtPayments_ID.BackColor = System.Drawing.SystemColors.Info;
            this.txtPayments_ID.Enabled = false;
            this.txtPayments_ID.Location = new System.Drawing.Point(83, 19);
            this.txtPayments_ID.MaxLength = 49;
            this.txtPayments_ID.Name = "txtPayments_ID";
            this.txtPayments_ID.Size = new System.Drawing.Size(137, 20);
            this.txtPayments_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã:";
            // 
            // txtPayments_Amount
            // 
            this.txtPayments_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayments_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPayments_Amount.Location = new System.Drawing.Point(83, 49);
            this.txtPayments_Amount.MaxLength = 19;
            this.txtPayments_Amount.Multiline = true;
            this.txtPayments_Amount.Name = "txtPayments_Amount";
            this.txtPayments_Amount.Size = new System.Drawing.Size(137, 78);
            this.txtPayments_Amount.TabIndex = 24;
            this.txtPayments_Amount.Text = "0";
            this.txtPayments_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPayments_Amount.Leave += new System.EventHandler(this.txtPayments_Amount_Leave);
            // 
            // dtpPayments_Date
            // 
            this.dtpPayments_Date.CustomFormat = "dd/MM/yyyyy";
            this.dtpPayments_Date.Enabled = false;
            this.dtpPayments_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPayments_Date.Location = new System.Drawing.Point(295, 19);
            this.dtpPayments_Date.Name = "dtpPayments_Date";
            this.dtpPayments_Date.Size = new System.Drawing.Size(157, 20);
            this.dtpPayments_Date.TabIndex = 23;
            this.dtpPayments_Date.Value = new System.DateTime(2016, 6, 27, 22, 30, 31, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số tiền:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ngày:";
            // 
            // txtPayments_Description
            // 
            this.txtPayments_Description.Location = new System.Drawing.Point(295, 49);
            this.txtPayments_Description.MaxLength = 2000;
            this.txtPayments_Description.Multiline = true;
            this.txtPayments_Description.Name = "txtPayments_Description";
            this.txtPayments_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPayments_Description.Size = new System.Drawing.Size(452, 78);
            this.txtPayments_Description.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chứng từ:";
            // 
            // txtPayments_Vouchers
            // 
            this.txtPayments_Vouchers.BackColor = System.Drawing.SystemColors.Info;
            this.txtPayments_Vouchers.Enabled = false;
            this.txtPayments_Vouchers.Location = new System.Drawing.Point(546, 19);
            this.txtPayments_Vouchers.MaxLength = 49;
            this.txtPayments_Vouchers.Name = "txtPayments_Vouchers";
            this.txtPayments_Vouchers.Size = new System.Drawing.Size(201, 20);
            this.txtPayments_Vouchers.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeachKH);
            this.groupBox1.Controls.Add(this.btnDeleteCustomer);
            this.groupBox1.Controls.Add(this.txtCustomer_Address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCustomer_Zalo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCustomer_Facbook);
            this.groupBox1.Controls.Add(this.Facbook);
            this.groupBox1.Controls.Add(this.txtCustomer_Email);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCustomer_Phone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCustomer_Name);
            this.groupBox1.Controls.Add(this.lbTenKH);
            this.groupBox1.Controls.Add(this.txtCustomer_ID);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 144);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnSeachKH
            // 
            this.btnSeachKH.ImageIndex = 5;
            this.btnSeachKH.ImageList = this.imageList1;
            this.btnSeachKH.Location = new System.Drawing.Point(178, 14);
            this.btnSeachKH.Name = "btnSeachKH";
            this.btnSeachKH.Size = new System.Drawing.Size(31, 28);
            this.btnSeachKH.TabIndex = 20;
            this.btnSeachKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeachKH.UseVisualStyleBackColor = true;
            this.btnSeachKH.Click += new System.EventHandler(this.btnSeachKH_Click);
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
            this.txtCustomer_Email.Location = new System.Drawing.Point(313, 44);
            this.txtCustomer_Email.MaxLength = 249;
            this.txtCustomer_Email.Name = "txtCustomer_Email";
            this.txtCustomer_Email.Size = new System.Drawing.Size(434, 20);
            this.txtCustomer_Email.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 47);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Điện thoại:";
            // 
            // txtCustomer_Name
            // 
            this.txtCustomer_Name.Location = new System.Drawing.Point(313, 18);
            this.txtCustomer_Name.MaxLength = 49;
            this.txtCustomer_Name.Name = "txtCustomer_Name";
            this.txtCustomer_Name.Size = new System.Drawing.Size(434, 20);
            this.txtCustomer_Name.TabIndex = 0;
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(249, 21);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(47, 13);
            this.lbTenKH.TabIndex = 8;
            this.lbTenKH.Text = "Tên KH:";
            // 
            // txtCustomer_ID
            // 
            this.txtCustomer_ID.Enabled = false;
            this.txtCustomer_ID.Location = new System.Drawing.Point(83, 18);
            this.txtCustomer_ID.MaxLength = 49;
            this.txtCustomer_ID.Name = "txtCustomer_ID";
            this.txtCustomer_ID.ReadOnly = true;
            this.txtCustomer_ID.Size = new System.Drawing.Size(93, 20);
            this.txtCustomer_ID.TabIndex = 5;
            this.txtCustomer_ID.TextChanged += new System.EventHandler(this.txtCustomer_ID_TextChanged);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(13, 22);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(43, 13);
            this.lbMaKH.TabIndex = 6;
            this.lbMaKH.Text = "Mã KH:";
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 371);
            this.Controls.Add(this.panelDanhsach);
            this.Controls.Add(this.panelDieukhien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thu chi";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            this.panelDieukhien.ResumeLayout(false);
            this.panelDanhsach.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabChitiet.ResumeLayout(false);
            this.groupThongtin.ResumeLayout(false);
            this.groupThongtin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDieukhien;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Panel panelDanhsach;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChitiet;
        private System.Windows.Forms.TextBox txtPayments_Vouchers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayments_Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPayments_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPayments_Date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupThongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtCustomer_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomer_Zalo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomer_Facbook;
        private System.Windows.Forms.Label Facbook;
        private System.Windows.Forms.TextBox txtCustomer_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomer_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomer_Name;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.TextBox txtCustomer_ID;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.TextBox txtPayments_Amount;
        private System.Windows.Forms.Button btnSeachKH;
    }
}