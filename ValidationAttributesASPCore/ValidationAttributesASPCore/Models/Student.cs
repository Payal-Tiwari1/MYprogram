using System.ComponentModel.DataAnnotations;

namespace ValidationAttributesASPCore.Models
{
    public class Student
    {
        [Display(Name = "Student Name:")]
        [Required(ErrorMessage = "Name is required.")]
        //[StringLength(15, MinimumLength = 3, ErrorMessage ="Length must be min 3 max 15 char..")]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required.")]
        //[EmailAddress]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage ="Enter valid Email Address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Age is required.")]
        [Range(18,100, ErrorMessage ="Age must be min 18 and max 100")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Please enter strong password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
        [Display(Name = "Confirm Password:")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "URL is required.")]
        [Url(ErrorMessage = "Please enter valid URL.")]
        public string URL { get; set; }
    }
}
