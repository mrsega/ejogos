using System.Collections.Generic;
using System.IO;
using EJOGOS.Interface;

namespace EJOGOS.Models
{

    // : representa a herança;
    //interface = contrato
    public class Equipe : EquipeBase, IEquipe

    {
        //prop TAB TAB

        //duplicar linha CTRL +D 
        public int IdEquipe { get; set; }
        public string nome { get; set; }
        public string Imagem { get; set; }

        //variável de banco de dados.

        //private nível de acesso
        //const = constante =  a varável não pode mudar.

        private const string caminho = "Database/equipe.csv";

        private string Preparar(Equipe e)
        {
            return $"{e.IdEquipe};{e.nome};{e.Imagem}";

        }

        //CONSTRUTOR, é um método acionado toda vez que a gente instancia uma classe,
        //se tiver o construtor ele vai executar o que tiver lá

        //atalho: ctor TAB TAB
        public Equipe()
        {

            //MÉTODO DA CLASSE DE HERANÇA;
            CriarPastaOuArquivo(caminho);

        }



        public void Criar(Equipe novaequipe)
        {
            //Equipe equipe = new Equipe(); //Exemplo feito a unha
            //equipe.IdEquipe = 1;
            //equipe.nome = "Time do Lucas";
            //equipe.Imagem = "Caminho da Imagem";

            //preparar a classe para retornar um texto.

            //array de strings = na posição 0 vai existir nossa linha
            string[] equipe_texto = { Preparar(novaequipe) };

            //arquivo vamos adicionar novas linhas.
            //(caminho, string em formato de array.)
            File.AppendAllLines(caminho, equipe_texto);
)
           

        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listadeEquipes = new List<Equipe>();

            //pegar o texto e adicionar na classe.

            string[] linhas = File.ReadAllLines(caminho);

            //adicionar a classe na lista

            foreach (string item in linhas)
            {
                // 1;NOME DO TIME; CAMINHO DA IMAGEM

                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.IdEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listadeEquipes.Add(equipeAtual);


            }

            //devolver a lista;
            return listadeEquipes;

        }
    }
}
