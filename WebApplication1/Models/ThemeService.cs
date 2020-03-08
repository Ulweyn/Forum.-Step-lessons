using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ThemeService
    {
        public Theme theme { get; set; }
        public string GetAuthor(Models.Forum forum)
        {

            return forum.Users.Find(theme.IdAutor).Nik;
        }
        //public Forum forum;
        //public ThemeService (Models.Forum f)
        //{
        //    forum = f;
        //}
        public int GetPostCount(Forum forum)
        {
            int i = 0;
            foreach(var p in forum.Post)
            {
                if (theme.Id == p.IdTheme)
                    i++;
            }
            return i;
        }
        public ThemeService()
        {

        }
        public DateTime LastPost(Forum forum)
        {
            DateTime dt = DateTime.MinValue;
            var postList = from p in forum.Post where p.IdTheme == theme.Id select p;
            foreach (var p in postList)
            {

                if (p.Moment > dt)
                    dt = p.Moment;
            }
            //Post post = postList.Last();
            return dt;
        }
    }
}