using System.ComponentModel.DataAnnotations;
namespace LSMWebApi.Model
{
    public class SignUpModel
    {
        [Required]
        public string First_Name { get; set; }

        [Required]
        public string Last_Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

    }
}
