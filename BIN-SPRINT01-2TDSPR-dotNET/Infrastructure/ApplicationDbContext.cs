using Microsoft.EntityFrameworkCore;
using BIN_SPRINT01_2TDSPR_dotNET.Domain.Entities;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("CLIENTES"); 
            entity.Property(e => e.ClienteID).HasColumnName("CLIENTEID");
            entity.Property(e => e.Nome).HasColumnName("NOME");
            entity.Property(e => e.CPF).HasColumnName("CPF");
            entity.Property(e => e.DataNascimento).HasColumnName("DATANASCIMENTO");
            entity.Property(e => e.Email).HasColumnName("EMAIL");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.ToTable("FUNCIONARIOS");
            entity.Property(e => e.FuncionarioID).HasColumnName("FUNCIONARIOID");
            entity.Property(e => e.Nome).HasColumnName("NOME");
            entity.Property(e => e.CPF).HasColumnName("CPF");
            entity.Property(e => e.Cargo).HasColumnName("CARGO");
            entity.Property(e => e.Salario).HasColumnName("SALARIO");
            entity.Property(e => e.DataContratacao).HasColumnName("DATACONTRATACAO");
        });

        base.OnModelCreating(modelBuilder);
    }
}
