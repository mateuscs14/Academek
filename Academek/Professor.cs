using System;
using System.Collections.Generic;

namespace Academek
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        private List<string> _turmas = new List<string>();
        public IReadOnlyList<string> Turmas => _turmas;

        public Professor(string nome, string cpf, string dataDeNascimento, double salario)
            : base(nome, cpf, dataDeNascimento)
        {
            Salario = salario;
        }

        public void AdicionarTurma(string turma)
        {
            if (!string.IsNullOrWhiteSpace(turma))
            {
                _turmas.Add(turma);
            }
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Data de Nascimento: {DataDeNascimento}");
            Console.WriteLine($"Salário: R$ {Salario:F2}");
            Console.WriteLine($"Turmas: {(Turmas.Count > 0 ? string.Join(", ", Turmas) : "Nenhuma turma associada")}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}