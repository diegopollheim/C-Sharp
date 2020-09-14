using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            bool continuar = true;

            do
            {
                Menu();
                string operacao = (Console.ReadLine());

                switch (operacao)
                {
                    case "1":
                        Soma();
                        break;

                    case "2":
                        Subtrair();
                        break;

                    case "3":
                        Multiplicar();
                        break;

                    case "4":
                        Dividir();
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
        }

        private static void Invalido()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" OPCAO INVÁLIDA!");
            Console.WriteLine(" APERTE UM TECLA PARA CONTINUAR...");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.ReadKey();
        }

        private static void Dividir()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("    DIVISÃO    ");
            Console.ResetColor();
            Console.WriteLine("===============");
            Console.Write(" Primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write(" Segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double res = num1 / num2;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"  {num1} / {num2} = {res}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Aperte uma Tecla para continuar....");
            Console.ReadKey();
        }

        private static void Multiplicar()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" MULTIPLICAÇAO ");
            Console.ResetColor();
            Console.WriteLine("===============");
            Console.Write(" Primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write(" Segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double res = num1 * num2;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"  {num1} * {num2} = {res}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Aperte uma Tecla para continuar....");
            Console.ReadKey();
        }

        private static void Subtrair()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   SUBTRAÇÃO   ");
            Console.ResetColor();
            Console.WriteLine("===============");
            Console.Write(" Primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write(" Segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double res = num1 - num2;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  {num1} - {num2} = {res}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Aperte uma Tecla para continuar....");
            Console.ReadKey();

        }

        static void Soma()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("      SOMA      ");
            Console.ResetColor();
            Console.WriteLine(" ===============");
            Console.Write(" Primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write(" Segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double res = num1 + num2;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  {num1} + {num2} = {res}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Aperte uma Tecla para continuar....");
            Console.ReadKey();

        }

        static void Menu()
        {

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("======================");
            Console.WriteLine("  CALCULADORA SIMPLES ");
            Console.WriteLine("======================");
            Console.ResetColor();
            Console.WriteLine();

            //Console.WriteLine("  QUAL A OPERAÇÃO ? ");
            //Console.WriteLine(" -------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  [1] SOMA          ");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  [2] SUBTRAÇÃO     ");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  [3] MULTIPLICAÇÃO ");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  [4] DIVISÃO       ");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  [5] SAIR          ");
            Console.ResetColor();

        }
    }
}
