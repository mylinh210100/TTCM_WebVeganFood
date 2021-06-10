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
            ComboDrinkDetails = new HashSet<ComboDrinkDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [StringLength(50, ErrorMessage = "maximum is 50 characters")]
        [Required(ErrorMessage = "You must input to this field")]
        public string IdDrink { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(50, ErrorMessage = "maximum is 50 characters")]
        public string DrinkName { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        public double DrinkPrice { get; set; }

        [StringLength(50, ErrorMessage = "maximum is 50 characters")]
        public string Drinkmaterial { get; set; }

        public long? Quantitysold { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(500, ErrorMessage = "maximum is 500 characters")]
        public string ImgDrink { get; set; }

        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComboDrinkDetail> ComboDrinkDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
