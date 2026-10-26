using System;
using System.Diagnostics.Contracts;

namespace ExceptionTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write(" Insere um numero inteiro: ");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido: {i}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please insert an int!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please insert a bigger/smaller number!");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown Error!");
            }
        }
    }
}

