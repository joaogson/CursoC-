using System;

namespace Biblioteca.Entities;

class Aluno : Usuario
{
	public int Matricula { get; set; }
	public string Sala { get; set; }
	public int LimiteLivro { get; set; }

	public Aluno()
	{

	}
	public Aluno(int matricula, string sala, int limiteLivro)
	{
		Matricula = matricula;
		Sala = sala;
		LimiteLivro = limiteLivro;
	}
}