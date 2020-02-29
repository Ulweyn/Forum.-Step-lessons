using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nik { get; set; }
        public string RealName { get; set; }
        public string PassHash { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? RegsiterAt { get; set; }
    }
}