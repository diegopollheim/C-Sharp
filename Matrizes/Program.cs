using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdLinha = 3;
            int qtdColuna = 3;
            int[,] matriz = new int[qtdLinha, qtdColuna];
            int op = 0;

            AtribuirValoresNaMatriz(matriz, qtdLinha, qtdColuna);

            //matriz[0, 0] = 10;
            //matriz[0, 1] = 20;
            //matriz[0, 2] = 30;
            //matriz[0, 3] = 35;

            //matriz[1, 0] = 40;
            //matriz[1, 1] = 50;
            //matriz[1, 2] = 60;
            //matriz[1, 3] = 65;

            //matriz[2, 0] = 70;
            //matriz[2, 1] = 80;
            //matriz[2, 2] = 90;
            //matriz[2, 3] = 95;

            //matriz[3, 0] = 70;
            //matriz[3, 1] = 80;
            //matriz[3, 2] = 90;
            //matriz[3, 3] = 95;

            void Menu()
            {
                Console.WriteLine("MENU DE OPCOES");
                Console.WriteLine("===================");
                Console.WriteLine("[1] Mostrar a Matriz");
                Console.WriteLine("[2] Diagonal Principal");
                Console.WriteLine("[3] Triangulo Superior");
                Console.WriteLine("[4] Triangulo Inferior");
                Console.WriteLine("[5] Sair");
                Console.WriteLine("Defina a qtdLinhas e qTdColunas no código Main");
                op = int.Parse(Console.ReadLine());
            }

            void MostrarMatriz()
            {
                for (int i = 0; i < qtdLinha; i++)
                {
                    for (int c = 0; c < qtdColuna; c++)
                    {

                        Console.Write(" {0} ", matriz[i, c]);

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            void MostrarDiagonalPrincipal()
            {
                for (int i = 0; i < qtdLinha; i++)
                {
                    for (int c = 0; c < qtdColuna; c++)
                    {
                        if (i == c)
                        {
                            Console.Write(" {0} ", matriz[i, c]);
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            void MostrarCantoInferior()
            {
                for (int i = 0; i < qtdLinha; i++)
                {
                    for (int c = 0; c < qtdColuna; c++)
                    {
                        if (i > c)
                        {
                            Console.Write(" {0} ", matriz[i, c]);
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            void MostrarCantoSuperior()
            {
                for (int i = 0; i < qtdColuna; i++)
                {
                    for (int c = 0; c < qtdColuna; c++)
                    {
                        if (i < c)
                        {
                            Console.Write(" {0} ", matriz[i, c]);
                        }
                        else
                        {
                            Console.Write("    ");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }
            }


            while (op != 5)
            {

                Menu();

                Console.Clear();

                switch (op)
                {
                    case 1:
                        MostrarMatriz();
                        break;
                    case 2:
                        MostrarDiagonalPrincipal();
                        break;
                    case 3:
                        MostrarCantoSuperior();
                        break;
                    case 4:
                        MostrarCantoInferior();
                        break;
                    case 5:
                        Console.WriteLine("ENCERRANDO PROGRAMA....");
                        break;
                }


            }

            Console.ReadKey();
        }

        static int[,] AtribuirValoresNaMatriz(int[,] matriz, int qtdLinha, int qtdColuna)
        {

            Random numeros = new Random();

            for (int l = 0; l < qtdLinha; l++)
            {
                for (int c = 0; c < qtdColuna; c++)
                {
                   matriz[l,c] = numeros.Next(10,99);
                }
            }



            return matriz;
        }
    }
}
