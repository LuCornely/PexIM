using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PexIM.Models
{
    public class Imoveis
    {
        [Key]
        public int CodImovel { get; set; }

        public Nullable<int> CodEstado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Tipo { get; set; }

        public int Dormitorios { get; set; }
        public int Garagem { get; set; }
        public bool Churrasqueira { get; set; }
        public int Banheiro { get; set; }
        public int Suite { get; set; }
        public decimal Valor { get; set; }
        public decimal AreaPrivativa { get; set; }
        public decimal AreaTotal { get; set; }
    }
}
