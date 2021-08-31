using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos
{
    public class CreateFilmeDto
    {
        
        [Required(ErrorMessage = "O Título é de preenchimento obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Diretor é de preenchimento obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Genero deve possuir apenas 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "O Filme deve possuir no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
