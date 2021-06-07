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
            OrderDetails = new HashSet<OrderDetail>();
            Comboes = new HashSet<Combo>();
        }

        [Key]
        [StringLength(50)]
        [Required(ErrorMessage ="You must input this field")]
        public string IdFood { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        [StringLength(100)]
        public string FoodName { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        public double FoodPrice { get; set; }

        [StringLength(500)]
        public string Foodmaterial { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        [StringLength(500)]
        public string ImgFood { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Combo> Comboes { get; set; }
    }
}
