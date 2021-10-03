using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI_01.Models;
using WebAPI_01.Repository;

namespace WebAPI_01.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository UsuarioRepo;

        public UsuarioController(IUsuarioRepository _UsuarioRepo)
        {
            this.UsuarioRepo = _UsuarioRepo;
        }

        [HttpGet]
        public IEnumerable<Usuario> RetornarTodos()
        {
            return UsuarioRepo.RetornarTodos();
        }
        [HttpGet("{id}", Name ="GetUsuario")]
        public IActionResult GetByID(long id)
        {
            var Usuario = UsuarioRepo.GetUsuario(id);
            if (Usuario == null)
                return NotFound();
            else
                return new ObjectResult(Usuario);
        }
        [HttpPut]
        public void AdicionarUsuario(Usuario user)
        {
            UsuarioRepo.AdicionarUsuario(user);
        }
        [HttpPost]
        public void AtualizarUsuario(Usuario user)
        {
            UsuarioRepo.AtualizarUsuario(user);
        }
    }
}
