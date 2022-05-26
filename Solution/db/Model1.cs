using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyLastCoursWorkTry.db
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model17")
        {
        }

        public virtual DbSet<StudentDB> StudentDB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDB>()
                .Property(e => e.SecondName)
                .IsUnicode(false);

            modelBuilder.Entity<StudentDB>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<StudentDB>()
                .Property(e => e.ThirdName)
                .IsUnicode(false);

            modelBuilder.Entity<StudentDB>()
                .Property(e => e.Grade)
                .IsUnicode(false);
        }
    }
}
