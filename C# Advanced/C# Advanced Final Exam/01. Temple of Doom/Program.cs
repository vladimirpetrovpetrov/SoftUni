namespace _01._Temple_of_Doom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var toolsL = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var substancesL = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var allChallenges = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //tools -- queue
            //substances -- stack
            Queue<int> tools = new Queue<int>(toolsL);
            Stack<int> substances = new Stack<int>(substancesL);

            while(tools.Count > 0 && substances.Count > 0 && allChallenges.Count>0)
            { 
                var currentSum = tools.Peek() * substances.Peek();
                if (allChallenges.Contains(currentSum))
                {
                    tools.Dequeue();
                    substances.Pop();
                    allChallenges.Remove(currentSum);
                }
                else
                {
                    var toolElement = tools.Dequeue();
                    toolElement++;
                    tools.Enqueue(toolElement);
                    var substanceElement = substances.Pop();
                    substanceElement--;
                    if (substanceElement > 0)
                    {
                        substances.Push(substanceElement);
                    }
                }
            }
            if((tools.Count == 0 || substances.Count == 0) && allChallenges.Count > 0)
            {
                Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            }else if(allChallenges.Count == 0)
            {
                Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
            }
            if(tools.Count > 0)
            {
                Console.WriteLine($"Tools: {String.Join(", ",tools)}");
            }
            if (substances.Count > 0)
            {
                Console.WriteLine($"Substances: {String.Join(", ", substances)}");
            }
            if (allChallenges.Count > 0)
            {
                Console.WriteLine($"Challenges: {String.Join(", ", allChallenges)}");
            }






        }
    }
}