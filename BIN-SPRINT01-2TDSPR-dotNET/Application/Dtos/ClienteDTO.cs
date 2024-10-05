using System.ComponentModel.DataAnnotations;
using BIN_SPRINT01_2TDSPR_dotNET.Application.Validations;

public class ClienteDTO
{
    [Required(ErrorMessage = "O ClienteID é obrigatório.")]
    public int ClienteID { get; set; }

    [Required(ErrorMessage = "O Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome não pode ter mais que 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [CpfValidation(ErrorMessage = "O CPF informado é inválido.")]
    public string CPF { get; set; }

    [Required(ErrorMessage = "A Data de Nascimento é obrigatória.")]
    [DataType(DataType.Date, ErrorMessage = "Data de Nascimento inválida.")]
    [DataNascimentoValidation(ErrorMessage = "A data de nascimento deve ser no passado.")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "O Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O formato do email é inválido.")]
    public string Email { get; set; }
}
