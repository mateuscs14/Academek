using System;
using System.Collections.Generic;
using System.Text;

namespace Academek
{
    public class Aluno : Pessoa
    {
        public double Notas { get; set; }

        public double Matricula { get; set; }

        public List<double> Medias { get; set; } = new List<double>
        {
            9,8
        };
        
    }
}
