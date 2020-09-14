using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
            bool continuar = true;

            do
            {
                Menu();
                string operacao = (Console.ReadLine());

                switch (operacao)
                {
                    case "1":
                        resultado = Soma(num1, num2);
                        Console.WriteLine($" Resultado: {resultado}");
                        Console.WriteLine(" APERTE UM TECLA PARA CONTINUAR...");
                        Console.ReadKey();
                        break;

                    case "2":
                        resultado = Subtrair(num1, num2);
                        Console.WriteLine($" Resultado: {resultado}");
                        Console.WriteLine(" APERTE UM TECLA PARA CONTINUAR...");
                        Console.ReadKey();
                        break;

                    case "3":
                        resultado = Multiplicar(num1, num2);
                        Console.WriteLine($" Resultado: {resultado}");
                        Console.WriteLine(" APERTE UM TECLA PARA CONTINUAR...");
                        Console.ReadKey();
                        break;

                    case "4":
                        resultado = Dividir(num1, num2);
                        Console.WriteLine($" Resultado: {resultado}");
                        Console.ReadKey();
                        Console.WriteLine(" APERTE UM TECLA PARA CONTINUAR...");
                        break;

                    case "5":
                        continuar = false;
                        Sair();
                        break;

                    default:
                        Invalido();
                        break;
                }

                Console.WriteLine();

            } while (continuar);

         }

        private static void Sair()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ENCERRANDO CALCULADORA...");
            Console.ReadKey();
        }

        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("======================");
            Console.WriteLine("  CALCULADORA SIMPLES ");
            Console.WriteLine("======================");
            Console.WriteLine();

            Console.WriteLine(" | QUAL A OPERAÇÃO ? |");
            Console.WriteLine(" |-------------------|");
            Console.WriteLine(" | [1] SOMA          |");
            Console.WriteLine(" |-------------------|");
            Console.WriteLine(" | [2] SUBTRAÇÃO     |");
            Console.WriteLine(" |-------------------|");
            Console.WriteLine(" | [3] MULTIPLICAÇÃO |");
            Console.WriteLine(" |-------------------|");
            Console.WriteLine(" | [4] DIVISÃO       |");
            Console.WriteLine(" |-------------------|");
            Console.WriteLine(" | [5] SAIR          |");
            Console.WriteLine(" |-------------------|");

        }

        static double Soma(double num1, double num2)
        {
            Console.Clear();
            Console.WriteLine("      SOMA      ");
            Console.WriteLine(" ===============");
            Console.Write(" Primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write(" Segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            return num1 + num2;

        }


        static double Subtrair(double num1, double num2)
        {
            Console.Clear();
            Console.WriteLine("    SUBTRAIR    ");
            Console.WriteLine(" ===============");
            Console.Write(" Primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write(" Segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            return num1 - num2;

        }

        static double Multiplicar(double num1, double num2)
        {
            Console.Clear();
            Console.WriteLine("  MULTIPLICAÇÃO ");
            Console.WriteLine(" ===============");
            Console.Write(" Primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write(" Segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            return num1 * num2;

        }

        static double Dividir(double num1, double num2)
        {
            Console.Clear();
            Console.WriteLine("    DIVIDISÃO   ");
            Console.WriteLine(" ===============");
            Console.Write(" Primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write(" Segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            return num1 / num2;

        }

        private static void Invalido()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" OPCÃO INVÁLIDA!");
            Console.WriteLine(" APERTE UM TECLA PARA CONTINUAR...");
            Console.Beep();
            Console.ReadKey();
        }
    }
}
