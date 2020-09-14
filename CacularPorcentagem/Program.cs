using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacularPorcentagem
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTotal = 0;
            double porcento = 0;
            double valorPercentual = 0;

            Console.WriteLine("Qual o valor Total ? ");
            valorTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o Percentual a retirar [%] ?");
            porcento = double.Parse(Console.ReadLine());

            valorPercentual = (porcento * valorTotal) / 100;

            Console.WriteLine(porcento + "% de " + valorTotal + " é: " + valorPercentual);


            Console.WriteLine("Primeiro Numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Numero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("[1] Somar");
            Console.WriteLine("[2] Subtrair");
            int op = int.Parse(Console.ReadLine());

            int resultado = 0;
            switch (op)
            {
                case 1:
                    resultado = Calculadora.Soma(n1, n2);
                    Console.WriteLine($"A soma dos numeros é: {resultado}");
                    break;

                case 2:
                    resultado = Calculadora.Subtracao(n1, n2);
                    Console.WriteLine($"A subtração dos numeros é: {resultado}");
                    break;
            }

            Console.ReadKey();
        }
    }
}
