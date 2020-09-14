
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AlgoritmoOrdenacao
{
    class Program
    {
        #region CONTEÚDO
        /*
         * Quando iniciamos o estudo em programação, um dos primeiros assuntos que se aprende é sobre algoritmo.
         * O algoritmo é um processo de resolução de uma determinada tarefa para a qual ele foi designado. 
         * Podemos citar como um exemplo os algoritmos de ordenação, que alem de ser o mais comum 
         * são também os mais solicitados em atividades acadêmicas quando essa possui como disciplina 
         * a programação.
         *
         * Em programação, um algoritmo de ordenação tem com objetivo realizar a ordenação de uma 
         * lista de valores. Existem os seguintes métodos:
         *
         * Ordenação por inserção (vai ordenando o valor dentro do local do vetor quando esse é inserido)
         *    Insertion Sort
         *    Shell Sort
         * Ordenação por seleção (percorre a lista pega o menor valor e coloca na posição correta)
         *    Selection Sort
         *    HeapSort
         * Ordenação por troca (vai percorrendo a lista e trocando os elementos de posiçào para ordenar)
         *    Bubble sort
         *    Cocktail sort
         *    Comb sort
         *    Gnome sort
         *    Odd-even sort
         *    Quicksort
         */
        #endregion

        #region DICAS
        /*
         * DICAS:
         * 
         * -------------------------------------------------------------------------------------------------
         * Console.SetCursorPosition(X,Y)
         * -------------------------------------------------------------------------------------------------
         * Envia o cursor (aquele que fica piscando na tela e por consequencia o local onde vamos escrever)
         * para a posição (X,Y) começando da esquerda para a diretira de cima para baixo
         * quanto mais para a direita, maior o valor de X, quanto mais para baixo, maior o valor de Y
         * 0      X → 1 2 3
         * 1  Y  ┌────────┐
         * 2  ↓  │        │
         * 3     │        │
         *       └────────┘
         * -------------------------------------------------------------------------------------------------
         * 
         * -------------------------------------------------------------------------------------------------
         * Stopwatch
         * -------------------------------------------------------------------------------------------------
         * Classe do C# que funciona como uma calculadora de intervalo de tempo
         * 1 - Primeiro você cria a variável como abaixo
         * Stopwatch stopWatch = new Stopwatch(); //C
         * 2 - Quando quiser começar a contar o tempo usa-se esse código
         * stopWatch.Start();
         * 3 - Então você chama a rotina que quer executar e ver quanto tempo ela demora, melhor deixar ela em um método
         * MetodoComRotinaQueEuFiz();
         * 4 - Quando acabou a rotina chama já na próxima linha o código abaixo para parar de contar o tempo
         * stopWatch.Stop();
         * 5 - Para saber quanto tempo durou o intervalo calculado, só acessar a propriedade abaixo, ela é um TimeSpan
         * Timespan intervalo = stopWatch.Elapsed;
         * OBS.: Você pode imprimir diretamente o dado:
         * Console.Write("Tempo: {0}", stopWatch.Elapsed); 
         * -------------------------------------------------------------------------------------------------
         * 
         * 
         * 
         * -------------------------------------------------------------------------------------------------
         * Console.Clear();
         * -------------------------------------------------------------------------------------------------
         * Método do console que apaga tudo que está escrito na tela
         * -------------------------------------------------------------------------------------------------
         * 
         * 
         * 
         * -------------------------------------------------------------------------------------------------
         * #region E #endregion
         * -------------------------------------------------------------------------------------------------
         * São anotações do Visual Studio que demarcam o início (#region) e o fim (#endregion) de um
         * agrupamento de código, serve somente para o programador organizar e entender melhor o código
         * -------------------------------------------------------------------------------------------------
         * 
         */
        #endregion

        static void Main(string[] args)
        {
            //Chama um método principal
            //Que será chamado outras 3 vezes para reiniciar a aplicação
            InicializaAplicacao();
        }

        private static void InicializaAplicacao()
        {
            //Crio a Janela do programa escrevendo com caracteres
            CriaJanela();
            //Crio o menu do programa
            CriaMenu();
            //Crio o Prompt do programa
            InicializaPrompt();
        }

        private static void CriaJanela()
        {
            //Apago tudo que escrevi no console para desenhar novamente
            Console.Clear();

            //Posiciono cursor nos cantos da tela e escrevo os caracteres que representam o canto dela
            Console.SetCursorPosition(0, 0);
            Console.Write("┌");
            Console.SetCursorPosition(79, 0);
            Console.Write("┐");
            Console.SetCursorPosition(0, 24);
            Console.Write("└");
            Console.SetCursorPosition(79, 24);
            Console.Write("┘");

            //Imprimo a barra de cima da janela com um for de acordo com a quantidade de caracteres (largura) de minha tela
            //Inicio no 1 porque no 0 já tenho o caracter de canto  e acabo no 78 ( i< 79) porque no 79 já tenho o caracter de canto
            for (int i = 1; i < 79; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("─");
            }

            //Imprimo a barra lateral esquerda, deixo na posição X = 0 e vou aumentando o Y para imprimir de acordo 
            //com a altura (quantidade de caracteres) da minha tela
            //Não imprimo no Y = 0 (i = 1) e nem no Y = 24 (i < 24) porque já tem os cantos lá
            for (int i = 1; i < 24; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("│");
            }

            //Imprimo a barra lateral direita, deixo na posição X = 79 e vou aumentando o Y para imprimir de acordo 
            //com a altura (quantidade de caracteres) da minha tela
            //Não imprimo no Y = 0 (i = 1) e nem no Y = 24 (i < 24) porque já tem os cantos lá
            for (int i = 1; i < 24; i++)
            {
                Console.SetCursorPosition(79, i);
                Console.Write("│");
            }

            //Imprimo a barra de baixo da janela na posição mais baixa da tela (24) com um for de acordo com a quantidade de caracteres (largura) de minha tela
            //Inicio no 1 porque no 0 já tenho o caracter de canto  e acabo no 78 ( i< 79) porque no 79 já tenho o caracter de canto
            for (int i = 1; i < 79; i++)
            {
                Console.SetCursorPosition(i, 24);
                Console.Write("─");
            }

            //Aponto para o local onde o título deve ser escrito
            Console.SetCursorPosition(2, 1);
            //Escrevo o título
            Console.Write("ALGORITMOS DE ORDENAÇÃO");

            //Aponto para o local de início onde vou colocar uma barra separando o título do conteúdo e coloco o caracteres inicial dela
            Console.SetCursorPosition(0, 2);
            Console.Write("├");
            //Aponto para o local de Fim onde vou colocar uma barra separando o título do conteúdo e coloco o caracteres inicial dela
            Console.SetCursorPosition(79, 2);
            Console.Write("┤");

            //Coloco a barra que separa o título do conteúdo entre a posição 1 e 79 do X, para que eu não sobrescreva os cantos
            for (int i = 1; i < 79; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("─");
            }

        }

        //Função que imprime o menu de opções
        private static void CriaMenu()
        {
            //Aqui eu vou apontando para o local onde deve ficar escrito o menu e vou escrevendo as opções e títulos do Menu
            //Console.SetCursorPosition(X, Y);
            //X é sempre igual a 2 porque eu devo respeitar o primeiro caractere (0) que é a borda da janela e depois mais 1 (1) que é o espaçamento
            //por isso ele inicia sempre em 2
            //Y é a linha que eu quero escrever
            Console.SetCursorPosition(2, 3);
            Console.Write(" MENU");
            Console.SetCursorPosition(2, 5);
            Console.Write("1)  Insertion Sort");
            Console.SetCursorPosition(2, 6);
            Console.Write("2)  Shell Sort");
            Console.SetCursorPosition(2, 7);
            Console.Write("3)  Selection Sort");
            Console.SetCursorPosition(2, 8);
            Console.Write("4)  Heap Sort");
            Console.SetCursorPosition(2, 9);
            Console.Write("5)  Bubble Sort");
            Console.SetCursorPosition(2, 10);
            Console.Write("6)  Cocktail Sort");
            Console.SetCursorPosition(2, 11);
            Console.Write("7)  Comb Sort");
            Console.SetCursorPosition(2, 12);
            Console.Write("8)  Gnome Sort");
            Console.SetCursorPosition(2, 13);
            Console.Write("9)  Odd-even Sort");
            Console.SetCursorPosition(2, 14);
            Console.Write("10) Quick Sort");
            Console.SetCursorPosition(2, 15);
            Console.Write("11) Sair");
        }

        //Aqui vou inicializar o prompt para que o usuário digite uma opção escolhida
        //Vou desenhar ele na última linha antes da borda de fim
        private static void InicializaPrompt()
        {
            //Crio o Stopwatch que vai ser utilizado depois para medir o tempo de execução do algortimo de ordenação
            Stopwatch stopWatch = new Stopwatch();

            //Coloco o cursor na posição X = 2 respeitando a borda e o espaçamento esquerdo e
            //na posição Y = 23, última linha antes da borda inferior
            Console.SetCursorPosition(2, 23);

            //Peço para o usuário informar uma opção, uso o COnsole.Write e não o Console.WriteLine, pois quero que ele digite ao lado da mensagem
            Console.Write("Escolha uma opção: ");
            string valor = Console.ReadLine();

            //Converto a opção para inteiro para usar no switch
            int opcao;
            int.TryParse(valor, out opcao);

            //Aqui está os números que vamos ordenar dispostos em um array (vetor) não ordenado
            //Vamos usar esse vetor para todas as operações
            int[] vetorComOsNumerosParaOrdenar = new int[] { 11, 9, 7, 5, 3, 1 };

            //Para cada opçào eu faço o seguinte:
            //Verifico que opção foi selecionada
            //stopWatch.Start(); //para iniciar o calculo do intervalo
            //Chamo a função que faz o sort de acordo com a escolha
            //stopWatch.Stop(); // para parar de calcular o intervalo
            //Movo o cursor para onde vou escrever o resultado e escrevo com Console.Write para ficar na mesma linha
            //Uso o Console.ReadKey(); para esperar o usuário digitar algo para continuar
            //
            //Caso for selecionado o 11 eu faço sair do programa
            //Caso a pessoa digitou uma opção inválida (default) eu reinicio a tela

            switch (opcao)
            {
                case 1: // Insertion Sort
                    stopWatch.Start();
                    OpcaoInsertionSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();

                    break;
                case 2: // Shell Sort
                    stopWatch.Start();
                    OpcaoShellSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 3: // Selection Sort
                    stopWatch.Start();
                    OpcaoSelectionSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 4: // Heap Sort
                    stopWatch.Start();
                    OpcaoHeapSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 5: // Bubble Sort
                    stopWatch.Start();
                    OpcaoBubbleSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 6: // Cocktail Sort
                    stopWatch.Start();
                    OpcaoCocktailSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 7: // Comb Sort
                    stopWatch.Start();
                    OpcaoCombSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 8: // Gnome Sort
                    stopWatch.Start();
                    OpcaoGnomeSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 9: // Odd-Even Sort
                    stopWatch.Start();
                    OpcaoOddEvenSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 10: // Quick Sort
                    stopWatch.Start();
                    OpcaoQuickSort(vetorComOsNumerosParaOrdenar);
                    stopWatch.Stop();

                    Console.SetCursorPosition(2, 8);
                    Console.Write("TEMPO:     " + stopWatch.Elapsed);

                    Console.ReadKey();
                    break;
                case 11: // SAIR
                    Environment.Exit(0);
                    break;
                default: // VOLTA PARA O MENU
                    InicializaAplicacao();
                    break;
            }

            //Inicializo a tela com os menus e prompt
            InicializaAplicacao();
        }

        //Método que recebe o vetor com os números inteiro e converte ele para
        //uma string com os números separados por vírgula para imprimir no Console
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

        #region Métodos que escrevem e chama cada algortimo de ordenação
        //Para cada método abaixo faço basicamente isso:
        //1 - Recebo o vetor para ordenar como parâmetro na variável int[] vetorParaOrdenar
        //2 - Crio a janela em branco para escrever a operação e os resultados
        //3 - Escrevo o título
        //4 - Converto o vetor para uma string e imprimo ela na tela
        //5 - Chamo o método de ordenação (que fica em outro método) e recebo o retorno dele em
        //    uma variável int[] vetorOrdenado com ele já ordenado pelo algoritmo
        //6 - Converto o vetor ordenado para String e imprimo na tela

        private static void OpcaoInsertionSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" INSERTION SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = InsertionSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoShellSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" SHELL SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = ShellSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoSelectionSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" SELECTION SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = SelectionSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoHeapSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" HEAP SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = HeapSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoBubbleSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" BUBBLE SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = BubbleSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoCocktailSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" COCKTAIL SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = CocktailSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoCombSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" COMB SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = CombSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoGnomeSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" GNOME SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = GnomeSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoOddEvenSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" ODD-EVEN SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = OddEvenSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }

        private static void OpcaoQuickSort(int[] vetorParaOrdenar)
        {
            CriaJanela();

            Console.SetCursorPosition(2, 3);
            Console.Write(" QUICK SORT");

            Console.SetCursorPosition(2, 5);
            Console.Write("VETOR:     " + VetorParaString(vetorParaOrdenar));

            int[] vetorOrdenado = QuickSort(vetorParaOrdenar);

            Console.SetCursorPosition(2, 6);
            Console.Write("RESULTADO: " + VetorParaString(vetorOrdenado));
        }
        #endregion

        #region Insertion Sort
        //O Insertion Sort ou Ordenação por inserção é um método simples de ordenação que percorre 
        //um vetor ordenando os elementos a esquerda a medida que avança
        //ver link https://pt.wikipedia.org/wiki/Insertion_sort

        public static int[] InsertionSort(int[] vetor)
        {
            int i, j, atual;
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor;
        }

        #endregion

        #region Shell Sort

        //É um método de ordenação por inserção criado por Donald Shell que basicamente divide a lista 
        //a ser ordenada em grupos menores e aplica o método de ordenação por inserção.
        //ver link https://pt.wikipedia.org/wiki/Shell_sort
        public static int[] ShellSort(int[] vetor)
        {
            int h = 1;
            int n = vetor.Length;

            while (h < n)
            {
                h = h * 3 + 1;
            }

            h = h / 3;
            int c, j;
            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    j = i;
                    while (j >= h && vetor[j - h] > c)
                    {
                        vetor[j] = vetor[j - h];
                        j = j - h;
                    }
                    vetor[j] = c;
                }
                h = h / 2;
            }

            return vetor;
        }

        #endregion

        #region Selection Sort

        //O Selection Sort é um método de ordenação por seleção. 
        //Ele percorre a lista em busca do menor valor e o move para a posição 
        //correta precedido sempre do elemento de menor valor.
        //ver link https://pt.wikipedia.org/wiki/Selection_sort
        public static int[] SelectionSort(int[] vetor)
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

        #endregion

        #region Heap Sort

        //Desenvolvido em 1964 por Robert W. Floyd e J.W.J. Williams, o algoritmo Heap Sort é um método 
        //de ordenação por seleção. Esse algoritmo tem esse nome por utiliza uma estrutura de dados chamada heap.
        //HEAP: Em ciência da computação, um heap (monte) é uma estrutura de dados especializada, 
        //baseada em árvore, que é essencialmente uma árvore quase completa que satisfaz a propriedade 
        //heap: se P é um nó pai de C, então o valor de P é maior que ou igual ao valor de C.
        //O nó no "topo" da heap (sem pais) é chamado de nó raiz.
        //ver link: https://pt.wikipedia.org/wiki/Heap
        //                100
        //         ┌───────┴───────┐
        //        19               36
        //   ┌────┴───┐       ┌─────┴───┐
        //   17       3       25        1
        //┌──┴──┐
        // 2    7
        //ver link https://pt.wikipedia.org/wiki/Heapsort
        public static int[] HeapSort(int[] vetor)
        {
            HeapSortBuildMaxHeap(vetor);
            int n = vetor.Length;

            for (int i = vetor.Length - 1; i > 0; i--)
            {
                HeapSortSwap(vetor, i, 0);
                HeapSortMaxHeapify(vetor, 0, --n);
            }

            return vetor;
        }

        private static void HeapSortBuildMaxHeap(int[] v)
        {
            for (int i = v.Length / 2 - 1; i >= 0; i--)
            {
                HeapSortMaxHeapify(v, i, v.Length);
            }
        }

        private static void HeapSortMaxHeapify(int[] v, int pos, int n)
        {
            int max = 2 * pos + 1, right = max + 1;
            if (max < n)
            {
                if (right < n && v[max] < v[right])
                {
                    max = right;
                }
                if (v[max] > v[pos])
                {
                    HeapSortSwap(v, max, pos);
                    HeapSortMaxHeapify(v, max, n);
                }
            }
        }

        private static void HeapSortSwap(int[] v, int j, int aposJ)
        {
            int aux = v[j];
            v[j] = v[aposJ];
            v[aposJ] = aux;
        }

        #endregion

        #region Bubble Sort
        //O Bubble Sort é um algoritmo de ordenação mais simples que tem como característica percorrer 
        //o vtor várias vezes e a cada passagem fazendo migrar para o topo (início do vetor) 
        //o maior elemento da sequência.
        //ver link: https://pt.wikipedia.org/wiki/Bubble_sort
        public static int[] BubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }

        #endregion

        #region Cocktails
        //O Cocktail Sort ou Bubble Sort Bidirecional é uma variação do Bubble Sort que se difere pelo fato de 
        //ordenar a lista em ambas as direções.
        //ver link: https://pt.wikipedia.org/wiki/Cocktail_sort
        public static int[] CocktailSort(int[] vetor)
        {
            int tamanho, inicio, fim, swap, aux;
            tamanho = vetor.Length;
            inicio = 0;
            fim = tamanho - 1;
            swap = 0;
            while (swap == 0 && inicio < fim)
            {
                swap = 1;
                for (int i = inicio; i < fim; i = i + 1)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        swap = 0;
                    }
                }

                fim = fim - 1;

                for (int i = fim; i > inicio; i = i - 1)
                {
                    if (vetor[i] < vetor[i - 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i - 1];
                        vetor[i - 1] = aux;
                        swap = 0;
                    }
                }

                inicio = inicio + 1;
            }

            return vetor;
        }

        #endregion

        #region Comb Sort
        //O Comb Sort, é um algoritmo de ordenação por troca. 
        //Desenvolvido em 1980 por Wlodzimierz Dobosiewicz e mais tarde, foi redescoberto e popularizado 
        //por Stephen Lacey e Richard Box em um artigo publicado na revista Byte em Abril de 1991. 
        //O Comb Sort é uma melhoria do Bubble Sort e rivaliza com o Quick Sort.
        //ver link https://pt.wikipedia.org/wiki/Comb_sort
        public static int[] CombSort(int[] vetor)
        {
            int gap = vetor.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                {
                    gap = (int)(gap / 1.247330950103979);
                }

                int i = 0;
                swapped = false;
                while (i + gap < vetor.Length)
                {
                    if (vetor[i].CompareTo(vetor[i + gap]) > 0)
                    {
                        int t = vetor[i];
                        vetor[i] = vetor[i + gap];
                        vetor[i + gap] = t;
                        swapped = true;
                    }
                    i++;
                }
            }

            return vetor;
        }

        #endregion

        #region Gnome Sort
        //O Gnome Sort é um algoritmo com uma sequencia grande de trocas como o Bubble Sort, 
        //porem ele é similar ao Insertion Sort com a diferença de levar um elemento para sua posição correta.
        //ver link: https://pt.wikipedia.org/wiki/Gnome_sort
        public static int[] GnomeSort(int[] vetor)
        {
            int p = 0;
            int aux;
            while (p < (vetor.Length - 1))
            {
                if (vetor[p] > vetor[p + 1])
                {
                    aux = vetor[p];
                    vetor[p] = vetor[p + 1];
                    vetor[p + 1] = aux;
                    if (p > 0)
                    {
                        p -= 2;
                    }
                }
                p++;
            }

            return vetor;
        }

        #endregion

        #region Odd-Even Sort
        //O Odd-Even Sort é um algoritmo de ordenação por comparação baseado no Bubble Sort.
        //ver link: https://pt.wikipedia.org/wiki/Odd-even_sort
        public static int[] OddEvenSort(int[] vetor)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                // odd-even
                for (int x = 1; x < vetor.Length - 1; x += 2)
                {
                    if (vetor[x] > vetor[x + 1])
                    {
                        int tmp = vetor[x];
                        vetor[x] = vetor[x + 1];
                        vetor[x + 1] = tmp;

                        sorted = false;
                    }
                }

                // even-odd
                for (int x = 0; x < vetor.Length - 1; x += 2)
                {
                    if (vetor[x] > vetor[x + 1])
                    {
                        int tmp = vetor[x];
                        vetor[x] = vetor[x + 1];
                        vetor[x + 1] = tmp;

                        sorted = false;
                    }
                }
            }
            return vetor;
        }

        #endregion

        #region Quick Sort
        //O Quick Sort é um método de ordenação inventado por Charles Antony Richard Hoare em 1960 quando estudante.
        //ver link https://pt.wikipedia.org/wiki/Quicksort
        public static int[] QuickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            QuickSort(vetor, inicio, fim);

            return vetor;
        }

        private static void QuickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                QuickSort(vetor, inicio, f - 1);
                QuickSort(vetor, f + 1, fim);
            }
        }

        #endregion
    }
}
