using Cursos.Domain.Interfaces;
namespace Cursos.Domain.Models
{
    public class CursosService
    {
        private readonly IRepository<Curso> _cursoRepository;
        public CursosService(IRepository<Curso> cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        public void Save(int id, string nome, string linguagem)
        {
            var curso = _cursoRepository.GetById(id);
            if(curso == null)
            {
                curso = new Cursos(nome, linguagem);
                _cursoRepository.Save(curso);
            }
            else
                curso.Update(nome, linguagem);
        }
    }
}