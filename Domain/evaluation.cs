namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hejer.evaluation")]
    public partial class evaluation
    {
        public int id { get; set; }

        public int? Eval { get; set; }
    }
}