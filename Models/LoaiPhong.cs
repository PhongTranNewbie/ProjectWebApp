using System;

namespace Khachsan.Models
{
    public class LoaiPhong
    {
        public string tenloaiphong
        {
            get
            {
                return tenloaiphong;
            }
            set
            {
                if(value=="A" ||  value=="B" || value=="C")
                {
                    tenloaiphong = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập loại phòng trên");
                }
            }
        }
        public float dongia 
        {
            get { return dongia; }
            set
            {
                if (value == 500000 || value==700000 || value==1200000)
                {
                    dongia = value;
                }
                else
                {
                    Console.WriteLine(" không thể nhập giá tiền trên ");
                }
            }
        }
        public string ghichu { set; }
        public int soluongphong
        {
            get
            {
                return soluongphong;
            }
            set
            {
                if (value<=300)
                {
                    soluongphong = value;
                }
                else
                {
                    Console.WriteLine("Không thể nhập số phòng trên");
                }
            }
        }
        public int maxsoluongkhach
        {
            get
            {
                return maxsoluongkhach;
            }
            set
            {
                if(value <=3)
                {
                    maxsoluongkhach = value;
                }
                else
                {
                    Console.WriteLine("không thể nhập số lượng khách lớn hơn 3");
                }
            }
        }
    }
}
