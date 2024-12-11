using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HUUTRUNG.Models
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        [Required]       
        public string Name { get; set; }  
        public string Thumbail { get; set; }
    }
}
