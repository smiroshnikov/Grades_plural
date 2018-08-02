using System;


namespace Grades
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please Work Motherfucker ! ");
            var var1 = 10;


            while (var1 != 0)
            {
                if (var1 != 0)
                {
                    Console.WriteLine("Substracting.... " + var1.ToString());
                    var1 = var1 - 1;
                }
                else
                {
                    Console.WriteLine("Yeah it is !");
                }
            }

            Console.WriteLine("Finito ! ....  " + var1.ToString());
        }
    }
}