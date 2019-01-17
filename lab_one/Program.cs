using System;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main()
        {
            //Correct answers array
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            //Questions array
            string[] questions = { "1. Question", "2. Question", "3. Question", "4. Question", "5. Question",
                "6. Question", "7. Question", "8. Question", "9. Question", "10. Question" };

            //User answers array
            string[] userAnswers = new string[10];

            //Test loop to print answers
            for (int x = 0; x < correctAnswers.Length; ++x)
                Console.WriteLine("Correct Answers {0}", correctAnswers[x].ToString());

            //Test loop to read user answers
            for (int x = 0; x < userAnswers.Length; ++x)
                userAnswers[x] = Console.ReadLine().ToUpper();

            //Test loop to print user answers
            for (int x = 0; x < userAnswers.Length; ++x)
                Console.WriteLine("User Answers {0}", userAnswers[x].ToString());
        }

    }
}
