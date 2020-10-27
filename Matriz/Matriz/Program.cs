using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 0;
            bool aux = false;
            while (aux == false)
            {
                try
                {
                    Console.WriteLine("Digite o tamanho da Matriz");
                    tamanho = int.Parse(Console.ReadLine());
                    aux = true;
                }
                catch
                {
                    Console.WriteLine("Digite um valor válido!");
                }
                Console.Clear();
            }
            
            byte[,] Matriz = new byte[tamanho, tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Matriz[i, j] = 0;
                    if (i == j)
                        Matriz[i, j] = 1;
                    Console.Write(Matriz[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
