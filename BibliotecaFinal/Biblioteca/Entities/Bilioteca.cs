using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Biblioteca.Entities;

class Bibliioteca
{
	public List<Livro> livros = new List<Livro>();
	public List<Usuario> Usuarios = new List<Usuario>();
	public void AdicionaLivro(string nomeLivro, string nomeAutor, string issn, string AnoPublicacao)
	{
		Livro livro = new Livro(nomeLivro, nomeAutor, issn, AnoPublicacao);
		livros.Add(livro);
	}
	public void RemoveLivro(string nomeLivro)
	{
		livros.Remove(livros.FirstOrDefault(x => x.NomeLivro == nomeLivro));
	}
	public void CadastroUsuario(int id, string name, string email)
	{
		Usuario usuario = new Usuario(id, name, email);
		Usuarios.Add(usuario);
	}
	public void RemoveUsuario(int id, string nome)
	{
		Usuarios.Remove(Usuarios.FirstOrDefault(x => x.Name == nome && x.Id == id));
	}
	
	public void Emprestimo(string nomeUsuario, int idUsuario, DateTime dataEmprestimo, string nomeLivro)
	{
		
		Usuario usuario = (Usuarios.FirstOrDefault(x => x.Name == (nomeUsuario) && x.Id == (idUsuario)));

        Livro livro = livros.FirstOrDefault(y => y.NomeLivro == (nomeLivro));

		if (livro.Disponivel)
		{
            Emprestimo emprestimo = new Emprestimo(usuario, dataEmprestimo, livro);

            usuario.Emprestimos.Add(emprestimo);

            emprestimo.Livro.Disponivel = false;

            Console.WriteLine(emprestimo);
        }
		else
		{

			Emprestimo verificaLivro = usuario.Emprestimos.FirstOrDefault(x => x.Livro.NomeLivro == nomeLivro);
			
            if (verificaLivro != null)
                Console.WriteLine("O usuario está com esse livro emprestado");
			else
            Console.WriteLine("Livro não disponivel");
		}

		
		Console.ReadKey();

    }
	public void FinalizaEmprestimo(Emprestimo emprestimo)
	{
        Console.WriteLine("Houve atraso? (s/n)");
		char ch = char.Parse(Console.ReadLine());
		if(ch == 's')
		{
            Console.WriteLine("Informe quantos dias: ");
			int dias = int.Parse(Console.ReadLine());
            Console.WriteLine("O usuario deverá pagar: " + "R$ " + emprestimo.CalculoMulta(dias));
        }
		
		emprestimo.Livro.Disponivel = true;
		emprestimo.Usuario.Emprestimos.Remove(emprestimo);
        Console.WriteLine("Emprestimo Finalizado!");
	}
	public void GetListLivros()
	{
		
		Console.WriteLine("Lista de livros: ");
        Console.WriteLine("-----------------");

        foreach (var livro in livros)
		{
			Console.Write(" | Nome do livro: " + livro.NomeLivro);
            Console.Write(" | Nome do Autor: " + livro.NomeAutor);
            Console.Write(" | Ano de publicação: " + livro.AnoPublicacao.ToString("dd/MM/yyyy"));
            Console.WriteLine(" | Disponivel: " + livro.Disponivel.ToString());
            Console.WriteLine("-----------------");
        }
        
    }
	public void GetListUsuarios()
	{
        Console.WriteLine("Lista de Usuarios: ");
        Console.WriteLine("-------------------");

        foreach (var user in Usuarios)
		{
            Console.Write(" | Id: " + user.Id);
            Console.Write(" | Nome: " + user.Name);
            Console.WriteLine(" | Email: " + user.Email);
            Console.WriteLine("-------------------");

        }
            

	}
}