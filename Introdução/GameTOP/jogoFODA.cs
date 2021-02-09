namespace GameTOP
{
    public class JogoFODA
    {
        private readonly jogador _jogador;

        public JogoFODA(jogador _jogador)
        {
            _jogador = jogador;
        }

        public void IniciarJogo()
        {
            Console.Write($"{ _jogador.nome} deu um passe");

        }
    }
    class jogador
    {
        private string _nome;
        public int nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public jogador(string _nome)
        {
            _nome = nome;
            
        }

        public void chuta()
        {
            console.Write($"{nome}está chutando");

        }
        public void corre()
        {
            console.Write($"{nome}está correndo");
        }
        public void passe()
        {
            console.Write($"{nome}está passando");
        }

    }

}