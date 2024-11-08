using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;


namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var Articles = new List<Article> {

                new Article(id: 1, title:"آموزش asp.net core" , description:" asp.net آموزش فوق العاده " , image:"blog-post-thumb-card-3.jpg"),
                new Article(id: 2, title:"آموزش گیت و گیت هاب" , description:"گیت و گیت هاب یکی از خفن ترین برنامه های " , image:"blog-post-thumb-card-4.jpg"),
                new Article(id: 3, title: "آموزش برنامه نویسی" , description:"آموزش برنامه نویسی بک اند با سی شارپ" , image:"blog-post-thumb-card-5.jpg"),
                new Article(id: 4, title:"آموزش هوش مصنوعی" , description:"هوش مصنوعی را با قدرت شروع کنید" , image:"blog-post-thumb-card-6.jpg")

         };

            
            return View("_LatestArticles", Articles );
        }

    }
}
