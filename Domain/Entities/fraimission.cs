namespace data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.fraimission")]
    public partial class fraimission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fraimission()
        {
            missions = new HashSet<mission>();
        }

        [Key]
        public int idR { get; set; }

        public DateTime? dateFM { get; set; }

        public float? depense { get; set; }

        [StringLength(255)]
        public string descriptionFM { get; set; }

        [Column(TypeName = "tinyblob")]
        public byte[] mission { get; set; }

        [StringLength(255)]
        public string necessite { get; set; }

        [StringLength(255)]
        public string nomFM { get; set; }

        [StringLength(255)]
        public string typeFM { get; set; }

        [StringLength(255)]
        public string urlFM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mission> missions { get; set; }
    }
}
