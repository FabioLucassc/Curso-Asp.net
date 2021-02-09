using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA("Teste");
            jogo.IniciarJogo();
        }
    }
    class JogoFODA
    {
        private readonly string nomeJogador;

        public JogoFODA(string nome)
        {
            this.nomeJogador = nome;
        }

        public void IniciarJogo()
        {
            Console.Write($"{nomeJogador} deu um passe");

        }

    }
}
