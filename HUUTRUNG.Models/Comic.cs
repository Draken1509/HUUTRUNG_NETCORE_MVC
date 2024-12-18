﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Xml.Linq;

namespace HUUTRUNG.Models
{
    public class Comic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Character name")]
        [MaxLength(100)]
        public string Name { get; set; }
       
        public string? Description { get; set; }
        
        public string? Thumbnail { get; set; }

        public string? Writer { get; set; }

        public string? ArtBy { get; set; }

        public string? Cover { get; set; }

        public string? Colorist { get; set; }

        [Display(Name = "List Price ")]
        [Range(1, 1000)]
        public double? Price { get; set; }

        [Display(Name = "List Price 50")]
        [Range(1, 1000)]
        public double? Price50 { get; set; }

        [Display(Name = "List Price 100")]
        [Range(1, 1000)]
        public double? Price100 { get; set; }

      
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime? OnSaleDate { get; set; }

        [Display(Name = "Page Count")]
        public int? PageCount { get; set; }

        public string? Rated { get; set; }

        [Display(Name="Comic Free")]
		public bool IsFree { get; set; }
        [Display(Name = "Comic New")]
        public bool IsNew { get; set; }

		public DateTime? Created_at { get; set; }

        public DateTime? Updated_at { get; set; }

        //add foreign key - TypeComic
        [Display(Name = "Type Comic")]      
        public int? TypeComicId { get; set; }
        [ForeignKey("ComicCategoryId")]
        [ValidateNever]
        [Display(Name = "Type")]
        public ComicCategory? ComicCategory { get; set; }

		//add foreign key - Series
		[Display(Name = "Series")]
		public int? SeriesId { get; set; }
		[ForeignKey("SeriesId")]
        [ValidateNever]
        public Series? Series { get; set; }



	}
}
