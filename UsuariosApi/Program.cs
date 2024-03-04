using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsuariosApi.Data;
using UsuariosApi.Models;
using UsuariosApi.Profiles;
using UsuariosApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//informar o contexto para se conectar com o banco de dados
var connString = builder.Configuration.GetConnectionString("UsuarioConnection");

builder.Services.AddDbContext<UsuarioDbContext>
    (opts =>
    {
        opts.UseMySql(connString, ServerVersion.AutoDetect(connString));
    });


builder.Services
//em seguida, definicao de identity. Informa ao Identity que eu quero adicionar o conceito de identidade para esse usuario e o papel dele no sistema vai ser gerenciado por você (identityrole)
    .AddIdentity<Usuario, IdentityRole>()
    //estou utilizando esse dbcontext para fazer a comunicação com o bd, quem vai armazenar as config dos usuarios é o usuariodbcontext
    .AddEntityFrameworkStores<UsuarioDbContext>()
    //usado na autenticacao
    .AddDefaultTokenProviders();

//adicionar o AutoMapper na aplicação como um todo
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//addscoped o cadastro service sempre vai ser instanciado quando houver uma requisição nova que demande uma instancia desse cadastro service. Com AddScoped é sempre usado o mesmo
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<TokenService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
