using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Entities;

class Bibliioteca
{
	public List<Livro> livros = new List<Livro>();
	public void AdicionaLivro(string nomeLivro, string nomeAutor, string issn, string AnoPublicacao)
	{
		Livro livro = new Livro(nomeLivro, nomeAutor, issn, AnoPublicacao);
		livros.Add(livro);
	}
	public void RemoveLivro(string nomeLivro)
	{
		livros.Remove(livros.FirstOrDefault(x => x.NomeLivro == nomeLivro));
	}
	public void CadastroUsuario()
	{
			
	}
	public void RemoveUsuario()
	{
		
	}
	
	public void Emprestimo(Usuario usuario, string dataEmprestimo, Livro livro)
	{
		
		Emprestimo emprestimo = new Emprestimo(usuario, dataEmprestimo, livro);
		//emprestimo.Devolvido == true ? livro.Disponivel = true : livro.Disponivel = false;
		if (emprestimo.Devolvido == true)
			livro.Disponivel = true;
		else
			livro.Disponivel = false;

		usuario.Emprestimos.Add(emprestimo);
		Console.WriteLine(emprestimo);
	}
	
	public void GetListLivros()
	{
		Console.WriteLine("------");
		Console.WriteLine("Lista de livros: ");
		foreach(var livro in livros)
		{
			Console.WriteLine(livro.NomeLivro);
		}
		Console.WriteLine("------");
	}
	
}