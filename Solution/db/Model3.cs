using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyLastCoursWorkTry.db
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<studentslogpass> studentslogpass { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<studentslogpass>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<studentslogpass>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
