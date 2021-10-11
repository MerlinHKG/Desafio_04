using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_04
{
    public class Aluno
    {
        public string nome {get; set;}
        public int idade { get; set; }
        private decimal nota { get; set; }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }


        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return idade;
        }


        public void SetNota(decimal nota)
        {
            this.nota = nota;
        }

        public decimal GetNota()
        {
            return nota;
        }

    }
}
