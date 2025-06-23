using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;
using System.Text.RegularExpressions;

namespace MyPortfolioUdemy.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult Index()
		{
			var values=context.ToDoLists.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateToDoList()
		{
			
			return View();
		}


		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList) 
		{
			toDoList.Status = false;
			context.ToDoLists.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{
			var todo=context.ToDoLists.Find(id);
			context.ToDoLists.Remove(todo);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateTodoList(int id)
		{
			var todo = context.ToDoLists.Find(id);
			return View(todo);
		}

		[HttpPost]
		public IActionResult UpdateTodoList(ToDoList p)
		{
			 context.ToDoLists.Update(p);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeIsreadToTrue(int id)
		{
			var value=context.ToDoLists.Find(id);
			value.Status = true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeIsreadToFalse(int id)
		{
			var value = context.ToDoLists.Find(id);
			value.Status = false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
