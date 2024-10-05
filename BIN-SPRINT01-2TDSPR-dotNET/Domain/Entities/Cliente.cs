namespace BIN_SPRINT01_2TDSPR_dotNET.Domain.Entities
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
