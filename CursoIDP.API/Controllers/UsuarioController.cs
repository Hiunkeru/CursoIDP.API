using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoIDP.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CursoIDP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario
            {
                Email = "usuario@gmail.com",
                Nombre = "Alejandro",
                Telefono = "111111111"
            });

            return usuarios;
        }
    }
}
