using System;

namespace Khachsan.Models
{
    public class Phong
    {
        private string _maphong;
        public string maphong
        {
            get { return _maphong; }
            set
            {
                if (value.Length < 3)
                {
                    _maphong = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập mã phòng trên.");
                }
            }
        }

        public string maloaiphong { get; set; }

        private float _dongia;
        public float dongia
        {
            get { return _dongia; }
            set
            {
                if (value >= 100000)
                {
                    _dongia = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập giá tiền trên.");
                }
            }
        }

        private string _matrangthai;
        public string matrangthai
        {
            get { return _matrangthai; }
            set
            {
                if (value.Length < 5)
                {
                    _matrangthai = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập mã trạng thái trên.");
                }
            }
        }

        private int _soluongkhacho;
        public int soluongkhacho
        {
            get { return _soluongkhacho; }
            set
            {
                if (value <= 3)
                {
                    _soluongkhacho = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập số lượng khách ở.");
                }
            }
        }
    }
}
