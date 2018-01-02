using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class NhanVienDAL
    {
        public NhanVien LayThongTinNhanVien(string tk,string mk)
        {
            int i = 2;
            DataTable dt = new DataTable();
            string query = "select *from [NhanVien] where taikhoan='" + tk + "' and matkhau='" + mk + "'";
            dt = DataProvider.Instance.GetDataQuerry(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                NhanVien.Instance.Manhanvien = dr["manhanvien"].ToString();
                NhanVien.Instance.Matkhau = mk;
                NhanVien.Instance.Taikhoan = tk;
                NhanVien.Instance.Quyenhan = Int16.Parse(dr["quyenhan"].ToString());
                NhanVien.Instance.Tennhanvien = dr["tennhanvien"].ToString();
                NhanVien.Instance.Gioitinh = dr["gioitinh"].ToString();
                NhanVien.Instance.Quequan = dr["quequan"].ToString();
                NhanVien.Instance.Ngaysinh = (DateTime)dr["ngaysinh"];
            }
            
         
            return NhanVien.Instance;
        }
        public bool DangNhap(string taikhoan,string matkhau)
        {
            SqlParameter[] parames = new SqlParameter[]
           {
                new SqlParameter("@taikhoan",taikhoan),
                new SqlParameter("@matkhau",matkhau)
           };
            return DataProvider.Instance.DangNhap("sp_checklogin", parames) > 0;
        }
        public bool DoiMatKhau(string manhanvien,string matkhau)
        {
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@matkhau",matkhau)
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_doimatkhau",pa)>0;
        }
        public List<NhanVien1> DanhSachNhanVien()
        {
            List<NhanVien1> listnv = new List<NhanVien1>();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from NhanVien");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                NhanVien1 nv = new NhanVien1();
                nv.Manhanvien = dr["manhanvien"].ToString();
                nv.Tennhanvien = dr["tennhanvien"].ToString();
                nv.Quyenhan = Int16.Parse( dr["quyenhan"].ToString());
                nv.Taikhoan= dr["taikhoan"].ToString();
                nv.Matkhau = dr["matkhau"].ToString();
                nv.Ngaysinh = (DateTime)dr["ngaysinh"];
                nv.Gioitinh = dr["gioitinh"].ToString();
                nv.Quequan = dr["quequan"].ToString();
                listnv.Add(nv);
            }
            return listnv;
        }
    }
}
