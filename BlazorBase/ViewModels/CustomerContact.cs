using System.ComponentModel.DataAnnotations;

namespace BlazorBase.ViewModels
{
    public class CustomerContact
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

    [MinLength(5, ErrorMessage = "Address must be at least 5 characters long.")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Message is required.")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters long.")]
    public string Message { get; set; }

    [Required(ErrorMessage = "Please select a service.")]
    public string SelectedService { get; set; } = string.Empty;

    [Required(ErrorMessage = "You must agree to the terms and conditions.")]
    public bool TermsAccepted { get; set; }
    }
}