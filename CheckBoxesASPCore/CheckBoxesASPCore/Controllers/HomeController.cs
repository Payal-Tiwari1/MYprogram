using CheckBoxesASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckBoxesASPCore.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    var model = new ViewModel()
        //    {
        //        AcceptTerms = false,
        //        Text = "I Accept the Terms and Conditions"
        //    };
        //    return View(model);
        //}



        public IActionResult Index()
        {
            var model = new ViewModel()
            { 
                CheckBoxes = new List<CheckBoxOption>
                {
                    new CheckBoxOption { IsChecked = true, Text = "Cricket", Value = "Cricket" },
                    new CheckBoxOption { IsChecked = false, Text = "Football", Value = "Football" },
                    new CheckBoxOption { IsChecked = false, Text = "Basketball", Value = "Basketball" },
                    new CheckBoxOption { IsChecked = false, Text = "Tennis", Value = "Tennis" }
                }

            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ViewModel view)
        {
            //bool data = view.AcceptTerms;
       
           return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
