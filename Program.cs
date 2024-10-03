using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços ao contêiner de injeção de dependências
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura o pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configura as rotas dos controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Paciente}/{action=Cadastrar}/{id?}");

app.Run();
