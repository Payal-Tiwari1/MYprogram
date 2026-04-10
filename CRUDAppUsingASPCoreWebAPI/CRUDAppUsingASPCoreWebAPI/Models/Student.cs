using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingASPCoreWebAPI.Models
{
    
    public class Student
    {
        public int id { get; set; }
        
        [Required(ErrorMessage = "Student Name is required")]
        public string studentName { get; set; }
        
        [Required(ErrorMessage = "Student Gender is required")]
        public string studentGender { get; set; }
        
        [Required(ErrorMessage = "Student age is required")]
        public int age { get; set; }
        
        [Required(ErrorMessage = "Student Class is required")]
        public int standard { get; set; }
    }

    
}
