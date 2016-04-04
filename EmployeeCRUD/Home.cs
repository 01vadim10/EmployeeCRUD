using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EmployeeCRUD
{
    public class Home
    {
        public void Index()
        {
            HttpContext context = HttpContext.Current;
            //context.RewritePath("~/Index.cshtml");
            
        }
    }
}