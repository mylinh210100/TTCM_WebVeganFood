namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypePermission")]
    public partial class TypePermission
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string IdPermission { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public virtual Permission Permission { get; set; }

        public virtual Type Type { get; set; }
    }
}
