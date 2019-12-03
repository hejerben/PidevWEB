namespace data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevjee.evaluation")]
    public partial class evaluation
    {
        public int id { get; set; }

        public int? idEmploye { get; set; }

        public virtual employe employe { get; set; }
    }
}
