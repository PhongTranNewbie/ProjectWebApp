using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeb.Models
{
    public class Type_client
    {
        public int Id_type_client { get; set; }
        [Required,DisplayName("Loại khách")]
        public string type_client { get; set; }
    }
}
