// PASSOS PARA RESOLVERO EXERCICIO
// 1 - Vetor de 1000 posiçoes. []
// 2 - Prencher. []
// 3 - Visualizar valores. []
// 4 - Ordenar. []

using System.Globalization;

Console.WriteLine("\nDigite a quantidade numero aleatorio que desaj criar para ordenar: ");
int tamanho = Convert.ToInt32(Console.ReadLine());

bool verifica = false;
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
Console.WriteLine("\n");

do
{
    int j = 0;
    j++;
    verifica = false;
    for (int c = 0; c < vetor.Length - j ; c++)
    {
            if (vetor[c] > vetor[c + 1])
            {
                int troca1 = vetor[c + 1];;
                vetor[c + 1] = vetor[c];
                vetor[c] = troca1;
                verifica = true;
            }
            
    }
} while (verifica != false);

Console.WriteLine("\n");
for (int i = 0; i < tamanho; i++)
{
    Console.Write(vetor[i] + " ");
}