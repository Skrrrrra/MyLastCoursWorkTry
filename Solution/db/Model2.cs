using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyLastCoursWorkTry.db
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<userlogpass> userlogpass { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<userlogpass>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<userlogpass>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
