using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {
        public void CriarPastaOuArquivo(string caminho)
        {
            // nomedapasta / nomedoarquivo.csv //caminho do arquivo
            //     [0]          [1]
            string pasta = caminho.Split('/')[0];

            //int total = camionho.Split('/').Lenght; pra saber o total de subpastas

            //string arquivo = caminho.Split('/')[1];

            //análise se a pasta existe
            //se não existir cria a pasta.

            if (!Directory.Exists(pasta)) //Se NÃO existe
            {
                Directory.CreateDirectory(pasta);
            }


            //análise se o arquivo existe
            //se não existir cria o arquivo.
            if (!File.Exists(caminho)
            {
                //criar o arquivo e fechart (encerrar a comunicação)
                File.Create(caminho).Close();


            }




        }
    }
}
