using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo
{

    class Game
    {

        public enum Resultado
        {

            Ganhar, Perder, Empatar

        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png"),
        };

        public Image imgPc
        { 
            get;
            private set;
        }

        public Image imgJogador 
        {
            get; private set; 
        }

        public Resultado Jogar(int jogador)
        {

            int pc = JogadaPC();

            imgJogador = images[jogador];
            imgPc = images[pc]; 

            if (jogador == pc)
            {
                return Resultado.Empatar;
            } else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
            {
                return Resultado.Ganhar;
            } else
            {
                return Resultado.Perder;
            }

           
        }

        private int JogadaPC()
        {
            int ms = DateTime.Now.Millisecond;
            if (ms < 333)
            {
                return 0;
            } else if (ms >= 333 && ms < 667)
            {
                return 1;
            } else
            {
                return 2;
            }
        }

    }
}
