using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FORM.Models
{
    public partial class form : DbContext
    {
        public form()
            : base("name=form")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FatherName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.MotherName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.dob)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Department)
                .IsUnicode(false);
        }
    }
}
