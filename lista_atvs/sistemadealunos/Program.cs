using System;
using System.Globalization;

namespace sistemadealunos
{
    class Program
    {
        static void Main(string [] args)/*Metodo que executa o programa*/{

            Console.WriteLine("Digite o nome do Aluno:");
            string nome = Console.ReadLine(); //Le a entrada do teclado como uma string

            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse( 
                Console.ReadLine(), 
                CultureInfo.InvariantCulture //Garante Separador decimal
            );

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse( 
                Console.ReadLine(), 
                CultureInfo.InvariantCulture //Garante Separador decimal
            );

            Alunos aluno = new Alunos(nome, nota1, nota2);

            aluno.ExibirResultado();
            


        }
    }
}