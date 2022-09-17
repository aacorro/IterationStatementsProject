using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0

            var num = 0;

            // do-while loop 

            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100);



            // while loop

            while (num < 200) 
            {
                num++;
                numbers.Add(num);
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");

                 // foreach loop

             foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

             Console.WriteLine("");
            Console.WriteLine("Decrease:");


            for (var i = 199; i >= 0; i--) 
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
