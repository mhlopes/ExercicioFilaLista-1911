using System;
using System.Collections.Generic;
using System.Text;

namespace Fila
{
    public class Fila
    {
        public Pessoa? Head { get; set; }
        public Pessoa? Tail { get; set; }
        public int Contador;

        public Fila()
        {
            Head = Tail = null;
            Contador = 0;
        }

        public bool VerificarVazia()
        {
            if (Head == null)
            {
                return true;
            }
            return false;
        }

        public void InserirElemento(Pessoa aux)
        {
            if (VerificarVazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
            Contador++;
        }

        public int GetContador()
        {
            return Contador;
        }
        public void MostrarFila()
        {
            Pessoa p = Head;
            for (int i = 0; i < Contador; i++)
            {
                if (p == null)
                {
                    Console.WriteLine("acabou");
                }
                else
                Console.WriteLine(p.Nome + ", ");
                p = p.Proximo;
            }
        }

        public void AndarFila()
        {
            if (!VerificarVazia())
            {
                Head = Head.Proximo;
                Contador--;
            }
        }
    }
}
