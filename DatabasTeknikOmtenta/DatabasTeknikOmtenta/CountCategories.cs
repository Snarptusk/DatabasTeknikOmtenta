namespace DatabasTeknikOmtenta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CountCategories
    {
        [Key]
        [StringLength(15)]
        public string CategoryName { get; set; }

        public int? Categories { get; set; }
    }
}
