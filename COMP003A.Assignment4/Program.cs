// Author: Kyle James
// Course: COMP003A
// Purpose: Assignment 4 Code
namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));
            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0;
            do
            {
                Console.WriteLine($"{counter}");
                counter += 5;
            }
            while (counter <= 50);

            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));
            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 % 2 ==0 && counter2 % 5 ==0)
                {
                    Console.WriteLine("FooBar");
                    counter2++;
                }
                else if (counter2 % 2 ==0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 ==0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }

                counter2++;
            }

        }
    }
}
