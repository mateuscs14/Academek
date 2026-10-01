using System;
using System.Collections.Generic;
using System.Text;

namespace Academek
{
    public class Aluno : Pessoa
    {
        public double Matricula { get; set; }

        private List<double> _notas = new List<double>();
        public IReadOnlyList<double> Notas => _notas;

        public Aluno(string nome, string cpf, string dataDeNascimento, double matricula)
            : base(nome, cpf, dataDeNascimento)
        {
            Matricula = matricula;
        }

        public void AdicionarNota(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                _notas.Add(nota);
            }
            else
            {
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            }
        }

       
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome} ");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Data de Nascimento: {DataDeNascimento}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Notas: {(Notas.Count > 0 ? string.Join(", ", Notas) : "Nenhuma nota registrada")}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}