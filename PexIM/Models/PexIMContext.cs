using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PexIM.Models
{
    public class PexIMContext: DbContext
    {
        public PexIMContext(DbContextOptions<PexIMContext> options)
          : base(options)
        {
        }

        public DbSet<Estados> Estados { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Imobiliarias> Imobiliarias { get; set; }
        public DbSet<ImobiliariasEstados> ImobiliariasEstados { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<UsuariosEstados> UsuariosEstados { get; set; }

        public DbSet<Imoveis> Imoveis { get; set; }
    }
}
