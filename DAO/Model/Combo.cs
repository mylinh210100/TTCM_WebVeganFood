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
            OrderDetails = new HashSet<OrderDetail>();
            Drinks = new HashSet<Drink>();
            Foods = new HashSet<Food>();
        }

        [Key]
        [StringLength(10)]
        public string IdCombo { get; set; }

        [Required]
        [StringLength(50)]
        public string ComboName { get; set; }

        public double ComboPrice { get; set; }

        public int NumberOfFoods { get; set; }

        public int NumberOfDinks { get; set; }

        public int NumberOfPerson { get; set; }

        [Required]
        [StringLength(500)]
        public string ImgCombo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Drink> Drinks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Food> Foods { get; set; }
    }
}
