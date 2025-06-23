using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext PortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=PortfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
