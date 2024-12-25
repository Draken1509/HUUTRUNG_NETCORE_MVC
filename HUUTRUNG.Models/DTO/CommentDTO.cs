using HUUTRUNG.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace HUUTRUNG_WEBAPI.Repositories
{
    public class CommentDTO
    {
        public int? CommentId { get; set; }
        [Required]
        public string Content { get; set; }
        public int? LikeCount { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreateAt { get; set; }

        public ApplicationUserDTO? ApplicationUser { get; set; }
    }
}