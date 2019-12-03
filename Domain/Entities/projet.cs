namespace data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.projet")]
    public partial class projet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public projet()
        {
            taches = new HashSet<tache>();
        }

        public int id { get; set; }

        public float budget { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public DateTime? start_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tache> taches { get; set; }
    }
}
