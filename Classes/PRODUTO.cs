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
        
        public USUARIO CadastroPor { get; set; }
        
        public List<PRODUTO> ListaProduto = new List<PRODUTO>();

        public PRODUTO(){

        }
        public PRODUTO(int _Codigo, string _NomeProduto, float _Preco,DateTime _DataCadastro, MARCA _Marca, USUARIO _CadastroPor){
            this.Codigo = _Codigo;
            this.NomeProduto = _NomeProduto;
            this.Preco = _Preco;
            this.DataDeCadastro = _DataCadastro;
            this.Marca = _Marca;
            this.CadastroPor = _CadastroPor;
        }

        public string Cadastrar(PRODUTO Produto)
        {
            ListaProduto.Add(Produto);
            return $"produto de nome: {Produto.NomeProduto}, cadastrado com susesso por {CadastroPor}";
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