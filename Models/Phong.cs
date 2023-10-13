using System;

namespace Khachsan.Models
{
    public class Phong
    {
        public string maphong
        {
            get
            {
                return maphong;
            }
            set
            {
                if(value.Length < 3)
                {
                    maphong = value;
                }
                else
                {
                    Console.WriteLine("không thể nhập mã phòng trên");
                }
            }
        }
        public string maloaiphong { get; set; }
        public float dongia 
        {
            get { return dongia; }
            set 
            {
                if (value >= 100000)
                {
                    dongia = value;
                }
                else
                {
                    Console.WriteLine(" không thể nhập giá tiền trên ");
                }
            }
        }
        public string matrangthai
        {
            get
            {
                return matrangthai;
            }
            set
            {
                if(value.Length < 5)
                {
                    matrangthai = value;
                }
                else
                {
                    Console.WriteLine("không thể nhập được mã phòng trên");
                }
            }
        }
        public int soluongkhacho
        {
            get
            {
                return soluongkhacho;
            }
            set
            {
                if(value<=3)
                {
                    soluongkhacho = value;
                }
                else
                {
                    Console.WriteLine("không thể nhập số lượng khách ở ");
                }
            }
        }
    }
}
