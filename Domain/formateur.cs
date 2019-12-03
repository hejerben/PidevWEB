namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hejer.formateur")]
    public partial class formateur
    {
        public int id { get; set; }

        [StringLength(255)]
        public string disponibilite { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int number { get; set; }

        [StringLength(255)]
        public string specialite { get; set; }
    }
}
