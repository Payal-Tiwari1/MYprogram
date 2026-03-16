using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            // TempData is a dictionary object that is used to pass data from controller to view.
            ViewData["data1"] = "View Data"; 
            ViewBag.data2 = "View Bag";
            TempData["data3"] = "Temp Data";
            
            String[] arr = { "Jheel", "Viha", "Dishank" };
            TempData["data4"] = arr;
            TempData.Keep("data3");

            return View();      // ViewResult, PartialViewResult, ViewComponentResult, 
                                //JsonResult, ContentResult, FileResult, EmptyResult, RedirectResult, 
                                //RedirectToRouteResult, RedirectToActionResult, LocalRedirectResult, StatusCodeResult etc.
        }

        public IActionResult About()
        {
            TempData.Keep("data3");
            return View();
        }

        public IActionResult Contact()
        {
            TempData.Keep("data3");
            return View();
        }

        public string Display()
        {
            return "Welcome to .NET MVC..";
        }

        public int DisplayId(int id)
        {
            return id;
        }
    }
}

//ViewBag is a dynamic object that provides a convenient way to pass data from controller to view.

//ViewBag.Data1 = "Payal Tiwari";
//ViewBag.Data2 = 40;
//ViewBag.Data3 = DateTime.Now.ToLongDateString();

//String[] arr = { "Jheel", "Viha", "Dishank" };
//ViewBag.Data4 = arr;

//ViewBag.Data5 = new List<string>() { "Sonal", "Payal", "Durgesh" };


// ViewData is a dictionary object that is used to pass data from controller to view. 
//It is a part of the ViewDataDictionary class and is available in all controllers and views. 
//It is a dynamic object that can store any type of data and can be accessed using a key.


//ViewData["Data1"] = "Payal Tiwari";
//ViewData["Data2"] = 40;
//ViewData["Data3"] = DateTime.Now.ToLongDateString();


//String[] arr = { "Jheel", "Viha", "Dishank" };
//ViewData["Data4"] = arr;

//ViewData["Data5"] = new List<string>() { "Sonal", "Payal", "Durgesh" };
