using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PexIM.Models
{
    public class ImobiliariasEstados
    {
        [Key]
        public int CodImobiliariaEstado { get; set; }
        public Nullable<int> CodImobiliaria { get; set; }
        public Nullable<int> CodEstado { get; set; }
    }
}
