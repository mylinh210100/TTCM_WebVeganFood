namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            ComboFoodDetails = new HashSet<ComboFoodDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(50, ErrorMessage = "maximum is 50 characters")]
        public string IdFood { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(100, ErrorMessage = "maximum is 100 characters")]
        public string FoodName { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        public double FoodPrice { get; set; }

        [StringLength(500, ErrorMessage = "maximum is 500 characters")]
        public string Foodmaterial { get; set; }

        public long? Quantitysold { get; set; }

        [StringLength(500, ErrorMessage = "maximum is 500 characters")]
        [Required(ErrorMessage = "You must input to this field")]
        public string ImgFood { get; set; }

        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComboFoodDetail> ComboFoodDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
