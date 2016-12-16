namespace DatabasTeknikOmtenta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerContactNameChanges
    {
        [Key]
        public int ContactNameChangeID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ContactID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string OldName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string NewName { get; set; }

        public DateTime ChangedDate { get; set; }

        public int UserId { get; set; }
    }
}
