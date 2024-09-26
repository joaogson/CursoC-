using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Entities;

class Bibliioteca
{
	List<Livro> livros = new List<Livro>();
	public void AdicionaLivro(string nomeLivro, string nomeAutor, string issn, string AnoPublicacao)
	{
		Livro livro = new Livro(nomeLivro, nomeAutor, issn, AnoPublicacao);
	}
	public void RemoveLivro()
	{
		
	}
	public void CadastroUsuario()
	{
		
	}
	public void RemoveUsuario()
	{
		
	}
	
}