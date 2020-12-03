using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PexIM.Models
{
    public class Usuarios
    {
        [Key]
        public int CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public bool Ativo { get; set; }
        public int CodGrupo { get; set; }
        public bool Download { get; set; }
        public bool Upload { get; set; }
        public bool Excluido { get; set; }
    }
}
