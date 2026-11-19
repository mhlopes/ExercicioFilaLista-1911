using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha1
{
    internal class Dinheiro(int valor)
    {
        public int Value { get; private set; } = valor;

        public Dinheiro? Next { get; set; } = null;

        public override string ToString()
        {
            return $"[{Value.ToString()}]";
        }
    }
}
