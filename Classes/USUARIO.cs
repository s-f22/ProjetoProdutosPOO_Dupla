using System;
using System.Collections.Generic;
using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class USUARIO : IUSUARIO
    {

        
        private int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        private DateTime DataCadastro { get; set; }
        
        //LOGIN acesso_3 = new LOGIN();

        
        


        public List<USUARIO> listaUsuariosCadastrados = new List<USUARIO>();


        public USUARIO()
        {
             
        }



        public USUARIO(string _nome, string _email, string _senha, int _codigo, DateTime _dataCadastro)
        {
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;
            this.Codigo = _codigo;
            this.DataCadastro = _dataCadastro;

            
        }        

        public string Cadastrar(USUARIO UsuarioADD)
        {

            listaUsuariosCadastrados.Add(UsuarioADD);

            foreach (USUARIO item in listaUsuariosCadastrados)
            {
                Console.WriteLine($"\n{item.Nome}, {item.Email}, {item.DataCadastro}, {item.Codigo}");
            }

            return "Usuario cadastrado com sucesso."; // não esta retornando
        }

        public string Deletar(USUARIO UsuarioRMV)
        {
            

            listaUsuariosCadastrados.RemoveAll(x => x.Nome == UsuarioRMV.Nome);

            foreach (USUARIO item in listaUsuariosCadastrados)
            {
                Console.WriteLine($"\n{item.Nome}, {item.Email}, {item.DataCadastro}, {item.Codigo}");
            }

            return "Usuario removido com sucesso!";


        }


    }
}