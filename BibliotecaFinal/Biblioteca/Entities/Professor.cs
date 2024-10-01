using System;
using System.Collections.Generic;

namespace Biblioteca.Entities;

class Professor : Usuario
{
	public double Salario { get; set; }
	
	public Professor(int id, string name, string email, double salario) : base(id, name, email)
	{
		Salario = salario;
	}

}