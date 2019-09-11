using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        //Create the random seed
        public static Random rand = new Random();

        public static bool correctGuess = false;

        static void Main(string[] args)
        {
            //Variables for Game
            int compGuess;
            string input;
            int _max = 11;
            int _min = 1;
            int rangeChange;

            //Prompts User to think of a number
            Console.WriteLine("Think of a number from " + _min + " to 10.");
            Console.ReadKey();

            while (!correctGuess)
            {
                //Program grabs a radom number from current scope
                compGuess = rand.Next(_min, _max);
                rangeChange = compGuess;

                //Output the program's random to User and get User's input
                Console.WriteLine("Is your number " + compGuess + "? (Y/N)");
                input = Console.ReadLine();

                //Checks User's input
                if (input == "Y" || input == "y")
                {
                    correctGuess = true;
                }
                else if (input == "N" || input == "n")
                {
                    string secondInput;

                    //Asks User if number is greater than or less than Program's guess
                    Console.WriteLine("Is your number greater or lesser? (Greater/Lesser)");
                    //Get User's input
                    secondInput = Console.ReadLine();

                    //Checks User's input and set the range of the guesses
                    if (secondInput == "Greater" || secondInput == "greater")
                    {
                        _min = rangeChange;
                        correctGuess = false;
                    }
                    else if (secondInput == "Lesser" || secondInput == "lesser")
                    {
                        _max = rangeChange + 1;
                        correctGuess = false;
                    }
                }
            }

        }
    }
}
