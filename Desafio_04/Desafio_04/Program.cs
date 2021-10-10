using System;
using System.Collections.Generic;

namespace Desafio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> ListAlunos = new List<Aluno>();
            var alunos = 0;

            Console.WriteLine("Qual a quantidade de alunos ?");
            alunos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            string[] StrAlunos = new string[alunos];
            string[] Idade = new string[alunos];
            decimal[] notas = new decimal[alunos];
            decimal aux = 0;

            for (int i = 0; i < alunos; i++)
            {
                var objaluno = new Aluno();
                Console.WriteLine("Qual o nome do aluno?: ");
                objaluno.SetNome(Console.ReadLine());
                Console.WriteLine("Qual a idade do aluno?: ");
                objaluno.SetIdade(Console.ReadLine());
                Console.WriteLine("Qual a nota do aluno?: ");
                objaluno.SetNota(decimal.Parse(Console.ReadLine()));
                notas[i] = objaluno.GetNota();
                ListAlunos.Add(objaluno);
                aux += notas[i];
            }
            ListAlunos.ForEach(Alunos => Console.WriteLine("Nome: " + Alunos.GetNome() + ",  " + Alunos.GetIdade() + ", Nota: " + Alunos.GetNota()));
            Console.WriteLine("A soma das notas é: " + aux);



        }
    }
}
