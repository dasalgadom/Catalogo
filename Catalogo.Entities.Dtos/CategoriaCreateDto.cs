using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Catalogo.Entities.Dtos
{
    public class CategoriaCreateDto
    {

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

    }
}
