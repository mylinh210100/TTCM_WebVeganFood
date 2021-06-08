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
        [StringLength(10, ErrorMessage = "maximum of length is 10 characters")]
        [Required(ErrorMessage = "You must input this field")]
        public string IdCombo { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        [StringLength(50, ErrorMessage = "maximum of length is 50 characters")]
        public string ComboName { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        public double ComboPrice { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        public int NumberOfFoods { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        public int NumberOfDinks { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        public int NumberOfPerson { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        [StringLength(500, ErrorMessage = "maximum of length is 500 characters")]
        public string ImgCombo { get; set; }

        public int Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComboDrinkDetail> ComboDrinkDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComboFoodDetail> ComboFoodDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
