using Cursos.Domain.Interface;
using Cursos.Domain.Models;
using Cursos.Infra.Context;
using Cursos.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cursos.Aplicaton.DI
{
    
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conection));

            services.AddScoped(typeof(IRepository<Curso>), typeof(CursoRepository));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(CursoService));
            services.AddScoped(typeof(IUnitOf), typeof(UnitOf));
        }
    }
}
