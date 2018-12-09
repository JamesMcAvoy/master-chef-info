namespace master_chef_info_cuisine.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<ingredients> ingredients { get; set; }
        public virtual DbSet<list> list { get; set; }
        public virtual DbSet<recipes> recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ingredients>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ingredients>()
                .Property(e => e.preservation)
                .IsUnicode(false);

            modelBuilder.Entity<ingredients>()
                .HasMany(e => e.list)
                .WithRequired(e => e.ingredients)
                .HasForeignKey(e => e.id_ingredients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<recipes>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<recipes>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<recipes>()
                .HasMany(e => e.list)
                .WithRequired(e => e.recipes)
                .WillCascadeOnDelete(false);
        }
    }
}
