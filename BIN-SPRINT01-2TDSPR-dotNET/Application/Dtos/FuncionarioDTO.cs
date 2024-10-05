using System.ComponentModel.DataAnnotations;
using BIN_SPRINT01_2TDSPR_dotNET.Application.Validations;

public class FuncionarioDTO
{
    [Required(ErrorMessage = "O FuncionarioID é obrigatório.")]
    public int FuncionarioID { get; set; }

    [Required(ErrorMessage = "O Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome não pode ter mais que 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [CpfValidation(ErrorMessage = "O CPF informado é inválido.")]
    public string CPF { get; set; }

    [Required(ErrorMessage = "O Cargo é obrigatório.")]
    [StringLength(50, ErrorMessage = "O cargo não pode ter mais que 50 caracteres.")]
    public string Cargo { get; set; }

    [Required(ErrorMessage = "O Salário é obrigatório.")]
    [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser maior que 0.")]
    public decimal Salario { get; set; }

    [Required(ErrorMessage = "A Data de Contratação é obrigatória.")]
    [DataType(DataType.Date, ErrorMessage = "Data de contratação inválida.")]
    [DataContratacaoValidation(ErrorMessage = "A data de contratação não pode ser no futuro.")]
    public DateTime DataContratacao { get; set; }
}
