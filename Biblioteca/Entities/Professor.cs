using System;
using System.Collections.Generic;

namespace Biblioteca.Entities;

class Professor : Usuario
{
	public double Salario { get; set; }
	
	public Professor(int id, string name, double salario) : base(id, name)
	{
		Salario = salario;
	}

}