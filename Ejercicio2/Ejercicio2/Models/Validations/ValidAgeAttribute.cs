using System.ComponentModel.DataAnnotations;
namespace Ejercicio2.Models.Validations;

public class ValidAgeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            int age = (int)value;

            if (age >= 18 && age <= 120)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("La edad debe estar entre 18 y 120 años.");
        }
        return new ValidationResult("La edad es obligatoria.");
    }
}

