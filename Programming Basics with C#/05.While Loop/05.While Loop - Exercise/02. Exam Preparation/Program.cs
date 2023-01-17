using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var maxBadGrades = int.Parse(Console.ReadLine());
            var exerciseName = " ";
            var badGradesCount = 0;
            var averageGrade = 0.0;
            var count = 0;
            var lastExercise = " ";
            while (exerciseName!="Enough" && badGradesCount != maxBadGrades)
            {
                exerciseName = Console.ReadLine();
                if (exerciseName == "Enough")
                {
                    break;
                }
                var currentGrade = int.Parse(Console.ReadLine());
                if(currentGrade <= 4)
                {
                    badGradesCount++;
                }
                if (exerciseName != "Enough")
                {
                    lastExercise = exerciseName;
                }
                averageGrade += currentGrade;
                count++;
            }
            if(exerciseName == "Enough")
            {
                Console.WriteLine($"Average score: {(averageGrade/count):0.00}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }








        }
    }
}
