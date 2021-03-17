using System;

namespace Lab2._2TableofPowers
{
    class Program
    {
        static void Main(string[] args)
        {
              /* What will the application do?
                 The application prompts the user to enter an integer.
                 The application displays a table of squares and cubes from 1 to the value entered.
                 The application prompts the user to continue.
                 Build Specifications
                 1.Assume that the user will enter valid data.
                 2.The application should loop and ask for input again if the user wants to continue, or
                 end otherwise.*/


           Console.WriteLine("Learn your squares and cubes!");

            Console.WriteLine("\n");

            bool userContinue = true;
            while (userContinue)
            {

                try
                {

                    Console.Write("Enter an integer:");
                    int num = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n");


                    if (num > 0 && num <= 1290)
                    {

                        Console.WriteLine(" \t\tNumber    \t\tSquared     \t\tCubed");
                        Console.WriteLine(" \t\t=====      \t\t=====      \t\t=====");
                        for (int i = 1; i <= num; i++)
                        {
                            Console.WriteLine($"\t\t{i}        \t\t{i * i}         \t\t{i * i * i}");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than zero, not negative, and it is not greater than 1290.");
                    }
                    Console.WriteLine("\n");
                }

                catch (FormatException)
                {

                    Console.WriteLine(" The number you entered is not an integer");
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Would you like to continue ? (y/n):");
                string userInput = Console.ReadLine();
                if(userInput.StartsWith("n", StringComparison.OrdinalIgnoreCase))
                {

                    userContinue = false;
                    Console.WriteLine("Thank you! Have a nice day!");

                }
                else
                {

                    userContinue = true;
                }
                
            }





            

        }
    }
}
