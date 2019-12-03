namespace data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Context")
        {
        }

        public virtual DbSet<abscence> abscences { get; set; }
        public virtual DbSet<competence> competences { get; set; }
        public virtual DbSet<employe> employes { get; set; }
        public virtual DbSet<evaluation> evaluations { get; set; }
        public virtual DbSet<fraimission> fraimissions { get; set; }
        public virtual DbSet<mission> missions { get; set; }
        public virtual DbSet<niveau> niveaux { get; set; }
        public virtual DbSet<projet> projets { get; set; }
        public virtual DbSet<tache> taches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<competence>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .HasMany(e => e.niveaux)
                .WithRequired(e => e.competence)
                .HasForeignKey(e => e.idCompetence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.evaluations)
                .WithOptional(e => e.employe)
                .HasForeignKey(e => e.idEmploye);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.taches)
                .WithOptional(e => e.employe)
                .HasForeignKey(e => e.employe_id);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.niveaux)
                .WithRequired(e => e.employe)
                .HasForeignKey(e => e.idEmploye)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.abscences)
                .WithMany(e => e.employes)
                .Map(m => m.ToTable("employe_abscence").MapLeftKey("Employe_id"));

            modelBuilder.Entity<employe>()
                .HasMany(e => e.missions)
                .WithMany(e => e.employes)
                .Map(m => m.ToTable("employe_mission").MapLeftKey("Employe_id").MapRightKey("missions_idM"));

            modelBuilder.Entity<employe>()
                .HasMany(e => e.missions1)
                .WithMany(e => e.employes1)
                .Map(m => m.ToTable("mission_employe").MapLeftKey("Employees_id").MapRightKey("Mission_idM"));

            modelBuilder.Entity<fraimission>()
                .Property(e => e.descriptionFM)
                .IsUnicode(false);

            modelBuilder.Entity<fraimission>()
                .Property(e => e.necessite)
                .IsUnicode(false);

            modelBuilder.Entity<fraimission>()
                .Property(e => e.nomFM)
                .IsUnicode(false);

            modelBuilder.Entity<fraimission>()
                .Property(e => e.typeFM)
                .IsUnicode(false);

            modelBuilder.Entity<fraimission>()
                .Property(e => e.urlFM)
                .IsUnicode(false);

            modelBuilder.Entity<fraimission>()
                .HasMany(e => e.missions)
                .WithMany(e => e.fraimissions)
                .Map(m => m.ToTable("mission_fraimission").MapLeftKey("listConso_idR").MapRightKey("Mission_idM"));

            modelBuilder.Entity<mission>()
                .Property(e => e.Duree)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.descriptionM)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.nomM)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.statut)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.typeM)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.zoneM)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .HasMany(e => e.taches)
                .WithOptional(e => e.projet)
                .HasForeignKey(e => e.projet_id);

            modelBuilder.Entity<tache>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<tache>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
