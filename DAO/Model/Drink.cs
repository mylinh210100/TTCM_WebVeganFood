namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Drink")]
    public partial class Drink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drink()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Comboes = new HashSet<Combo>();
        }

        [Key]
        [StringLength(50)]
        public string IdDrink { get; set; }

        [Required]
        [StringLength(50)]
        public string DrinkName { get; set; }

        public double DrinkPrice { get; set; }

        [StringLength(50)]
        public string Drinkmaterial { get; set; }

        [Required]
        [StringLength(500)]
        public string ImgDrink { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Combo> Comboes { get; set; }
    }
}
