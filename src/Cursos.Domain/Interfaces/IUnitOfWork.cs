using System.Threading.Tasks;
namespace Cursos.Domain.Interfaces
{
    public interface IUnitOfWork
    {
          Task Commit();
    }
}