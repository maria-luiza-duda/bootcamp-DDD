using System;
namespace Cursos.Domain.Models
{
    public class Curso : BaseEntity
    {
        public Curso(string nome, string linguagem)
        {
            ValidaCategoria(nome, linguagem);
            Nome = nome;
            Linguagem = linguagem;
        }
        public string Nome { get; private set; }
        public string linguagem{ get; private set; }
        public void Update(string nome, string linguagem)
        {
             ValidaCategoria(nome, linguagem);
        }

        private void ValidaCategoria(string nome,string linguagem)
        {
            if(string.IsNullOrEmpty(nome))
               throw new InvalidOperationException("O nome é inválido");
            if(string.IsNullOrEmpty(linguagem))
               throw new InvalidOperationException("A linguagem é inválida");
        }
    }
}