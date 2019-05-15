using System;
using System.ComponentModel.DataAnnotations;

namespace FORMSUBMISSION.Models
{
    public class User
    {
        [Required]
        [MinLength(4,
        ErrorMessage = "you kidding?")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4,
        ErrorMessage = "name too short")]
        public string LastName { get; set; }

        [Required]
        [Range(0, 2147483647,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("RepeatPassword",
        ErrorMessage = "Passwords don't match")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }
    }
}