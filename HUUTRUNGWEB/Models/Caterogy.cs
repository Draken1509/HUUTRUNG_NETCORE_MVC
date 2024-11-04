using System.ComponentModel.DataAnnotations;

namespace HUUTRUNGWEB.Models
{
    public class Caterogy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
    }
}
