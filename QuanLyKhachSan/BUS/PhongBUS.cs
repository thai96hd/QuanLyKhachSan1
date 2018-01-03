﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongBUS
    {
        public List<Phong> getListPhong()
        {
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.getListPhong();
        }
        public List<Phong> DanhSachPhongTrongTheoNgay(DateTime ngaythue,DateTime ngaytra)
        {
            return new PhongDAL().DanhSachPhongTrongTheoNgay(ngaythue, ngaytra);
        }
        public List<Phong> DanhSachPhongTrong()
        {
            return new PhongDAL().DanhSachPhongTrong();
        }
    }
}
