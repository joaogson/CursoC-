using System;
using System.Collections.Generic;

namespace Biblioteca.Entities;

class Emprestimo
{
	public Usuario usuario { get; set; }
	public DateTime DataEmprestimo { get; set; }
	public DateTime DataDevolucao { get; set; }
	public bool Devolvido = false;
	public Livro livro { get; set; }
	public double MultaAtraso { get; set; } 
	
	public Emprestimo(Usuario usuario, string dataEmprestimo, Livro livro) 
	{
		this.usuario = usuario;
		DataEmprestimo = DateTime.Parse(dataEmprestimo);
		this.livro = livro;
	}

	public DateTime CalculoDataDevolucao()
	{
		DataDevolucao = DataEmprestimo.AddDays(21);
		return DataDevolucao;
	}
	
	public double CalculoMulta(int dias)
	{
		return MultaAtraso * dias;
	}
}