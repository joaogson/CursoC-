using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1.Entities
{
    class Bilioteca
    {
        List<Livro> Livros = new List<Livro>();
        List<Usuario> Usuarios = new List<Usuario>();

        public Bilioteca()
        {

        }

        public void AdicionaLivro(string nomeLivro, string nomeAutor, string issn, string anoPublicacao)
        {
            Livro livro = new Livro(nomeLivro, nomeAutor, issn, anoPublicacao);
            Livros.Add(livro);
        }

        public void RemoveLivro(string nomeLivro, string issnLivro)
        {
            Livros.Remove(Livros.FirstOrDefault(x => x.ISSN == issnLivro && x.NomeLivro == nomeLivro));
        }

        public void CadastraUsuario(int id, string nome)
        {
            Usuario usuario = new Usuario(id, nome);
            Usuarios.Add(usuario);
        }

        public void RemoveUsuario(string nome, int id)
        {
            Usuarios.Remove(Usuarios.FirstOrDefault(x => x.Id == id && x.Nome == nome));
        }
        public void Emprestimo(string nomeUsuario, int idUsuario, string dataEmprestimo, string nomeLivro, string issn)
        {
            Usuario usuario = Usuarios.FirstOrDefault(x => x.Nome == nomeUsuario && x.Id == idUsuario);
            Livro livro =  Livros.FirstOrDefault(y => y.NomeLivro == nomeLivro && y.ISSN == issn);
            

            if (usuario == null)
                Console.WriteLine("Usuario inexistente");

            if (livro == null)
                Console.WriteLine("Livro não existe");

            Emprestimo emprestimo = new Emprestimo(usuario, dataEmprestimo, livro);

           Console.WriteLine(emprestimo);

            //Não consegui adicionar o emprestimo a uma lista na classe usuario
            //usuario.Emprestimos.Add(emprestimo);
        }
        public void GetUsuarios()
        {
            foreach(var usuario in Usuarios)
                Console.WriteLine(usuario);
        }   
        public void GetLivros()
        {
            foreach(var livro in Livros)
                Console.WriteLine(livro);
        }

    }
}
