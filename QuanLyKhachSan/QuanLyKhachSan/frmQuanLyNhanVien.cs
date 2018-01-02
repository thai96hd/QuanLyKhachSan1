using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmQuanLyNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cmbTimKiem.SelectedIndex = 0;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.DataSource = new NhanVienBUS().DanhSachNhanVien();
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}