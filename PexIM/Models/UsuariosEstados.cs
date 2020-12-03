using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PexIM.Models
{
    public class UsuariosEstados
    {
        [Key]
        public int CodUsuarioEstado { get; set; }
        public Nullable<int> CodUsuario { get; set; }
        public Nullable<int> CodEstado { get; set; }
        public bool Excluido { get; set; }
    }
}
