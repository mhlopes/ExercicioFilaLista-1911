namespace Hospital
{
    public class FilaSenhas
    {
        public Senha? Head { get; set; }
        public Senha? Tail { get; set; }
        public int Contador;
        public string Prefixo { get; set; }

        public FilaSenhas(string prefixo)
        {
            Head = Tail = null;
            Contador = 0;
            Prefixo = prefixo;
        }

        public bool VerificarVazia()
        {
            return Head == null;
        }

        public void InserirElemento(Senha aux)
        {
            if (VerificarVazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail!.Proximo = aux;
                Tail = aux;
            }
            Contador++;
        }

        public Senha GerarSenha()
        {
            Senha nova = new Senha(Prefixo + Random.Shared.Next(100, 1000));
            InserirElemento(nova);
            return nova;
        }

        public Senha? RemoverElemento()
        {
            if (VerificarVazia())
            {
                return null;
            }

            Senha removida = Head!;
            Head = Head!.Proximo;
            removida.Proximo = null;
            if (Head == null)
            {
                Tail = null;
            }
            Contador--;
            return removida;
        }

        public int GetContador()
        {
            return Contador;
        }

        public void MostrarFila()
        {
            if (VerificarVazia())
            {
                Console.WriteLine("  (vazia)");
                return;
            }

            Senha? s = Head;
            while (s != null)
            {
                Console.Write("  " + s.Codigo);
                s = s.Proximo;
            }
            Console.WriteLine();
        }
    }
}
