using System.Collections.Generic;
using ProjetoProdutosPOO_Dupla.Classes;

namespace ProjetoProdutosPOO_Dupla.INTERFACES
{
    public interface IMARCA
    {
        string Cadastrar(MARCA Marca); 

        List<MARCA> Listar();

        string Deletar(MARCA Marca); 
    }
}