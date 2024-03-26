using FirstApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Expressions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos =
[
    new Produto("Celular", "Android", 4500),
    new Produto("Celular", "IOS",3000),
    new Produto("Televisão", "LG",2000),
    new Produto("Cafeteira", "Oster",250)

];

//Cadastrar um produto na lista 
//a) Através das informações na URL
//b) Através das informações no corpo da requisição
//REALIZAR AS OPERAÇÕES DAS ALTERAÇÕES E REMOÇÃO DA LISTA

app.MapGet("/api/produto/cadastrar", () => "Minha primeira api com watch");
app.MapGet("/api/produto/listar", () => produtos);
// GET: http://localhost:5105//api/produto/buscar/{nomedoproduto}
app.MapGet("/api/produto/buscar/{nome}", ([FromRoute] string nome) =>
{
    //ENDPOINT COM VARIAS LINHAS DE CODIGO 
    Console.WriteLine(nome);
    for (int i = 0; i < produtos.Count; i++)
    {
        if (produtos[i].Nome == nome)
        {
            return Results.Ok(produtos[i]);
        }
    }
    return Results.NotFound();
});

app.Run();

// Produto.setNome("Nome do produto");
// Console.WriteLine(produto.getNome());

