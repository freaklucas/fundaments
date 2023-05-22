﻿using System;
using System.Collections.Generic;

public interface IPessoa
{
    string Name { get; set; }
    int Age { get; set; }
    string LastName { get; set; }

    void SayHelloName();
}

public interface IAnimal
{
    string Size { get; set; }
    string Name { get; set; }
    string Specie { get; set; }
    double Weight { get; set; }
    string Song { get; set; }
    bool Violent { get; set; }

    void SaySong();
}

public class Dog : IAnimal
{
    public string Size { get; set; }
    public string Name { get; set; }
    public string Specie { get; set; }
    public double Weight { get; set; }
    public string Song { get; set; }
    public bool Violent { get; set; }

    public void SaySong()
    {
        Console.WriteLine($"O animal {Name} da espécie {Specie} faz o som de {Song}");
    }
}

public class Book : Pessoa
{
    public int Pages { get; set; }
}

public class Employee : Pessoa
{
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

public class Pessoa : IPessoa
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string LastName { get; set; }

    public void SayHelloName()
    {
        Console.WriteLine($"Olá, {Name}");
    }
}

public class Alien : Pessoa
{
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
    public string Specie { get; set; }
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

public class Program
{
    public static void Main()
    {
        List<IPessoa> pessoas = new List<IPessoa>();

        pessoas.Add(new Pessoa { Name = "Lucas", Age = 24, LastName = "Oliveira" });

        foreach (var pessoa in pessoas)
        {
            pessoa.SayHelloName();

            Console.WriteLine($"{pessoa.Name} {pessoa.LastName} - {pessoa.Age} anos");
        }

        List<Carr> carrs = new List<Carr>();
        Carr car = new Carr();

        car.Name = "Ferrari";
        car.ModelCarr = "Sport";

        Console.WriteLine("-----");
        Console.WriteLine("-----");

        carrs.Add(car);

        Console.WriteLine($"O carro possui o nome de {car.Name}, é um {car.ModelCarr}");
        Console.WriteLine("-----");
        Console.WriteLine("-----");

        List<Employee> employees = new List<Employee>();
        Employee employee = new Employee
        {
            Name = "Joaozinho",
            LastName = "Silva",
            Salary = 3.500,
            JobRole = "Programador Assembly",
            Birthday = "12 novembro"
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
            Type = "Moto 6 cilindradas Honda"
        };
        velhice.SayFabrication();
        Console.WriteLine("-----");

        velhices.Add(velhice);

        foreach (var element in velhices)
        {
            Console.WriteLine($"{element.Name} - {element.Type} fabricado em {element.AgeFabrication} ");
        }
        Console.WriteLine("-----");
        Console.WriteLine("-----");

        List<IAnimal> animals = new List<IAnimal>();
        Animal animal = new Animal
        {
            Name = "Leao",
            Weight = 100,
            Specie = "Mamífero"
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
            Specie = "Canine",
            Weight = 20.5,
            Song = "Woof Woof"
        });

        dogs.Add(new Dog
        {
            Name = "Buddy",
            Specie = "Canine",
            Weight = 15.2,
            Song = "Bark Bark"
        });

        foreach (Dog dog in dogs)
        {
            Console.WriteLine($"Nome: {dog.Name}");
            Console.WriteLine($"Espécie: {dog.Specie}");
            Console.WriteLine($"Peso: {dog.Weight}");
            Console.WriteLine($"Som: {dog.Song}");

            dog.SaySong();

            Console.WriteLine("--------------------");
        }
    }
}
