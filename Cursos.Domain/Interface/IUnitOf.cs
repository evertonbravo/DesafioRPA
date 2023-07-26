using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.Domain.Interface
{
   
    public interface IUnitOf
    {
        Task Commit();
    }
}
