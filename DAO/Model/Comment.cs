namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        [StringLength(50)]
        public string IdProduct { get; set; }

        [Required]
        [StringLength(500)]
        public string Comments { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public virtual Account Account { get; set; }
    }
}
