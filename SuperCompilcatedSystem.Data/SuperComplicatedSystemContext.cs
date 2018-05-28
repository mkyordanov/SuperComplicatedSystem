using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SuperComplicatedSystem.Models;

namespace SuperCompilcatedSystem.Data
{
    public class SuperComplicateSystemContext: DbContext
    {
        public SuperComplicateSystemContext(): base("SuperComplicateSystemContext")
        {
        }

        public virtual IDbSet<PC> PC { get; set; }
        public virtual IDbSet<Components> Components { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

    }
}
