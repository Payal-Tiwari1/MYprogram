using CRUDAppUsingASPCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;


namespace CRUDAppUsingASPCoreWebAPI.Controllers
{
    public class StudentController : Controller
    {
        private string url = "https://localhost:7124/api/StudentAPI/";
        private HttpClient client = new HttpClient();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage response = await client.GetAsync(url); 
            if(response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Student>>(result);
                if(data != null)
                {
                    students = data;
                }   
            }
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student std)
        {
            var data = JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = client.PostAsync(url, content).Result)
            if(response.IsSuccessStatusCode)
            {
                 TempData["CreateMessage"] = "Student created successfully!";
                 return RedirectToAction("Index");
            }
            return View();

            }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student students = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    students = data;
                  
                }
            }
            return View(students);
        }

        [HttpPost]
        public IActionResult Edit(Student std)
        {
            var data = JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url+std.id, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["EditData"] = "Student Edited Successfully!";
                    return RedirectToAction("Index");
                }
            
            return View();

        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            Student students = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    students = data;
                }
            }
            return View(students);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student students = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    students = data;
                }
            }
            return View(students);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            HttpResponseMessage response = client.DeleteAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["DeleteData"] = "Student Deleted Successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
