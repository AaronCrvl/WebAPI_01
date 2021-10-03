using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_01.Models;

namespace WebAPI_01.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext contexto;
        public UsuarioRepository(UsuarioDbContext ctx)
        {
            contexto = ctx;
        }
        public void AdicionarUsuario(Usuario user)
        {
            contexto.Add(user);
            contexto.SaveChanges();
        }

        public void AtualizarUsuario(Usuario user)
        {
            contexto.Usuarios.Update(user);
            contexto.SaveChanges();
        }

        public Usuario GetUsuario(long id)
        {
            var UserAux = contexto.Usuarios.Find(id);
            return UserAux;
        }

        public void RemoverUsuario(long id)
        {
            var UserAux = contexto.Usuarios.Find(id);
            contexto.Usuarios.Remove(UserAux);
            contexto.SaveChanges();
        }

        public IEnumerable<Usuario> RetornarTodos()
        {
            var lstUsuarios = contexto.Usuarios.ToList();
            return lstUsuarios;
        }
    }
}
