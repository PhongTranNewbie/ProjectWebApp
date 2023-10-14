using System;
using System.ComponentModel.DataAnnotations;

namespace Khachsan.Models
{
    public class LoaiPhong
    {
        [RegularExpression("A|B|C", ErrorMessage = "Không thể nhập loại phòng trên.")]
        public string tenloaiphong { get; set; }

        [Range(500000, 1200000, ErrorMessage = "Không thể nhập giá tiền trên.")]
        public float dongia { get; set; }

        public string ghichu { get; set; }

        [Range(0, 300, ErrorMessage = "Không thể nhập số phòng trên.")]
        public int soluongphong { get; set; }

        [Range(0, 3, ErrorMessage = "Không thể nhập số lượng khách lớn hơn 3.")]
        public int maxsoluongkhach { get; set; }
    }
}
