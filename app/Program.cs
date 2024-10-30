// See https://aka.ms/new-console-template for more information
using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions =
            {
            " What is the capital of Italy",
            " How to say fuck off in italian",
            " What is the time difference to india from italy now",
            " Che cazzo hai fatto"

           };
            string[] answers =
            {
            "Rome","Vaffanculo","4 hours 30 minutes","what did you done"
           };

            int score = 0;
            
            
            Console.WriteLine("Get ready for the quiz\n");


            for (int i = 0; i < questions.Length; i++)
            {
                int append = 0;
                bool correctanswer = false;
                while (append < 2 && !correctanswer)
                {
                    Console.WriteLine($"question{i + 1}:{questions[i]}");
                    Console.Write("Your answer: \n");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer.Equals(answers[i], StringComparison.OrdinalIgnoreCase))
                    {
                        score = score + 10;
                        correctanswer = true;

                    }
                    else
                    {
                        append++;
                        Console.WriteLine("wrong guess. Try again");
                    }
                
                if (append == 2)
                {
                    Console.WriteLine($"The correct answer is:{answers[i]}");}
                
                }
                Console.WriteLine($"The score is:{score}");
            }

        }
    }
}


