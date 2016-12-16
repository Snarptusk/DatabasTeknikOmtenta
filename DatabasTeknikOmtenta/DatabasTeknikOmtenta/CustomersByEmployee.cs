namespace DatabasTeknikOmtenta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomersByEmployee")]
    public partial class CustomersByEmployee
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(30)]
        public string ContactName { get; set; }
    }
}
