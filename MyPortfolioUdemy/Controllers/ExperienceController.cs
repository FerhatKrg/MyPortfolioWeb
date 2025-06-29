﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult ExperienceList()
		{
			var values=context.Experiences.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateExperience()
		{ 
			return View();
		}

		[HttpPost]
		public IActionResult CreateExperience(Experience p)
		{ 
			context.Experiences.Add(p);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

		public IActionResult DeleteExperience(int id) 
		{
			var exp=context.Experiences.Find(id);
			context.Experiences.Remove(exp);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		[HttpGet]
		public IActionResult UpdateExperience(int id) 
		{
			var exp = context.Experiences.Find(id);
			
			return View(exp);
		}

		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			context.Experiences.Update(experience);
			context.SaveChanges();

			return RedirectToAction("ExperienceList");
		}
	}
}
