using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_04
{
    public class Aluno
    {
        private string nome {get; set;}
        private string idade { get; set; }
        private decimal nota { get; set; }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }


        public void SetIdade(string idade)
        {
            this.idade = idade;
        }

        public string GetIdade()
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
