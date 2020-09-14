using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            double[] notas = new double[10];
            double somaNota = 0; // Pega as notas para fazer a média no final.


            for (int cont = 0; cont < nomes.Length; cont++) // Pelo meu conhecimento dentro de um for a variável criada é apenas local.
            {
                Console.WriteLine("{0}º Aluno: ", cont + 1);
                nomes[cont] = Console.ReadLine();
                Console.WriteLine("Nota: ");
                notas[cont] = double.Parse(Console.ReadLine());
                somaNota += notas[cont]; // Cada vez que for digitada uma nota ela sera colocada dentro da variável somaNota.
                Console.Clear();
            }

            Console.WriteLine(" Aluno |  Nota");
            Console.WriteLine();

            Array.Sort(nomes, notas); // tirar a duvida do porque ele deu as notas de cada aluno corretamente

            for (int cont = 0; cont < nomes.Length; cont++)
            {

                Console.WriteLine(" {0} - {1} ", nomes[cont], notas[cont].ToString("N1"));

            }

            double media = somaNota / notas.Length;  // Aqui pego todas as notas somadas dentro da varivel somaNota e divido pelo tamanho da Array notas.
            Console.WriteLine();
            Console.WriteLine(" A média da sala foi: {0}", media.ToString("N1")); // Escreve na tela a média com formatação de 1 numero apos a vírgula.
            Console.ReadKey();
        }
    }
}
