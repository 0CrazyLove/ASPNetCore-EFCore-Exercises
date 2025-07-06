namespace Ejercicio4.Models.Validations;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class ValidTitleAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string title && !string.IsNullOrWhiteSpace(title))
        {
           
            if (Regex.IsMatch(title, @"^[A-Z][A-Za-z]{2,14}$"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("El título debe comenzar con una letra mayúscula y tener entre 3 y 15 caracteres alfabéticos.");
        }
        return new ValidationResult("El título es obligatorio.");
    }

}

