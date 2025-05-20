using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace PRACTICA_AEAE_3.Models
{
    public class BDFACTURACION : DbContext
    {
        public DbSet<TBLCLIENTES> TBLCLIENTE { get; set; }
        public DbSet<TBLPRODUCTO> TBLPRODUCTO { get; set; }
        public DbSet<TBLCATEGORIA> TBLCATEGORIA { get; set; }
    }
}