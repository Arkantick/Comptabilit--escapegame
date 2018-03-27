namespace Compta_PPE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("escapegame.Personnel")]
    public partial class Personnel
    {
        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string identifiant { get; set; }

        [Required]
        [StringLength(45)]
        public string mdp { get; set; }

        public int accreditation { get; set; }

        public int site { get; set; }
    }
}
