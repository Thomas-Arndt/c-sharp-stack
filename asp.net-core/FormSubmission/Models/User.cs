using System.ComponentModel.DataAnnotations;
public class User{
    [Required]
    [MinLength(4, ErrorMessage = "Must be more than 4 characters.")]
    [Display(Name = "First Name:")]
    public string FirstName { get;set; }
    [Required]
    [MinLength(4, ErrorMessage = "Must be more than 4 characters.")]
    public string LastName { get;set; }
    [Required]
    [Range(0, 150, ErrorMessage = "Must be positive.")]
    public int Age { get;set; }
    [Required]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string Email { get;set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get;set; }
}