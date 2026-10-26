using System;
using System.Diagnostics.Contracts;

namespace ExceptionTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write(" Insere um numero inteiro: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero inserido: {i}");
        }
    }
}
