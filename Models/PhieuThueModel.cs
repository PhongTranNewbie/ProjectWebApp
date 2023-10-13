using System;
using System.ComponentModel.DataAnnotations;
namespace ProjectWeb.Models
{
    public class PhieuThue
    {
        [StringLength(5, ErrorMessage = "Mã không được dài hơn 10 ký tự.")]
        public string MPT { get; set; }
        [StringLength(5, ErrorMessage = "Mã không được dài hơn 10 ký tự.")]
        public string MKH { get; set; }
        public DateTime NgayLapPhieu { get{return NgayLapPhieu; } set{ NgayLapPhieu = DateTime.Now;} }
    }
}
