using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = Convert.ToInt32(args[0]);
            int numeroDue = Convert.ToInt32(args[1]);

            Console.WriteLine(numeroUno+numeroDue);
        }
    }
}
