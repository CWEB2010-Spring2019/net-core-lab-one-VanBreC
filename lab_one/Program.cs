using System;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main()
        {
            //Wrong answers array
            string[] wrongAnswers = { };

            //Correct answers array
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            //Questions array
            string[] questions = { "1. Question", "2. Question", "3. Question", "4. Question", "5. Question",
                "6. Question", "7. Question", "8. Question", "9. Question", "10. Question" };

            //Question options array
            string[] questionOptions = {"A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4" };

            //User answers array
            string[] userAnswers = new string[10];
            
            //Test loop to print answers
            for (int x = 0; x < 10; ++x)
            {
                Console.WriteLine("{0}", questions[x].ToString());
                Console.WriteLine("{0}", questionOptions[x].ToString());
                Console.WriteLine();
                userAnswers[x] = Console.ReadLine().ToUpper();
                if (userAnswers[x] != correctAnswers[x])
                    wrongAnswers.Add(x);
                Console.WriteLine();
            }
            //Test loop to read user answers
            //for (int x = 0; x < 10; ++x)
               // userAnswers[x] = Console.ReadLine().ToUpper();

            //Test loop to print user answers
            //for (int x = 0; x < 10; ++x)
                //Console.WriteLine("User Answers {0}", userAnswers[x].ToString());
        }

    }
}
