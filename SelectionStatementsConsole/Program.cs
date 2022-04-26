using System;

namespace SelectionStatementsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favNum = 60;
            Console.WriteLine("Guess my favorite number. Hint: Below 75.");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNum)
            {
                Console.WriteLine("Too Low!");

            }
            else if (userGuess > favNum)
            {
                Console.WriteLine("Too High");
            }
            else if (userGuess == favNum)
            {
                Console.WriteLine("You were correct!"); 
            }
            else
            {
                Console.WriteLine("nevermind");
            }
            

            

            
        }
    }
}
