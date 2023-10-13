using System;

namespace Khachsan.Models
{
    public class LoaiPhong
    {
        public string tenloaiphong { get; set; }
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
        public string ghichu { get; set; }
        public int soluongphong {  get ; set; }
        public int maxsoluongkhach {  get; set; }
    }
}
