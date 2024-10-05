using Microsoft.AspNetCore.Mvc;
using BIN_SPRINT01_2TDSPR_dotNET.Domain.Entities;

[Route("api/[controller]")]
[ApiController]
public class FuncionarioController : ControllerBase
{
    private readonly FuncionarioService _funcionarioService;

    public FuncionarioController(FuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Funcionario>>> GetFuncionarios()
    {
        var funcionarios = await _funcionarioService.GetFuncionariosAsync();
        return Ok(funcionarios);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Funcionario>> GetFuncionarioById(int id)
    {
        var funcionario = await _funcionarioService.GetFuncionarioByIdAsync(id);
        if (funcionario == null)
        {
            return NotFound();
        }
        return Ok(funcionario);
    }

    [HttpPost]
    public async Task<ActionResult<Funcionario>> AddFuncionario(FuncionarioDTO funcionarioDTO)
    {
        var funcionario = await _funcionarioService.AddFuncionarioAsync(funcionarioDTO);
        return CreatedAtAction(nameof(GetFuncionarioById), new { id = funcionario.FuncionarioID }, funcionario);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateFuncionario(int id, FuncionarioDTO funcionarioDTO)
    {
        var funcionario = await _funcionarioService.UpdateFuncionarioAsync(id, funcionarioDTO);
        if (funcionario == null)
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteFuncionario(int id)
    {
        var deleted = await _funcionarioService.DeleteFuncionarioAsync(id);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
