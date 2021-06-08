namespace DAO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComboDrinkDetail")]
    public partial class ComboDrinkDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10, ErrorMessage = "maximum of length is 10 characters")]
        [Required(ErrorMessage = "You must input this field")]
        public string IdCombo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50, ErrorMessage = "maximum of length is 50 characters")]
        [Required(ErrorMessage = "You must input this field")]
        public string IdDrink { get; set; }

        public double? Price { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual Drink Drink { get; set; }
    }
}
