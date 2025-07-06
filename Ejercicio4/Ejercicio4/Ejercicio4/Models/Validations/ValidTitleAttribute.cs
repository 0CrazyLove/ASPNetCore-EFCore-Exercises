namespace Ejercicio4.Models.Validations;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class ValidTitleAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string title && !string.IsNullOrWhiteSpace(title))
        {
            var regex = new Regex(@"^[A-Z][A-Za-z]{2,14}$");
            if (!regex.IsMatch(title))
            {
                return new ValidationResult("El título debe comenzar con mayúscula, no contener números, tildes ni caracteres especiales, y tener entre 3 y 15 caracteres.");
            }
            return ValidationResult.Success;
        }
        return new ValidationResult("El título es obligatorio.");
    }

}

