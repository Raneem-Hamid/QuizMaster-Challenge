namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string PINK = "\u001b[38;5;205m";
            string RESET = "\u001b[0m";
            string CYAN = "\u001b[36m";
            string RED = "\u001b[31m";
            try
            {
                Console.WriteLine($"{PINK}Welcome to the JavaScript Quiz!{RESET}");
                Console.WriteLine($"{PINK}The test will start in 10 seconds.{RESET}");
                Thread.Sleep(3000);
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine($"{CYAN}Starting in {i}...{RESET}");
                    Thread.Sleep(1000); 
                    Console.Clear();
                }
                Console.WriteLine("Starting the quiz now...\n");
                Thread.Sleep(1000);
                Console.Clear();
                 QuizMaster.StartQuiz();
            }
            catch (Exception error)
            {
                Console.WriteLine($"{RED} There is Something wrong please try again!{RESET}");
            }
            finally
            {
                Console.WriteLine($"{PINK}thank you for using our QuizMaster {RESET}");
            }
           
            
        }
    }
}
