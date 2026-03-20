using ASPCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ studentId = 1, studentName = "John", studentGender = "Male" },
                new Student(){ studentId = 2, studentName = "Jane", studentGender = "Female" },
                new Student(){ studentId = 3, studentName = "Bob", studentGender = "Male" },
                new Student(){ studentId = 4, studentName = "Alice", studentGender = "Female" },
                new Student(){ studentId = 5, studentName = "Tom", studentGender = "Male" },
            };
            
            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ studentId = 1, studentName = "John", studentGender = "Male" },
                new Student(){ studentId = 2, studentName = "Jane", studentGender = "Female" },
                new Student(){ studentId = 3, studentName = "Bob", studentGender = "Male" },
                new Student(){ studentId = 4, studentName = "Alice", studentGender = "Female" },
                new Student(){ studentId = 5, studentName = "Tom", studentGender = "Male" },
            };

            return View(students);
        }
        public IActionResult Contact()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ studentId = 1, studentName = "John", studentGender = "Male" },
                new Student(){ studentId = 2, studentName = "Jane", studentGender = "Female" },
                new Student(){ studentId = 3, studentName = "Bob", studentGender = "Male" },
                new Student(){ studentId = 4, studentName = "Alice", studentGender = "Female" },
                new Student(){ studentId = 5, studentName = "Tom", studentGender = "Male" },
            };
            
            return View(students);
        }
    }
}
