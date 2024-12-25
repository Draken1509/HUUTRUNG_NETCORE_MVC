using HUUTRUNG.Models.Domain;
using HUUTRUNG_WEBAPI.Repositories;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HUUTRUNG_WEBAPI.Model.DTO
{
    public class AddComicRequestDTO
    {


        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Thumbnail { get; set; }

        public string? Writer { get; set; }

        public string? ArtBy { get; set; }

        public DateTime? OnSaleDate { get; set; }

        public int ComicCategoryId { get; set; }
        public int SeriesId { get; set; }

        public SeriesDTO Series { get; set; }
        public ComicCategory ComicCategory { get; set; }

 

    }
}
