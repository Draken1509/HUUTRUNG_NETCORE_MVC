using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.Models
{
    public  class District
    {

       
      
        [Key] // Đánh dấu đây là khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Không tự động tăng

        public int DistrictId { get; set; }

        public string DistrictName { get; set; }

        public string DistrictType { get; set; }

        public int ProvinceId { get; set; }
    }
}
