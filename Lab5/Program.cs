using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!");
            //Prompt user to enter an integer from 1 to 21
            while (true)
            {
                string userNumber, userAnswer;
                int number;
                long result;

                Console.WriteLine("Enter an integer that's greater than 0 but less than 21: ");
                userNumber = Console.ReadLine();
                bool parsed = int.TryParse(userNumber, out number);

                //Calculate the factorial using their number
                result = GetFactorial(number);
                Console.WriteLine("The factorial of " + userNumber + " is " + result + ".");
              
                //Prompt them to continue
                Console.WriteLine("Would you like to continue? Type N to quit.");
                userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == "N")
                {
                    break;
                }
            }
        }

        //Method to calculate the factorial using recursion
        public static long GetFactorial(int x)
        {
            //condition to stop
            if (x == 0)
            {
                return 1;
            }

            //call itself
            return x * GetFactorial(x - 1);
        }

        //ways to improve: catch if they enter input that isn't an integer (decimal or text)

    }
        
}
