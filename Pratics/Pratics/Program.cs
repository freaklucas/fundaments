public class Pessoa {
    public String Name { get; set; }
    public int Age { get; set; }
    public String LastName { get; set; }

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

public class Animal : Pessoa
{
    public string Species { get; set; }
    public double Weight { get; set; }
    public string Song { get; set; }

    public void WhatAnimalIm()
    {
        Console.WriteLine($"Eu sou animal {Name} da especie {Species} e peso {Weight} ");
    }

    public void SaySong()
    {
        Console.WriteLine($"O animal {Species} faz um som de {Song}");
    }
}

public class Carr : Animal
{
    public string ModelCarr { get; set; }

    public void SayCarr()
    {
        Console.WriteLine($"Olá, nome do carro é {Name}, com modelo {ModelCarr}");
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Name = "Lucas";
        pessoa.LastName = "Oliveira";
        pessoa.Age = 24;

        Alien alien = new Alien();
        alien.Name = "jzshET";
        alien.Height = 1.79;

        pessoa.SayHelloName();
        alien.CallAlien();

        List <Animal> animals = new List<Animal>();
        Animal dog = new Animal();

        dog.Name = "bilu";
        dog.Species = "Vira-lata";
        dog.Song = "auau";
        animals.Add(dog);

        Console.WriteLine("-----");

        dog.SaySong();

        Console.WriteLine("-----");

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Nome: {animal.Name} especie: {animal.Species}");
        }

        List <Carr> carrs = new List<Carr>();
        Carr car = new Carr();

        car.Name = "Ferrari";
        car.ModelCarr = "Sport";
        car.SayCarr();
        
        Console.WriteLine("-----");

        carrs.Add(car);

        Console.WriteLine($"O carro possui o nome de {car.Name}, é um {car.ModelCarr}");

    }
}