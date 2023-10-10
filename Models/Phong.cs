using System;

namespace Khachsan.Models
{
    public class Phong
    {
        public string maphong { get; set; }
        public string maloaiphong { get; set; }
        public float dongia 
        {
            get { return dongia; }
            set 
            {
                if (value != 100000)
                {
                    dongia = value;
                }
                else
                {
                    Console.WriteLine(" không thể nhập giá tiền trên ");
                }
            }
        }
        public string matrangthai {  get; set; }
        public int soluongkhacho { get; set; }
    }
}
