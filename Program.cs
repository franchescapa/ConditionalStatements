// Author: Franchesca Guerra
// Date: 9/16/20
// Comments: This C# console application code demonstrate the use of conditional statements


using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user for input
            Console.WriteLine("Please enter the integer of what grade do you expect to get in ISM 4300 ...");
            try
            {
                // This variable wil gather the user input
                String input = Console.ReadLine();

                // This variable will be used to store grades after the input vatiable is parsed to integer
                int grade = int.Parse(input);





                if ((grade > 90) && (grade < 100))
                {

                    Console.WriteLine("Your grade for ISM 4300 would be: A");
                    Console.ReadKey(true);
                }
                else if ((grade > 80) && (grade < 89))
                {
                    Console.WriteLine("Your grade for ISM 4300 would be: B");
                    Console.ReadKey(true);
                }
                else if ((grade > 70) && (grade < 79))
                {
                    Console.WriteLine("Your grade for ISM 4300 would be: C");
                    Console.ReadKey(true);
                }
                else if ((grade > 60) && (grade < 69))
                {
                    Console.WriteLine("Your grade for ISM 4300 would be: D");
                    Console.ReadKey(true);
                }
                else if (grade < 59)
                        {
                    Console.WriteLine("Your grade for ISM 4300 would be: F");
                    Console.ReadKey(true);
                }
                       
            } // end of try
            catch
            {
                Console.WriteLine("Please use a interger data type as your grade next time");
                Console.WriteLine("Press any key to exkit the program and try agai");
                Console.ReadKey(true);
            
            } // end of catch


        }
    }
}
