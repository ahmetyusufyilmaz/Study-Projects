using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace School_DbFirst.Models
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=SchoolContext2")
        {
        }

        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
        public virtual DbSet<Ogretmen> Ogretmen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogretmen>()
                .HasMany(e => e.Ogrenci)
                .WithRequired(e => e.Ogretmen)
                .WillCascadeOnDelete(false);
        }
    }
}
