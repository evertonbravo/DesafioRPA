using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.Domain.Models
{
    public class Curso : BaseEntity
    {
        public Curso(string titulo, string professor, string cargaHoraria, string descricao,string palavraPesquisada, DateTime data)
        {
            ValidaCampos(titulo, professor, descricao);
            Titulo = titulo;
            Professor = professor;
            CargaHoraria = cargaHoraria;
            Descricao = descricao;
            PalavraPesquisada = palavraPesquisada;
            Data = data;
        }

        public string Titulo { get; private set; }
        public string Professor { get; private set; }
        public string CargaHoraria { get; private set; }
        public string Descricao { get; private set; }
        public string PalavraPesquisada { get; private set; }
        public DateTime Data { get; private set; }

        public void Update(string titulo, string professor, string cargaHoraria, string descricao)
        {
            ValidaCampos(titulo, professor, descricao);
        }
        private void ValidaCampos(string titulo, string professor,string descricao)
        {
            if (string.IsNullOrEmpty(titulo))
                throw new InvalidOperationException("O Titulo esta vazio ou nulo");


            if (string.IsNullOrEmpty(professor))
                throw new InvalidOperationException("O Professor esta vazio ou nulo");

            if (string.IsNullOrEmpty(descricao))
                throw new InvalidOperationException("A descrição esta vazia ou nulo");
        }
    }
}
