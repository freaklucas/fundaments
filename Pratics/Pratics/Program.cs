using System;
using System.Collections.Generic;
using System.Linq;

public interface IPessoa
{
    string Name { get; set; }
    int Age { get; set; }
    string LastName { get; set; }

    void SayHelloName();
}

public interface IWalmart
{
    string Category { get; set; }
    int Quantity { get; set; }
    double PricePurchase { get; set; }

    void ClosePurchase(double price, int qtd);
}

public class Walmart : IWalmart
{
    public string Category { get; set; }
    public int Quantity { get; set; }
    public double PricePurchase { get; set; } = 0;

    public void ClosePurchase(double price, int qtd)
    {
        PricePurchase = price;
        Quantity = qtd;
        Console.WriteLine($"Fechando compra no valor de {PricePurchase * Quantity}");
    }
}

public interface IAnimal
{
    string Size { get; set; }
    string Name { get; set; }
    string Species { get; set; }
    double Weight { get; set; }
    string Song { get; set; }
    bool Violent { get; set; }

    void SaySong();
}

public class Dog : IAnimal
{
    public string Size { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }
    public string Song { get; set; }
    public bool Violent { get; set; }

    public void SaySong()
    {
        Console.WriteLine($"O animal {Name} da espécie {Species} faz o som de {Song}");
    }
}

public class Book : IPessoa
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string LastName { get; set; }

    public void SayHelloName()
    {
        Console.WriteLine($"Olá, {Name}");
    }

    public int Pages { get; set; }
}

public class Employee : IPessoa
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string LastName { get; set; }

    public void SayHelloName()
    {
        Console.WriteLine($"Olá, {Name}");
    }

    public double Salary { get; set; }
    public string JobRole { get; set; }
    public string Birthday { get; set; }
}

public class Velhice : Employee
{
    public string AgeFabrication { get; set; }
    public string Type { get; set; }

    public void SayFabrication()
    {
        Console.WriteLine($"{Type} de {Name} foi fabricado no ano {AgeFabrication}");
    }
}

public class Alien : IPessoa
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string LastName { get; set; }

    public void SayHelloName()
    {
        Console.WriteLine($"Olá, {Name}");
    }

    public double Height { get; set; }

    public void CallAlien()
    {
        Console.WriteLine($"Olá terrestre, eu sou o {Name} e tenho {Height} de altura");
    }
}

public class Animal : IAnimal
{
    public string Size { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }
    public string Song { get; set; }
    public bool Violent { get; set; }

    public void SaySong()
    {
        Console.WriteLine($"O animal {Name} pesa {Weight} kg!");
    }
}

public class Carr : Animal
{
    public string ModelCarr { get; set; }
}

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<IPessoa> pessoas = new List<IPessoa>();

        pessoas.Add(new Employee { Name = "Lucas", Age = 24, LastName = "Oliveira", Salary = 3000, JobRole = "Developer", Birthday = "01/01/1990" });
        pessoas.Add(new Alien { Name = "E.T.", Age = 9999, LastName = "Extraterrestrial", Height = 1.5 });
        pessoas.Add(new Employee { Name = "John", Age = 35, LastName = "Doe", Salary = 4000, JobRole = "Manager", Birthday = "05/10/1986" });

        var peopleFilters = pessoas.Where(p => p.Age > 14).ToList();
        foreach (var pessoa in peopleFilters)
        {
            Console.WriteLine($"Pessoas no filtro:");
            Console.WriteLine($"{pessoa.Name} {pessoa.LastName} e idade {pessoa.Age}");
        }

        foreach (var pessoa in pessoas)
        {
            pessoa.SayHelloName();
            Console.WriteLine($"{pessoa.Name} {pessoa.LastName} - {pessoa.Age} anos");
        }

        List<Carr> carrs = new List<Carr>();
        Carr car = new Carr
        {
            Name = "Ferrari",
            ModelCarr = "Sport",
            Size = "Medium",
            Species = "Car",
            Weight = 1500,
            Song = "Vroom Vroom",
            Violent = false
        };

        carrs.Add(car);

        Console.WriteLine("-----");
        Console.WriteLine("-----");

        Console.WriteLine($"O carro possui o nome de {car.Name}, é um {car.ModelCarr}");
        Console.WriteLine("-----");
        Console.WriteLine("-----");

        List<Employee> employees = new List<Employee>();
        Employee employee = new Employee
        {
            Name = "Joaozinho",
            LastName = "Silva",
            Age = 30,
            Salary = 3500,
            JobRole = "Programmer",
            Birthday = "12 de novembro"
        };
        employees.Add(employee);

        foreach (var elementEmployee in employees)
        {
            Console.WriteLine($"{elementEmployee.Name} {elementEmployee.LastName} {elementEmployee.Salary}k - {elementEmployee.JobRole}");
        }

        Console.WriteLine("-----");
        Console.WriteLine("-----");

        List<Velhice> velhices = new List<Velhice>();
        Velhice velhice = new Velhice
        {
            Name = "Moto",
            AgeFabrication = "2022",
            Type = "Moto 6 cilindradas Honda",
            Age = 3,
            Salary = 5000,
            JobRole = "Engineer",
            Birthday = "01/01/2019"
        };
        velhice.SayFabrication();
        Console.WriteLine("-----");

        velhices.Add(velhice);

        foreach (var element in velhices)
        {
            Console.WriteLine($"{element.Name} - {element.Type} fabricado em {element.AgeFabrication}");
        }
        Console.WriteLine("-----");
        Console.WriteLine("-----");

        List<IAnimal> animals = new List<IAnimal>();
        Animal animal = new Animal
        {
            Name = "Leao",
            Weight = 100,
            Species = "Mamífero",
            Size = "Large",
            Song = "Roar",
            Violent = true
        };

        animals.Add(animal);

        foreach (var element in animals)
        {
            element.SaySong();
        }

        List<Dog> dogs = new List<Dog>();
        dogs.Add(new Dog
        {
            Name = "Rex",
            Species = "Canine",
            Weight = 20.5,
            Song = "Woof Woof",
            Size = "Medium",
            Violent = false
        });

        dogs.Add(new Dog
        {
            Name = "Buddy",
            Species = "Canine",
            Weight = 15.2,
            Song = "Bark Bark",
            Size = "Small",
            Violent = false
        });

        foreach (Dog dog in dogs)
        {
            Console.WriteLine($"Nome: {dog.Name}");
            Console.WriteLine($"Espécie: {dog.Species}");
            Console.WriteLine($"Peso: {dog.Weight}");
            Console.WriteLine($"Som: {dog.Song}");

            dog.SaySong();

            Console.WriteLine("--------------------");
        }

        Console.WriteLine("--------------------");
        List<Product> products = new List<Product>()
        {
            new Product { Name = "Product A", Price = 10.99, Category = "Category 1" },
            new Product { Name = "Product B", Price = 19.99, Category = "Category 2" },
            new Product { Name = "Product C", Price = 15.49, Category = "Category 1" },
            new Product { Name = "Product D", Price = 25.99, Category = "Category 2" },
            new Product { Name = "Product E", Price = 12.99, Category = "Category 3" }
        };

        double targetPrice = 20.0;
        var filteredProducts = products.Where(p => p.Price > targetPrice).ToList();
        Console.WriteLine("Produto e categoria com preço acima de 20.0");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"{product.Name} {product.Price} - {product.Category}");
        }

        IWalmart walmart = new Walmart();
        walmart.Category = "Beer";
        walmart.PricePurchase = 129;
        walmart.Quantity = 13;

        walmart.ClosePurchase(walmart.PricePurchase, walmart.Quantity);
    }
}
