using System;

namespace Biblioteca.Entities;

class Aluno : Usuario
{
	public int Matricula { get; set; }
	public string Sala { get; set; }
	public int LimiteLivro { get; set; }

	public Aluno(int id, string name, int matricula, string sala, int limiteLivro) : base(id, name)
	{
		Matricula = matricula;
		Sala = sala;
		LimiteLivro = limiteLivro;
	}
}