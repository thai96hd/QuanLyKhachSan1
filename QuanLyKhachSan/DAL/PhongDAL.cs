using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
