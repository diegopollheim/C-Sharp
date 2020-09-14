1
using System;

namespace AlunosDaSala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos alunos tem a turma?");
            int qtdAlunos = int.Parse(Console.ReadLine());
            Console.Clear();

            string[] nome = new string[qtdAlunos];
            double[] nota = new double[qtdAlunos];
            double melhorNota = 0;
            string melhorAluno = "";
            
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Nome do {0}º Aluno: ", i + 1);
                nome[i] = Console.ReadLine();
                Console.WriteLine("Nota Aluno: ");
                nota[i] = double.Parse(Console.ReadLine());
                if (nota[i] > melhorNota)
                {
                    melhorNota = nota[i]; 
                    melhorAluno = nome[i];
                }
            }
            Console.WriteLine("O aluno com melhor aproveitamento foi {0} com a nota {1}", melhorAluno, melhorNota);
            Console.ReadKey();
        
        }
    }
}
