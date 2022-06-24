using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StonesNatureTnWeb.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product product { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}
