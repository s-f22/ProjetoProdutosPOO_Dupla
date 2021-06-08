using System;
using System.Collections.Generic;
using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class PRODUTO : IPRODUTO
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public MARCA Marca { get; set; }
        
        public Usuario CadastroPor { get; set; }
        
        public List<PRODUTO> ListaProduto { get; set; }
        
        public string Cadastrar(PRODUTO Produto)
        {
            throw new System.NotImplementedException();
        }

        public string Deletar(PRODUTO Produto)
        {
            throw new System.NotImplementedException();
        }

        public List<PRODUTO> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}