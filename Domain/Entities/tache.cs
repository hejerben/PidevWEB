namespace data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.tache")]
    public partial class tache
    {
        public int id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? state { get; set; }

        public int? employe_id { get; set; }

        public int? projet_id { get; set; }

        public virtual employe employe { get; set; }

        public virtual projet projet { get; set; }
    }
}
