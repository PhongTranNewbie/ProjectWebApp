using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models;
public class CT_HoaDon
{
    [Required, StringLength(5, MinimumLength = 0, DisplayName("Mã Hóa Đơn")]
    public string MAHD { get; set; };
    [Required, StringLength(5, MinimumLength = 0, DisplayName("Mã Phiếu Thuê")]
    public string MAPT { get; set; };
    [Required, StringLength(5, MinimumLength = 0, DisplayName("Mã Phòng")]
    public string MAPHONG { get; set; };
    [Range(1,100), DisplayName("Số ngày")]
    public int? SONGAY { get; set; };
    [Required, Range(500000, int.MaxValue), DisplayName("Đơn Giá")]
    public int DONGIA { get; set; };
    [Required, Range(500000, int.MaxValue), DisplayName("Thành Tiền")]
    public int THANHTIEN { get; set; };
}