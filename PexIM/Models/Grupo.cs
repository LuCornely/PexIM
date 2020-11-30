using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PexIM.Models
{
    public class Grupo
    {
        [Key]
        public int CodGrupo { get; set; }
        public string Nome { get; set; }
        public bool Excluido { get; set; }

    }
}
