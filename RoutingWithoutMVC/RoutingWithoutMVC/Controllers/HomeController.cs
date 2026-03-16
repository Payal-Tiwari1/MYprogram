using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    [Route("[controller]/[action]")]        //token we can type any controller and any action method in the URL and it will be routed to the corresponding action method in the controller. 
                                            //For example, if we have a controller named "HomeController" and an action method named "Index", we can access it via the URL "/home/index". 
                                            //If we have another controller named "UserController" and an action method named "Profile", we can access it via the URL "/user/profile". This route template provides a flexible way to define routes based on the controller and action names.
    public class HomeController : Controller
    {
        [Route("")]
        // [Route("home")]
        //[Route("index")]
        //[Route("[action]")]
        [Route("~/")]                // Defining the route at the action level overrides the route defined at the controller level. So, this action can be accessed via the root URL ("/") instead of "/home/index".
        [Route("~/home")]           //token 
        public IActionResult Index()
        {
            return View();
        }

        //[Route("about")]
        public IActionResult About()
        {
            return View();
        }

        //[Route("details/{id?}")]
        [Route("{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;
        }

    }
}
