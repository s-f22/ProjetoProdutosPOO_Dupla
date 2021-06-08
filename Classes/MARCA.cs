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

        List<MARCA> ListaMarca = new List<MARCA>();

        public MARCA(){

        }
        public MARCA(int _codigo, string _nome, DateTime _DataCadastro){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.DataDeCadastro = _DataCadastro;
        }
        
        public string Cadastrar(MARCA Marca)
        {
            ListaMarca.Add(Marca);
            return $"{Marca.Nome} foi adicionado com susseso";
        }

        public string Deletar(MARCA Marca)
        {
            ListaMarca.Remove(Marca);
            return $"{Marca.Nome} foi deletada com susseso";
        }

        public List<MARCA> Listar()
        {
            return ListaMarca;
        }
    }
}