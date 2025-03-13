// PASSOS PARA RESOLVERO EXERCICIO
// 1 - Vetor de 1000 posiçoes. []
// 2 - Prencher. []
// 3 - Visualizar valores. []
// 4 - Ordenar. []

using System.Globalization;

int tamanho;

Console.WriteLine("\nDigite a quantidade numero aleatorio que desaj criar para ordenar: ");
tamanho = Convert.ToInt32(Console.ReadLine());

int[] vetor = new int[tamanho];

// Gerar um valor randômico

for (int i = 0; i < tamanho; i++)
{
    Random r = new Random();
    vetor[i] = r.Next(tamanho);
}

for (int i = 0; i < tamanho; i++)
{
    Console.Write(vetor[i] + " ");
}

Array.Sort(vetor);

Console.WriteLine("\n");
for (int i = 0; i < tamanho; i++)
{
    Console.Write(vetor[i] + " ");
}