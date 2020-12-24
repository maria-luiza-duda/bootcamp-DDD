using System.Collections.Generic;
namespace Cursos.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
         TEntity GetById(int id);
         IEnumerable<TEntity> GetAll();
         void Save(TEntity entity);
    }
}