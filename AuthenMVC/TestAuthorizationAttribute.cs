using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenMVC
{
    public class TestAuthorizationAttribute : FilterAttribute, IAuthorizationFilter
    {
        private string[] _roles;
        public TestAuthorizationAttribute(params string[] roles)
        {
            _roles = roles;
        }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var name = filterContext.HttpContext.User.Identity.Name;
            foreach(string s in _roles){

            }
        }
    }
}