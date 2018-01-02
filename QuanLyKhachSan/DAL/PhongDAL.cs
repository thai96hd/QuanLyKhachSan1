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
    public class PhongDAL
    {
        public List<Phong> getListPhong()
        {
            DataTable dt = new DataTable();
            dt=DataProvider.Instance.GetDataQuerry("select * from Phong  p join LoaiPhong lp on p.maloaiphong=lp.maloaiphong");
            List<Phong> list = new List<Phong>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Phong p = new Phong();
                p.Maphong = dr["maphong"].ToString();
                p.Tenphong = dr["tenphong"].ToString();
                p.Loaiphong = dr["tenloaiphong"].ToString();
                p.Dadat =(bool) dr["dadat"];
                p.Dathue= (bool)dr["dathue"];
                list.Add(p);
            }
            return list;
        }
        public List<Phong1> DanhSachPhongTrongTheoNgay(DateTime ngaythue,DateTime ngaytra)
        {
            DataTable dt = new DataTable();
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@ngayden",ngaythue),
                new SqlParameter("@ngaytra",ngaytra)
            };
            dt = DataProvider.Instance.GetData("sp_timkiemphongtheongay", pa);
            List<Phong1> list = new List<Phong1>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Phong1 p = new Phong1();
                p.Maphong = dr["maphong"].ToString();
                p.Tenphong = dr["tenphong"].ToString();
                p.Tenloaiphong = dr["tenloaiphong"].ToString();
                p.Giaphong = Decimal.Parse(dr["giaphong"].ToString());
                p.Songuoi = (int)dr["songuoi"];
                p.Maloaiphong = dr["maloaiphong"].ToString();
                list.Add(p);
            }
            return list;
        }
    }
}
