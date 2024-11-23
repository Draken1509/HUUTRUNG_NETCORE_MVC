using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUUTRUNG.Models.ViewModel.Customer
{
    public class ComicVM_C
    {
		//customer
		[ValidateNever]
		public Comic Comic { get; set; }
        [ValidateNever]
        public List<Comic> ComicList { get; set; }
        [ValidateNever]
        public List<Comic> ComicFreeList { get; set; }
        [ValidateNever]
        public List<Comic> ComicNewList { get; set; }
		[ValidateNever]
		public List<Comic> ComicRelatedSeriesList { get; set; }

	}
}
