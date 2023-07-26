using Cursos.Domain.Models;
using Cursos.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.Infra.Repositories
{   
    public class CursoRepository : Repository<Curso>
    {
        public CursoRepository(AppDbContext context) : base(context)
        { }

        public override Curso GetById(int id)
        {
            var query = _context.Set<Curso>().Where(e => e.Id == id);

            if (query.Any())
                return query.First();

            return null;
        }

       

        public override IEnumerable<Curso> GetAll()
        {
            var query = _context.Set<Curso>();

            return query.Any() ? query.ToList() : new List<Curso>();
        }
    }
}
