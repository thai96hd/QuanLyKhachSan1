using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVuBUS
    {
        public List<DichVu> DanhSachDichVu()
        {
            return new DichVuDAL().DanhSachDichVu();
        }
        public List<DichVu> TimKiemDichVu(string chuoitimkiem)
        {
            return new DichVuDAL().TimKiemDichVu(chuoitimkiem);
        }
    }
}
