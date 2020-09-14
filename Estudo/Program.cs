using System;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdPessoas;
            DateTime dataNasc;

            void Topo()
            {
                Console.WriteLine("========================");
                Console.WriteLine("   ESCOLA DA VELHICE    ");
                Console.WriteLine("========================");
                Console.WriteLine();
            }


            Topo();

            Console.WriteLine("Quantas pessoas você quer cadastrar?");
            qtdPessoas = int.Parse(Console.ReadLine());

            string[] nome = new string[qtdPessoas];
            DateTime[] idade = new DateTime[qtdPessoas];
            int maiorIdade = 0;
            string maisVelho = "";
            
            for (int i = 0;i < nome.Length; i++)
            {

                Console.WriteLine("{0}º nome: ", i + 1);
                nome[i] = Console.ReadLine();

                Console.WriteLine("Data de Nascimento [ XX/XX/XXXX ]: ");
                dataNasc = DateTime.Parse(Console.ReadLine());

                TimeSpan diferenca = DateTime.Now - dataNasc;
                idade[i] = new DateTime(diferenca.Ticks);
            }

            Console.Clear();
            Topo();

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("{0} tem {1} anos.", nome[i], idade[i].Year - 1);
                if (idade[i].Year -1 > maiorIdade)
                {
                    maiorIdade = idade[i].Year - 1;
                    maisVelho = nome[i]; 
                }                
               
            }
            Console.WriteLine();    
            Console.WriteLine("A pessoa mais velha é {0} com {1} anos.", maisVelho, maiorIdade);

            
            Console.ReadKey();
        }
    }
}
