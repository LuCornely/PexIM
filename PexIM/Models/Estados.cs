using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PexIM.Models
{
    public class Estados
    {
        [Key]
        public int CodEstado { get; set; }
        public string NomeEstado { get; set; }
        public string SiglaEstado { get; set; }
    }
}
