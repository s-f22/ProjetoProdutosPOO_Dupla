using ProjetoProdutosPOO_Dupla.Classes;

namespace ProjetoProdutosPOO_Dupla.INTERFACES
{
    public interface ILOGIN
    {
         string Logar(USUARIO Usuario);
         string Deslogar(USUARIO Usuario);

    }
}