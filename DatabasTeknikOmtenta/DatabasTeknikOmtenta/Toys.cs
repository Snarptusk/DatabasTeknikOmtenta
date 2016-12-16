namespace DatabasTeknikOmtenta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Toys
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToyID { get; set; }

        [StringLength(40)]
        public string Description { get; set; }

        public bool? MadeBySanta { get; set; }
    }
}
