using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCard_MVC.Controllers
{
	public class HomeController : Controller
	{
		

		public HomeController()
		{
			
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Contact()//get data of page
		{

			var model = new Contact();
			return View(model);
		}


		//[HttpPost]
		//public JsonResult Contact(IFormCollection form) //Send data to page
		//{


		//	var name=form["name"];
		//return Json(Ok()  );

		//}

		[HttpPost]
		public JsonResult Contact(Contact form)
		{
	
			return Json( Ok() );


		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}



    }
}
