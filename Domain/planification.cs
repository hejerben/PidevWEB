namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hejer.planification")]
    public partial class planification
    {
        public int id { get; set; }

        [StringLength(255)]
        public string dateDebut { get; set; }

        [StringLength(255)]
        public string dateFin { get; set; }

        public int numberP { get; set; }

        public int? idFormation { get; set; }
    }
}
