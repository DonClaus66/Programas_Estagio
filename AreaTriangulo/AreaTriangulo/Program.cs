using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaTriangulo
{
    public class Triangulo
    {
        public bool VerificarExistencia(double lado1, double lado2, double lado3)
        {
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
                return true;
            else
                return false;
        }
        public double CalcularArea(double lado1, double lado2, double lado3)
        {
            double s = (lado1+lado2+lado3)/2; //Semi Perímetro
            return Math.Pow((s*(s-lado1)*(s-lado2)*(s-lado3)),0.5); //Fórmula de Heron
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            double lado1 = 0;
            double lado2 = 0;
            double lado3 = 0;

            bool aux = false;
            while (aux == false)
            {
                Console.Write("Digite o lado 1: ");
                aux = Double.TryParse(Console.ReadLine(), out lado1);
                if (aux == false)
                    Console.WriteLine("Digite um Valor válido!");
            }
            aux = false;
            while (aux == false)
            {
                Console.Write("Digite o lado 2: ");
                aux = Double.TryParse(Console.ReadLine(), out lado2);
                if (aux == false)
                    Console.WriteLine("Digite um Valor válido!");
            }
            aux = false;
            while (aux == false)
            {
                Console.Write("Digite o lado 3: ");
                aux = Double.TryParse(Console.ReadLine(), out lado3);
                if (aux == false)
                    Console.WriteLine("Digite um Valor válido!");
            }
            if (triangulo.VerificarExistencia(lado1, lado2, lado3) == true)
            {
                Console.WriteLine("A área é: "+triangulo.CalcularArea(lado1, lado2, lado3));
            }
            else
                Console.WriteLine("O Triângulo não existe!");
            Console.ReadKey();
        }
    }
}
