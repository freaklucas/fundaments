using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapPost("/saveproduct", (Product product) =>
    {
        ProductRepository.Add(product);
    });

    endpoints.MapGet("/getproduct/{code}", ([FromRoute] string code) =>
    {
        var product = ProductRepository.GetBy(code);

        return product;
    });
});

app.Run();

public static class ProductRepository
{
    public static List<Product> Products { get; set; }

    static ProductRepository()
    {
        Products = new List<Product>();
    }

    public static void Add(Product product)
    {
        Products.Add(product);
    }

    public static Product GetBy(string code)
    {
        return Products.First(p => p.Code == code);
    }
}

public class Product
{
    public string Code { get; set; }
    public string Name { get; set; }
}
