using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversão
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            bool aux = false;
            while (aux == false)
            {
                try
                {
                    Console.Write("Digite o valor: ");
                    valor = double.Parse(Console.ReadLine());
                    aux = true;
                }
                catch
                {
                    Console.WriteLine("Digite um valor válido");
                }
            }
            Console.Clear();
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("P -> Converte de Polegadas para Centímetros\nG -> Converte de Galões para Litros\nM -> Converte de Milhas para Quilômetros");

            aux = false;
            char opcao = 'a';
            while (aux == false)
            {
                try
                {
                    opcao = char.Parse(Console.ReadLine());
                    aux = true;
                }
                catch
                {
                    Console.WriteLine("Digite um valor válido!");
                } 
            }
            Console.Clear();
            switch (opcao)
            {
                case 'P':
                    Console.WriteLine("{0} Polegadas são {1} centímetros", valor, valor * 2.54);
                    break;
                case 'G':
                    Console.WriteLine("{0} Galões são {1} litros", valor, valor * 3.78);
                    break;
                case 'M':
                    Console.WriteLine("{0} Milas são {1} Quilômetros", valor, valor * 1.609);
                    break;
                case 'p':
                    Console.WriteLine("{0} Polegadas são {1} centímetros", valor, valor * 2.54);
                    break;
                case 'g':
                    Console.WriteLine("{0} Galões são {1} litros", valor, valor * 3.78);
                    break;
                case 'm':
                    Console.WriteLine("{0} Milas são {1} Quilômetros", valor, valor * 1.609);
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
