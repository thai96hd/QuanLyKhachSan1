using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmThuePhong : Form
    {
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.ShowDialog();
            frmThuePhong_Load(sender, e);
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            cmbTimKiemKhach.SelectedIndex = 0;
            dgvKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KhachHangBUS khBUS = new KhachHangBUS();
            dgvKhach.DataSource = khBUS.DanhSachKhachHang();

        }

        private void txtTimKiemKhach_TextChanged(object sender, EventArgs e)
        {
            dgvKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KhachHangBUS khBUS = new KhachHangBUS();
            if (cmbTimKiemKhach.SelectedIndex == 0)
            {

                dgvKhach.DataSource = khBUS.TimKiemKhachHang(0, txtTimKiemKhach.Text);
            }
            else if (cmbTimKiemKhach.SelectedIndex == 1)
                dgvKhach.DataSource = khBUS.TimKiemKhachHang(1, txtTimKiemKhach.Text);
            else if (cmbTimKiemKhach.SelectedIndex == 2)
                dgvKhach.DataSource = khBUS.TimKiemKhachHang(2, txtTimKiemKhach.Text);
            else if (cmbTimKiemKhach.SelectedIndex == 3)
                dgvKhach.DataSource = khBUS.TimKiemKhachHang(3, txtTimKiemKhach.Text);
        }

        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow dgvr = dgvKhach.Rows[e.RowIndex];
                txtTenKhachHang.Text = dgvr.Cells["tenkhachhang"].Value.ToString();
                txtSoDienThoai.Text = dgvr.Cells["sodienthoai"].Value.ToString();
                txtSochunminh.Text = dgvr.Cells["sochungminh"].Value.ToString();
                txtGioiTinh.Text = dgvr.Cells["gioitinh"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvr.Cells["ngaysinh"].Value;

            }
            catch
            {

            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
          
           PhongBUS pBUS = new PhongBUS();
          // lvPhong.Clear();
            List<Phong1> list= pBUS.DanhSachPhongTrongTheoNgay(dtpNgayThue.Value,dtpNgaytra.Value);
            foreach(Phong1 p in list)
            {
                ListViewItem lvitem = new ListViewItem();
                lvitem.SubItems[0].Text = p.Maphong;
                lvitem.SubItems[0].Text = p.Tenphong;
                lvitem.SubItems[0].Text = p.Giaphong.ToString();
                lvitem.SubItems[0].Text = p.Songuoi.ToString();
                lvitem.SubItems[0].Text = p.Tenloaiphong;
                lvPhong.Items.Add(lvitem);
            }
            
        }
    }

}
