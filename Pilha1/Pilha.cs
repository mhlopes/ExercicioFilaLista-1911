using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Pilha1
{
    internal class Pilha
    {
        public Dinheiro? Head { get; set; } = null;

        public bool IsEmpty()
        {
            return Head is null;
        }

        public void AddElement(Dinheiro dinheiro)
        {
            dinheiro.Next = Head;
            Head = dinheiro;
        }

        public void RemoveElement()
        {
            Head = Head?.Next;
        }

        public void ShowPilha()
        {
            var aux = Head;
            while (aux is not null)
            {
                Console.WriteLine($"[{aux.Value,2}]");
                aux = aux.Next;
            }
        }

        public int ElementCount()
        {
            var aux = Head;
            int count = 0;
            while (aux is not null)
            {
                count++;
                aux = aux.Next;
            }
            return count;
        }
    }
}
