using System;

namespace Khachsan.Models
{
    public class LoaiPhong
    {
        private string _tenloaiphong;
        public string tenloaiphong
        {
            get { return _tenloaiphong; }
            set
            {
                if (value == "A" || value == "B" || value == "C")
                {
                    _tenloaiphong = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập loại phòng trên.");
                }
            }
        }
        private float _dongia;
        public float dongia
        {
            get { return _dongia; }
            set
            {
                if (value == 500000 || value == 700000 || value == 1200000)
                {
                    _dongia = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập giá tiền trên.");
                }
            }
        }
        public string ghichu { get; set; }
        private int _soluongphong;
        public int soluongphong
        {
            get { return _soluongphong; }
            set
            {
                if (value <= 300)
                {
                    _soluongphong = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập số phòng trên.");
                }
            }
        }
        private int _maxsoluongkhach;
        public int maxsoluongkhach
        {
            get { return _maxsoluongkhach; }
            set
            {
                if (value <= 3)
                {
                    _maxsoluongkhach = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập số lượng khách lớn hơn 3.");
                }
            }
        }
    }
}
