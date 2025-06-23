using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class SkillController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AddSkill(Skill skill)
		{
			context.Skills.Add(skill);
			return View();
		}
	}
}
