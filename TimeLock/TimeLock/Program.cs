using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pergunta pergunta = new Pergunta();
            Consequencias consequencias = new Consequencias();
            int fim = 0;
            while (true)
            {
                fim = pergunta.GerarPergunta();
                if (fim == 1)
                {
                    break;
                }
            }
        }
    }
}
