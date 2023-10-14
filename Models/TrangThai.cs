using System;
using System.ComponentModel.DataAnnotations;

namespace Khachsan.Models
{
    public class TrangThai
    {
        [StringLength(5, ErrorMessage = "Mã trạng thái không thể có nhiều hơn 5 ký tự.")]
        public string matrangthai { get; set; }

        [StringLength(10, ErrorMessage = "Tên trạng thái không thể có nhiều hơn 10 ký tự.")]
        public string tentrangthai { get; set; }
    }
}
