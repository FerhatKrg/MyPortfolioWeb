using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext Context=new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = Context.Skills.Count();
			ViewBag.v2 = Context.Messages.Count();
			ViewBag.v3 = Context.Messages.Where(x=>x.IsRead==false).Count();
			ViewBag.v4 = Context.Messages.Where(x=>x.IsRead==true).Count();
			
			return View();
		}
	}
}
