using System.ComponentModel.DataAnnotations;

namespace healpoint.Model.PatientModel
{
    public class LoginRequestDTO
    {

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6,ErrorMessage = "Passowrd should be minimum 6 characters")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public required UserRole Role { get; set; }

    }

    public enum UserRole
    {
        Admin,
        User
    }
}
