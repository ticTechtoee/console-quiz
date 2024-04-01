using System;

namespace Geography_Quiz_Game
{
    internal class extra
    {
        //static void Main(string[] args)
        //{
        //    bool replay = true;

        //    while (replay)
        //    {
        //        Console.WriteLine("Select Your Option");
        //        Console.WriteLine("1-Multiple Choice Questions");
        //        Console.WriteLine("2-Open-Ended Questions");
        //        Console.WriteLine("3-True or False Questions");

        //        int get_user_input = int.Parse(Console.ReadLine());

        //        switch (get_user_input)
        //        {
        //            case 1:
        //                OptionOne();
        //                break;
        //            case 2:
        //                OptionTwo();
        //                break;
        //            case 3:
        //                OptionThree();
        //                break;
        //            default:
        //                Console.WriteLine("Wrong Choice");
        //                break;
        //        }

        //        Console.WriteLine("Do you want to replay the quiz? (yes/no)");
        //        string replayAnswer = Console.ReadLine().ToLower();

        //        if (replayAnswer != "yes")
        //        {
        //            replay = false;
        //        }
        //    }
        //}

        public static void OptionOne()
        {
            Console.WriteLine("Option One - Multiple Choice Questions");
            Console.WriteLine("Answer the following multiple choice questions:");

            string[] questions = {
        "Which of the following is the world's largest ocean?",
        "The Amazon Rainforest, known for its rich biodiversity, is primarily located in which continent?",
        "What is the capital city of Canada?",
        "The highest mountain peak in the world, Mount Everest, is part of which mountain range?",
    };

            string[][] choices = {
        new string[] { "A. Indian Ocean", "B. Atlantic Ocean", "C. Pacific Ocean", "D. Arctic Ocean" },
        new string[] { "A. South America", "B. Africa", "C. Asia", "D. Australia" },
        new string[] { "A. Ottawa", "B. Toronto", "C. Vancouver", "D. Montreal" },
        new string[] { "A. Rocky Mountains", "B. Alps", "C. Andes", "D. Himalayas" },
    };

            string[] correctAnswers = {
        "c", // The correct answer for the first question
        "a", // The correct answer for the second question
        "a", // The correct answer for the third question
        "d", // The correct answer for the fourth question
    };

            int score = 0;
            int totalQuestions = questions.Length;

            for (int i = 0; i < totalQuestions; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {questions[i]}");

                foreach (string choice in choices[i])
                {
                    Console.WriteLine(choice);
                }

                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine().Trim().ToLower();

                if (userAnswer == correctAnswers[i])
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {correctAnswers[i]}");
                }
            }

            Console.WriteLine("\nQuiz completed!");
            Console.WriteLine($"Your score: {score} out of {totalQuestions}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }


        public static void OptionTwo()
        {
            Console.WriteLine("Option Two - Open-Ended Questions");
            Console.WriteLine("Answer the following open-ended questions:");

            string[] questions = {
                "What is the longest river in the world?",
                "What is the tallest mountain in North America?",
                "What is the highest peak in the United Kingdom?",
                "Which country is known as the Land of the Rising Sun?",
                 };

            string[] correctAnswers = {
                "nile river", // The correct answer for the first question
                "mount mckinley or denali", // The correct answer for the second question
                "ben nevis",
                "japan",
                  };

            int score = 0;
            int totalQuestions = questions.Length;

            for (int i = 0; i < totalQuestions; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {questions[i]}");
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine().Trim().ToLower();

                // Check if the correct answer contains the user's input
                bool isCorrect = false;
                foreach (string correctAnswer in correctAnswers)
                {
                    if (correctAnswer.ToLower().Contains(userAnswer))
                    {
                        isCorrect = true;
                        break;
                    }
                }

                if (isCorrect)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine("\nQuiz completed!");
            Console.WriteLine($"Your score: {score} out of {totalQuestions}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }




        public static void OptionThree()
        {
            Console.WriteLine("Option Three - True or False Questions");
            Console.WriteLine("Answer the following true or false questions:");

            string[] statements = {
                "London is the capital city of both England and the United Kingdom.",
                "The Sahara Desert is the largest desert in the world.",
                "The equator passes through Europe",
                "The United Kingdom consists of four countries: England, Wales, Scotland, and Ireland.",
                // Add more statements here
            };

            bool[] correctAnswers = {
                true, // The correct answer for the first statement
                true, // The correct answer for the second statement
                false, // The correct answer for the third statement
                false, // The correct answer for the forth statement
            };

            int score = 0;
            int totalQuestions = statements.Length;

            for (int i = 0; i < totalQuestions; i++)
            {
                Console.WriteLine($"\nStatement {i + 1}: {statements[i]}");
                Console.Write("True or False? (Type 'true' or 'false'): ");
                string userAnswer = Console.ReadLine().ToLower();

                // Check if the user's answer matches the correct answer
                bool isCorrect = (userAnswer == "true") == correctAnswers[i];

                if (isCorrect)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine("\nQuiz completed!");
            Console.WriteLine($"Your score: {score} out of {totalQuestions}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}