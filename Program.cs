using System;
 
namespace kvadrat
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ведите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ведите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double kvad;
            kvad = Math.Pow(a, 2);
            if (b == kvad)
            {
                Console.WriteLine("b является квадратом числа a");
            }
            else
            {
                Console.WriteLine("b не является квадратом числа a");
            }
            
        }
    }
}
