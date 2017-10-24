using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MeuPrimeiroBackend.Models.Contexto
{
    public class MeuContexto:DbContext
    {

        public MeuContexto():base("strConn")
        {

        }

        public System.Data.Entity.DbSet<MeuPrimeiroBackend.Models.TipoItem> TipoItems { get; set; }

        public System.Data.Entity.DbSet<MeuPrimeiroBackend.Models.Item> Items { get; set; }
    }
}