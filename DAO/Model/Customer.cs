namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(10)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "You must input to this field")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        public long? IdAcc { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
