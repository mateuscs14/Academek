using System;
using System.Collections.Generic;
using System.Text;

namespace Academek
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
    }
}
