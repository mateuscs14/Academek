using System;
using System.Collections.Generic;
using System.Text;

namespace Academek
{
    public abstract class Pessoa : IImprimivel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataDeNascimento { get; set; }

        public Pessoa (string nome, string cpf, string dataDeNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataDeNascimento = dataDeNascimento;
        }

        public abstract void ExibirInformacoes();
    }
}
