using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuAlgoritmoDeOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6] { 2, 5, 3, 6, 1, 4 };

            CriaTela();
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("APERTE UMA TECLA PARA EXECUTAR O ALGORITMO");
            Console.ReadKey();

            Console.SetCursorPosition(2, 15);
            Console.WriteLine("VETOR DESORDENADO: " + EscreverVetorNaTela(vetor));

            int[] vetorOrdenado = OrdenaVetor(vetor);

            Console.SetCursorPosition(2, 17);
            Console.WriteLine("VETOR ORDENADO: " + EscreverVetorNaTela(vetorOrdenado));
            Console.ReadKey();

        }

        private static string EscreverVetorNaTela(int[] vetor)
        {
            string virgula = string.Empty;
            string vetorEmString = string.Empty;

            for (int i = 0; i < vetor.Length; i++)
            {
                vetorEmString += virgula + vetor[i];
                virgula = ",";
            }

            return vetorEmString;
        }

        static int[] OrdenaVetor(int[] vetor)
        {

            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }
            return vetor;
        }

        static void CriaTela()
        {
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("┌");

            Console.SetCursorPosition(1, 18);
            Console.WriteLine("└");

            Console.SetCursorPosition(65, 18);
            Console.WriteLine("┘");

            Console.SetCursorPosition(65, 1);
            Console.WriteLine("┐");

            for (int i = 2; i < 65; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.WriteLine("─");
            }

            for (int i = 2; i < 65; i++)
            {
                Console.SetCursorPosition(i, 18);
                Console.WriteLine("─");
            }

            for (int i = 2; i < 18; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("│");
            }

            for (int i = 2; i < 18; i++)
            {
                Console.SetCursorPosition(65, i);
                Console.WriteLine("│");
            }

            Console.SetCursorPosition(1, 3);
            Console.WriteLine("├");

            Console.SetCursorPosition(65, 3);
            Console.WriteLine("┤");

            for (int i = 2; i < 65; i++)
            {

                Console.SetCursorPosition(i, 3);
                Console.WriteLine("─");
            }

            Console.SetCursorPosition(20, 2);
            Console.WriteLine(" APRESENTAÇÃO SELLECTION SORT ");
        }
    }


}
