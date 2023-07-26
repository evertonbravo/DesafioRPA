using Cursos.Domain.Interface;

namespace Cursos.Domain.Models
{   
    public class CursoService
    {
        private readonly IRepository<Curso> _cursoRepository;

        public CursoService(IRepository<Curso> cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public void Create(int id, string titulo, string professor, string cargaHoraria, string descricao, string palavraPesquisada, DateTime data)
        {
            var curso = _cursoRepository.GetById(id);

            if (curso == null)
            {
                curso = new Curso(titulo, professor, cargaHoraria, descricao, palavraPesquisada,data);
                _cursoRepository.Save(curso);
            }
            else
                curso.Update(titulo, professor, cargaHoraria, descricao);
        }
    }
}
