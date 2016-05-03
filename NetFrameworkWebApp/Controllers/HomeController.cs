using System;
using System.Web.Mvc;

namespace NetFrameworkWebApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = $"Running on {Environment.MachineName}";

			return View();
		}
	}
}