using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Linq.Expressions;

namespace DevCard_MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly List<Service> _services = new List<Service>
		{
			new Service(1,"نقرهای"),
			new Service(2 , "طلایی"),
			new Service(3 , "پلاتین"),
			new Service(4 , "الماس"),


		};

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

			var model = new Contact
			{
				Services = new SelectList(_services, "Id", "Name")
			};
			return View(model);
		}


		//[HttpPost]
		//public JsonResult Contact(IFormCollection form) //Send data to page
		//{


		//	var name=form["name"];
		//return Json(Ok()  );

		//}

		[HttpPost]
		public IActionResult Contact(Contact model)
		{

			model.Services = new SelectList(_services, "Id", "Name");

			if (!ModelState.IsValid)
			{  // is empty
				ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره امتحان کنید";
				return View(model);
			}
			ModelState.Clear();
			model = new Contact
			{

				Services = new SelectList(_services, "Id", "Name")

			};


			////If was empty
			//return RedirectToAction("Index");
			ViewBag.success = "پیغام شما با موفقیت ارسال شد. با تشکر";
			return View(model);

		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}



	}
}
