using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Ejercicio2.Models.Validations;

public class ValidNameAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            string name = value.ToString()!;
            if (Regex.IsMatch(name, @"^[a-zA-Z]{2,15}$"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("El nombre debe contener entre 2 y 15 caracteres alfabeticos.");
        }
        return new ValidationResult("El nombre es obligatorio.");
    }
}

