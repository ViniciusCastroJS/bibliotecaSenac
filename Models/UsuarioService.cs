using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Models
{
    public class UsuarioService 
    {
        public void Inserir(Usuario e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Add(e);
                bc.SaveChanges();
            }
        }

        public Usuario ListarUsuario(string Login)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario User = bc.Usuarios.Where(u => u.Login == Login).First();
                
                return User;
            }
        }

        public List<Usuario> ListarTodos(string filtro = null)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Usuario> query = bc.Usuarios;
                
                //ordenação padrão
                return query.ToList();
            }
        }

        public void Atualizar(Usuario e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuarios.Find(e.Id);
                usuario.Id = e.Id;
                usuario.Login = e.Login;
                usuario.Senha = e.Senha;
                usuario.NomeUsuario = e.NomeUsuario;

                bc.SaveChanges();
            }
        }

        public Usuario ObterPorId(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Find(id);
            }
        }
        public Usuario ObterPorLogin(string login)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Where(u => u.Login == login).First();
            }
        }


    }
}