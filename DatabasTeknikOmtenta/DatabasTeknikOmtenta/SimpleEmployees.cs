namespace DatabasTeknikOmtenta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SimpleEmployees
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Title { get; set; }
    }
}
