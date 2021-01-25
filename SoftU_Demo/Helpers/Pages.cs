using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftU_WebApp.Helpers
{
    public class Pages
    {
        private Pages(string value) { Value = value; }
        public string Value { get; set; }
        public static Pages SignUp { get { return new Pages("SignUp"); } }
        public static Pages SignIn { get { return new Pages("SignIn"); } }
        public static Pages ResetPassword { get { return new Pages("ResetPassword"); } }
    }

}
