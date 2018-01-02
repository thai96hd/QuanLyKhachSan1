using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThietBi
    {
        private string mathietbi;
        private string tenthietbi;
        private decimal giathietbi;
        private int soluong;
        public string Mathietbi { get => mathietbi; set => mathietbi = value; }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public decimal Giathietbi { get => giathietbi; set => giathietbi = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
