using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalcularBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "";

            while (continuar != "n")
            {
                Console.Clear();
                Console.WriteLine("Digite um numero entre 0 - 255: ");
                int numero = int.Parse(Console.ReadLine());

                int[] binario = new int[8];
               
                Console.Write($"Numero {numero} em Binário: ");

                while (numero > 0) {
                    for (int i = 7; i >= 0; i--) {
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

                for (int i = 0; i < binario.Length; i++)
                {
                    Console.Write($" {binario[i]} ");
                }
                
                Console.WriteLine("\n Continuar ? [S/N]");
                continuar = Console.ReadLine();

            } 
            
        }
    }
}
