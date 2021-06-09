using ProjetoProdutosPOO_Dupla.Classes;

namespace ProjetoProdutosPOO_Dupla.INTERFACES
{
    public interface IUSUARIO
    {
         string Cadastrar(USUARIO Usuario);
         string Deletar(USUARIO Usuario);
    }
}