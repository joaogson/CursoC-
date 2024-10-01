// See https://aka.ms/new-console-template for more information

using Biblioteca.Entities;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

Bibliioteca biblioteca = new Bibliioteca();

int IdUsuario = 1;
bool menu = true;

biblioteca.AdicionaLivro("Dom Quixote", "Pessoa", "123GD", "15/06/1906");
biblioteca.AdicionaLivro("teste", "pessoa", "1234", "15/12/2004");
biblioteca.AdicionaLivro("Dom casmurro", "Machado de Assis", "123abc", "16/09/1902");
biblioteca.AdicionaLivro("O capital", "Karl Marx", "654jgh", "20/03/1898");

biblioteca.CadastroUsuario(IdUsuario, "Joao", "joaogsonalio@gmail.com");
biblioteca.CadastroUsuario(2, "Emilia", "emiliasonalio@gmail.com");
biblioteca.CadastroUsuario(3, "Pedro", "pedrosilva@hotmail.com");
biblioteca.CadastroUsuario(4, "Fulano", "fulano@hotmail.com");

while (menu)
{
    Console.Clear();
    Console.WriteLine("---- Biblioteca ----");
    Console.WriteLine();
    Console.WriteLine("1. Gerenciar Pessoas");
    Console.WriteLine("2. Gerenciar Livros");
    Console.WriteLine("3. Gerenciar Emprestimos");
    Console.WriteLine("4. Sair");
    Console.WriteLine();
    Console.WriteLine("---- Biblioteca ----");
    Console.WriteLine("Escolha uma opção (1, 2, 3): ");
    char ch = char.Parse(Console.ReadLine());

    switch (ch)
    {
        case '1':

            Console.Clear();
            Console.WriteLine("--- Biblioteca ----");
            Console.WriteLine();
            Console.WriteLine("1. Adicionar Pessoas");
            Console.WriteLine("2. Remover Pessoas");
            Console.WriteLine("3. Listar Usuarios");
            Console.WriteLine("4. Voltar");
            Console.WriteLine();
            Console.WriteLine("--- Biblioteca ----");

            char opc = char.Parse(Console.ReadLine());

            switch (opc)
            {
                case '1':

                    Console.Clear();
                    Console.Write("Informe o nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Informe o email: ");
                    string email = Console.ReadLine();
                    biblioteca.CadastroUsuario(IdUsuario, nome, email);
                    IdUsuario++;
                    Console.WriteLine("Usuario cadastrado com sucesso!");

                    break;
                case '2':

                    Console.Clear();
                    Console.Write("Informe o nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Informe o Id: ");
                    int id = int.Parse(Console.ReadLine());
                    biblioteca.RemoveUsuario(id, nome);
                    Console.WriteLine("Usuario cadastrado com sucesso!");
                    break;
                case '3':

                    biblioteca.GetListUsuarios();
                    Console.ReadKey();
                    break;
                case '4':

                    break;
            }

            break;
        case '2':

            Console.Clear();
            Console.WriteLine("--- Biblioteca ----");
            Console.WriteLine();
            Console.WriteLine("1. Adicionar Livros");
            Console.WriteLine("2. Remover Livros");
            Console.WriteLine("3. Listar Livros");
            Console.WriteLine("4. Voltar");
            Console.WriteLine();
            Console.WriteLine("--- Biblioteca ----");

            opc = char.Parse(Console.ReadLine());

            switch (opc)
            {
                case '1':

                    Console.Clear();
                    Console.Write("Informe o nome do Livro: ");
                    string nomeLivro = Console.ReadLine();
                    Console.Write("Informe o nome do Autor: ");
                    string nomeAutor = Console.ReadLine();
                    Console.Write("Informe o ISSN: ");
                    string issn = Console.ReadLine();
                    Console.Write("Informe o ano de publicação do livro: ");
                    string ano = Console.ReadLine();

                    biblioteca.AdicionaLivro(nomeLivro, nomeAutor, issn, ano);
                    Console.WriteLine("Livro adicionado com sucesso!");

                    break;
                case '2':

                    Console.Clear();
                    Console.WriteLine("Informe o nome do livro: ");
                    nomeLivro = Console.ReadLine();

                    biblioteca.RemoveLivro(nomeLivro);
                    Console.WriteLine("Livro removido com sucesso!");

                    break;
                case '3':

                    biblioteca.GetListLivros();
                    Console.ReadKey();
                    break;
                case '4':

                    break;
            }

            break;
        case '3':

            Console.Clear();
            Console.WriteLine("--- Biblioteca ----");
            Console.WriteLine();
            Console.WriteLine("1. Realizar Emprestimo");
            Console.WriteLine("2. Ver Emprestimos");
            Console.WriteLine("3. Finalizar um Emprestimo");
            Console.WriteLine("4. Voltar");
            Console.WriteLine();
            Console.WriteLine("--- Biblioteca ----");

            opc = char.Parse(Console.ReadLine());

            switch (opc)
            {
                case '1':

                    Console.Clear();

                    biblioteca.GetListUsuarios();

                    Console.Write("Informe o usuario: ");
                    string nome = Console.ReadLine();
                    Console.Write("Informe o id do usuario: ");
                    int id = int.Parse(Console.ReadLine());

                    biblioteca.GetListLivros();

                    Console.WriteLine("Informe o nome do livro: ");
                    string nomeLivro = Console.ReadLine();
                    biblioteca.Emprestimo(nome, id, DateTime.Now, nomeLivro);

                    break;
                case '2':

                    Console.Clear();
                    Console.WriteLine("Informe o usuario: ");

                    biblioteca.GetListUsuarios();

                    nome = Console.ReadLine();
                    Usuario usuario  = biblioteca.Usuarios.FirstOrDefault(x => x.Name == nome);

                    Console.WriteLine("Emprestimos: ");
                    foreach (var itemEmprestimo in usuario.Emprestimos)
                        Console.WriteLine(itemEmprestimo);

                    Console.ReadKey();

                    break;
                case '3':

                    Console.WriteLine("Informe de qual usuario é o emprestimo: ");

                    Console.WriteLine();
                    biblioteca.GetListUsuarios();
                    Console.WriteLine();

                    nome = Console.ReadLine();
                    Usuario user = biblioteca.Usuarios.FirstOrDefault(x => x.Name == nome);
                    if(user != null)
                    {
                        Console.WriteLine("Informe o livro emprestado: ");

                        Console.WriteLine();
                        biblioteca.GetListLivros();
                        Console.WriteLine();

                        nomeLivro = Console.ReadLine();
                        Emprestimo emprestimo = user.Emprestimos.FirstOrDefault(x => x.Livro.NomeLivro == nomeLivro);

                        if (emprestimo != null)
                            biblioteca.FinalizaEmprestimo(emprestimo);
                        else
                            Console.WriteLine("Livro não encontrado!");

                    }
                    else
                        Console.WriteLine("Usuario não encontrado!");
                    break;
            }

            break;
        case '4':
            menu = false;
            break;
        default:
            menu = false;
            break; 
    }
    
}

