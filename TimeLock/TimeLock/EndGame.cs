using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLock
{
    internal class EndGame
    {
        public int Endings(int Dinheiro, int RelSocial, int Ambiental, int Projeto, int Situacao)
        {
            Console.WriteLine(Dinheiro);
            Console.WriteLine(RelSocial);
            Console.WriteLine(Ambiental);
            Console.WriteLine(Projeto);
            Console.WriteLine(Situacao);

            if (Projeto <= 0 || Dinheiro <= 0 || RelSocial <= 0 || Ambiental <= 0)
            {
                if (Projeto <= 0)
                {
                    Console.WriteLine("O projeto deu errado!");
                    Console.WriteLine("GAME OVER!");
                    return 1;
                }
                else if (Dinheiro <= 0)
                {
                    Console.WriteLine("A empresa faliu!");
                    Console.WriteLine("GAME OVER!");
                    return 1;
                }

                else if (RelSocial <= 0)
                {
                    Console.WriteLine("Você é demitido!");
                    Console.WriteLine("GAME OVER!");
                    return 1;
                }

                else if (Ambiental <= 0)
                {
                    Console.WriteLine("O governo descobre a emissão de radiação causada pela sua empresa e você é preso!");
                    Console.WriteLine("GAME OVER!");
                    return 1;
                }
            }

            if (Situacao == 5)
            {
                if (Projeto >= 100)
                {
                    Console.WriteLine("O projeto deu totalmente certo!");
                    Console.WriteLine("GG!");
                    return 1;
                }
                else if (Projeto >= 70)
                {
                    Console.WriteLine("O projeto deu certo mas gerou insegurança!");
                    Console.WriteLine("Fim de jogo!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("O projeto deu completamente errado!");
                    Console.WriteLine("Game over!");
                    return 1;
                }

            }
            return 0;
        }
    }
}