using System;

namespace TP1
{
    public class Exo4
    {
        public static void Square()
        {
            Console.WriteLine("Please write a number between 1 and 1000 and press enter :");
            int.TryParse(Console.ReadLine(), out var N);
            Console.WriteLine("Please write a number between 1 and 1000 and press enter :");
            int.TryParse(Console.ReadLine(), out var M);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if ((i == 0 && j == 0) || (i == N-1 && j == 0) || (i == 0 && j == M-1) || (i == N-1 && j == M-1))
                    {
                        Console.Write("0");
                    }
                    else if (j == 0 || j == M-1)
                    {
                        Console.Write("|");
                    }
                    else if (i == 0 || i == N-1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}