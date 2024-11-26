using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLock
{
    internal class Consequencias
    {
        public int Dinheiro = 50;
        public int RelSocial = 50;
        public int Ambiental = 50;
        public int Projeto = 15;
        public int Situacao = 0;

        EndGame endGame = new EndGame();

        public void Consequencia(string pergunta, int escolha)
        {
            Pergunta asks = new Pergunta();
            int valor = 0;
            foreach (var ask in asks.perguntas)
            {
                valor++;
                if (ask.Key == pergunta)
                {
                    Analisar(valor, escolha);
                }
            }
        }

        public void Analisar(int valor, int escolha)
        {
            if(valor == 1)
            {
                if (escolha == 1)
                {
                    Dinheiro -= 10;
                    RelSocial += 10;
                } else
                {
                    Dinheiro += 10;
                    RelSocial -= 15;
                }
            }

            else if (valor == 2)
            {
                if (escolha == 1)
                {
                    Dinheiro -= 15;
                    Projeto += 10;
                    Ambiental -= 5;
                }
                else
                {
                    Projeto -= 5;
                    Ambiental += 5;
                }
            }

            else if (valor == 3)
            {
                if (escolha == 1)
                {
                    RelSocial -= 15;
                    Projeto += 15;
                    Ambiental -= 10;
                }
                else
                {
                    Projeto -= 5;
                    Ambiental += 10;
                }
            }

            else if (valor == 4)
            {
                if (escolha == 1)
                {
                    RelSocial -= 30;
                    Projeto += 15;
                    Ambiental -= 15;
                }
                else
                {
                    Projeto -= 10;
                    Ambiental += 10;
                    RelSocial += 10;
                }
            }

            else if (valor == 5) //BAD ENDING
            {
                if (escolha == 1)
                {
                    Dinheiro = 0;
                    RelSocial = 0;
                    Projeto = 0;
                    Ambiental = 0;
                }
                else
                {
                    Projeto -= 5;
                    Ambiental += 5;
                }
            }

            else if (valor == 6) 
            {
                if (escolha == 1)
                {
                    Dinheiro -=15;
                    RelSocial += 5;
                    Ambiental += 10;
                }

                else
                {
                    Dinheiro += 5;
                    Ambiental -= 10;
                }
            }

            else if (valor == 7) 
            {
                if (escolha == 1)
                {
                    Dinheiro -= 15;
                    RelSocial += 5;
                    Projeto += 10;
                }
                else
                {
                    Dinheiro += 10;
                    Projeto -= 5;
                }
            }

            else if (valor == 8)
            {
                if (escolha == 1)
                {
                    Dinheiro -= 5;
                    RelSocial += 15;
                    Projeto -= 10;
                }
                else
                {
                    Dinheiro += 10;
                    Projeto += 5;
                }
            }

            else 
            {
                if (escolha == 1)
                {
                    RelSocial += 20;
                    Projeto -= 10;
                }

                else
                {
                    RelSocial -= 20;
                    Projeto += 5;
                }
            }
        }

        public int Game()
        {
            Situacao++;
            return endGame.Endings(Dinheiro, RelSocial, Ambiental, Projeto, Situacao);
        }
    }
}
