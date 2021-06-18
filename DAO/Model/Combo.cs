namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Combo")]
    public partial class Combo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Combo()
        {
            ComboDrinkDetails = new HashSet<ComboDrinkDetail>();
            ComboFoodDetails = new HashSet<ComboFoodDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [StringLength(50)]
        [Required(ErrorMessage = "You must input to this field")]
        public string IdCombo { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(50)]
        public string ComboName { get; set; }

        public double? ComboPrice { get; set; }

        public int? NumberOfFoods { get; set; }

        public int? NumberOfDinks { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        public int NumberOfPerson { get; set; }

        public long? Quantitysold { get; set; }

        [Required(ErrorMessage = "You must input to this field")]
        [StringLength(500)]
        public string ImgCombo { get; set; }

        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComboDrinkDetail> ComboDrinkDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComboFoodDetail> ComboFoodDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
