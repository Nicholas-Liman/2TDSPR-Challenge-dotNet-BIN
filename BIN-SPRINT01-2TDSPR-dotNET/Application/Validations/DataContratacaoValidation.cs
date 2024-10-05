namespace BIN_SPRINT01_2TDSPR_dotNET.Application.Validations
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DataContratacaoValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dataContratacao = (DateTime)value;

            if (dataContratacao > DateTime.Now)
            {
                return new ValidationResult("A data de contratação não pode ser no futuro.");
            }

            return ValidationResult.Success;
        }
    }

}
