using System;

namespace TP1
{
    public class Exo1
    {
        //Exo 1.1
        public static void Multiplication()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Table of " + i);
                for (int x = 1; x < 11; x++)
                {
                    Console.WriteLine(i + " * " + x + " = " + i*x);
                }
            }
        }
        //Exo 1.2
        public static void MultiplicationOdd()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Table of " + i);
                for (int x = 1; x < 11; x++)
                {
                    if ((i * x) % 2 == 1)
                    {
                        Console.WriteLine(i + " * " + x + " = " + i * x);
                    }
                }
            }
        }
        //Exo 1.3
        public static void MultiplicationUser()
        {
            Console.WriteLine("Please write a number between 0 and 1000 and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            Console.WriteLine("Table of " + result + "\n");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(result + " * " + i + " = " + i*result);
            }
        }
    }
}