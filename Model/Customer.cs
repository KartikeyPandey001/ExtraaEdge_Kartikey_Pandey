using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileSalesExtraedgeassignment.Model
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string? CustomerName { get; set; }
        [Required]
        public string? CustomerAdress { get; set; }
    }
}
