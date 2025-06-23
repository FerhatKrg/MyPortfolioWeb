using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
	public class _FeatureComponentPartial : ViewComponent
	{
		MyPortfolioContext PortfolioContext = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values=PortfolioContext.Features.ToList();
			return View(values);
		}
	}
}
