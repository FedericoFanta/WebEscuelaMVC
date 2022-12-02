using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebEscuelaMVCc.Models;

namespace WebEscuelaMVCc.Data
{
    public class AulaDbContext : DbContext
    {
        public AulaDbContext() : base("keyAulasDB") { }

        public DbSet<Aula> Aulas { get; set; }
    }
}