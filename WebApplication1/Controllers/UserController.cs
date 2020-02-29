using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        Models.Forum forum = new Models.Forum();
        public ActionResult Index()
        {
            ViewBag.Users = forum.Users;
            
            

            return View();
        }
        public string Add(Models.User user)
        {
            user.RegsiterAt = DateTime.Now;
            forum.Users.Add(user);
            forum.SaveChanges();
          
            return "<p>добавлено</b><hr/><a href='/User'>Взад</a>";
        }
    }
}