using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<FuncionarioService>();


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API de Cadastro de Clientes e Funcionários",
        Description = "Uma API ASP.NET Core para gerenciar Clientes e Funcionários",
        Contact = new OpenApiContact
        {
            Name = "Suporte",
            Email = "suporte@exemplo.com",
        }
    });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Cadastro v1");
        c.RoutePrefix = string.Empty;  
    });
}


app.UseHttpsRedirection();
app.UseAuthorization();


app.MapControllers();

app.Run();
