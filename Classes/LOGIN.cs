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
            Logado = false;

            USUARIO acesso_1 = new USUARIO();

            do
            {
                Console.WriteLine("Insira a opção desejada: \n\n1-Cadastrar Usuario; \n2-Deletar Usuario; \n3-Log-in; \n4-Log-off; \n5-Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.WriteLine("Insira o nome de usuario para cadastrar: ");
                        string nome = Console.ReadLine().ToUpper();

                        Console.Write("Insira a senha: ");
                        string senha = Console.ReadLine();

                        Console.Write("Insira o email: ");
                        string email = Console.ReadLine().ToLower();

                        contadorCodigo++;

                        DateTime DataDoCadastro = DateTime.Now;

                        USUARIO novo_usuario = new USUARIO(nome, email, senha, contadorCodigo, DataDoCadastro);

                        Console.WriteLine(acesso_1.Cadastrar(novo_usuario)); 
                        


                        break;

                    case "2":

                        Console.WriteLine("Qual o nome do usuario que deseja remover?");
                        string nomeDeletar = Console.ReadLine().ToUpper();

                        USUARIO deletar_usuario = new USUARIO(nomeDeletar);

                        acesso_1.Deletar(deletar_usuario);

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
            USUARIO acesso_2 = new USUARIO();


            Console.WriteLine("Insira seu email: ");
            string emailLogin = Console.ReadLine().ToLower();

            foreach (USUARIO item in acesso_2.listaUsuariosCadastrados)
            {

                if (emailLogin == item.Email)
                {
                    Console.Write("Insira sua senha: ");
                    string senhaLogin = Console.ReadLine();

                    if (senhaLogin == item.Senha)
                    {
                        Logado = true;
                        return "Login realizado com sucesso!";
                    }

                }
                else
                {
                    Logado = false;
                    return "Usuario não localizado.";
                }
            }

            return "OK";
        }

    }
}