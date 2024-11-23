using HUUTRUNG.DataAccess.Repository.IRepository;
using HUUTRUNG.Models;
using HUUTRUNG.Models.ViewModel.Admin;
using HUUTRUNG.Models.ViewModel.Customer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Common;


namespace HUUTRUNGWEB.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ComicsController : Controller
    {
		private readonly ILogger<ComicsController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public ComicsController(ILogger<ComicsController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
			var comicList = _unitOfWork.Comic.GetAll().ToList();
			ComicVM_C comicVM = new()
			{
				ComicFreeList = comicList.Where(c => c.IsFree == true).ToList(),
				ComicNewList = comicList.Where(c => c.IsNew == true).ToList(),
				ComicList = comicList,				
			};			
			return View(comicVM);
		}
		public IActionResult Details(int ? comicId) {
			var comic = _unitOfWork.Comic.Get(u => u.Id == comicId, inclueProperties: "TypeComic");
            ComicVM_C ComicVM_C = new()
            {
                Comic = comic,
                ComicRelatedSeriesList = _unitOfWork.Comic.GetAll()
                .Where(c => c.SeriesId == comic.SeriesId)
                .Select(c => new Comic
                {
                    Id = c.Id,
                    Price=c.Price,
                    Thumbnail = c.Thumbnail,
                    Name = c.Name,
                })
                .OrderBy(c => c.Name) // Sắp xếp theo tên
                .ToList()
                };

            return View(ComicVM_C);
		}

    }


}
