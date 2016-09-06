namespace BANHANG
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusFooter = new System.Windows.Forms.StatusStrip();
            this.toolTennguoidung = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.toolConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSendType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolModel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPriceType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrderNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOrderManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolInv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolInputNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolInpurManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOutputNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOutputManage = new System.Windows.Forms.ToolStripMenuItem();
            this.statusFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusFooter
            // 
            this.statusFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTennguoidung});
            this.statusFooter.Location = new System.Drawing.Point(3, 562);
            this.statusFooter.Name = "statusFooter";
            this.statusFooter.Size = new System.Drawing.Size(1023, 22);
            this.statusFooter.TabIndex = 1;
            this.statusFooter.Text = "Footer";
            // 
            // toolTennguoidung
            // 
            this.toolTennguoidung.Name = "toolTennguoidung";
            this.toolTennguoidung.Size = new System.Drawing.Size(74, 17);
            this.toolTennguoidung.Text = "Người dùng:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHethong,
            this.toolThoat,
            this.toolDoimatkhau,
            this.toolSanpham,
            this.toolPayment,
            this.toolOrder,
            this.toolInv});
            this.menuStrip1.Location = new System.Drawing.Point(3, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolHethong
            // 
            this.toolHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNguoidung,
            this.toolConfig});
            this.toolHethong.Name = "toolHethong";
            this.toolHethong.Size = new System.Drawing.Size(69, 20);
            this.toolHethong.Text = "Hệ thống";
            // 
            // toolNguoidung
            // 
            this.toolNguoidung.Name = "toolNguoidung";
            this.toolNguoidung.Size = new System.Drawing.Size(138, 22);
            this.toolNguoidung.Text = "Người dùng";
            this.toolNguoidung.Click += new System.EventHandler(this.toolNguoidung_Click);
            // 
            // toolConfig
            // 
            this.toolConfig.Name = "toolConfig";
            this.toolConfig.Size = new System.Drawing.Size(138, 22);
            this.toolConfig.Text = "Cấu hình";
            this.toolConfig.Click += new System.EventHandler(this.toolConfig_Click);
            // 
            // toolThoat
            // 
            this.toolThoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolThoat.Name = "toolThoat";
            this.toolThoat.Size = new System.Drawing.Size(50, 20);
            this.toolThoat.Text = "Thoát";
            this.toolThoat.Click += new System.EventHandler(this.toolThoat_Click);
            // 
            // toolDoimatkhau
            // 
            this.toolDoimatkhau.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolDoimatkhau.Name = "toolDoimatkhau";
            this.toolDoimatkhau.Size = new System.Drawing.Size(90, 20);
            this.toolDoimatkhau.Text = "Đổi mật khẩu";
            this.toolDoimatkhau.Click += new System.EventHandler(this.toolDoimatkhau_Click);
            // 
            // toolSanpham
            // 
            this.toolSanpham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCategory,
            this.toolColor,
            this.toolSendType,
            this.toolModel,
            this.toolProduct,
            this.toolCustomer,
            this.toolSupplier,
            this.toolPriceType,
            this.toolPrice});
            this.toolSanpham.Name = "toolSanpham";
            this.toolSanpham.Size = new System.Drawing.Size(74, 20);
            this.toolSanpham.Text = "Danh mục";
            // 
            // toolCategory
            // 
            this.toolCategory.Name = "toolCategory";
            this.toolCategory.Size = new System.Drawing.Size(177, 22);
            this.toolCategory.Text = "Chủng loại";
            this.toolCategory.Click += new System.EventHandler(this.toolCategory_Click);
            // 
            // toolColor
            // 
            this.toolColor.Name = "toolColor";
            this.toolColor.Size = new System.Drawing.Size(177, 22);
            this.toolColor.Text = "Màu sắc";
            this.toolColor.Click += new System.EventHandler(this.toolColor_Click);
            // 
            // toolSendType
            // 
            this.toolSendType.Name = "toolSendType";
            this.toolSendType.Size = new System.Drawing.Size(177, 22);
            this.toolSendType.Text = "Hình thức gửi hàng";
            this.toolSendType.Click += new System.EventHandler(this.toolSendType_Click);
            // 
            // toolModel
            // 
            this.toolModel.Name = "toolModel";
            this.toolModel.Size = new System.Drawing.Size(177, 22);
            this.toolModel.Text = "Kiểu cách";
            this.toolModel.Click += new System.EventHandler(this.toolModel_Click);
            // 
            // toolProduct
            // 
            this.toolProduct.Name = "toolProduct";
            this.toolProduct.Size = new System.Drawing.Size(177, 22);
            this.toolProduct.Text = "Sản phẩm";
            this.toolProduct.Click += new System.EventHandler(this.toolProduct_Click);
            // 
            // toolCustomer
            // 
            this.toolCustomer.Name = "toolCustomer";
            this.toolCustomer.Size = new System.Drawing.Size(177, 22);
            this.toolCustomer.Text = "Khách hàng";
            this.toolCustomer.Click += new System.EventHandler(this.toolCustomer_Click);
            // 
            // toolSupplier
            // 
            this.toolSupplier.Name = "toolSupplier";
            this.toolSupplier.Size = new System.Drawing.Size(177, 22);
            this.toolSupplier.Text = "Nhà cung cấp";
            this.toolSupplier.Click += new System.EventHandler(this.toolSupplier_Click);
            // 
            // toolPriceType
            // 
            this.toolPriceType.Name = "toolPriceType";
            this.toolPriceType.Size = new System.Drawing.Size(177, 22);
            this.toolPriceType.Text = "Loại giá";
            this.toolPriceType.Click += new System.EventHandler(this.toolPriceType_Click);
            // 
            // toolPrice
            // 
            this.toolPrice.Name = "toolPrice";
            this.toolPrice.Size = new System.Drawing.Size(177, 22);
            this.toolPrice.Text = "Làm giá";
            this.toolPrice.Click += new System.EventHandler(this.toolPrice_Click);
            // 
            // toolPayment
            // 
            this.toolPayment.Name = "toolPayment";
            this.toolPayment.Size = new System.Drawing.Size(100, 20);
            this.toolPayment.Text = "Quản lý thu chi";
            this.toolPayment.Click += new System.EventHandler(this.toolPayment_Click);
            // 
            // toolOrder
            // 
            this.toolOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOrderNew,
            this.toolOrderManage});
            this.toolOrder.Name = "toolOrder";
            this.toolOrder.Size = new System.Drawing.Size(69, 20);
            this.toolOrder.Text = "Bán hàng";
            // 
            // toolOrderNew
            // 
            this.toolOrderNew.Name = "toolOrderNew";
            this.toolOrderNew.Size = new System.Drawing.Size(183, 22);
            this.toolOrderNew.Text = "Thêm mới đơn hàng";
            this.toolOrderNew.Click += new System.EventHandler(this.toolOrderNew_Click);
            // 
            // toolOrderManage
            // 
            this.toolOrderManage.Name = "toolOrderManage";
            this.toolOrderManage.Size = new System.Drawing.Size(183, 22);
            this.toolOrderManage.Text = "Quản lý đơn hàng";
            this.toolOrderManage.Click += new System.EventHandler(this.toolOrderManage_Click);
            // 
            // toolInv
            // 
            this.toolInv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolInputNew,
            this.toolInpurManage,
            this.toolOutputNew,
            this.toolOutputManage});
            this.toolInv.Name = "toolInv";
            this.toolInv.Size = new System.Drawing.Size(73, 20);
            this.toolInv.Text = "Nhập xuất";
            // 
            // toolInputNew
            // 
            this.toolInputNew.Name = "toolInputNew";
            this.toolInputNew.Size = new System.Drawing.Size(189, 22);
            this.toolInputNew.Text = "Thêm mới nhập hàng";
            this.toolInputNew.Click += new System.EventHandler(this.toolInputNew_Click);
            // 
            // toolInpurManage
            // 
            this.toolInpurManage.Name = "toolInpurManage";
            this.toolInpurManage.Size = new System.Drawing.Size(189, 22);
            this.toolInpurManage.Text = "Quản lý nhập hàng";
            this.toolInpurManage.Click += new System.EventHandler(this.toolInpurManage_Click);
            // 
            // toolOutputNew
            // 
            this.toolOutputNew.Name = "toolOutputNew";
            this.toolOutputNew.Size = new System.Drawing.Size(189, 22);
            this.toolOutputNew.Text = "Thêm mới xuất hàng";
            this.toolOutputNew.Click += new System.EventHandler(this.toolOutputNew_Click);
            // 
            // toolOutputManage
            // 
            this.toolOutputManage.Name = "toolOutputManage";
            this.toolOutputManage.Size = new System.Drawing.Size(189, 22);
            this.toolOutputManage.Text = "Quản lý xuất hàng";
            this.toolOutputManage.Click += new System.EventHandler(this.toolOutputManage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 588);
            this.Controls.Add(this.statusFooter);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusFooter.ResumeLayout(false);
            this.statusFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusFooter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolHethong;
        private System.Windows.Forms.ToolStripMenuItem toolNguoidung;
        private System.Windows.Forms.ToolStripMenuItem toolConfig;
        private System.Windows.Forms.ToolStripMenuItem toolThoat;
        private System.Windows.Forms.ToolStripMenuItem toolDoimatkhau;
        private System.Windows.Forms.ToolStripStatusLabel toolTennguoidung;
        private System.Windows.Forms.ToolStripMenuItem toolSanpham;
        private System.Windows.Forms.ToolStripMenuItem toolCategory;
        private System.Windows.Forms.ToolStripMenuItem toolColor;
        private System.Windows.Forms.ToolStripMenuItem toolSendType;
        private System.Windows.Forms.ToolStripMenuItem toolModel;
        private System.Windows.Forms.ToolStripMenuItem toolProduct;
        private System.Windows.Forms.ToolStripMenuItem toolCustomer;
        private System.Windows.Forms.ToolStripMenuItem toolSupplier;
        private System.Windows.Forms.ToolStripMenuItem toolPayment;
        private System.Windows.Forms.ToolStripMenuItem toolPriceType;
        private System.Windows.Forms.ToolStripMenuItem toolPrice;
        private System.Windows.Forms.ToolStripMenuItem toolOrder;
        private System.Windows.Forms.ToolStripMenuItem toolOrderNew;
        private System.Windows.Forms.ToolStripMenuItem toolOrderManage;
        private System.Windows.Forms.ToolStripMenuItem toolInv;
        private System.Windows.Forms.ToolStripMenuItem toolInputNew;
        private System.Windows.Forms.ToolStripMenuItem toolInpurManage;
        private System.Windows.Forms.ToolStripMenuItem toolOutputNew;
        private System.Windows.Forms.ToolStripMenuItem toolOutputManage;
    }
}

