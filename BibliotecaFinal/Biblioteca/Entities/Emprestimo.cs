using System;
using System.Collections.Generic;
using System.Globalization;

namespace Biblioteca.Entities;

class Emprestimo
{
	public Usuario Usuario { get; set; }
	public DateTime DataEmprestimo { get; set; }
	public DateTime DataDevolucao { get; set; }
	public bool Devolvido = false;
	public Livro Livro { get; set; }
	public double MultaAtraso { get; set; } 
	
	public Emprestimo(Usuario usuario, DateTime dataEmprestimo, Livro livro) 
	{
		this.Usuario = usuario;
		DataEmprestimo = dataEmprestimo;
		this.Livro = livro;
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

    public override string ToString()
    {
		return Usuario.Name + ", "
			+ DataEmprestimo.ToLongDateString() + ", "
			+ Livro.NomeLivro;
    }
}