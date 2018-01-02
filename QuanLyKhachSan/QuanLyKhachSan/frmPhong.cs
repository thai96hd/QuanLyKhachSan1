using BUS;
using System;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmPhong : Form
    {
        private LoaiPhongBUS lpBus = new LoaiPhongBUS();

        public frmPhong()
        {
            InitializeComponent();
            DanhSachLoaiPhong();
            LoaiPhongBiding();
        }

        private void DanhSachLoaiPhong()
        {
            dgvLoaiPhong.DataSource = lpBus.DanhSachLoaiPhong();
        }

        private void LoaiPhongBiding()
        {
            txtMaLP.DataBindings.Clear();
            txtMaLP.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "Maloaiphong", true, DataSourceUpdateMode.Never));
            txtTenLP.DataBindings.Clear();
            txtTenLP.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "Tenloaiphong", true, DataSourceUpdateMode.Never));
            txtGiaLP.DataBindings.Clear();
            txtGiaLP.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "Giaphong", true, DataSourceUpdateMode.Never));
            txtSoNguoiLP.DataBindings.Clear();
            txtSoNguoiLP.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "Songuoi", true, DataSourceUpdateMode.Never));
        }

        private void btnThemLP_Click(object sender, EventArgs e)
        {
            string maloaiphong = txtMaLP.Text;
            string tenloaiphong = txtTenLP.Text;
            decimal giaphong = Decimal.Parse(txtGiaLP.Text);
            int songuoi = Int32.Parse(txtSoNguoiLP.Text);
            if (maloaiphong.ToString() != "" && tenloaiphong.ToString() != "" && giaphong.ToString() != "" && songuoi.ToString() != "")
            {
                if (lpBus.ThemLoaiPhong(maloaiphong, tenloaiphong, giaphong, songuoi))
                {
                    MessageBox.Show("Thêm mới thành công");
                    DanhSachLoaiPhong();
                    LoaiPhongBiding();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm ");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập dữ liệu!");
            }
        }

        private void btnSuaLP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa nó", "Thông báo!!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string maloaiphong = txtMaLP.Text;
                string tenloaiphong = txtTenLP.Text;
                decimal giaphong = Decimal.Parse(txtGiaLP.Text);
                int songuoi = Int32.Parse(txtSoNguoiLP.Text);
                if (lpBus.SuaLoaiPhong(maloaiphong, tenloaiphong, giaphong, songuoi))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Sửa");
                }
                DanhSachLoaiPhong();
                LoaiPhongBiding();
            }
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa nó?? ";
            string caption = "Thông báo!!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string maloaiphong = txtMaLP.Text;
                if (lpBus.XoaLoaiPhong(maloaiphong))
                {

                    MessageBox.Show("Xóa thành công!!!");
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }
                DanhSachLoaiPhong();
                LoaiPhongBiding();
            }
        }

        private void txtTimKiemLP_TextChanged(object sender, EventArgs e)
        {
            dgvLoaiPhong.DataSource = lpBus.TimKiemloaiphong(txtTimKiemLP.Text);
        }
    }
}