using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Academek
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public List<string> Turmas = new List<string>();

        public Professor()
        {
            Turmas.AddRange(new[] { "Matematica 1A", "Portugues 2B" });
        }
    }
}
