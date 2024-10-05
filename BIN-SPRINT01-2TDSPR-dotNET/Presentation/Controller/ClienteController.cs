using Microsoft.AspNetCore.Mvc;
using BIN_SPRINT01_2TDSPR_dotNET.Domain.Entities;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _clienteService;

    public ClienteController(ClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
    {
        return Ok(await _clienteService.GetClientesAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cliente>> GetClienteById(int id)
    {
        var cliente = await _clienteService.GetClienteByIdAsync(id);
        if (cliente == null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }

    [HttpPost]
    public async Task<ActionResult<Cliente>> AddCliente(ClienteDTO clienteDTO)
    {
        var cliente = await _clienteService.AddClienteAsync(clienteDTO);
        return CreatedAtAction(nameof(GetClienteById), new { id = cliente.ClienteID }, cliente);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateCliente(int id, ClienteDTO clienteDTO)
    {
        var cliente = await _clienteService.UpdateClienteAsync(id, clienteDTO);
        if (cliente == null)
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCliente(int id)
    {
        var deleted = await _clienteService.DeleteClienteAsync(id);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
