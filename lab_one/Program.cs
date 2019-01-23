using System;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main()
        {
            //message for user to start quiz
            Console.WriteLine("Press the 'Enter' key to start the quiz");

            //User must hit enter to start quiz
            bool start = false;
            while (!start)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    Console.WriteLine("Starting Quiz");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    start = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong key input, please press 'Enter' to start.");
                }
            }
            

            //Right answers list
            List<string> correct = new List<string>();

            //Wrong answers list
            List<string> wrong = new List<string>();

            //Correct answers array
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            //Questions array
            string[] questions = { "1. When Was .NET Core 1.0 Released?","2. When Was .NET Core 2.0 Released?",
                "3. When Was .NET Core 3 announced?", "4. Question",
                "5. Question","6. Question",
                "7. Question", "8. Question",
                "9. Question", "10. Question" };

            //Question options array
            string[] questionOptions = {"A. July 27th 2016      B. June 27th 2016     C. July 26th 2010     D. June 25th 2007",
                "A. September 15th 2017      B. August 14th 2017     C. November 16th 2016     D. August 15th 2017",
                "A. May 8th 2018      B. April 7th 2018     C. May 7th 2018     D. December 8th 2017",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4",
                "A. Option1      B. Option2     C. Option3     D. Option4" };

            //User answers array
            string[] userAnswers = new string[10];


            bool done = false;
            while (!done)
            {

                //Test loop to print answers
                for (int x = 0; x < 10; ++x)
                {
                    Console.WriteLine("{0}", questions[x].ToString());
                    Console.WriteLine("{0}", questionOptions[x].ToString());
                    Console.WriteLine();
                    userAnswers[x] = Console.ReadLine().ToUpper();
                    if (userAnswers[x] == correctAnswers[x])
                        correct.Add(userAnswers[x]);
                    else
                        wrong.Add("Question: " + (x + 1) + ") " + userAnswers[x]);

                    Console.WriteLine();
                }


                Console.WriteLine("You answered " + correct.Count + " out of " + questions.Length + " correctly");


                if (correct.Count >= 7)
                    Console.WriteLine("You Passed The Assessment");
                else
                    Console.WriteLine("You Didnt Pass");

                Console.WriteLine("Enter -1 to retry, otherwise press enter twice to end the program");
                Console.WriteLine();

                string end = Console.ReadLine();

                if (end != "-1")
                    done = true;
                else
                {
                    Console.WriteLine("Restarting Test");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }

            }

        }
    }
}