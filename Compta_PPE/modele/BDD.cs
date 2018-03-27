namespace Compta_PPE
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BDD : DbContext
    {
        public BDD()
            : base("name=BDD")
        {
        }

        public virtual DbSet<Joueurs> Joueurs { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Joueurs>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<Joueurs>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Joueurs>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<Joueurs>()
                .Property(e => e.pseudo)
                .IsUnicode(false);

            modelBuilder.Entity<Joueurs>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Joueurs)
                .HasForeignKey(e => e.joueur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.identifiant)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.mdp)
                .IsUnicode(false);
        }
    }
}
