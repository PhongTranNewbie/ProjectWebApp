using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models;
public class PhieuThue
{
    [Required, StringLength(5)]
    public string MPT(get;set;);
    [Required, StringLength(5)]
    public string MKH(get;set;);
    public DateTime NgayLapPhieu(get;set;);
}