using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models
{
    public class Type_client
    {
        [Required, DisplayName="Mã loại khách",RegularExpression(@"^\d{5}&")]
        public int Id_type_client { get; set; }
        [Required,DisplayName("Tên loại khách"), StringLength (10, MinimumLength = 0) ]
        public string type_client { get; set;} 
    }
}
