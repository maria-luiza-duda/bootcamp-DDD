using System.Collections.Generic;
using System.Linq;
using Cursos.Domain.Interfaces;
using Cursos.Domain.Models;
using Cursos.Web.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Cursos.Web.Controllers
{
     [Route("api/[controller]")]
    public class CursosController : Controller
    {
        private readonly CursosService _cursosService;
        private readonly IRepository<Cursos> _cursosRepository;

        public CursosController(CursosService cursosService,
            IRepository<Cursos> cursosRepository)
        {
            _cursosService = cursosService;
            _cursosRepository = cursosRepository;
        }

         [HttpGet]
         public IEnumerable<CursosDTO> GetCursos()
         {
             var cursos = _cursosRepository.GetAll();
            
            var resultado = cursos.Select(c => new CursosDTO{ Id = c.Id, Nome = c.Nome, Linguagem= c.Linguagem });

            return resultado;
         }


         [HttpGet("{id}")]
         public  ActionResult<Cursos> GetCursos(int id)
         {
             var curso =  _cursosRepository.GetById(id);
             if (curso == null)
             {
                 return NotFound(new { message = $"Curso de id={id} não encontrado" });
             }
             return curso;
         }
    }
}