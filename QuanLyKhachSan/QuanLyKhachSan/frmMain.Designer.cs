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
            this.btnThuePhong1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblLoiChao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaDichVu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietSuDungDichVu = new System.Windows.Forms.DataGridView();
            this.masudungdichvu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendichvu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemDichVu = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayThue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoChungMinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.madichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemDichVu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSuDungDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemDichVu.Properties)).BeginInit();
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
            this.btnQuanLyKhachHang,
            this.btnThuePhong1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1158, 143);
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
            this.btnQuanLyDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyDichVu_ItemClick);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.Caption = "Khách hàng";
            this.btnQuanLyKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKhachHang.Glyph")));
            this.btnQuanLyKhachHang.Id = 9;
            this.btnQuanLyKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKhachHang.LargeGlyph")));
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyKhachHang_ItemClick);
            // 
            // btnThuePhong1
            // 
            this.btnThuePhong1.Caption = "Thuê Phòng";
            this.btnThuePhong1.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThuePhong1.Glyph")));
            this.btnThuePhong1.Id = 11;
            this.btnThuePhong1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThuePhong1.LargeGlyph")));
            this.btnThuePhong1.Name = "btnThuePhong1";
            this.btnThuePhong1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThuePhong1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
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
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnThuePhong1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thuê phòng";
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
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 400);
            this.panel1.TabIndex = 1;
            // 
            // lvPhong
            // 
            this.lvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhong.Location = new System.Drawing.Point(0, 0);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(291, 400);
            this.lvPhong.TabIndex = 0;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imagephong.png");
            this.imageList1.Images.SetKeyName(1, "imagephong1.jpg");
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnXoaDichVu);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnThemDichVu);
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Location = new System.Drawing.Point(309, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 400);
            this.panel2.TabIndex = 8;
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.Location = new System.Drawing.Point(102, 269);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(78, 27);
            this.btnXoaDichVu.TabIndex = 10;
            this.btnXoaDichVu.Text = "Xóa";
            this.btnXoaDichVu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvChiTietSuDungDichVu);
            this.groupBox1.Location = new System.Drawing.Point(8, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sử dụng";
            // 
            // dgvChiTietSuDungDichVu
            // 
            this.dgvChiTietSuDungDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietSuDungDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietSuDungDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masudungdichvu1,
            this.tendichvu1,
            this.dongia1,
            this.soluong1,
            this.thanhtien});
            this.dgvChiTietSuDungDichVu.Location = new System.Drawing.Point(14, 20);
            this.dgvChiTietSuDungDichVu.Name = "dgvChiTietSuDungDichVu";
            this.dgvChiTietSuDungDichVu.Size = new System.Drawing.Size(527, 58);
            this.dgvChiTietSuDungDichVu.TabIndex = 0;
            // 
            // masudungdichvu1
            // 
            this.masudungdichvu1.HeaderText = "Mã Sử Dụng";
            this.masudungdichvu1.Name = "masudungdichvu1";
            // 
            // tendichvu1
            // 
            this.tendichvu1.HeaderText = "Tên DV";
            this.tendichvu1.Name = "tendichvu1";
            // 
            // dongia1
            // 
            this.dongia1.HeaderText = "Đơn Giá";
            this.dongia1.Name = "dongia1";
            // 
            // soluong1
            // 
            this.soluong1.HeaderText = "Số lượng";
            this.soluong1.Name = "soluong1";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.Location = new System.Drawing.Point(8, 269);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(80, 27);
            this.btnThemDichVu.TabIndex = 9;
            this.btnThemDichVu.Text = "Thêm";
            this.btnThemDichVu.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtNgayThue);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtSoChungMinh);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtTenKhachHang);
            this.groupControl1.Controls.Add(this.txtTenDV);
            this.groupControl1.Controls.Add(this.txtMaKhachHang);
            this.groupControl1.Controls.Add(this.txtMaDichVu);
            this.groupControl1.Controls.Add(this.nudSoLuong);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.dgvDichVu);
            this.groupControl1.Controls.Add(this.txtTimKiemDichVu);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(3, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(834, 251);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tra cứu dịch vụ";
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.Location = new System.Drawing.Point(99, 108);
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.ReadOnly = true;
            this.txtNgayThue.Size = new System.Drawing.Size(170, 21);
            this.txtNgayThue.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày thuê";
            // 
            // txtSoChungMinh
            // 
            this.txtSoChungMinh.Location = new System.Drawing.Point(99, 81);
            this.txtSoChungMinh.Name = "txtSoChungMinh";
            this.txtSoChungMinh.ReadOnly = true;
            this.txtSoChungMinh.Size = new System.Drawing.Size(170, 21);
            this.txtSoChungMinh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số chứng minh";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(99, 54);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(170, 21);
            this.txtTenKhachHang.TabIndex = 5;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(99, 186);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.ReadOnly = true;
            this.txtTenDV.Size = new System.Drawing.Size(170, 21);
            this.txtTenDV.TabIndex = 8;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(99, 26);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(170, 21);
            this.txtMaKhachHang.TabIndex = 4;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.Location = new System.Drawing.Point(99, 156);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.ReadOnly = true;
            this.txtMaDichVu.Size = new System.Drawing.Size(170, 21);
            this.txtMaDichVu.TabIndex = 7;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(101, 213);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(168, 21);
            this.nudSoLuong.TabIndex = 6;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên DV";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã DV";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madichvu,
            this.tendichvu,
            this.dongia});
            this.dgvDichVu.Location = new System.Drawing.Point(290, 29);
            this.dgvDichVu.MultiSelect = false;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(539, 205);
            this.dgvDichVu.TabIndex = 2;
            // 
            // madichvu
            // 
            this.madichvu.DataPropertyName = "Madichvu";
            this.madichvu.HeaderText = "Mã DV";
            this.madichvu.Name = "madichvu";
            this.madichvu.ReadOnly = true;
            // 
            // tendichvu
            // 
            this.tendichvu.DataPropertyName = "Tendichvu";
            this.tendichvu.HeaderText = "Tên dịch vụ";
            this.tendichvu.Name = "tendichvu";
            this.tendichvu.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "Dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // txtTimKiemDichVu
            // 
            this.txtTimKiemDichVu.Location = new System.Drawing.Point(99, 135);
            this.txtTimKiemDichVu.MenuManager = this.ribbonControl1;
            this.txtTimKiemDichVu.Name = "txtTimKiemDichVu";
            this.txtTimKiemDichVu.Size = new System.Drawing.Size(170, 20);
            this.txtTimKiemDichVu.TabIndex = 1;
            this.txtTimKiemDichVu.EditValueChanged += new System.EventHandler(this.txtTimKiemDichVu_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLoiChao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSuDungDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemDichVu.Properties)).EndInit();
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblLoiChao;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private DevExpress.XtraEditors.TextEdit txtTimKiemDichVu;
        private System.Windows.Forms.TextBox txtNgayThue;
        private System.Windows.Forms.TextBox txtSoChungMinh;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChiTietSuDungDichVu;
        private DevExpress.XtraBars.BarButtonItem btnThuePhong1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.Button btnXoaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn masudungdichvu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn madichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
    }
}

