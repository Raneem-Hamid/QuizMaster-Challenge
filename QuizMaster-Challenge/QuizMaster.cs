using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuizMaster_Challenge
{
    internal class QuizMaster
    {

       public static void StartQuiz()
        {
             string RED = "\u001b[31m";
           string GREEN = "\u001b[32m";
            string RESET = "\u001b[0m";
            string YELLOW = "\u001b[33m";
            string BLUE = "\u001b[34m";
            string CYAN = "\u001b[36m";
            string ORANGE = "\u001b[38;5;208m";
            string PINK = "\u001b[38;5;205m";

            List<string> questions = new List<string>
         {
            $"{YELLOW}What will be the output of the following JavaScript code?{RESET}\n" +
            $"{BLUE}`console.log(typeof null);`{RESET}\n" +
            $"{CYAN}a) \"null\"\nb) \"object\"\nc) \"undefined\"\nd) \"number\"{RESET}",

            $"{YELLOW}Which of the following is a correct way to create an array in JavaScript?{RESET}\n" +
            $"{CYAN}a) var arr = ();{RESET}\n" +
            $"{CYAN}b) var arr = [];{RESET}\n" +
            $"{CYAN}c) var arr = ..;{RESET}\n" +
            $"{CYAN}d) var arr = <>;{RESET}",

            $"{YELLOW}What is the purpose of the Array.prototype.map method in JavaScript?{RESET}\n" +
            $"{CYAN}a) To mutate each element of the array{RESET}\n" +
            $"{CYAN}b) To create a new array with the results of calling a provided function on every element{RESET}\n" +
            $"{CYAN}c) To filter the array based on a condition{RESET}\n" +
            $"{CYAN}d) To sort the elements of the array{RESET}",

            $"{YELLOW}How can you declare a constant variable in JavaScript?{RESET}\n" +
            $"{CYAN}a) var PI = 3.14;{RESET}\n" +
            $"{CYAN}b) constant PI = 3.14;{RESET}\n" +
            $"{CYAN}c) let PI = 3.14;{RESET}\n" +
            $"{CYAN}d) const PI = 3.14;{RESET}\n"
            ,

            $"{YELLOW}What is the value of x after the following code executes?{RESET}\n" +
            $"{BLUE}`let x = 10;\nx = x + (x % 3);`{RESET}\n" +
            $"{CYAN}a) 10{RESET}\n" +
            $"{CYAN}b) 11{RESET}\n" +
            $"{CYAN}c) 12{RESET}\n" +
            $"{CYAN}d) 13{RESET}",

            $"{YELLOW}What will be the output of the following JavaScript code?{RESET}\n" +
            $"{BLUE}`var a = [1, 2, 3];\nvar b = a;\nb.push(4);\nconsole.log(a);`{RESET}\n" +
            $"{CYAN}a) [1, 2, 3]{RESET}\n" +
            $"{CYAN}b) [1, 2, 3, 4]{RESET}\n" +
            $"{CYAN}c) [4, 1, 2, 3]{RESET}\n" +
            $"{CYAN}d) Error{RESET}",

            $"{YELLOW}Which of the following is not a JavaScript data type?{RESET}\n" +
            $"{CYAN}a) Number{RESET}\n" +
            $"{CYAN}b) String{RESET}\n" +
            $"{CYAN}c) Character{RESET}\n" +
            $"{CYAN}d) Boolean{RESET}",


             $"{YELLOW}Which method can be used to convert a JSON string into a JavaScript object?{RESET}\n" +
            $"{CYAN}a) JSON.parse()\n{RESET}" +
            $"{CYAN}b) JSON.stringify()\n{RESET}" +
            $"{CYAN}c) JSON.objectify()\n{RESET}" +
            $"{CYAN}d) JSON.convert(){RESET}",


              $"{ YELLOW}What will be the output of the following JavaScript code?{ RESET}\n" +
            $"{ BLUE}`console.log(typeof NaN);`{ RESET}\n" +
             $"{CYAN}a) number\n{RESET}" +
            $"{CYAN}b) string\n{RESET}" +
            $"{CYAN}c) undefined\n{RESET}" +
            $"{CYAN}d) object{RESET}",
            

               $"{ YELLOW}What will the following code output?{ RESET}\n" +
            $"{ BLUE}`console.log([1, 2, 3] + [4, 5, 6]);`{ RESET}\n" +
            $"{ CYAN}a) [1, 2, 3, 4, 5, 6]{ RESET}\n" +
            $"{ CYAN}b) 1,2,34,5,6{ RESET}\n" +
            $"{ CYAN}c) 1,2,3,4,5,6{ RESET}\n" +
            $"{ CYAN}d) undefined{ RESET}"

        };


            List<string> answers = new List<string>
        {
            "b", "b", "b", "d", "b", "b", "c", "a", "a", "b"
        };

            int score = 0;
            
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{PINK}Question {i + 1}:{RESET}");
                Console.WriteLine(questions[i]);
                Console.Write($"{CYAN}Your answer: {RESET}");
                string userAnswer = Console.ReadLine();


                if (userAnswer != "A" && userAnswer != "B" && userAnswer != "C" && userAnswer != "D" && userAnswer != "a" && userAnswer != "b" && userAnswer != "c" && userAnswer != "d")
                {
                    Console.WriteLine($"{RED}Invalid input. Please enter a/A, b/B, c/C, or d/D.{RESET}");
                    i--;
                    continue;
                }

                if (userAnswer.ToLower() == answers[i])
                {
                    score++;
                    Console.WriteLine($"{GREEN}Correct!{RESET}");
                }
                else
                {
                    Console.WriteLine($"{RED}Incorrect!{RESET}");
                }
            }
            Thread.Sleep(2000);
            Console.Clear();

            switch (score)
            {
                case 0:
                    Console.WriteLine($"your score is :{RED}{score}{RESET}");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine($"your score is :{ORANGE}{score}{RESET}");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine($"your score is :{YELLOW}{score}{RESET}");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine($"your score is :{BLUE}{score}{RESET}");
                    break;
                case 10:
                    Console.WriteLine($"your score is :{GREEN}{score}{RESET}");
                    break;
              
            }

           


         


        }

    }
}
