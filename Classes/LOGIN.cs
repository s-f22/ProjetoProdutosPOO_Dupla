using System;
using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class LOGIN : ILOGIN
    {
        public LOGIN() // metodo construtor sem parametros/argumentos
        {
            //TODA A LOGICA AQUI
            string opcao;
            int contadorCodigo = 0;
            do
            {
                Console.WriteLine("Insira a opção desejada: 1-Cadastrar Usuario; 2 Deletar Usuario; 3-Log-in; 4-Log-off; 5-Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.Write("Insira o nome de usuario para cadastrar: ");
                        string nome = Console.ReadLine().ToUpper();

                        Console.Write("Insira a senha: ");
                        string senha = Console.ReadLine();

                        Console.Write("Insira o email: ");
                        string email = Console.ReadLine().ToLower();

                        contadorCodigo++;

                        DateTime DataDoCadastro = DateTime.Now;

                        USUARIO novo_usuario = new USUARIO(nome, senha, email, contadorCodigo, DataDoCadastro);
                        
                        novo_usuario.Cadastrar(novo_usuario);
                       

                        break;

                    case "2":

                        USUARIO ChamarDeletar = new USUARIO();

                        ChamarDeletar.Deletar(ChamarDeletar);

                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        Console.WriteLine("Até logo!!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != "5");

        }




        private bool Logado { get; set; }




        public string Deslogar(USUARIO Usuario)
        {
            throw new System.NotImplementedException();
        }

        public string Logar(USUARIO Usuario)
        {
            throw new System.NotImplementedException();
        }

    }
}