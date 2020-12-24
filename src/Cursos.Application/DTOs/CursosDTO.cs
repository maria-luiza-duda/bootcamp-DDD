using System.ComponentModel.DataAnnotations;

namespace Cursos.Web.DTOs
{
    public class CursosDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Linguagem{ get; set; }
    }
}