using System.Collections.Generic;
using System.Linq;
using Cursos.Domain.Models;
using Cursos.Infra.Context;
namespace Cursos.Infra.Repositories
{
    public class CursosRepository : Repository<Cursos>
    {
        public CursosRepository(AppDbContext context) : base(context)
        {}

        public override Cursos GetById(int id)
        {
            var query = _context.Set<Cursos>().Where(e => e.Id == id);

            if(query.Any())
                return query.First();

            return null;
        }

        public override IEnumerable<Cursos> GetAll()
        {
            var query = _context.Set<Cursos>();

            return query.Any() ? query.ToList() : new List<Cursos>();
        }
    }
}