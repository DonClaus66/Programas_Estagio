using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Referencia
{
    class Program
    {
        static void PassandoPorReferencia(ref string palavra)
        {
            palavra = "Alterado!";
        }
        static void PassandoSemReferencia(string palavra)
        {
            palavra = "Alterado!";
        }
        static void Main(string[] args)
        {
            string palavra;
            Console.Write("Digite algo para passar para um método com e sem referência: ");
            palavra = Console.ReadLine();
            PassandoSemReferencia(palavra);
            Console.WriteLine("Essa é a variável que você digitou dps de passar pelo método sem referência: {0}", palavra);
            PassandoPorReferencia(ref palavra);
            Console.WriteLine("Essa é a variável que você digitou dps de passar pelo método com referência: {0}", palavra);
            Console.ReadKey();
        }
    }
}
