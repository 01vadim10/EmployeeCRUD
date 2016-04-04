using System.Web.Http;
using System.Web.Routing;

namespace EmployeeCRUD
{
    public class MvcApp : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "Home",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = RouteParameter.Optional }
                );
        }
    }
}