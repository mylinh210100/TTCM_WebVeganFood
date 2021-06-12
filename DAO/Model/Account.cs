namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Comments = new HashSet<Comment>();
            Customers = new HashSet<Customer>();
        }

        [Key]
        public long IdAcc { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(50)]
        public string PassWo { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(50)]
        public string ConfirmPass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
