using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/user", () => new {Name = "Lucas Oliveira", Age="24"});
app.MapGet("/header", () => (HttpResponse response) => response.Headers.Add("Teste", "Lucas Header"));

app.MapPost("/saveproduct", async (HttpRequest request) => {
  var product = await request.ReadFromJsonAsync<Product>();
  return product.Code + " " + product.Name;
});

// api.app.com/users?dataInit={date}&dateEnd={dateEnd}
app.MapGet("/product", ([FromQuery]string dateInit, [FromQuery] string dateEnd) => {
  return dateInit + " - " + dateEnd;
});
//api.app.com/user/{code}
app.MapGet("/product/{code}", ([FromRoute] string code) => {
  return code;
});


app.Run();

public class Product {
  public string? Code { get; set; }
  public string? Name { get; set; }


}