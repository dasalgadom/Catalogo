using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Catalogo.Entities.Dtos
{
    public class CategoriaDeleteDto
    {
        public int Id { get; set; }

        public bool Estado { get; set; }
    }
}
