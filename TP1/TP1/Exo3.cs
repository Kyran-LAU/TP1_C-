using System;

namespace TP1
{
    public class Exo3
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public static void TryCatch()
        {
            int result = 0;
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    Console.WriteLine(10 / PowerFunction(i));
                    result = 10 / PowerFunction(i);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}