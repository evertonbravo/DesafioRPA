using Cursos.Domain.Interface;
using Cursos.Domain.Models;
using Cursos.WebApi.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Cursos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : Controller
    {
        private readonly CursoService _cursoService;
        private readonly IRepository<Curso> _cursoRepository;

        public CursoController(CursoService cursoService,
            IRepository<Curso> cursoRepository)
        {
            _cursoService = cursoService;
            _cursoRepository = cursoRepository;
        }

        [HttpPost]
        public ActionResult<Curso> Post(Curso curso)
        {
                _cursoRepository.Save(curso);

                return Ok(new
                {
                    mensagem = $"Curso {curso.Titulo} cadastrado com sucesso"
                });
        }

    }
}
