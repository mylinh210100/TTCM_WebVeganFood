namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Foundation")]
    public partial class Foundation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Foundation()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdFound { get; set; }

        [Required]
        [StringLength(500)]
        public string FoundationName { get; set; }

        public string ContentFound { get; set; }

        public double TotalCash { get; set; }

        public string ImgFound { get; set; }

        public string Link { get; set; }

        public int Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
