using System.ComponentModel.DataAnnotations;

namespace BlazorBase.ViewModels
{
    public class Course
    {
        [Required(ErrorMessage = "Full Name is required.")]
        [MinLength(3, ErrorMessage = "Full Name must be at least 3 characters long.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone Number must be 10-12 digits.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please select a course.")]
        public string SelectedCourse { get; set; }

        [Required(ErrorMessage = "Please select a learning method.")]
        public int LearningMode { get; set; }

        [Required(ErrorMessage = "Please select a desired start date.")]
        public DateTime DesiredStartDate { get; set; }

        public string Comments { get; set; }

        [Required(ErrorMessage = "You must agree to the terms and conditions.")]
        public bool AcceptTerms { get; set; }
    }
}