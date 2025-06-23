using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
	public class Default : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
