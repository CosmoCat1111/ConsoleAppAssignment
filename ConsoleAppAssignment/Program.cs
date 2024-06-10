using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating welcome request and converting into boolean answer to match
            Console.WriteLine("Guess my age?");
            int myAge = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = myAge == 42;
            //the do while 
            do
            {   //switch statements to have for the contents of the program
                switch (myAge)
                {
                    case 62:
                        Console.WriteLine("You guessed 62, try again.");
                        Console.WriteLine("Guess a number?");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29, try again.");
                        Console.WriteLine("Guess a number?");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55, try again.");
                        Console.WriteLine("Guess a number?");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 42:
                        Console.WriteLine("You guessed 42, that is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }


            //to keep the program running though the switches
            while (!isGuessed);
            Console.Read();
        }
    }
}
