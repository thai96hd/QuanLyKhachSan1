namespace QuanLyKhachSan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTroGiup = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyTrangThietBi = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblLoiChao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDoiMatKhau,
            this.btnDangXuat,
            this.btnTroGiup,
            this.btnThongTin,
            this.btnQuanLyNhanVien,
            this.btnQuanLyPhong,
            this.btnQuanLyTrangThietBi,
            this.btnQuanLyDichVu,
            this.btnQuanLyKhachHang});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(810, 143);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Glyph")));
            this.btnDoiMatKhau.Id = 1;
            this.btnDoiMatKhau.ImageUri.Uri = "Edit";
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.ImageUri.Uri = "Reset";
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Caption = "Trợ giúp";
            this.btnTroGiup.Id = 3;
            this.btnTroGiup.ImageUri.Uri = "SaveDialog";
            this.btnTroGiup.Name = "btnTroGiup";
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thông tin phần mềm";
            this.btnThongTin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Glyph")));
            this.btnThongTin.Id = 4;
            this.btnThongTin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThongTin.LargeGlyph")));
            this.btnThongTin.Name = "btnThongTin";
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Caption = "Nhân viên";
            this.btnQuanLyNhanVien.Id = 5;
            this.btnQuanLyNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNhanVien.LargeGlyph")));
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyNhanVien_ItemClick);
            // 
            // btnQuanLyPhong
            // 
            this.btnQuanLyPhong.Caption = "Phòng";
            this.btnQuanLyPhong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyPhong.Glyph")));
            this.btnQuanLyPhong.Id = 6;
            this.btnQuanLyPhong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyPhong.LargeGlyph")));
            this.btnQuanLyPhong.Name = "btnQuanLyPhong";
            this.btnQuanLyPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyPhong_ItemClick);
            // 
            // btnQuanLyTrangThietBi
            // 
            this.btnQuanLyTrangThietBi.Caption = "Trang thiết bị";
            this.btnQuanLyTrangThietBi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyTrangThietBi.Glyph")));
            this.btnQuanLyTrangThietBi.Id = 7;
            this.btnQuanLyTrangThietBi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyTrangThietBi.LargeGlyph")));
            this.btnQuanLyTrangThietBi.Name = "btnQuanLyTrangThietBi";
            this.btnQuanLyTrangThietBi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyTrangThietBi_ItemClick);
            // 
            // btnQuanLyDichVu
            // 
            this.btnQuanLyDichVu.Caption = "Dịch vụ";
            this.btnQuanLyDichVu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyDichVu.Glyph")));
            this.btnQuanLyDichVu.Id = 8;
            this.btnQuanLyDichVu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyDichVu.LargeGlyph")));
            this.btnQuanLyDichVu.Name = "btnQuanLyDichVu";
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.Caption = "Khách hàng";
            this.btnQuanLyKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKhachHang.Glyph")));
            this.btnQuanLyKhachHang.Id = 9;
            this.btnQuanLyKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKhachHang.LargeGlyph")));
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài khoản";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTroGiup);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThongTin);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản trị";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLyNhanVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLyPhong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLyTrangThietBi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLyDichVu);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLyKhachHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lvPhong);
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 318);
            this.panel1.TabIndex = 1;
            // 
            // lvPhong
            // 
            this.lvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhong.Location = new System.Drawing.Point(0, 0);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(291, 318);
            this.lvPhong.TabIndex = 0;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong});
            this.dataGridView1.Location = new System.Drawing.Point(344, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 281);
            this.dataGridView1.TabIndex = 2;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imagephong.png");
            this.imageList1.Images.SetKeyName(1, "imagephong1.jpg");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblLoiChao
            // 
            this.lblLoiChao.AutoSize = true;
            this.lblLoiChao.Location = new System.Drawing.Point(617, 75);
            this.lblLoiChao.Name = "lblLoiChao";
            this.lblLoiChao.Size = new System.Drawing.Size(60, 13);
            this.lblLoiChao.TabIndex = 6;
            this.lblLoiChao.Text = "Chào Bạn :";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 523);
            this.Controls.Add(this.lblLoiChao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnTroGiup;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyPhong;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyTrangThietBi;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyDichVu;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLoiChao;
    }
}

