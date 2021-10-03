using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Forms;
using WebAPI_01.Models;
using WebAPI_01.Repository;

namespace WebAPI_01.Controllers
{
    [Route("api/[Controller]")]
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

        [HttpGet("{id}", Name = "GetUsuario")]
        public IActionResult GetByID(long id)
        {
            var Usuario = UsuarioRepo.GetUsuario(id);
            if (Usuario == null)
                return NotFound();
            else
                return new ObjectResult(Usuario);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest();

            UsuarioRepo.AdicionarUsuario(usuario);

            return CreatedAtRoute("GetUsuario", new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Usuario usuario)
        {
            if (usuario == null || usuario.Id != id)
                return BadRequest();

            var UserAx = UsuarioRepo.GetUsuario(id);

            if (UserAx == null)
                return NotFound();

            UserAx.Nome = usuario.Nome;
            UserAx.Senha = usuario.Senha;
            UserAx.Email = usuario.Email;

            UsuarioRepo.AtualizarUsuario(UserAx);
            return new NoContentResult();
        }

        //[HttpDelete("{id}")]
        //public IActionResult ddddddddddddddddd(long id)
        //{
        //    var UserAx = UsuarioRepo.GetUsuario(id);

        //    if (UserAx == null)
        //        return NotFound();

        //    UsuarioRepo.RemoverUsuario(id);
        //    return new NoContentResult();
        //}
    }
}
