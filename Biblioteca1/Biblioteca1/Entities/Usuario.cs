using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1.Entities
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Emprestimo> Emprestimos { get; set; }
        public Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public override string ToString()
        {
            return Nome + ", "
                + Id;
        }

        public void GetEmprestimos()
        {
            foreach (var emprestimo in Emprestimos)
            {
                Console.WriteLine(emprestimo);
            }
        }
    }
}
