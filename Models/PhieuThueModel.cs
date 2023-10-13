using System;
using System.ComponentModel.DataAnnotations;
namespace ProjectWeb.Models
{
    public class PhieuThue
    {
        [StringLength(5, ErrorMessage = "Must have less than 5 characters.")]
        public string MPT { get; set; }
        [StringLength(5, ErrorMessage = "Must have less than 5 characters.")]
        public string MKH { get; set; }
        public DateTime NgayLapPhieu { get{return NgayLapPhieu; } set{ NgayLapPhieu = DateTime.Now;} }
    }
}
