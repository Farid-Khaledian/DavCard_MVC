using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke() // This method return that view component where we create 
        {

            var projects = new List<Project>
            {
                new Project(id:1 , name:"تاکسی", description:"تاکسی برای سفرهای درون شهری", image:"project-1.jpg", client:"Atria"),
                new Project(id:2 , name:"زودفود", description:"درخواست انلاین غذا",image:"project-2.jpg" , client:"ZoodFood"),
                new Project(id:3 , name:"مدارس", description:"سیستم یکپارچه سرار ایران", image:"project-3.jpg" ,  client:"Monop"),
                new Project(id:4 , name:"فضاپیما", description:"شرکت مدیرت فضاپیما", image:"project-4.jpg"  , client:"Nasa"),



            };

            return View("_Projects" , projects ); //we return _Projects view component

        }


    }
}
