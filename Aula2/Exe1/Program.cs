// using System;

// class Program
// {
//     static void Main()
//     {
//         // Criando um vetor de números inteiros
//         int[] vetorDeInteiros = { 5, 2, 7, 1, 9, 12, 23, 34, 45, 56, 67, 68, 79, 89, 120,320, 450, 200000000};

//         // Ordenando o vetor de inteiros
//         Array.Sort(vetorDeInteiros);

//         // Imprimindo o vetor ordenado
//         Console.WriteLine("Vetor Ordenado:");
//         for (int i = 0; i < vetorDeInteiros.Length; i++)
//         {
//             Console.WriteLine(vetorDeInteiros[i]);
//         }
//     }
// }
using System;

class Program
{
    static void Main()
    {
        // Criando um vetor de números inteiros
        int[] vetorDeInteiros = { 5, 2, 7, 1, 9, 12, 23, 34, 45, 56, 67, 68, 79, 89, 120,320, 450, 200000000 };

        // Chamando a função de ordenação
        BubbleSort(vetorDeInteiros);

        // Imprimindo o vetor ordenado
        Console.WriteLine("Vetor Ordenado:");
        for (int i = 0; i < vetorDeInteiros.Length; i++)
        {
            Console.WriteLine(vetorDeInteiros[i]);
        }
    }

    static void BubbleSort(int[] vetor)
    {
        int tamanho = vetor.Length;
        for (int i = 0; i < tamanho - 1; i++)
        {
            for (int j = 0; j < tamanho - 1 - i; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    // Troca os elementos se estiverem fora de ordem
                    int temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                }
            }
        }
    }
}

