using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenandoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> Numeros = new List<float>();
            while (true)
            {
                Console.Write("Digite um número: ");
                try
                {
                    Numeros.Add(float.Parse(Console.ReadLine()));
                    Console.Write("Deseja continuar (s/n): ");
                    if (Console.ReadLine() == "n")
                        break;
                }
                catch
                {
                    Console.WriteLine("Digite um valor válido");
                }
            }
            Console.Clear();
            Numeros.Sort();
            foreach (float NumerosOrdenados in Numeros)
            {
                Console.WriteLine(NumerosOrdenados);
            }
            Console.ReadKey();
        }
    }
}
