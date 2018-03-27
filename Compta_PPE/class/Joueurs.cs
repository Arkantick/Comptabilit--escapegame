namespace Compta_PPE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("escapegame.Joueurs")]
    public partial class Joueurs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Joueurs()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string nom { get; set; }

        [Required]
        [StringLength(45)]
        public string prenom { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateNaissance { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime dateInscription { get; set; }

        public float credit { get; set; }

        [Required]
        [StringLength(100)]
        public string mail { get; set; }

        [Required]
        [StringLength(45)]
        public string pseudo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
