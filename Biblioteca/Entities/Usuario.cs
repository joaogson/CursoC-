using System;
using System.Collections.Generic;
using System.Linq;


namespace Biblioteca.Entities;

class Usuario
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Email { get; set; }
	public List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>(); 

	public void Emprestimo(Usuario usuario, string dataEmprestimo, Livro livro)
	{
		
		Emprestimo emprestimo = new Emprestimo(usuario, dataEmprestimo, livro);
		//emprestimo.Devolvido == true ? livro.Disponivel = true : livro.Disponivel = false;
		if (emprestimo.Devolvido == true)
			livro.Disponivel = true;
		else
			livro.Disponivel = false;
	}
}