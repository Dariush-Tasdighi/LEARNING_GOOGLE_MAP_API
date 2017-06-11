using System.Web.Mvc;

namespace LEARNING_GOOGLE_MAP_API
{
	public static class RouteConfig
	{
		public static void RegisterRoutes(System.Web.Routing.RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = System.Web.Mvc.UrlParameter.Optional }
			);
		}
	}
}
