using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class LoaiPhong
    {
        private string maloaiphong;
        private string tenloaiphong;
        private int songuoi;
        private decimal giaphong;

        public string Maloaiphong { get => maloaiphong; set => maloaiphong = value; }
        public string Tenloaiphong { get => tenloaiphong; set => tenloaiphong = value; }
        public int Songuoi { get => songuoi; set => songuoi = value; }
        public decimal Giaphong { get => giaphong; set => giaphong = value; }
    }
}
