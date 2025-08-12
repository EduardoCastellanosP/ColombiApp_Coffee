using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colombian_Coffe.src.Modules.Login.Domain.Entities
{
    public class Usuario
    {
         public int Id { get; set; }
        public string? Nombre { get; set; } = string.Empty;
        public string? Clave { get; set; } = string.Empty;
    }
}