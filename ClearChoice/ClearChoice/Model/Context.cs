using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClearChoice.Model
{
    public class Context:DbContext
    {

        public Context():base("ClearChoice")
        {

        }

            public DbSet<Pessoa> Pessoas { get; set; }
    }
}