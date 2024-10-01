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

	public Usuario(int id, string name, string email)
	{
		Id = id;
		Name = name;
		Email = email;
	}

	public void GetListEmprestimos()
	{
        Console.WriteLine("Emprestimos: ");
        Console.WriteLine("-----------------");
		foreach(var emprestimo in Emprestimos)
		{
            Console.WriteLine(" | " + emprestimo);
            Console.WriteLine("-----------------");
        }
            
    }

    public override string ToString()
    {
		return Id + ", "
			+ Name + ", "
			+ Email;
    }

}