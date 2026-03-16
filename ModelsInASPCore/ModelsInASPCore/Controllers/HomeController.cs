using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using ModelsInASPCore.Repository;
using System.Diagnostics;

namespace ModelsInASPCore.Controllers
{
        [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudent _studentRepository;

        public HomeController(ILogger<HomeController> logger,IStudent studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }
        public List<StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }
        [HttpGet("{rollNo:int}")]
        public StudentModel getStudentByRollNo(int rollNo)
        {
            return _studentRepository.getStudentByRollNo(rollNo);
        }



        public IActionResult Index()
        {
            //var studends = new List<StudentModel>
            //{
            //    new StudentModel { rollNo = 1, Name = "Payal",Gender = "Female", Standard = 10 },
            //    new StudentModel { rollNo = 2, Name =  "Sonal",Gender = "Female",Standard = 11 },
            //    new StudentModel { rollNo = 3, Name =  "Durgesh",Gender = "Male",Standard = 12 }
            //};
            //ViewData["Students"] = studends;
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
