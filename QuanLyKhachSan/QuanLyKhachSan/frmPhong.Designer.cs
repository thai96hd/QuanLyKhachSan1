namespace QuanLyKhachSan
{
    partial class frmPhong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTimKiemLP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaLP = new System.Windows.Forms.Button();
            this.txtGiaLP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNguoiLP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSuaLP = new System.Windows.Forms.Button();
            this.btnThemLP = new System.Windows.Forms.Button();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.Maloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Songuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.dgvLoaiPhong);
            this.tabPage2.Controls.Add(this.txtTimKiemLP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnXoaLP);
            this.tabPage2.Controls.Add(this.txtGiaLP);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSoNguoiLP);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtTenLP);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtMaLP);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnSuaLP);
            this.tabPage2.Controls.Add(this.btnThemLP);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại phòng";
            // 
            // txtTimKiemLP
            // 
            this.txtTimKiemLP.Location = new System.Drawing.Point(518, 167);
            this.txtTimKiemLP.Name = "txtTimKiemLP";
            this.txtTimKiemLP.Size = new System.Drawing.Size(179, 26);
            this.txtTimKiemLP.TabIndex = 47;
            this.txtTimKiemLP.TextChanged += new System.EventHandler(this.txtTimKiemLP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tìm kiếm";
            // 
            // btnXoaLP
            // 
            this.btnXoaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLP.Location = new System.Drawing.Point(285, 163);
            this.btnXoaLP.Name = "btnXoaLP";
            this.btnXoaLP.Size = new System.Drawing.Size(75, 40);
            this.btnXoaLP.TabIndex = 45;
            this.btnXoaLP.Text = "Xóa";
            this.btnXoaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLP.UseVisualStyleBackColor = true;
            this.btnXoaLP.Click += new System.EventHandler(this.btnXoaLP_Click);
            // 
            // txtGiaLP
            // 
            this.txtGiaLP.Location = new System.Drawing.Point(518, 78);
            this.txtGiaLP.Name = "txtGiaLP";
            this.txtGiaLP.Size = new System.Drawing.Size(179, 26);
            this.txtGiaLP.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Giá Phòng";
            // 
            // txtSoNguoiLP
            // 
            this.txtSoNguoiLP.Location = new System.Drawing.Point(518, 24);
            this.txtSoNguoiLP.Name = "txtSoNguoiLP";
            this.txtSoNguoiLP.Size = new System.Drawing.Size(179, 26);
            this.txtSoNguoiLP.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Số Người";
            // 
            // txtTenLP
            // 
            this.txtTenLP.Location = new System.Drawing.Point(167, 82);
            this.txtTenLP.Name = "txtTenLP";
            this.txtTenLP.Size = new System.Drawing.Size(193, 26);
            this.txtTenLP.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tên Loại Phòng";
            // 
            // txtMaLP
            // 
            this.txtMaLP.Location = new System.Drawing.Point(167, 25);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(193, 26);
            this.txtMaLP.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 19);
            this.label14.TabIndex = 37;
            this.label14.Text = "Mã Loại Phòng";
            // 
            // btnSuaLP
            // 
            this.btnSuaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLP.Location = new System.Drawing.Point(167, 163);
            this.btnSuaLP.Name = "btnSuaLP";
            this.btnSuaLP.Size = new System.Drawing.Size(75, 40);
            this.btnSuaLP.TabIndex = 36;
            this.btnSuaLP.Text = "Sửa";
            this.btnSuaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaLP.UseVisualStyleBackColor = true;
            this.btnSuaLP.Click += new System.EventHandler(this.btnSuaLP_Click);
            // 
            // btnThemLP
            // 
            this.btnThemLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLP.Location = new System.Drawing.Point(50, 163);
            this.btnThemLP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLP.Name = "btnThemLP";
            this.btnThemLP.Size = new System.Drawing.Size(85, 40);
            this.btnThemLP.TabIndex = 35;
            this.btnThemLP.Text = "Thêm";
            this.btnThemLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLP.UseVisualStyleBackColor = true;
            this.btnThemLP.Click += new System.EventHandler(this.btnThemLP_Click);
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloaiphong,
            this.Tenloaiphong,
            this.Songuoi,
            this.Giaphong});
            this.dgvLoaiPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(3, 254);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(811, 175);
            this.dgvLoaiPhong.TabIndex = 48;
            // 
            // Maloaiphong
            // 
            this.Maloaiphong.DataPropertyName = "Maloaiphong";
            this.Maloaiphong.HeaderText = "Mã Loại Phòng";
            this.Maloaiphong.Name = "Maloaiphong";
            this.Maloaiphong.ReadOnly = true;
            // 
            // Tenloaiphong
            // 
            this.Tenloaiphong.DataPropertyName = "Tenloaiphong";
            this.Tenloaiphong.HeaderText = "Tên Loại Phòng";
            this.Tenloaiphong.Name = "Tenloaiphong";
            this.Tenloaiphong.ReadOnly = true;
            // 
            // Songuoi
            // 
            this.Songuoi.DataPropertyName = "Songuoi";
            this.Songuoi.HeaderText = "Số Người";
            this.Songuoi.Name = "Songuoi";
            this.Songuoi.ReadOnly = true;
            // 
            // Giaphong
            // 
            this.Giaphong.DataPropertyName = "Giaphong";
            this.Giaphong.HeaderText = "Giá ";
            this.Giaphong.Name = "Giaphong";
            this.Giaphong.ReadOnly = true;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 464);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTimKiemLP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaLP;
        private System.Windows.Forms.TextBox txtGiaLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoNguoiLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSuaLP;
        private System.Windows.Forms.Button btnThemLP;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaphong;
    }
}