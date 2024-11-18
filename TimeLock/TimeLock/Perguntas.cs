using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLock
{
    internal class Pergunta
    {
        public int Dinheiro { get; set; }
        public int RelSocial { get; set; }
        public int Ambiental { get; set; }
        public int Projeto { get; set; }
        
        public List<string> perguntas = new List<string> {
            "1. Funcionário da produção: \"Nós, da equipe de produção, estamos insatisfeitos com o salário em relação ao serviço exigido.\"",
            "2. Gerente do projeto: “O projeto está cada vez mais difícil de se sustentar, precisamos instalar fusíveis tecnológicos, entretanto eles possuem o elemento cobalto-60, e podem emitir radiação ao meio ambiente.”",
            "3. Gerente do projeto: “Senhor, andei analisando, e percebi que se usarmos composto químico comburente, conseguiremos um grande avanço no projeto, mas correremos um risco de uma danificação nos motores”",
            "4. Engenheiro Ambiental:  Descobrimos uma maneira de reduzir as emissões de carbono da empresa em 50%, mas isso exigirá um investimento significativo em novas tecnologias.\"",
            "5. Supervisor de Produção: “Estamos enfrentando problemas com a qualidade dos materiais fornecidos por nosso atual fornecedor. Trocar de fornecedor pode melhorar a qualidade mas aumentará os custos”",
            "6. Gerente de Manutenção: \"Precisamos realizar uma manutenção em nossos equipamentos para evitar falhas futuras, mas isso resultará em um custo significativo e tempo de inatividade.\"",
            "7. Diretora do RH:  “Nossos funcionários estão cada dia mais exaustos com o trabalho excessivo. Permita férias mais frequentes, isso ajudará a progredir no desempenho pessoal.”"
        };

        public void GerarPergunta()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next() % 6;

            Console.WriteLine("Pergunta:");
            Console.Write(perguntas[numeroAleatorio]);
        }
    }
}
