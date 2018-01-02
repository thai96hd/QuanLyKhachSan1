using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Phân quyền cho nhân viên hệ thống
            lblLoiChao.Text += NhanVien.Instance.Tennhanvien;
            if (NhanVien.Instance.Quyenhan == 2)
            {
                btnQuanLyDichVu.Enabled = false;
                btnQuanLyKhachHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnQuanLyTrangThietBi.Enabled = false;
                btnQuanLyPhong.Enabled = false;
                
            }
            #endregion
            PhongBUS phongBUS = new PhongBUS();
            dataGridView1.DataSource = phongBUS.getListPhong();
            lvPhong.LargeImageList = imageList1;
            lvPhong.View = View.LargeIcon;
            foreach(Phong p in  phongBUS.getListPhong())
            {
                ListViewItem lvItem = new ListViewItem(p.Tenphong);
                lvItem.SubItems.Add(p.Maphong);
                lvItem.SubItems.Add(p.Loaiphong);
                if (p.Dathue == false)
                {
                    lvItem.ImageIndex = 0;
                    lvItem.BackColor = Color.Green;
                }
                else
                {
                    lvItem.ImageIndex = 1;
                    lvItem.BackColor = Color.Red;
                }
                lvPhong.Items.Add(lvItem);

            }
           
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.ShowDialog();
        }

        private void btnQuanLyNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLyNhanVien f = new frmQuanLyNhanVien();
            f.ShowDialog();
        }


        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            frmThuePhong f = new frmThuePhong();
            f.ShowDialog();
        }
        private void btnQuanLyTrangThietBi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThietBi f = new frmThietBi();
            f.ShowDialog();
        }

        private void btnQuanLyPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhong f = new frmPhong();
            f.ShowDialog();
        }
    }
}
