using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TabelaASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i.ToString()+ "=>" + Convert.ToChar(i));
                i++;
            }
            while (i < 256);
            Console.ReadKey();
        }
    }
}
