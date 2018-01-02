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
    public class KhachHangDAL
    {
        public List<KhachHang> DanhSachKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from KhachHang");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                KhachHang kh = new KhachHang();
                kh.Makhachhang = dr["makhachhang"].ToString();
                kh.Tenkhachhang = dr["tenkhachhang"].ToString();
                kh.Sochungminh = dr["sochungminh"].ToString();
                kh.Ngaysinh = (DateTime)dr["ngaysinh"];
                kh.Sodienthoai = dr["sodienthoai"].ToString();
                kh.Gioitinh = dr["gioitinh"].ToString();
                kh.Diadiem = dr["diadiem"].ToString();
                list.Add(kh);
            }
            return list;
        }
        public List<KhachHang> TimKiemKhachHang(int danhmuctimkiem,string chuoitimkiem)
        {
            List<KhachHang> list = new List<KhachHang>();
            DataTable dt = new DataTable();
            if (danhmuctimkiem == 0)
                dt = DataProvider.Instance.GetDataQuerry("select * from KhachHang where tenkhachhang like N'%"+chuoitimkiem+"%'");
            else if(danhmuctimkiem==1)
                dt= DataProvider.Instance.GetDataQuerry("select * from KhachHang where makhachhang like N'%" + chuoitimkiem + "%'");
            else if(danhmuctimkiem==2)
                dt = DataProvider.Instance.GetDataQuerry("select * from KhachHang where sochungminh like '%" + chuoitimkiem + "%'");
            else if (danhmuctimkiem == 3)
            {
                dt = DataProvider.Instance.GetDataQuerry("select * from KhachHang where sodienthoai like N'%" + chuoitimkiem + "%'");
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                KhachHang kh = new KhachHang();
                kh.Makhachhang = dr["makhachhang"].ToString();
                kh.Tenkhachhang = dr["tenkhachhang"].ToString();
                kh.Sochungminh = dr["sochungminh"].ToString();
                kh.Ngaysinh = (DateTime)dr["ngaysinh"];
                kh.Sodienthoai = dr["sodienthoai"].ToString();
                kh.Gioitinh = dr["gioitinh"].ToString();
                kh.Diadiem = dr["diadiem"].ToString();
                list.Add(kh);
            }
    
                return list;
           
        }
        public bool ThemKhachHang(KhachHang kh)
        {
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@makhachhang",sinhmakhachhang()),
                new SqlParameter("@tenkhachhang",kh.Tenkhachhang),
                new SqlParameter("@sodienthoai",kh.Sodienthoai),
                new SqlParameter("@ngaysinh",kh.Ngaysinh),
                new SqlParameter("@gioitinh",kh.Gioitinh),
                new SqlParameter("@sochungminh",kh.Sochungminh),
                new SqlParameter("@diadiem",kh.Diadiem)
            };

            return DataProvider.Instance.ExecuteNonQuery("sp_themkhachhang", pa) > 0;
        }
        public string sinhmakhachhang()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from KhachHang");
            if (dt.Rows.Count < 0)
            {
                s = "KH0001";
            }
            else
            {
                int k = dt.Rows.Count;
                if (k < 9)
                {
                    s = "KH000" + (k + 1).ToString();
                }
                else if (k >= 9 && k < 99)
                {
                    s = "KH00" + (k + 1).ToString();
                }
                else if (k >= 99 && k < 999)
                {
                    s = "KH0" + (k + 1).ToString();
                }
                else if (k >= 999)
                    s = "KH" + (k + 1).ToString();

            }
            return s;
        }

    }
}
