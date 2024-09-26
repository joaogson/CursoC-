// See https://aka.ms/new-console-template for more information

using Biblioteca.Entities;

	Bibliioteca bibliioteca = new Bibliioteca();

Console.WriteLine("");

bibliioteca.AdicionaLivro("Dom Quixote", "Pessoa", "123GD", "15/06/1906");
bibliioteca.AdicionaLivro("teste", "pessoa", "1234", "15/12/2004");

Aluno aluno = new Aluno(1, "Joao", 1, "1b", 3);
bibliioteca.GetListLivros();
bibliioteca.Emprestimo(aluno, "26/09/2024", bibliioteca.livros.FirstOrDefault(x => x.NomeLivro == "Dom Quixote"));


