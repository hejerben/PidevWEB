namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<employer> employer { get; set; }
        public virtual DbSet<evaluation> evaluation { get; set; }
        public virtual DbSet<formateur> formateur { get; set; }
        public virtual DbSet<formation> formation { get; set; }
        public virtual DbSet<planification> planification { get; set; }
        public virtual DbSet<empfor> empfor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.disponibilite)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.specialite)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.duration)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.nomFormation)
                .IsUnicode(false);

            modelBuilder.Entity<planification>()
                .Property(e => e.dateDebut)
                .IsUnicode(false);

            modelBuilder.Entity<planification>()
                .Property(e => e.dateFin)
                .IsUnicode(false);
        }
    }
}
