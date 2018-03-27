namespace Compta_PPE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("escapegame.Transactions")]
    public partial class Transactions
    {
        public int id { get; set; }

        public int joueur { get; set; }

        public int valeur { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime date { get; set; }

        public virtual Joueurs Joueurs { get; set; }
    }
}
