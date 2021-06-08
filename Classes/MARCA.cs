using System;
using System.Collections.Generic;
using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class MARCA : IMARCA
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public DateTime DataDeCadastro;
        
        public string Cadastrar(MARCA Marca)
        {
            throw new System.NotImplementedException();
        }

        public string Deletar(MARCA Marca)
        {
            throw new System.NotImplementedException();
        }

        public List<MARCA> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}