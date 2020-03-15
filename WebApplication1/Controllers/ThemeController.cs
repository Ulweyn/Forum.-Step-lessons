using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ThemeController : Controller
    {
        // GET: Theme
        public ActionResult Index(int? id=1)//Создавая метод мы создаем точку входа. Для этого случая "~/Theme/Index/". id - аргумент, попадет в индекс из адресной строки по принципу id=2 "~/Theme/Index/2"
        {//int? значение может быть null
            ViewBag.ThemeId = id;
            Models.Forum forum = new Models.Forum();
            ViewBag.Theme = forum.Theme.Find(id);
            

            return View();

        }
       
    }
}