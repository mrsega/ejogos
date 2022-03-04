using System.Collections.Generic;
using EJOGOS.Models;

namespace EJOGOS.Interface
{
    public interface IEquipe
    {

        //CONTRATO.
        //Representa os métodos que são obrigatórios em uma classe

        void Criar(Equipe novaequipe);

        List<Equipe> LerEquipes();

        
        



    }
}
