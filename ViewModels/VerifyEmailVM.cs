using System.ComponentModel.DataAnnotations;

namespace PTirta.ViewModels
{
    public class VerifyEmailVM
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}