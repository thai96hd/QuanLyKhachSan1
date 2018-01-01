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
 public    class KhachHangDAL
    {
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
