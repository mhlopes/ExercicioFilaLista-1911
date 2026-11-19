using System;
using System.Collections.Generic;
using System.Text;

namespace Lista
{
    public class Contato(string nome)
    {
        //public int Id { get; set; }
        public string Name { get; private set; } = nome;
        public string Phone { get; set; }
        public char? Gender { get; set; }

    }
}
