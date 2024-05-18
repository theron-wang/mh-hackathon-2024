using System.ComponentModel.DataAnnotations;

namespace DataValidation;
public class SignUpModel
{
    [Required]
    public string? Name { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }

    [Required]
    [Compare(nameof(Password))]
    public string? ConfirmPassword { get; set; }

    [Required]
    public List<int> Skills { get; set; } = [];
}
