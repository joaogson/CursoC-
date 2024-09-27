using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1.Entities
{
    internal class Emprestimo
    {
        public Usuario usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Livro livro { get; set; }
        public double MultaAtraso { get; set; }

        public Emprestimo(Usuario usuario, string dataEmprestimo, Livro livro)
        {
            this.usuario = usuario;
            DataEmprestimo = DateTime.Parse(dataEmprestimo);
            this.livro = livro;
            CalculoDataDevolucao();
        }

        public void CalculoDataDevolucao()
        {
            DataDevolucao = DataEmprestimo.AddDays(21);
        }

        public double CalculoMulta(int diasAtraso)
        {
            return MultaAtraso * diasAtraso;
        }

        public override string ToString()
        {
            return "Nome: " + usuario + ", Data: "
                + DataEmprestimo.ToLongDateString() + ", Livro: "
                + livro;
        }
    }
}
