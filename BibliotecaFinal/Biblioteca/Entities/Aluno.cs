using System;

namespace Biblioteca.Entities;

class Aluno : Usuario
{
	public int Matricula { get; set; }
	public string Sala { get; set; }
	public int LimiteLivro { get; set; }

	public Aluno(int id, string name, string email, int matricula, string sala, int limiteLivro) : base(id, name, email)
	{
		Matricula = matricula;
		Sala = sala;
		LimiteLivro = limiteLivro;
	}
}