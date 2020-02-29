using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int IdTheme { get; set; }
        public int IdUser { get; set; }
        public int Cite { get; set; }
        public string Content { get; set; }
        public DateTime Moment { get; set; }
    }
}