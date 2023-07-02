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
    endpoints.MapPost("/products", (Product product) =>
    {
        ProductRepository.Add(product);
        return Results.Created($"/products/{product.Code}", product.Code); 
    });

    endpoints.MapGet("/products/{code}", ([FromRoute] string code) =>
    {
        var product = ProductRepository.GetBy(code);

        if(product != null)
            return Results.Ok(product);
        
        return Results.NotFound();
    });

    endpoints.MapPut("/products", (Product product) =>
    {
        var productSaved = ProductRepository.GetBy(product.Code);

        productSaved.Name = product.Name;

        return Results.Ok(productSaved);
    });

    endpoints.MapDelete("/products/{code}", ([FromRoute] string code ) => {
        var productSaved = ProductRepository.GetBy(code);

        ProductRepository.Remove(productSaved);

        return Results.Ok(productSaved);
    });
    endpoints.MapGet("/configuration/database", (IConfiguration configuration) => {
        return Results.Ok($"{configuration["database:connection"]}/{configuration["database:Port"]}");
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
        return Products.FirstOrDefault(p => p.Code == code);
    }

    public static void Remove(Product product) {
        Products.Remove(product);
    }
}

public class Product
{   
    public string Code { get; set; }
    public string Name { get; set; }
}
