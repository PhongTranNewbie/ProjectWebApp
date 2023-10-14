using System;
using System.ComponentModel.DataAnnotations;
namespace ProjectWeb.Models
{
    public class CT_PhieuThue
    {
        [StringLength(5, ErrorMessage = "Must have less than 5 characters.")]
        public string MPT { get; set; }
        [StringLength(5, ErrorMessage = "Must have less than 5 characters.")]
        public string MAPhong { get; set; }
        public DateTime NgayDen { get{ return _NgayDen;} set{ _NgayDen=value;} }
        public TimeSpan GioDen { get{return _GioDen;} set{_GioDen=value;} }
        public string NgayDi 
            { 
                get{return NgayDi;} 
                set
                {
                    if( value >= _NgayDen)
                    {
                        _NgayDi = value;
                    }
                    else{
                        throw new ArgumentException("NgayDi must be greater than or equal to NgayDen.");
                    }

                } 
            }
        [StringLength(5, ErrorMessage = "Must have less than 5 characters.")]
        public string MAHD { get { return _MAHD; }
            set { _maHD = value?.Length < 5 ? value : throw new ArgumentException("MaHD must have less than 5 characters"); } }
    }
}
