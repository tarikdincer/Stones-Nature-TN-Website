using System.ComponentModel.DataAnnotations;

namespace StonesNatureTnWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
