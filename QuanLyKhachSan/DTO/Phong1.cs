﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong1
    {
        private string maphong;
        private string tenphong;
        private string maloaiphong;
        private string tenloaiphong;
        private int songuoi;
        private decimal giaphong;

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

        public string Maloaiphong
        {
            get
            {
                return maloaiphong;
            }

            set
            {
                maloaiphong = value;
            }
        }

        public string Tenloaiphong
        {
            get
            {
                return tenloaiphong;
            }

            set
            {
                tenloaiphong = value;
            }
        }

        public int Songuoi
        {
            get
            {
                return songuoi;
            }

            set
            {
                songuoi = value;
            }
        }

        public decimal Giaphong
        {
            get
            {
                return giaphong;
            }

            set
            {
                giaphong = value;
            }
        }
    }
}
