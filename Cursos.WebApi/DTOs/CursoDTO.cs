using System.ComponentModel.DataAnnotations;

namespace Cursos.WebApi.DTOs
{
    public class CursoDTO
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Professor { get; set; }

        public int CargaHoraria { get; set; }
        public string Descricao { get; set; }
        public string PalavraPesquisada { get; set; }
        public DateTime Data { get; set; }
    }
}
