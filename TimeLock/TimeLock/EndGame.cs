using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLock
{
    internal class EndGame
    {
        public int Endings(int Dinheiro, int RelSocial, int Ambiental, int Projeto)
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

            return 0;
        }
    }
}