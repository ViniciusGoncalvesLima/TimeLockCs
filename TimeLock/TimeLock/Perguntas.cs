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

        public Dictionary<string, int> perguntas = new Dictionary<string, int> {
            { "1. Funcionário da produção: \"Nós, da equipe de produção, estamos insatisfeitos com o salário em relação ao serviço exigido.\"", 1 },
            { "2. Gerente do projeto: “O projeto está cada vez mais difícil de se sustentar, precisamos instalar fusíveis tecnológicos, entretanto eles possuem o elemento cobalto-60, e podem emitir radiação ao meio ambiente.”", 1 },
            {"2.1. Gerente do projeto: “Com o uso dos fusíveis, o projeto teve um avanço significativo, entretanto alguns funcionários estão sendo afetados pela radiação, o senhor deseja continuar com o uso dos fusíveis?”", 2 },
            {"2.1.1 Diretora do RH: “Esses fusíveis que o senhor implementou é uma tremenda loucura, nosso funcionários estão se sentindo cada vez pior por trabalhar com eles. Pare de usar esses fusíveis agora mesmo!”", 3 },
            { "3. Gerente do projeto: “Senhor, andei analisando, e percebi que se usarmos composto químico comburente, conseguiremos um grande avanço no projeto, mas correremos um risco de uma danificação nos motores”", 1 },
            { "4. Engenheiro Ambiental:  Descobrimos uma maneira de reduzir as emissões de carbono da empresa em 50%, mas isso exigirá um investimento significativo em novas tecnologias.\"", 1 },
            { "5. Supervisor de Produção: “Estamos enfrentando problemas com a qualidade dos materiais fornecidos por nosso atual fornecedor. Trocar de fornecedor pode melhorar a qualidade mas aumentará os custos”", 1 },
            { "6. Gerente de Manutenção: \"Precisamos realizar uma manutenção em nossos equipamentos para evitar falhas futuras, mas isso resultará em um custo significativo e tempo de inatividade.\"", 1 },
            { "7. Diretora do RH:  “Nossos funcionários estão cada dia mais exaustos com o trabalho excessivo. Permita férias mais frequentes, isso ajudará a progredir no desempenho pessoal.”", 1 }
        };

        public List<string> respostas = new List<string> {
            "1 (Aumentar salário) ou 2 (O salário permanecerá igual)",
            "1 (Instale os fusíveis) ou 2 (Não instale os fusíveis)",
            "1 (Continue usando os fusíveis) ou 2 (Pare imediatamente o uso dos fusíveis)",
            "1 (O projeto precisa dos fusíveis) ou 2 (Os fusíveis não serão mais usados)",
            "1 (Está permitido o uso) ou 2 (Não use o comburente)",
            "1 (Investir em novas tecnologias) ou 2 (Manter as tecnologias atuais)",
            "1 (Trocar de fornecedor) ou 2 (Manter o fornecedor atual)",
            "1 (Realizar a manutenção preventiva) ou 2 (Adiar a manutenção)",
            "1 (Dar férias) ou 2 (Vai trabalhar ô)"
        };

        public List<KeyValuePair<string, int>> lista;
        public Pergunta()
        {
            lista = new List<KeyValuePair<string, int>>(perguntas);
        }

        public void GerarPergunta()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next() % 9;

            Console.WriteLine("Pergunta:");
            Console.WriteLine(lista[numeroAleatorio].Key);
            Console.WriteLine("");
            Console.WriteLine("Escolha:");
            Console.WriteLine(respostas[numeroAleatorio]);
        }
    }
}