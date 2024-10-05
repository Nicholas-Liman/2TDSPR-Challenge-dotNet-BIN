namespace BIN_SPRINT01_2TDSPR_dotNET.Domain.Entities
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}