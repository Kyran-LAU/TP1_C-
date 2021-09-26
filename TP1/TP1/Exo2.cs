using System;

namespace TP1
{
    public class Exo2
    {
        //Exo 2.1
        public static void Nbpremier()
        {
            Console.WriteLine("Please write a number between 0 and 1000 and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            int nombre = 1;
            Console.WriteLine("Les nombres premier entre 1 et " + result + " sont : ");
            while (nombre < result)
            {
                int r = 0;
                nombre++;
                for (int i = 1; i <= nombre; i++)
                {
                    if ((nombre % i) == 0)
                    {
                        r++;
                    }
                }

                if (r == 2)
                {
                    Console.Write(nombre + "; ");
                }
            }
        }
        //Exo 2.2
        public static void Fibonacci()
        {
            Console.WriteLine("Please write a number between 0 and 1000 and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            Console.Write("F" + result + " : ");
            if (result >= 2)
            {
                int x = 0;
                int y = 1;
                int fibo = 0;
                for (int i = 2; i <= result; i++)
                {
                    fibo = x + y;
                    x = y;
                    y = fibo;
                }
                Console.WriteLine(fibo);
            }
            else if (result == 0)
            {
                Console.WriteLine("0");
            }
            else if (result == 1)
            {
                Console.WriteLine("1");
            }
        }
        //Exo 2.3
        public static void factoriel()
        {
            Console.WriteLine("Please write a number between 0 and 25 and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            int x = 1;
            if (result == 0)
            {
                Console.WriteLine("!" + result + " = 0"); 
            }
            else if (result <= 25)
            {
                for (int i = 1; i <= result; i++)
                {
                    x = x * i;
                }
                Console.WriteLine("!" + result + " = " + x); 
            }
            else
            {
                Console.WriteLine("Mettre un nombre entre 0 et 25 sinon ça explose !!!");
            }
        }
        
    }
}