using Microsoft.EntityFrameworkCore;
using BIN_SPRINT01_2TDSPR_dotNET.Domain.Entities;

public class FuncionarioService
{
    private readonly ApplicationDbContext _context;

    public FuncionarioService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Funcionario>> GetFuncionariosAsync()
    {
        return await _context.Funcionarios.ToListAsync();
    }

    public async Task<Funcionario> GetFuncionarioByIdAsync(int id)
    {
        var funcionario = await _context.Funcionarios.FindAsync(id);
        if (funcionario == null)
        {
            throw new KeyNotFoundException("Funcionário não encontrado.");
        }
        return funcionario;
    }

    public async Task<Funcionario> AddFuncionarioAsync(FuncionarioDTO funcionarioDTO)
    {
        try
        {
            var funcionario = new Funcionario
            {
                FuncionarioID = funcionarioDTO.FuncionarioID, 
                Nome = funcionarioDTO.Nome,
                CPF = funcionarioDTO.CPF,
                Cargo = funcionarioDTO.Cargo,
                Salario = funcionarioDTO.Salario,
                DataContratacao = funcionarioDTO.DataContratacao
            };
            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao adicionar funcionário.", ex);
        }
    }

    public async Task<Funcionario> UpdateFuncionarioAsync(int id, FuncionarioDTO funcionarioDTO)
    {
        var funcionario = await _context.Funcionarios.FindAsync(id);
        if (funcionario == null) return null;

        funcionario.Nome = funcionarioDTO.Nome;
        funcionario.CPF = funcionarioDTO.CPF;
        funcionario.Cargo = funcionarioDTO.Cargo;
        funcionario.Salario = funcionarioDTO.Salario;
        funcionario.DataContratacao = funcionarioDTO.DataContratacao;

        try
        {
            await _context.SaveChangesAsync();
            return funcionario;
        }
        catch (Exception ex)
        {
            // Log o erro aqui, se necessário
            throw new Exception("Erro ao atualizar funcionário.", ex);
        }
    }

    public async Task<bool> DeleteFuncionarioAsync(int id)
    {
        var funcionario = await _context.Funcionarios.FindAsync(id);
        if (funcionario == null) return false;

        try
        {
            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            // Log o erro aqui, se necessário
            throw new Exception("Erro ao deletar funcionário.", ex);
        }
    }
}
