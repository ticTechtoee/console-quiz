using System;
using System.Collections.Generic;
using System.Linq;

namespace Geography_Quiz_Game
{
    internal class Program
    {
        // Define dictionaries to store questions and their answers for each type
        static Dictionary<string, string> trueFalseQuestions = new Dictionary<string, string>();
        static Dictionary<string, string> openEndedQuestions = new Dictionary<string, string>();
        static Dictionary<string, string[]> multipleChoiceQuestions = new Dictionary<string, string[]>();

        static void Main(string[] args)
        {
            bool replay = true;

            while (replay)
            {
                Console.WriteLine("Select Your Option");
                Console.WriteLine("1-Create/Edit/Delete True or False Question");
                Console.WriteLine("2-Create/Edit/Delete Open-Ended Question");
                Console.WriteLine("3-Create/Edit/Delete Multiple Choice Question");
                Console.WriteLine("4-Play Quiz");
                Console.WriteLine("5-Exit");

                int get_user_input = int.Parse(Console.ReadLine());

                switch (get_user_input)
                {
                    case 1:
                        ManageTrueFalseQuestions();
                        break;
                    case 2:
                        ManageOpenEndedQuestions();
                        break;
                    case 3:
                        ManageMultipleChoiceQuestions();
                        break;
                    case 4:
                        PlayQuiz();
                        break;
                    case 5:
                        replay = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }

        // Method to create, edit, or delete True or False questions
        static void ManageTrueFalseQuestions()
        {
            Console.WriteLine("True or False Questions");
            Console.WriteLine("1-Create Question");
            Console.WriteLine("2-Edit Question");
            Console.WriteLine("3-Delete Question");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateTrueFalseQuestion();
                    break;
                case 2:
                    EditTrueFalseQuestion();
                    break;
                case 3:
                    DeleteTrueFalseQuestion();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }

        static void CreateTrueFalseQuestion()
        {
            Console.WriteLine("Enter the True or False question:");
            string question = Console.ReadLine();
            Console.WriteLine("Enter the answer (True/False):");
            string answer = Console.ReadLine();
            trueFalseQuestions.Add(question, answer);
            Console.WriteLine("Question added successfully.");
        }

        static void EditTrueFalseQuestion()
        {
            Console.WriteLine("Type the question you want to edit:");
            DisplayQuestions(trueFalseQuestions);

            string question = Console.ReadLine();

            if (trueFalseQuestions.ContainsKey(question))
            {
                Console.WriteLine("Enter the updated question:");
                string updatedQuestion = Console.ReadLine();

                Console.WriteLine("Enter the updated answer (True/False):");
                string answer = Console.ReadLine();

                // Remove the old question and add the updated question with its answer
                trueFalseQuestions.Remove(question);
                trueFalseQuestions.Add(updatedQuestion, answer);

                Console.WriteLine("Question updated successfully.");
            }
            else
            {
                Console.WriteLine("Question not found.");
            }
        }

        static void DeleteTrueFalseQuestion()
        {
            Console.WriteLine("Select the question you want to delete:");
            DisplayQuestions(trueFalseQuestions);

            string question = Console.ReadLine();

            if (trueFalseQuestions.ContainsKey(question))
            {
                trueFalseQuestions.Remove(question);
                Console.WriteLine("Question deleted successfully.");
            }
            else
            {
                Console.WriteLine("Question not found.");
            }
        }

        // Method to create, edit, or delete Open-Ended questions
        static void ManageOpenEndedQuestions()
        {
            Console.WriteLine("Open-Ended Questions");
            Console.WriteLine("1-Create Question");
            Console.WriteLine("2-Edit Question");
            Console.WriteLine("3-Delete Question");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateOpenEndedQuestion();
                    break;
                case 2:
                    EditOpenEndedQuestion();
                    break;
                case 3:
                    DeleteOpenEndedQuestion();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }

        static void CreateOpenEndedQuestion()
        {
            Console.WriteLine("Enter the open-ended question:");
            string question = Console.ReadLine();

            Console.WriteLine("Enter the answer (4 to 5 words):");
            string answer = Console.ReadLine();

            openEndedQuestions.Add(question, answer);
            Console.WriteLine("Question added successfully.");
        }

        static void EditOpenEndedQuestion()
        {
            Console.WriteLine("Type the question you want to edit:");
            DisplayQuestions(openEndedQuestions);

            string question = Console.ReadLine();

            if (openEndedQuestions.ContainsKey(question))
            {
                Console.WriteLine("Enter the updated question:");
                string updatedQuestion = Console.ReadLine();

                Console.WriteLine("Enter the updated answer (4 to 5 words):");
                string answer = Console.ReadLine();

                // Remove the old question and add the updated question with its answer
                openEndedQuestions.Remove(question);
                openEndedQuestions.Add(updatedQuestion, answer);

                Console.WriteLine("Question updated successfully.");
            }
            else
            {
                Console.WriteLine("Question not found.");
            }
        }

        static void DeleteOpenEndedQuestion()
        {
            Console.WriteLine("Select the question you want to delete:");
            DisplayQuestions(openEndedQuestions);

            string question = Console.ReadLine();

            if (openEndedQuestions.ContainsKey(question))
            {
                openEndedQuestions.Remove(question);
                Console.WriteLine("Question deleted successfully.");
            }
            else
            {
                Console.WriteLine("Question not found.");
            }
        }

        // Method to create, edit, or delete Multiple Choice questions
        static void ManageMultipleChoiceQuestions()
        {
            Console.WriteLine("Multiple Choice Questions");
            Console.WriteLine("1-Create Question");
            Console.WriteLine("2-Edit Question");
            Console.WriteLine("3-Delete Question");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateMultipleChoiceQuestion();
                    break;
                case 2:
                    EditMultipleChoiceQuestion();
                    break;
                case 3:
                    DeleteMultipleChoiceQuestion();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }

        static void CreateMultipleChoiceQuestion()
        {
            Console.WriteLine("Enter the multiple-choice question:");
            string question = Console.ReadLine();

            Console.WriteLine("Enter the choices separated by commas (e.g., choice1,choice2,choice3,choice4):");
            string choicesInput = Console.ReadLine();
            string[] choices = choicesInput.Split(',');

            Console.WriteLine("Enter the index of the correct choice (1 to 4):");
            int correctChoiceIndex = int.Parse(Console.ReadLine()) - 1;

            if (correctChoiceIndex >= 0 && correctChoiceIndex < choices.Length)
            {
                // Store the correct choice index as an integer
                multipleChoiceQuestions.Add(question, choices.Append(correctChoiceIndex.ToString()).ToArray());
                Console.WriteLine("Question added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid choice index.");
            }
        }



        static void EditMultipleChoiceQuestion()
        {
            Console.WriteLine("Type the question you want to edit:");
            DisplayQuestions(multipleChoiceQuestions);

            string question = Console.ReadLine();

            if (multipleChoiceQuestions.ContainsKey(question))
            {
                Console.WriteLine("Enter the updated question:");
                string updatedQuestion = Console.ReadLine();

                Console.WriteLine("Enter the choices separated by commas (e.g., choice1,choice2,choice3,choice4):");
                string choicesInput = Console.ReadLine();
                string[] choices = choicesInput.Split(',');

                Console.WriteLine("Enter the index of the correct choice (1 to 4):");
                int correctChoiceIndex = int.Parse(Console.ReadLine()) - 1;

                if (correctChoiceIndex >= 0 && correctChoiceIndex < choices.Length)
                {
                    // Append the correct choice index to the choices array
                    choices = choices.Append(correctChoiceIndex.ToString()).ToArray();

                    // Remove the old question and add the updated question with its choices
                    multipleChoiceQuestions.Remove(question);
                    multipleChoiceQuestions.Add(updatedQuestion, choices);
                    Console.WriteLine("Question updated successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid choice index.");
                }
            }
            else
            {
                Console.WriteLine("Question not found.");
            }
        }



        static void DeleteMultipleChoiceQuestion()
        {
            Console.WriteLine("Select the question you want to delete:");
            DisplayQuestions(multipleChoiceQuestions);

            string question = Console.ReadLine();

            if (multipleChoiceQuestions.ContainsKey(question))
            {
                multipleChoiceQuestions.Remove(question);
                Console.WriteLine("Question deleted successfully.");
            }
            else
            {
                Console.WriteLine("Question not found.");
            }
        }

        static void DisplayQuestions(Dictionary<string, string> questions)
        {
            foreach (var question in questions)
            {
                Console.WriteLine($"{question.Key}");
            }
        }

        static void DisplayQuestions(Dictionary<string, string[]> questions)
        {
            foreach (var question in questions)
            {
                Console.WriteLine($"{question.Key}");
            }
        }

        // Method to play the quiz
        static void PlayQuiz()
        {
            Console.WriteLine("Select the type of question:");
            Console.WriteLine("1-True or False");
            Console.WriteLine("2-Open-Ended");
            Console.WriteLine("3-Multiple Choice");

            int questionType = int.Parse(Console.ReadLine());

            switch (questionType)
            {
                case 1:
                    PlayTrueFalseQuiz();
                    break;
                case 2:
                    PlayOpenEndedQuiz();
                    break;
                case 3:
                    PlayMultipleChoiceQuiz();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void PlayTrueFalseQuiz()
        {
            if (trueFalseQuestions.Count == 0)
            {
                Console.WriteLine("Create some questions first.");
                return; // Return to the main menu
            }

            int score = 0;

            // Iterate through each true/false question
            foreach (var question in trueFalseQuestions)
            {
                Console.WriteLine(question.Key); // Display the question
                Console.Write("Your answer (True/False): ");
                string userAnswer = Console.ReadLine().ToLower();

                // Check if the user's answer matches the correct answer
                if (userAnswer == question.Value.ToLower())
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            // Display the score
            Console.WriteLine("\nQuiz completed!");
            Console.WriteLine($"Your score: {score} out of {trueFalseQuestions.Count}");
        }

        static void PlayOpenEndedQuiz()
        {
            if (openEndedQuestions.Count == 0)
            {
                Console.WriteLine("Create some Open-Ended questions first.");
                return; // Return to the main menu
            }

            int score = 0;

            // Iterate through each open-ended question
            foreach (var question in openEndedQuestions)
            {
                Console.WriteLine(question.Key); // Display the question
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine().ToLower();

                // Check if the user's answer matches the correct answer
                if (userAnswer == question.Value.ToLower())
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            // Display the score
            Console.WriteLine("\nQuiz completed!");
            Console.WriteLine($"Your score: {score} out of {openEndedQuestions.Count}");
        }

        static void PlayMultipleChoiceQuiz()
        {
            if (multipleChoiceQuestions.Count == 0)
            {
                Console.WriteLine("Create some questions first.");
                return; // Return to the main menu
            }

            int score = 0;

            // Iterate through each multiple-choice question
            foreach (var question in multipleChoiceQuestions)
            {
                Console.WriteLine(question.Key); // Display the question

                // Display the choices
                for (int i = 0; i < question.Value.Length - 1; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Value[i]}");
                }

                Console.Write("Your answer (1 to 4): ");
                int userChoiceIndex = int.Parse(Console.ReadLine()) - 1;

                // Check if the user's choice index is valid and matches the correct choice index
                if (userChoiceIndex >= 0 && userChoiceIndex < question.Value.Length - 1)
                {
                    // Get the index of the correct choice
                    int correctChoiceIndex = int.Parse(question.Value[question.Value.Length - 1]);

                    if (userChoiceIndex == correctChoiceIndex)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

            // Display the score
            Console.WriteLine("\nQuiz completed!");
            Console.WriteLine($"Your score: {score} out of {multipleChoiceQuestions.Count}");


        }

    }
}
