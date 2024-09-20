using System.ComponentModel.DataAnnotations;

namespace Unit1Project.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public string? Name { get; set; } //Variable for name

    }
}
