using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private string maphong;
        private string tenphong;
        private string loaiphong;
        private bool dadat;
        private bool dathue;

        public string Maphong
        {
            get
            {
                return maphong;
            }

            set
            {
                maphong = value;
            }
        }

        public string Tenphong
        {
            get
            {
                return tenphong;
            }

            set
            {
                tenphong = value;
            }
        }

        public string Loaiphong
        {
            get
            {
                return loaiphong;
            }

            set
            {
                loaiphong = value;
            }
        }

        public bool Dadat
        {
            get
            {
                return dadat;
            }

            set
            {
                dadat = value;
            }
        }

        public bool Dathue
        {
            get
            {
                return dathue;
            }

            set
            {
                dathue = value;
            }
        }
    }
}
