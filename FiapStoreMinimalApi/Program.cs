using FiapStoreMinimalApi.Entidade;
using FiapStoreMinimalApi.Interface;
using FiapStoreMinimalApi.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IUsuarioRepository, UsuarioRepositoiry>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


//Endpoint GET

app.MapGet("/buscar-todos-usuarios", (IUsuarioRepository usuarioRepository) =>
{
    return usuarioRepository.MostrarTodosUsuarios();

});
 //Endpoint GET por ID
app.MapGet("/usuarios/{id}", (int id, IUsuarioRepository usuarioRepository) =>
{
    return usuarioRepository.MostrarUsuariosPeloId(id);

});

// Endpoint POST
app.MapPost("/usuario", (Usuario usuario, IUsuarioRepository usuarioRepository) =>
{
    usuarioRepository.CriarUsuario(usuario);
});
// Endpoint PUT

app.MapPut("/usuario", (Usuario usuario, IUsuarioRepository usuarioRepository) =>
{
    usuarioRepository.EditarUsuario(usuario);
});
app.MapDelete("/usuario/{id}", (int id, IUsuarioRepository usuarioRepository) =>
{
    usuarioRepository.ExcluirUsuario(id);
});


app.Run();

