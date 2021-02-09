using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new jogador("Teste1"));
            jogo.IniciarJogo();
        }
    }



      public class jogador
    {
        
        public readonly string _nome;

      

        public jogador(string nome)
        {
            _nome = nome;
            
        }

        public void chuta()
        {
            console.Write($"{_nome}está chutando");

        }
        public void corre()
        {
            console.Write($"{_nome}está correndo");
        }
        public void passe()
        {
            console.Write($"{_nome}está passando");
        }

    }
}
