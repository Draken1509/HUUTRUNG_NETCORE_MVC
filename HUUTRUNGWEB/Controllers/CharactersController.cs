using Microsoft.AspNetCore.Mvc;

namespace HUUTRUNGWEB.Controllers
{
	public class CharactersController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
