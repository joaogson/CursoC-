// See https://aka.ms/new-console-template for more information

using Biblioteca1.Entities;



/*
Console.WriteLine(livro);
Console.WriteLine();
Console.WriteLine(usuario);
Console.WriteLine();
Console.WriteLine();
*/

Bilioteca bilioteca = new Bilioteca();

bilioteca.AdicionaLivro("dom quixote", "autor", "12fd4x3", "15/12/2004");
bilioteca.AdicionaLivro("it", "autor2", "12345", "16/03/2005");
bilioteca.AdicionaLivro("harry potter", "autor3", "16fj5g8", "28/06/2010");
bilioteca.AdicionaLivro("senhor dos aneis", "teste", "89fg345", "06/12/2002");
bilioteca.AdicionaLivro("dom casmurro", "machado de Assis", "daw5342", "06/02/1906");

bilioteca.CadastraUsuario(1, "joao");
bilioteca.CadastraUsuario(2, "pedro");
bilioteca.CadastraUsuario(3, "paulo");
bilioteca.CadastraUsuario(4, "marcos");
bilioteca.CadastraUsuario(5, "emilia");

bilioteca.GetLivros();
Console.WriteLine();
bilioteca.GetUsuarios();

Usuario usuario = new Usuario(4, "marcos");
Livro livro = new Livro("dom casmurro", "machado de Assis", "daw5342", "06/02/1906");

Emprestimo emprestimo = new Emprestimo(usuario, "27/09/2024", livro);
Console.WriteLine(emprestimo);


Console.WriteLine();
bilioteca.Emprestimo("joao", 1, "27/09/2024", "dom quixote", "12fd4x3");
