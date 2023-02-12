using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FinalPI.Models;

namespace FinalPI.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("ledzeppelin") { }
        public DbSet<Publicacao> Publicacoes { get; set; }
    }
}