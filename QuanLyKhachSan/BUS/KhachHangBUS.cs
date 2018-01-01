using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        public bool ThemKhachHang(KhachHang kh)
        {
            KhachHangDAL khDAL = new KhachHangDAL();
            return khDAL.ThemKhachHang(kh);
        }
    }
}
