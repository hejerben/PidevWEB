namespace data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.mission")]
    public partial class mission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mission()
        {
            employes = new HashSet<employe>();
            employes1 = new HashSet<employe>();
            fraimissions = new HashSet<fraimission>();
        }

        [Key]
        public int idM { get; set; }

        [StringLength(255)]
        public string Duree { get; set; }

        public float consommation { get; set; }

        public DateTime? dateDebutM { get; set; }

        [StringLength(255)]
        public string descriptionM { get; set; }

        [StringLength(255)]
        public string nomM { get; set; }

        public float plafond { get; set; }

        [StringLength(255)]
        public string statut { get; set; }

        [StringLength(255)]
        public string typeM { get; set; }

        [StringLength(255)]
        public string zoneM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employe> employes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employe> employes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fraimission> fraimissions { get; set; }
    }
}
