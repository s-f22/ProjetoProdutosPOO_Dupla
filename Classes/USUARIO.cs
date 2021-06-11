using System;
using System.Collections.Generic;
using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class USUARIO : IUSUARIO
    {


        public int Codigo { get; set; }
        public string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
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

        public USUARIO(string _email, string _senha)
        {
            this.Email = _email;
            this.Senha = _senha;
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



        public USUARIO ValidarLogin(USUARIO _usuarioParaValidar)
        {
            USUARIO usuario_ok = new USUARIO();

            bool email = false;
            bool senha = false;

            usuario_ok.Codigo = 0;

            foreach (USUARIO item in listaUsuariosCadastrados)
            {
                if (item.Email != _usuarioParaValidar.Email)
                {
                    email = false;

                }
                else
                {
                    if (item.Senha != _usuarioParaValidar.Senha)
                    {
                        email = true;
                        senha = false;

                    }
                    else
                    {
                        email = true;
                        senha = true;
                        usuario_ok = item;
                        usuario_ok.Nome = item.Nome;
                        usuario_ok.Codigo = item.Codigo;
                        usuario_ok.DataCadastro = item.DataCadastro;

                        break;
                    }
                }
            }

            if (email == false)
            {
                Console.WriteLine("\nSenha invalida.");
            }
            else if (email == true && senha == false)
            {
                Console.WriteLine("\nEmail não encontrado.");
            }

            return usuario_ok;

        }

    }


}

