using HUUTRUNG_WEBAPI.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.Models.DTO
{
    public class ComicPagedDTO
    {
        public List<ComicDTO> Comics { get; set; }
        public int TotalItems { get; set; }   
    }
}
