using System;

namespace CracklePop
{
    class Program
    {   /*Write a program that prints out the numbers 1 to 100 (inclusive).
        If the number is divisible by 3, print Crackle instead of the number.
        If it's divisible by 5, print Pop.
        If it's divisible by both 3 and 5, print CracklePop.*/
        static void Main(string[] args)
        {
            Console.WriteLine("CracklePop");
            for (int i = 1; i <= 100; i++)
            {

                if ((i % 3 == 0)&& (i % 5 == 0))
                { Console.WriteLine("Crackle Pop"); }
                 else if (i % 3 == 0)
                    {Console.WriteLine("Crackle"); }
                 else if (i % 5 == 0)
                    {Console.WriteLine("Pop"); }
                 else {Console.WriteLine(i); }
                

            }
        }
    }
}
