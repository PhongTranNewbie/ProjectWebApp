using System.ComponentModel.DataAnnotations;

public class PhuThu
{
    [StringLength(5, ErrorMessage = "Mã không được dài hơn 10 ký tự.")]
    public string MaPhuThu { get; set; }

    public DateTime NgayLap { get; set; }
}
