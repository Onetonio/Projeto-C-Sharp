
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>()
{
     new Produto("Celular", "Android"),
    new Produto("Celular", "IOS"),
    new Produto("Televisão", "LG"),
    new Produto("Cafeteira", "Oster"),

};

app. MapGet("/", () => "Minha primeira api com watch");
app. MapGet("/api/produto", () => produtos);
app.Run();

public record Produto(string Nome, string Descricao);
