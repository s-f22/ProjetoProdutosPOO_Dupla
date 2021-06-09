using System;
using System.Collections.Generic;
using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class USUARIO : IUSUARIO
    {

        public USUARIO()
        {

        }
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        private DateTime DataCadastro { get; set; }

        public USUARIO(string _nome, string _email, string _senha, int _codigo, DateTime _dataCadastro)
        {
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;
            this.Codigo = _codigo;
            this.DataCadastro = _dataCadastro;
        }

        public List<USUARIO> listaUsuariosCadastrados = new List<USUARIO>();

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
            Console.WriteLine("Qual o nome do usuario que deseja remover?");
            UsuarioRMV.Nome = Console.ReadLine().ToLower();

            listaUsuariosCadastrados.RemoveAll(x => x.Nome == UsuarioRMV.Nome);

            return "Usuario removido com sucesso!";


        }


    }
}