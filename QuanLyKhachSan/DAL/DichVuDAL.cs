using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DichVuDAL
    {
        public List<DichVu> DanhSachDichVu()
        {
            List<DichVu> list = new List<DichVu>();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from DichVu");
            foreach(DataRow dr in dt.Rows)
            {
                DichVu d = new DichVu();
                d.Madichvu = dr["madichvu"].ToString();
                d.Tendichvu = dr["tendichvu"].ToString();
                d.Dongia =Decimal.Parse( dr["dongia"].ToString());
                list.Add(d);
            }
            return list;
        }
        public List<DichVu> TimKiemDichVu(string chuoitimkiem)
        {

            List<DichVu> list = new List<DichVu>();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select * from DichVu where tendichvu like N'%" + chuoitimkiem + "%'");
            foreach (DataRow dr in dt.Rows)
            {
                DichVu d = new DichVu();
                d.Madichvu = dr["madichvu"].ToString();
                d.Tendichvu = dr["tendichvu"].ToString();
                d.Dongia = Decimal.Parse(dr["dongia"].ToString());
                list.Add(d);
            }
            return list;
        }
    }
}
