using System;
using System.ComponentModel.DataAnnotations;

namespace Khachsan.Models
{
    public class Phong
    {
        [StringLength(2, ErrorMessage = "Mã phòng không thể có nhiều hơn 2 ký tự.")]
        public string maphong { get; set; }

        public string maloaiphong { get; set; }

        [Range(100000, double.MaxValue, ErrorMessage = "Giá tiền không thể nhỏ hơn 100000.")]
        public float dongia { get; set; }

        [StringLength(4, ErrorMessage = "Mã trạng thái không thể có nhiều hơn 4 ký tự.")]
        public string matrangthai { get; set; }

        [Range(0, 3, ErrorMessage = "Số lượng khách ở không thể lớn hơn 3.")]
        public int soluongkhacho { get; set; }
    }
}
