using System.ComponentModel.DataAnnotations;

namespace DataValidation;
public class SignInModel
{
    [Required]
    public string? Username { get; set; }

    [Required]
    public string? Password { get; set; }

    public bool RememberMe { get; set; } = true;
}
