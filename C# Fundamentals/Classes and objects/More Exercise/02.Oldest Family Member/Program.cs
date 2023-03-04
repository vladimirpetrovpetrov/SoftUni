namespace _02.Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var age = int.Parse(input[1]);
                Person person = new Person(name,age);
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember());

        }
    }
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }

    }
    public class Family
    {
        public List<Person> Members { get; set; } = new List<Person>();
        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }
        public Person GetOldestMember()
        {
            var oldest = this.Members.Max(x => x.Age);
            return this.Members.First(x=>x.Age == oldest);
        }
    }
}