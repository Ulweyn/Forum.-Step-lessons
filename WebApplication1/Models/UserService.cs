using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserService
    {
        
        public static User GetUserByLogPass(String login, String pass)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
                return null;
            Forum forum = new Forum();
            String pass_hash = Utils.Hasher.GetSHA_256(pass);
            var querry = from u in forum.Users where u.Nik.Equals(login) && u.PassHash.Equals(pass_hash) select u;
            foreach( User u in querry)
            {
                return u;
            }
            return null;
        }
         
    }
}