using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUUTRUNG.Models
{
    public class Province
    {

        [Key] // Đánh dấu đây là khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Không tự động tăng
        public int ProvinceId { get; set; }

        public string ProvinceName { get; set; }

        public string ProvinceType { get; set; }

    }
}
