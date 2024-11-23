using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HUUTRUNG.Models
{
    public class Alignment
	{
        [Key]
        public int Id { get; set; }

        [Required]             
        public string Name { get; set; }                        
    }
}
