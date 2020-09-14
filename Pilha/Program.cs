using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            bool continuar = true;
            int opcao;

            while (continuar)
            {
                Console.WriteLine("==============MENU===============");
                Console.WriteLine("1 - Sair do Programa");
                Console.WriteLine("2 - Verificar se a Pilha esta vazia");
                Console.WriteLine("3 - Empilhar");
                Console.WriteLine("4 - Desempilhar");
                Console.WriteLine("5 - Tamanho da Pilha");
                Console.WriteLine("6 - Mostrar Topo");
                Console.WriteLine("7 - Limpar Pilha");
                Console.WriteLine("---------------------------------");

                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        continuar = false;
                        break;

                    case 2:
                        if (pilha.Count == 0)
                        {
                            Console.WriteLine("Pilha Vazia");
                        }
                        else
                        {
                            Console.WriteLine("Pilha não Vazia");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Digite o dado que deseja empilhar");
                        String dado = Console.ReadLine();
                        pilha.Push(dado);
                        break;

                    case 4:
                        if (pilha.Count > 0)
                        {
                            String temp = pilha.Pop();
                            Console.WriteLine($"{temp} foi desempilhado!");
                        }
                        else
                        {
                            Console.WriteLine("A pilha está vazia");
                        }
                        break;

                    case 5:
                        int temp2 = pilha.Count;
                        Console.WriteLine($"Tamanho da Pilha: {temp2}");
                        break;

                    case 6:
                        if (pilha.Count != 0)
                        {
                            Console.WriteLine(pilha.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Pilha Vazia!");
                        }
                        break;

                    case 7:
                        pilha.Clear();
                        Console.WriteLine("A pilha foi limpa!");
                        break;
                }

            }
        }
    }
}
