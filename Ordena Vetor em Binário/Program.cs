using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordena_Vetor_em_Binário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SERÃO DADOS NÚMEROS ALEATÓRIOS APENAS DE O TAMANHO DO VETOR");
            Console.Write("TAMANHO DO VETOR: ");
            int tamanhoVetor = int.Parse(Console.ReadLine());

            string[] binarioConvertido = new string[tamanhoVetor];
            int[] vetor = new int[tamanhoVetor];

            PegaNumeros(vetor);

            //Console.WriteLine("APERTE UMA TECLA PARA EXECUTAR O ALGORITMO");
            //Console.ReadKey();
            Console.Clear();

            Console.WriteLine();

            string vetorEmStringDesordenado = VetorParaString(vetor);
            Console.WriteLine("VETOR DESORDENADO: " + vetorEmStringDesordenado);

            int[] vetorOrdenado = SelectionSort(vetor, binarioConvertido);

            string vetorEmString = VetorParaString(vetorOrdenado);

            Console.WriteLine();
            Console.WriteLine("VETOR ORDENADO: " + vetorEmString);
            Console.WriteLine();

            Console.WriteLine("VALORES ORDENADOS EM BINÁRIO");
            EscreverNaTela(vetor, binarioConvertido);

            Console.ReadKey();

        }

        private static void PegaNumeros(int[] vetor)
        {
            //Console.WriteLine("Digite numeros aleatórios entre 0 - 1023");
            //Console.WriteLine();

            Random n1 = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {

                //Console.Write($"{i+1}º: ");
                vetor[i] = n1.Next(0, 1023);//int.Parse(Console.ReadLine());
                //Console.WriteLine();
            }
        }

        private static void EscreverNaTela(int[] vetor, string[] binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                Console.WriteLine("---------------------------");
                Console.Write($" {vetor[i]}: ");
                Console.WriteLine($" {binario[i]}");
            }
        }

        private static string VetorParaString(int[] vetor)
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

        public static int[] SelectionSort(int[] vetor, string[] binarioConvertido)
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

            for (int c = 0; c < vetor.Length; c++)
            {
                binarioConvertido[c] = ConverteEmBinario(vetor[c]);
            }

            return vetor;
        }

        public static string ConverteEmBinario(int numero)
        {
            int[] binario = new int[0];

            if (numero >= 0)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 2)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 4)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 8)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 16)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 32)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 64)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 128)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 255)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            if (numero >= 511)
            {
                Array.Resize(ref binario, binario.Length + 1);
            }

            while (numero > 0)
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    if (numero % 2 == 0)
                    {
                        binario[i] = 0;
                    }
                    if (numero % 2 == 1)
                    {
                        binario[i] = 1;
                    }
                    numero /= 2;
                }

            }

            string binarioEmString = VetorParaString(binario);

            return binarioEmString;
        }
    }
}
