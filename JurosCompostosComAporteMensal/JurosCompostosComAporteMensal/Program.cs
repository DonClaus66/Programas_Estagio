using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JurosCompostosComAporteMensal
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_presente = 0;
            double valor_futuro;
            double aporte_mensal = 0;
            double taxa = 0;
            int tempo = 0;
            for (bool aux1 = false; aux1 == false; )
            {
                Console.Write("Valor Presente: ");
                if (double.TryParse(Console.ReadLine(), out valor_presente) == true)
                    break;
                else
                    Console.WriteLine("Digite um valor válido!");
            }
            for (bool aux2 = false; aux2 == false; )
            {
                Console.Write("Aporte Mensal: ");
                if (double.TryParse(Console.ReadLine(), out aporte_mensal) == true)
                    break;
                else
                    Console.WriteLine("Digite um valor válido!");
            }
            for (bool aux3 = false; aux3 == false; )
            {
                Console.Write("Taxa: ");
                if (double.TryParse(Console.ReadLine(), out taxa) == true)
                    break;
                else
                    Console.WriteLine("Digite um valor válido!");
            }
            for (bool aux4 = false; aux4 == false; )
            {
                Console.Write("Tempo: ");
                if (int.TryParse(Console.ReadLine(), out tempo) == true)
                    break;
                else
                    Console.WriteLine("Digite um valor válido!");
            }
            valor_futuro = (aporte_mensal * (Math.Pow((1 + taxa), tempo) - 1)) / taxa + valor_presente * Math.Pow((1 + taxa), tempo);
            Console.WriteLine(valor_futuro);
            Console.ReadLine();
        }
    }
}
