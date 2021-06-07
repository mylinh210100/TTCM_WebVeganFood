namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int IdOrder { get; set; }

        public int IdCustomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int SumOfProduct { get; set; }

        public int IdFoundation { get; set; }

        public double? Discount { get; set; }

        public double TotalCash { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Foundation Foundation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
