using System;
using System.Collections.Generic;
using System.Text;

namespace Fila
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa? Proximo;

        public Pessoa(string nome)
        {
            Nome = nome;
            Proximo = null;
        }
    }
}
