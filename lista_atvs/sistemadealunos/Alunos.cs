using System;

namespace sistemadealunos
{
    public class Alunos
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public Alunos(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }

        public void ExibirResultado()
        {
            double media = CalcularMedia();
            Console.WriteLine($"\nAluno: {Nome}");
            Console.WriteLine($"Média: {media}");

            if (media >= 6.0)
            {
                Console.WriteLine("Aluno aprovado!!!");
            }
            else if (media >= 4.0)
            {
                Console.WriteLine("Aluno está em recuperação!!!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado!!!");
            }
        }
    }
}
