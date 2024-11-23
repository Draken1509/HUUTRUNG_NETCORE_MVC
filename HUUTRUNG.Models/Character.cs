using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.Models
{
	public class Character
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[DisplayName("Character name")]
		[MaxLength(30)]
		public string Name { get; set; }
	
		public string Thumbnail {  get; set; }

		[DisplayName("Character name")]
		[MaxLength(100)]
		public string Power { get; set; }

		[DisplayName("Alias/Alter Ego")]
		
		public string Alias { get; set; }
		
		public string Description{ get; set; }

		[DisplayName("First Appearance")]	
		public string FirstAppearance { get; set; }

		[MaxLength(30)]
		public string BaseOfOperations { get; set; }
		[MaxLength(30)]

		[DisplayName("Occupation")]
		public string Occupation { get; set; }

		public DateTime Created_at { get; set; }

		public DateTime Updated_at { get; set; }



		//[Display(Name="List Price")]
		//[Range(1,1000)]
		//public string Price { get; set; }

		//[Display(Name = "List Price")]
		//[Range(1, 1000)]
		//public string Price50 { get; set; }

		//[Display(Name = "List Price")]
		//[Range(1, 1000)]
		//public string Price100 { get; set; }

	}
}
