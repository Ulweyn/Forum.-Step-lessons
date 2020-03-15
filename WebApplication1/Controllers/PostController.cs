using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Edit(int? id)
        {
            return View();
        }
    }
}