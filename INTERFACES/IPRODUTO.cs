using System.Collections.Generic;
using ProjetoProdutosPOO_Dupla.Classes;

namespace ProjetoProdutosPOO_Dupla.INTERFACES
{
    public interface IPRODUTO
    {
        string Cadastrar(PRODUTO Produto);

        List<PRODUTO> Listar();

        string Deletar(PRODUTO Produto);
    }
}