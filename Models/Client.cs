using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models
{
    public class Client
    {
        [Required,Range(10000000,999999999999),DisplayName("CCCD")]
        public long Id { get; set; }
        [Required,DisplayName("Họ")]
        public string ho { get; set; }
        [Required,DisplayName("TÊN")]
        public string Name { get; set; }
        [Required, DisplayName("SĐt"),Range(10000000000,999999999999)]
        public long? phone { get; set; }
        [ DisplayName("Email")]
        public string? Email { get; set; }
        [DisplayName("Địa chỉ")]
        public string? place { get; set; }
        public string? id_type_client { get; set; }


    }
}
