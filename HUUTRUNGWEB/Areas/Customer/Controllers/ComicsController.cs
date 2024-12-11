using HUUTRUNG.DataAccess.Repository;
using HUUTRUNG.DataAccess.Repository.IRepository;
using HUUTRUNG.Models;
using HUUTRUNG.Models.ViewModel.Admin;
using HUUTRUNG.Models.ViewModel.Customer;
using HUUTRUNG.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Common;
using System.Security.Claims;


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
			ShoppingCartVM shoppingCartVM = new()
			{
				ComicFreeList = comicList.Where(c => c.IsFree == true).ToList(),
				ComicNewList = comicList.Where(c => c.IsNew == true).ToList(),
				ComicList = comicList,	
                
			};			
			return View(shoppingCartVM);
		}
        
		public IActionResult Details(int ? comicId) {
            Comic comic = _unitOfWork.Comic.Get(u => u.Id == comicId, includeProperties: "TypeComic");        
            ShoppingCartVM shoppingCartVM = new()
            {
                ComicRelatedSeriesList = _unitOfWork.Comic.GetAll(c => c.SeriesId == comic.SeriesId)               
                .Select(c => new Comic
                {
                    Id = c.Id,
                    Price = c.Price,
                    Thumbnail = c.Thumbnail,
                    Name = c.Name,
                })
                .OrderBy(c => c.Name) // Sắp xếp theo tên
                .ToList(),

                ShoppingCart = new()
                {
                    Comic = comic,
                    Count = 1,
                    ComicId = comicId ?? 0
                }
            };
            return View(shoppingCartVM);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCartVM shoppingCartVM)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            shoppingCartVM.ShoppingCart.ApplicationUserId = userId;
            ShoppingCart cartFromDb =
                 _unitOfWork
                .ShoppingCart
                .Get(u => u.ApplicationUserId == userId && u.ComicId == shoppingCartVM.ShoppingCart.ComicId);

            if (cartFromDb != null)
            {
                cartFromDb.Count += shoppingCartVM.ShoppingCart.Count;
               // _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.ShoppingCart.Add(shoppingCartVM.ShoppingCart);
                _unitOfWork.Save();
                HttpContext.Session.SetInt32(SD.SessionCart,
               _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId).Count());
            }
          
            TempData["success"] = "Cart updated successfully!";

            return RedirectToAction(nameof(Index));
        }

    }


}

