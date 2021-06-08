using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class LOGIN : ILOGIN
    {
        public LOGIN() // metodo construtor sem parametros/argumentos
        {
        }
        public LOGIN(bool status) // metodo construtor já recebendo um parametro/argumento booleano para inicializar o atributo "Logado" da Classe LOGIN
        {
            Logado = status;
        }

        private bool Logado { get; set; }

        public void Deslogar(string Usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Logar(string Usuario)
        {
            throw new System.NotImplementedException();
        }

    }
}