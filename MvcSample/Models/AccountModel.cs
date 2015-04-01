using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSample.Models
{
    public class AccountModel
    {
        private string userName;
        private string password;

        public string UserName {
            get { return userName; }
            set { userName = value; } 
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}