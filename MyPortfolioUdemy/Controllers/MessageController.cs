using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using NuGet.Protocol.Plugins;
namespace MyPortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext Context=new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var values=Context.Messages.ToList();
			return View(values);
		}

		public IActionResult ChangeIsreadToTrue(int id)
		{
			var values = Context.Messages.Find(id);
			values.IsRead=true;
			Context.SaveChanges();
			return RedirectToAction("InBox");
		}


		public IActionResult ChangeIsreadToFalse(int id)
		{
			var values = Context.Messages.Find(id);
			values.IsRead = false;
			Context.SaveChanges();
			return RedirectToAction("InBox");
		}

		public IActionResult DeleteMessage(int id) 
		{
			var values = Context.Messages.Find(id);
			Context.Messages.Remove(values);
			Context.SaveChanges();
			return RedirectToAction("InBox");
		}

		public IActionResult MessageDetail(int id)
		{
			var values = Context.Messages.Find(id);
			
			return View(values);
		}

		
	}
}
