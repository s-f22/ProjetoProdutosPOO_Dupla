using System;
using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class USUARIO : IUSUARIO
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        private DateTime DataCadastro { get; set; }

        public void Cadastrar(string Usuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(string Usuario)
        {
            throw new NotImplementedException();
        }
    }
}