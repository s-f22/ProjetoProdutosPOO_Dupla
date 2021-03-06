using System;
using ProjetoProdutosPOO_Dupla.INTERFACES;

namespace ProjetoProdutosPOO_Dupla.Classes
{
    public class LOGIN : ILOGIN
    {
        private bool Logado { get; set; }
        

        public LOGIN() // metodo construtor sem parametros/argumentos
        {
            //TODA A LOGICA AQUI
            string opcao;
            int contadorCodigo = 0;
            Logado = false;
            MARCA escolha;   
            string escolha_marca;  
            
            MARCA marca_1 = new MARCA();
            USUARIO acesso_1 = new USUARIO();
            PRODUTO produto_1 = new PRODUTO();

            do
            {
                Console.WriteLine("Insira a opção desejada: \n\n1-Cadastrar Usuario; \n2-Deletar Usuario; \n3-Log-in; \n4-Sair");
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

                        Logado = false;

                        break;

                    case "2":

                        Console.WriteLine("Qual o nome do usuario que deseja remover?");
                        string nomeDeletar = Console.ReadLine().ToUpper();
                        if (marca_1.ListaMarca.Count == 0)
                        {
                            Console.WriteLine("a lista esta vazia não tem o que fazer aqui");
                        }
                        else
                        {   
                            USUARIO deletar_usuario = acesso_1.listaUsuariosCadastrados.Find(x =>x.Nome == nomeDeletar);
                            acesso_1.Deletar(deletar_usuario);
                        }
                        Logado = false;
                        break;
                    case "3":
                        Console.Write("Insira seu email: ");
                        string _emailLog = Console.ReadLine().ToLower();

                        Console.Write("Insira sua senha: ");
                        string _senhaLog = Console.ReadLine();


                        USUARIO log = new USUARIO(_emailLog, _senhaLog);

                        USUARIO usuarioLogonOK = new USUARIO();

                        usuarioLogonOK = acesso_1.ValidarLogin(log);

                        Console.WriteLine(Logar(usuarioLogonOK));


                        do
                        {

                            if (Logado)
                            {
                                Console.WriteLine($@"Menu:
1- Cadastrar Marca
2- Listar Marcas
3- Deletar Marca
4- Cadastrar Produto
5- Listar produtos
6- Deletar Produto
7- Log-off
");
                                string menu = Console.ReadLine();
                                switch (menu)
                                {
                                    case "1":
                                        Console.WriteLine("Qual o codigo da marca?");
                                        int marca_codigo = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Qual o nome da marca?");
                                        string marca_nome = (Console.ReadLine());

                                        DateTime data_cadastro = DateTime.Now;

                                        MARCA marca_2 = new MARCA(marca_codigo, marca_nome, data_cadastro);
                                        Console.WriteLine(marca_1.Cadastrar(marca_2));
                                        
                                        break;
                                        
                                    case "2":
                                        foreach (MARCA item in marca_1.ListaMarca)
                                        {
                                            Console.WriteLine($"{item.NomeMarca}\n");
                                        }
                                        break;

                                    case "3":
                                        Console.WriteLine("Qual o nome da marca que deseja deletar?");
                                        string nome_marca = Console.ReadLine();
                                        if (marca_1.ListaMarca.Count == 0)
                                        {
                                            Console.WriteLine("lista vazia não tem o que deletar");
                                        }
                                        else
                                        {
                                            MARCA marca_deletar = marca_1.ListaMarca.Find(x =>x.NomeMarca == nome_marca);
                                            marca_1.Deletar(marca_deletar);
                                        }
                                        break;

                                    case "4":
                                        Console.WriteLine("Qual o codigo do produto?");
                                        int produto_codigo = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Qual o nome do produto?");
                                        string produto_nome = (Console.ReadLine());

                                        Console.WriteLine("Qual o preço do produto?");
                                        float produto_preco = float.Parse(Console.ReadLine());

                                        DateTime data_produto = DateTime.Now;
                                        if (marca_1.ListaMarca.Count == 0)
                                        {
                                            Console.WriteLine("você ainda não cadastrou nenhuma marca");
                                        }
                                        else
                                        {
                                            foreach (var item in marca_1.ListaMarca)
                                            {
                                                Console.WriteLine($"{item.Codigo} - {item.NomeMarca}\n");
                                            }
                                            Console.WriteLine("Qual nome da marca que vc quer?");
                                            escolha_marca = Console.ReadLine();
                                            escolha = marca_1.ListaMarca.Find(x =>x.NomeMarca == escolha_marca);
                                            if (escolha != null)
                                            {        
                                                
                                                PRODUTO produto_2 = new PRODUTO(produto_codigo, produto_nome, produto_preco, data_produto, escolha, usuarioLogonOK);
                                                produto_1.Cadastrar(produto_2);
                                            }
                                            else
                                            {
                                                Console.WriteLine("algo deu errado tente novamente");
                                            }
                                        }

                                        break;

                                    case "5":
                                        foreach (PRODUTO item in produto_1.ListaProduto)
                                        {
                                            Console.WriteLine($"Código do produto: {item.Codigo} - Nome: {item.NomeProduto} - Preç: {item.Preco} - Data de cadastro: {item.DataDeCadastro} - Marca: {item.Marca.NomeMarca} - Cadastrado por: {usuarioLogonOK}\n");
                                        }
                                        break;

                                    case "6":
                                        Console.WriteLine("Qual o nome da marca que deseja deletar?");
                                        string nome_produto = Console.ReadLine();
                                        if (marca_1.ListaMarca.Count == 0)
                                        {
                                            Console.WriteLine("lista vaizi não tem o que deletar");
                                        }
                                        else
                                        {
                                            PRODUTO produto_deletar = produto_1.ListaProduto.Find(x =>x.NomeProduto == nome_produto);
                                            produto_1.Deletar(produto_deletar);
                                        }
                                        break;

                                    case "7":
                                        Console.WriteLine("tchau!");
                                        Logado = false;
                                        break;
                                    default:
                                        Console.WriteLine("opção invalida!");
                                        break;
                                }

                            }
                        } while (Logado == true) ;
                    break;

                    case "4":
                        Console.WriteLine("Até logo!!");
                        Logado = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                        
                }

            } while (Logado == false);

        }

        public string Deslogar(USUARIO Usuario)
        {
            Logado = false;
            return "Você deslogou";
        }

        public string Logar(USUARIO Usuario)
        {
            if (Usuario.Codigo != 0)
            {
                Logado = true;
                return "Login realizado com sucesso.\n";
            }
            return "Login não concluido.\n";
        }

    }
}