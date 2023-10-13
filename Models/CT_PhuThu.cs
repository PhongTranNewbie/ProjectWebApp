using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models;
public class CT_PhuThu
{
    [StringLength(5, ErrorMessage = "Mã không được dài hơn 10 ký tự.")]
    public string MaPT { get; set; }
    [StringLength(5, ErrorMessage = "Mã không được dài hơn 10 ký tự.")]
    public string MaPhong { get; set; }
    [StringLength(5, ErrorMessage = "Mã không được dài hơn 10 ký tự.")]
    public string MaPhuThu { get; set; }
    public float sotienphuthu { get; set; }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (sotienphuthu > 0.5)
        {
            yield return new ValidationResult("Số tiền phụ thu phải bé hơn 50%.", new[] { "SoTienPhuThu" });
        }
    }
}
