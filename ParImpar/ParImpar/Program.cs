using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParImpar
{
    class Program
    {
        static void ParImpar(int numero)
        {
            if (numero % 2 == 0)
                Console.WriteLine("O número é par!");
            else
                Console.WriteLine("O número é ímpar!");
        }
        static void Main(string[] args)
        {
            int numero = 0;
            bool aux = false;
            while (aux == false)
            {
                try
                {
                    Console.WriteLine("Digite um número: ");
                    numero = Int32.Parse(Console.ReadLine());
                    aux = true;
                }
                catch
                {
                    Console.WriteLine("Digite um número válido!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.Clear();
            ParImpar(numero);
            Console.ReadKey();
        }
    }
}
