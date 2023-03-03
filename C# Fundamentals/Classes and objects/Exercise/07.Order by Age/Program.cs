namespace _07.Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (line[0] == "End")
                {
                    break;
                }
                bool exist = false;
                foreach (var item in people)
                {
                    if (item.ID == line[1])
                    {
                        exist = true;
                        item.Name = line[0];
                        item.Age = int.Parse(line[2]);
                        break;
                    }
                }
                if (!exist)
                {
                    people.Add(new Person(line[0], line[1], int.Parse(line[2])));
                }
            }
            foreach (var person in people.OrderBy(x=>x.Age))
            {
                Console.WriteLine(person);
            }



        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}