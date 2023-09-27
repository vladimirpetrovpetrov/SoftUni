using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations;


public class Pet : INameable, IBirthable
{
    public Pet(string name, string birthDate)
    {
        Name = name;
        Birthday = birthDate;
    }

    public string Name { get; private set; }

    public string Birthday { get; private set; }
}

