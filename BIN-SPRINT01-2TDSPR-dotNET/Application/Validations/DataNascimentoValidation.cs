using System;
using System.ComponentModel.DataAnnotations;

public class DataNascimentoValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var dataNascimento = (DateTime)value;

        if (dataNascimento >= DateTime.Now)
        {
            return new ValidationResult("A data de nascimento deve ser no passado.");
        }

        var idade = DateTime.Now.Year - dataNascimento.Year;
        if (dataNascimento.AddYears(idade) > DateTime.Now)
        {
            idade--;
        }

        if (idade > 150)
        {
            return new ValidationResult("A idade não pode ser maior que 150 anos.");
        }

        return ValidationResult.Success;
    }
}
