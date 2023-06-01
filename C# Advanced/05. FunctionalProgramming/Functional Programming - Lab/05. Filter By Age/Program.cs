using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   //n
        List<Person> people = ReadPeople(int.Parse(Console.ReadLine()));
        string condition = Console.ReadLine();
        int ageThreshold = int.Parse(Console.ReadLine());
        string format = Console.ReadLine();

        Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
        Action<Person> printer = CreatePrinter(format);

        PrintFilteredPeople(people, filter, printer);
    }

    static List<Person> ReadPeople(int n)
    {
        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(", ");
            Person person = new Person(input[0], int.Parse(input[1]));
            people.Add(person);
        }
        return people;
    }

    static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
    {
        if (condition == "younger")
        {
            return person => person.Age < ageThreshold;
        }
        else if (condition == "older")
        {
            return person => person.Age >= ageThreshold;
        }

        throw new ArgumentException("Invalid condition.");
    }

    static Action<Person> CreatePrinter(string format)
    {
        if (format == "name")
        {
            return person => Console.WriteLine(person.Name);
        }
        else if (format == "age")
        {
            return person => Console.WriteLine(person.Age);
        }
        else if (format == "name age")
        {
            return person => Console.WriteLine($"{person.Name} - {person.Age}");
        }

        throw new ArgumentException("Invalid format.");
    }

    static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
    {
        var filteredPeople = people.Where(filter);

        foreach (var person in filteredPeople)
        {
            printer(person);
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
