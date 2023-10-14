using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models
{
    public class Client
    {
        [Required,RegularExpression(@"^\d{8}$|^\d{12}$"),DisplayName("CCCD")]
        public long Id { get; set; }
        [Required,DisplayName("Họ"),StringLength(40, MinimumLength = 0)]
        public string ho { get; set; }
        [Required,DisplayName("TÊN"), StringLength(40, MinimumLength = 0)] 
        public string Name { get; set; }
        [Required, DisplayName("SĐT"), RegularExpression(@"^\d{10}$")]
        public long phone { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Địa chỉ")]
        public string place { get; set; }
        public string? id_type_client { get; set; }


    }
}
