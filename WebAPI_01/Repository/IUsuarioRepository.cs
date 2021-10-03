using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_01.Models;

namespace WebAPI_01.Repository
{
    public interface IUsuarioRepository
    {
        Usuario GetUsuario(long id);
        IEnumerable<Usuario> RetornarTodos();
        void AdicionarUsuario(Usuario user);
        void RemoverUsuario(long id);
        void AtualizarUsuario(Usuario user);        
    }
}
