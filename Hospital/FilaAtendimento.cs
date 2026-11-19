namespace Hospital
{
    public class FilaAtendimento : FilaSenhas
    {
        public FilaPrioritaria Prioritaria { get; set; }
        public FilaNormal Normal { get; set; }
        private int prioritariasSeguidas;

        public FilaAtendimento() : base("")
        {
            Prioritaria = new FilaPrioritaria();
            Normal = new FilaNormal();
            prioritariasSeguidas = 0;
        }

        public Senha? ChamarProximo()
        {
            Senha? chamada;

            if (prioritariasSeguidas < 2 && !Prioritaria.VerificarVazia())
            {
                chamada = Prioritaria.RemoverElemento();
                prioritariasSeguidas++;
            }
            else if (!Normal.VerificarVazia())
            {
                chamada = Normal.RemoverElemento();
                prioritariasSeguidas = 0;
            }
            else
            {
                // sem ninguem na normal, a prioritaria continua sendo atendida
                chamada = Prioritaria.RemoverElemento();
            }

            if (chamada != null)
            {
                InserirElemento(chamada);
            }
            return chamada;
        }
    }
}
