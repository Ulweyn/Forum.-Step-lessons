using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Models.Forum forum = new Models.Forum();
        public ActionResult Index()
        {

            int usersCnt = forum.Users.Count();
            if (usersCnt == 0)
            {
                forum.Users.Add(new Models.User()
                {
                    RealName = "Василь Петрович",
                    Nik = "Pertovi4",
                    PassHash = Utils.Hasher.GetSHA_256("pass")/*,
                    RegsiterAt = DateTime.Now.,
                    LastLogin=DateTime.MinValue*/
                });
                forum.Users.Add(new Models.User()
                {
                    RealName = "Архип Петрович",
                    Nik = "ArchPertovi4",
                    PassHash = Utils.Hasher.GetSHA_256("pass")
                });
                forum.Users.Add(new Models.User()
                {
                    RealName = "Григорий Петрович",
                    Nik = "GreatPertovi4",
                    PassHash = Utils.Hasher.GetSHA_256("pass")
                });
                forum.SaveChanges();
            }
            int nThemes = forum.Theme.Count();
            if (nThemes == 0)
            {
                forum.Theme.Add(new Models.Theme()
                {
                    Id = 1,
                    Title = "Поехали",
                    Description = "Юра, мы всё проебали",
                    IdAutor = 1,
                    DTCreated = DateTime.Now
                });
                forum.Theme.Add(new Models.Theme()
                {
                    Id = 2,
                    Title = "Поехали",
                    Description = "Почта, вы всё проебали",
                    IdAutor = 1,
                    DTCreated = DateTime.Now
                });
                forum.SaveChanges();

            }
            int nPosts = forum.Post.Count();
            if (nPosts == 0)
            {
                forum.Post.Add(new Models.Post()
                {
                    Id = 1,
                    IdTheme = 1,
                    IdUser = 2,
                    Cite = 1,
                    Content = "Пост УГ",
                    Moment = DateTime.Now
                });
                forum.SaveChanges();
            }
            ViewBag.Users = forum.Users;
            ViewBag.Themes = forum.Theme;
            ViewBag.Posts = forum.Post;
            ViewBag.TP = from t in forum.Theme join p in forum.Post on t.Id equals p.IdTheme select p.Content + " " + t.Title;

            ///////////

            ViewBag.query = from u in forum.Users join p in forum.Post on u.Id equals p.IdUser select new Models.NikPost { Name = u.Nik, Content = p.Content };

            //////////

            string login=Request.Params["user_login"];
            string pass= Request.Params["user_pass"];
            Models.User user = Models.UserService.GetUserByLogPass(login, pass);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}