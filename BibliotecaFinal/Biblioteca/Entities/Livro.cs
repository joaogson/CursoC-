using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Biblioteca.Entities;

class Livro
{
	public string NomeLivro { get; set; }
	public string NomeAutor { get; set; }
	public string ISSN { get; set; }
	public bool Disponivel { get; set; }
	public DateTime AnoPublicacao { get; set; }	
	
	public Livro(string nomeLivro, string nomeAutor, string issn, string anoPublicacao)
	{
		NomeLivro = nomeLivro;
		NomeAutor = nomeAutor;
		ISSN = issn;
		AnoPublicacao = DateTime.Parse(anoPublicacao);
		Disponivel = true;
	}
}