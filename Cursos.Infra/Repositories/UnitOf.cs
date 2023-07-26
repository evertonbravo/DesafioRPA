using Cursos.Domain.Interface;
using Cursos.Domain.Models;
using Cursos.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.Infra.Repositories
{
    public class UnitOf : IUnitOf
    {
        private readonly AppDbContext _context;

        public UnitOf(AppDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}