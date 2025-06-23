using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.ViewComponents
{
	public class _ContactComponentPartial : ViewComponent
	{
		
		public IViewComponentResult Invoke() { return View(); }


		
	}
}
