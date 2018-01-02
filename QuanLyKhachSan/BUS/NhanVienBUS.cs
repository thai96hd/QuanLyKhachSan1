using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class NhanVienBUS
    {
        public bool DangNhap(string tk,string mk)
        {
            return new NhanVienDAL().DangNhap(tk, mk);
        }
        public NhanVien LayThongTinNhanVien(string tk,string mk)
        {
            return new NhanVienDAL().LayThongTinNhanVien(tk, mk);
        }
        public bool DoiMatKhau(string manhanvien,string matkhau)
        {
            return new NhanVienDAL().DoiMatKhau(manhanvien, matkhau);
        }
        public List<NhanVien1> DanhSachNhanVien()
        {
            return new NhanVienDAL().DanhSachNhanVien();
        }
    }
}
